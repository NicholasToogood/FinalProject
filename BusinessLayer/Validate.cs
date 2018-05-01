using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Validate
    {
        public static bool ValidateLength(string value, int length)
        {
            if (value.Length <= length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidateName(string value)
        {
            //Regex r = new Regex("^[a-zA-Z]+$");

            //if (r.Match(value).Success)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            return true;
        }

        public static bool ValidatePhoneNumber(string number)
        {
            Regex r = new Regex("^[0-9]{3}-[0-9]{4}$");
            Regex rTwo = new Regex("^[0-9]{3}-[0-9]{3}-[0-9]{4}$");

            if (r.Match(number).Success || rTwo.Match(number).Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        

    public static Boolean IsValidPostalCode(string postalCode)
        {
            Regex r = new Regex("[ABCEGHJ-NPRSTVXY]{1}[0-9]{1}[ABCEGHJ-NPRSTV-Z]{1}[ ]?[0-9]{1}[ABCEGHJ-NPRSTV-Z]{1}[0-9]{1}$");


            if (r.Match(postalCode).Success)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        // HR

        public static bool ValidateEmail(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public static Boolean IsValidSIN(string sin)
        {
            Regex r = new Regex(@"^\d{9}$");

            if (r.Match(sin).Success)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static Boolean IsValidBiweeklyPay(string BiWeeklyPay)
        {
            int n;
            bool isNumeric = int.TryParse(BiWeeklyPay, out n);


            if (isNumeric)
            {
                if (n > 0)
                {
                    return true;

                }
            }
            return false;

        }

        public static Boolean IsValidEmployeeID(String attemptEmpID)
        {
            int empID;
            if (int.TryParse(attemptEmpID, out empID))
            {
                if(attemptEmpID.Count() == 8)
                {
                    return true;
                }
            }
            return false;
        }

        public static Boolean IsValidPercentageIncreaseRequest(String attempt)
        {
            Double percentage;
            if (Double.TryParse(attempt, out percentage))
            {
                if (percentage > 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
