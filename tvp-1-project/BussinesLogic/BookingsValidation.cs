using System.Collections.Generic;
using System.Linq;
using tvp_1_project.Model;

namespace tvp_1_project.BussinesLogic
{
    public static class BookingsValidation
    { 
        public static bool IsBookingInRange(Booking booking)
        {
            List<Offer> offers = GetOffersForCar(booking.Car);
            Offer startOffer = GetStartOffer(offers, booking);
            Offer endOffer = GetEndOffer(offers, booking);
            List<Offer> middleOffers = GetMiddleOffers(offers, startOffer, endOffer, booking);

            // Booking is out of any offer
            if (startOffer == null && endOffer == null)
            {
                return false;
            }
            // Booking is in one offer
            else if (endOffer == null)
            {
                booking.Price = ((booking.DateTo.Date - booking.DateFrom.Date).Days * int.Parse(startOffer.DayPrice)).ToString();
                startOffer.Bookings.Add(booking);
                return true;
            }

            // Middle offers are not "touching" or there are no middle offers (only start and end offers)
            if (middleOffers == null)
            {
                if (AreOffersTouching(startOffer, endOffer))
                {
                    Booking startBooking = booking;
                    startBooking.DateTo = startOffer.DateTo;
                    startBooking.Price = ((startBooking.DateTo.Date - startBooking.DateFrom.Date).Days * int.Parse(startOffer.DayPrice)).ToString();

                    Booking endBooking = booking;
                    endBooking.DateFrom = endOffer.DateFrom;
                    endBooking.Price = ((endBooking.DateTo.Date - endBooking.DateFrom.Date).Days * int.Parse(endOffer.DayPrice)).ToString();

                    startOffer.Bookings.Add(startBooking);
                    endOffer.Bookings.Add(endBooking);
                    return true;
                }
                return false;
            }
            // There are middle offers
            else
            {
                if (AreOffersTouching(startOffer, middleOffers.ElementAt(0)) && AreOffersTouching(middleOffers.ElementAt(middleOffers.Count), endOffer))
                {
                    Booking startBooking = booking;
                    startBooking.DateTo = startOffer.DateTo;
                    startBooking.Price = ((startBooking.DateTo.Date - startBooking.DateFrom.Date).Days * int.Parse(startOffer.DayPrice)).ToString();

                    Booking endBooking = booking;
                    endBooking.DateFrom = endOffer.DateFrom;
                    endBooking.Price = ((endBooking.DateTo.Date - endBooking.DateFrom.Date).Days * int.Parse(endOffer.DayPrice)).ToString();

                    foreach (Offer offer in middleOffers)
                    {
                        Booking tempBooking = booking;
                        tempBooking.DateFrom = offer.DateFrom;
                        tempBooking.DateTo = offer.DateTo;
                        tempBooking.Price = ((tempBooking.DateTo.Date - tempBooking.DateFrom.Date).Days * int.Parse(offer.DayPrice)).ToString();
                        offer.Bookings.Add(tempBooking);
                    }

                    return true;
                }
                return false;
            }
        }        

        private static Offer GetStartOffer(List<Offer> offers, Booking booking)
        {
            foreach (Offer offer in offers)
            {
                if (offer.DateFrom <= booking.DateFrom && offer.DateTo >= booking.DateFrom)
                {
                    if (offer.DateTo < booking.DateTo)
                        booking.DateTo = offer.DateTo;

                    if (AreBookingDatesFree(offer, booking))
                        return offer;
                }
            }
            return null;
        }

        private static Offer GetEndOffer(List<Offer> offers, Booking booking)
        {
            foreach (Offer offer in offers)
            {
                if (offer.DateFrom <= booking.DateTo && offer.DateTo >= booking.DateTo)
                {
                    booking.DateFrom = offer.DateFrom;
                    if (AreBookingDatesFree(offer, booking))
                    {
                        return offer;
                    }
                }
            }
            return null;
        }

        private static List<Offer> GetMiddleOffers(List<Offer> offers, Offer startOffer, Offer endOffer, Booking booking)
        {
            List<Offer> middleOffers = new List<Offer>();

            foreach (Offer offer in offers)
            {
                if (startOffer.DateTo < offer.DateFrom && endOffer.DateFrom > offer.DateTo)
                {
                    middleOffers.Add(offer);
                }                    
            }

            if (middleOffers.Count > 0)
            {
                for (int i = 0; i < middleOffers.Count - 1; i++)
                {
                    if (!AreOffersTouching(middleOffers.ElementAt(i), middleOffers.ElementAt(i + 1)) || middleOffers.ElementAt(i).Bookings.Count > 0)
                    {
                        return null;
                    }
                }
                return middleOffers;
            }
            return null;            
        }

        private static bool AreOffersTouching(Offer startOffer, Offer endOffer) => (endOffer.DateFrom.Date - startOffer.DateTo.Date).Days == 1;

        private static bool AreBookingDatesFree(Offer offer, Booking booking)
        {
            if (offer.Bookings.Count > 0)
            {
                foreach (Booking offerBooking in offer.Bookings)
                {
                    if (offerBooking.DateFrom < booking.DateTo && booking.DateFrom < offerBooking.DateTo)
                    {
                        return false;
                    }
                }
            }
                            
            return true;
        }

        internal static List<Offer> GetOffersForCar(Car car)
        {
            List<Offer> offers = Offer.ReadAll();
            List<Offer> offersForCar = new List<Offer>();

            foreach (Offer offer in offers.Where(o => o.Car.Id.Equals(car.Id)))
            {
                offersForCar.Add(offer);
            }

            return offersForCar;
        }
    }
}
