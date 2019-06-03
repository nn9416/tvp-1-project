using System.Collections.Generic;
using System.Linq;
using tvp_1_project.Model;

namespace tvp_1_project.BussinesLogic
{
    public static class BookingsValidation
    {
        static Booking startBooking;
        static Booking endBooking;

        public static bool IsBookingInRange(Booking booking, string mode)
        {
            List<Offer> offers = GetOffersForCar(booking.Car);
            Offer startOffer = GetStartOffer(offers, booking);
            Offer endOffer = GetEndOffer(offers, booking, startOffer);
            List<Offer> middleOffers = GetMiddleOffers(offers, startOffer, endOffer, booking);

            // Booking is out of any offer
            if (startOffer == null && endOffer == null)
            {
                return false;
            }
            // Booking is in one offer
            else if (endOffer == null)
            {                
                if (mode.Equals("Create"))
                {                    
                    booking.Price = ((booking.DateTo.Date - booking.DateFrom.Date).Days * int.Parse(startOffer.DayPrice)).ToString();
                    startOffer.Bookings.Add(booking);
                    booking.Create();
                }
                else if (mode.Equals("Delete"))
                {
                    foreach (Booking b in startOffer.Bookings.Where(b => b.Id.Equals(booking.Id)))
                    {
                        startOffer.Bookings.Remove(b);
                    }                    
                }

                return true;
            }

            // Middle offers are not "touching" or there are no middle offers (only start and end offers)
            if (middleOffers == null)
            {
                if (AreOffersTouching(startOffer, endOffer))
                {
                    startBooking.DateTo = startOffer.DateTo;
                    int startPrice = ((startBooking.DateTo.Date - startBooking.DateFrom.Date).Days * int.Parse(startOffer.DayPrice));
                    startBooking.Price = startPrice.ToString();

                    endBooking.DateFrom = endOffer.DateFrom;
                    int endPrice = ((endBooking.DateTo.Date - endBooking.DateFrom.Date).Days * int.Parse(endOffer.DayPrice));
                    endBooking.Price = endPrice.ToString();
                    
                    startOffer.Bookings.Add(startBooking);
                    endOffer.Bookings.Add(endBooking);                    

                    if (mode.Equals("Create"))
                    {
                        int totalPrice = startPrice + endPrice;
                        booking.Price = totalPrice.ToString();              
                        booking.Create();
                    }
                    else if (mode.Equals("Delete"))
                    {
                        foreach (Booking b in startOffer.Bookings.Where(b => b.Id.Equals(booking.Id)))
                        {
                            startOffer.Bookings.Remove(b);                            
                        }

                        foreach (Booking b in endOffer.Bookings.Where(b => b.Id.Equals(booking.Id)))
                        {
                            endOffer.Bookings.Remove(b);                            
                        }
                    }

                    return true;
                }
                return false;
            }
            // There are middle offers
            else
            {
                if (AreOffersTouching(startOffer, middleOffers.ElementAt(0)) && AreOffersTouching(middleOffers.ElementAt(middleOffers.Count), endOffer))
                {
                    int totalPrice = 0;

                    Booking startBooking = booking;
                    startBooking.DateTo = startOffer.DateTo;
                    int startPrice = ((startBooking.DateTo.Date - startBooking.DateFrom.Date).Days * int.Parse(startOffer.DayPrice));
                    startBooking.Price = startPrice.ToString();

                    Booking endBooking = booking;
                    endBooking.DateFrom = endOffer.DateFrom;
                    int endPrice = ((endBooking.DateTo.Date - endBooking.DateFrom.Date).Days * int.Parse(endOffer.DayPrice));
                    endBooking.Price = endPrice.ToString();

                    totalPrice = startPrice + endPrice;

                    foreach (Offer offer in middleOffers)
                    {
                        Booking tempBooking = booking;
                        tempBooking.DateFrom = offer.DateFrom;
                        tempBooking.DateTo = offer.DateTo;
                        int tempPrice = ((tempBooking.DateTo.Date - tempBooking.DateFrom.Date).Days * int.Parse(offer.DayPrice));
                        tempBooking.Price = tempPrice.ToString();

                        totalPrice += tempPrice;

                        offer.Bookings.Add(tempBooking);
                    }

                    booking.Price = totalPrice.ToString();
                    booking.Create();
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
                    startBooking = new Booking(booking.Id, booking.Customer, booking.Car, booking.DateFrom, booking.DateTo, "0");
                    if (offer.DateTo < booking.DateTo)
                        startBooking.DateTo = offer.DateTo;      

                    if (AreBookingDatesFree(offer, startBooking))
                        return offer;
                }
            }
            return null;
        }

        private static Offer GetEndOffer(List<Offer> offers, Booking booking, Offer startOffer)
        {
            foreach (Offer offer in offers)
            {
                if (!offer.Equals(startOffer) && offer.DateFrom <= booking.DateTo && offer.DateTo >= booking.DateTo)
                {
                    endBooking = new Booking(booking.Id, booking.Customer, booking.Car, booking.DateFrom, booking.DateTo, "0")
                    {
                        DateFrom = offer.DateFrom
                    };

                    if (AreBookingDatesFree(offer, endBooking))
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

            if (endOffer == null)
                return null;

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
