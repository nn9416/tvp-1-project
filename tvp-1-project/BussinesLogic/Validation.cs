using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
    }
}
