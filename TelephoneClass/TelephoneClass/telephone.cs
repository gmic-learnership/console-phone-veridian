using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TelephoneClass
{
    class telephone
    {
        //declaring variables
        public string tele;
        public string message;

        //method for removing characters in contact number
        public string removechars()
        {

            if (tele.Contains("(") || tele.Contains(")") || tele.Contains("-") || tele.Contains(" "))
            {

                string one;
                one = tele.Replace("(", "");
                tele = one;

                one = tele.Replace(")", "");
                tele = one;

                one = tele.Replace("-", "");
                tele = one;

                one = tele.Replace(" ", "");
                tele = one;


            }

            return tele;
        }

        //method for counting number of digits and for code accepted

        public string Count(string tele)

        {

            if (tele.Length != 10)
            {
                message = "the contact must be 10 digits,Please Redial.";

            }

            else if (tele.Substring(0, 3) != "012" && tele.Substring(0, 3) != "011" && tele.Substring(0, 3) != "076" && tele.Substring(0, 3) != "083" && tele.Substring(0, 3) != "069")
            {
                message = "contact number can not start with" + " " + tele.Substring(0, 3) + ", " + "only this codes are allowed: 011, 012, 076, 083 and 069,please redial.";

            }
            else
            {
                message = "The telephone number you are calling is:" + " " + tele  + " " + "calling.";
            }

            return message;
        }

        //method for storing contacts

        public string contacts(string tele)
        {
            

            if (tele == "0693999452")
            {
                Console.WriteLine("Winny....");
            }
            else if (tele == "0834561234")
            {
                Console.WriteLine("Dale...");
            }
            else if (tele == "0834561234")
            {
                Console.WriteLine("Lesego...");
            }
            else if (tele == "0769090311")
            {
                Console.WriteLine("Vivian...");
            }
            else if (tele == "0834567654")
            {
                Console.WriteLine("Bonginkosi...");
            }

            return message;

        }
    }
}
