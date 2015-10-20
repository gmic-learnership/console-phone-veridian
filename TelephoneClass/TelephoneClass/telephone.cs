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
        public string tele;
        public string message;        
        
  public string removechars()
        {
            tele = tele.Replace("(", "");
            tele = tele.Replace(")", "");
            tele = tele.Replace("-", "");
            tele = tele.Replace(" ", "");
            return tele;
        } 
        public string Count(string tele)
        {
            string teleCode = tele.Substring(0, 3);
            if (tele.Length != 10)
            {
                message = "the contact must be 10 digits,Please Redial.";
            }
                else if (teleCode != "011" &&
                         teleCode != "012" &&
                         teleCode != "076" &&
                         teleCode != "083" &&
                         teleCode != "069")
                 {
                message = "contact number can not start with" + " " + teleCode + ", " + "only this codes are allowed: 011, 012, 076, 083 and 069,please redial.";
                 }
                else
                 {
                message = "The telephone number you are calling is: " + tele + " calling.";
                 }
            return message;
        }
        public void contacts(string tele)
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
        }
    }
}
