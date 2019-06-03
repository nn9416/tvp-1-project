﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using tvp_1_project.Model;

namespace tvp_1_project.BussinesLogic
{
    public static class Validation
    {
        #region Customer Validation
        internal static bool ValidateCustomer(Dictionary<string, string> values)
        {
            List<bool> validations = new List<bool>()
            {
                FirstName(values["FirstName"]),
                LastName(values["LastName"]),
                Ssn(values["Ssn"]),
                BirthDate(values["BirthDate"]),
                PhoneNumber(values["PhoneNumber"]),
                Username(values["Username"]),
                Password(values["Password"])
            };

            foreach (bool value in validations)
            {
                if (!value)
                    return false;
            }
            return true;
        }

        internal static bool FirstName(string data)
        {
            Regex regex = new Regex("([A-Za-z]{1,15}\\s?[A-Za-z]{1,15})");

            if (regex.IsMatch(data) && data.Length < 32)
            {
                return true;
            }
            else
            {
                // TODO: Notify user of wrong input for first name
                return false;
            }
        }

        internal static bool LastName(string data)
        {
            Regex regex = new Regex("([A-Za-z]{1,15}\\s?[A-Za-z]{1,15})");

            if (regex.IsMatch(data))
            {
                return true;
            }
            else
            {
                // TODO: Notify user of wrong input for last name
                return false;
            }
        }

        internal static bool Ssn(string data)
        {
            Regex regex = new Regex("(\\d{13})");

            if (regex.IsMatch(data))
            {
                return true;
            }
            else
            {
                // TODO: Notify user of wrong input for ssn
                return false;
            }
        }

        internal static bool BirthDate(string data)
        {
            DateTime date = DateTime.ParseExact(data, "dd.MM.yyyy.", CultureInfo.InvariantCulture);
            int numberOfDaysForLast18Years = 0;

            for (int i = 18; i >= 0; i--)
            {
                numberOfDaysForLast18Years += DateTime.IsLeapYear(DateTime.Today.AddYears(i).Year) ? 366 : 365;
            }

            if ((DateTime.Now - date).TotalDays > numberOfDaysForLast18Years)
            {
                return true;
            }
            else
            {
                // TODO: Notify user of wrong input for birth date
                return false;
            }
        }

        internal static bool PhoneNumber(string data)
        {
            Regex regex = new Regex("(\\d{9,10})");

            if (regex.IsMatch(data))
            {
                return true;
            }
            else
            {
                // TODO: Notify user of wrong input for phone number
                return false;
            }
        }

        internal static bool Username(string data)
        {
            Regex regex = new Regex("(\\w)");

            if (regex.IsMatch(data))
            {
                return true;
            }
            else
            {
                // TODO: Notify user of wrong input for username
                return false;
            }
        }

        internal static bool Password(string data)
        {
            Regex regex = new Regex("(\\w)");

            if (regex.IsMatch(data))
            {
                return true;
            }
            else
            {
                // TODO: Notify user of wrong input for password
                return false;
            }
        }
        #endregion

        #region Offer Validation
        internal static bool ValidateOffer(Dictionary<string, object> values)
        {
            DateTime dateFrom = DateTime.ParseExact(values["DateFrom"] as string, "dd.MM.yyyy.", CultureInfo.InvariantCulture);
            DateTime dateTo = DateTime.ParseExact(values["DateTo"] as string, "dd.MM.yyyy.", CultureInfo.InvariantCulture);

            List<bool> validations = new List<bool>()
            {
                IsCarAvaliable(values["Car"] as Car, dateFrom, dateTo),
                IsDateInRange(dateFrom, dateTo),
                IsPriceInt(values["Price"] as string)
            };

            foreach (bool value in validations)
            {
                if (!value)
                    return false;
            }
            return true;
        }

        internal static bool IsCarAvaliable(Car car, DateTime dateFrom, DateTime dateTo)
        {
            List<Offer> offers = Offer.ReadAll();
            foreach (Offer offer in offers.Where(o => o.Car.Id.Equals(car.Id)))
            {
                if (offer.DateFrom < dateTo && dateFrom < offer.DateTo)
                {
                    return false;
                }
            }
            return true;
        }

        internal static bool IsPriceInt(string price) => int.TryParse(price, out int result);
        #endregion

        #region Booking Validation
        internal static bool ValidateBooking(Dictionary<string, object> values)
        {
            Customer customer = values["Customer"] as Customer;
            Car car = values["Car"] as Car;
            DateTime dateFrom = DateTime.ParseExact(values["DateFrom"] as string, "dd.MM.yyyy.", CultureInfo.InvariantCulture);
            DateTime dateTo = DateTime.ParseExact(values["DateTo"] as string, "dd.MM.yyyy.", CultureInfo.InvariantCulture);

            string mode = values["Mode"] as string;

            Booking booking = new Booking(customer, car, dateFrom, dateTo)
            {
                Id = values["Id"].ToString()
            };

            return IsDateInRange(dateFrom, dateTo) && BookingsValidation.IsBookingInRange(booking, mode);                      
        }
        #endregion

        internal static bool IsDateInRange(DateTime dateFrom, DateTime dateTo)
        {
            if (dateFrom.Date < dateTo.Date && dateFrom.Date >= DateTime.Now.Date)
                return true;
            // TODO: Notify user of wrong input for dates
            return false;
        }
    }
}
