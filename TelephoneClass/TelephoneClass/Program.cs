using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TelephoneClass
{
    namespace TelephoneClass
    {
        class executeTelephoneclass
        {
            static void Main(string[] args)
            {
                telephone Telephone = new telephone();

                Telephone.tele = "";
                Console.WriteLine("Please enter contact number:");
                Telephone.tele = Console.ReadLine();

                while (Regex.IsMatch(Telephone.tele, "[a-zA-Z]"))
                {
                    Console.WriteLine("the contact number must be only digits.");
                    Console.WriteLine("Please enter contact number:");
                    Telephone.tele = Console.ReadLine();
                }
                Telephone.tele = Telephone.removechars();
                string msg = "";
                msg = Telephone.Count(Telephone.tele);
                Console.WriteLine(msg);
                Telephone.contacts(Telephone.tele);
                Console.ReadKey();
            }
        }
    }
}
