using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TelephoneClass
{
    class Program
    {
        }
    //instatiating a class
        class executeTelephoneclass
        {
        //instatiating a class
        static void Main(string[] args)
            {
            telephone t = new telephone();

            //prompting a user to enter contact number
            t.tele = "";
            Console.WriteLine("Please enter contact number:");
            t.tele = Console.ReadLine();

            //removing letters from contact number
            while (Regex.IsMatch(t.tele, "[a-zA-Z]"))
            {
                Console.WriteLine("the contact number must be only digits."); 
                Console.WriteLine("Please enter contact number:");
               t.tele = Console.ReadLine();
            }     
                //calling method for removing characters                                      
                t.tele = t.removechars() ;

            string msg = "";
            //calling method for counting digits and accepting codes
            msg = t.Count(t.tele);
            Console.WriteLine(msg);

            //methods for retrieving stored contacts
            //t.contacts(t.tele);            
            msg=t.contacts(t.tele);
            Console.ReadKey();
            }
        }
    }
