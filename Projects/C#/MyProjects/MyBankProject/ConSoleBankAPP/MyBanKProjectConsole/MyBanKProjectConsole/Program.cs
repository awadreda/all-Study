using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankbusinessLayer;

namespace MyBanKProjectConsole
{
    class Program
    {

    public static void    testFindClient(int ID )
        {
            ClientsBusiness Client = ClientsBusiness.FindClient(ID);

            if(Client!=null)
            {
                Console.WriteLine("Client Info\n");

                Console.WriteLine("Client ID : " + Client.ClientID);

                Console.WriteLine("Client Name " + Client.FirstName + " " + Client.LastName)
                    ;Console.WriteLine("Email : " + Client.Email);
                Console.WriteLine("Phone : " + Client.Email);
                Console.WriteLine("PinCode : " + Client.PINCODE);
                Console.WriteLine("AccountBalance : " + Client.AccountBalance);

            }
            else
            {
                Console.WriteLine("The CLient Is Not Found ");
            }

        }


        static void Main(string[] args)
        {

            testFindClient(1);

            Console.ReadKey();
        }
    }
}
