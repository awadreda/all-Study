using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankDataAccessLayer;

namespace BankbusinessLayer
{
    public class ClientsBusiness
    {
        enum enMode { AddNew=0, Update=1};


        public int ClientID { get; set; }

        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Email { set; get; }
        public string Phone { set; get; }
        public string AccountNumber { set; get; }
        public string PINCODE { set; get; }
        public float AccountBalance { set; get; }
        enMode Mode = enMode.AddNew;


        ClientsBusiness()
        {
         this.ClientID = -1;
         this.FirstName = "";
         this.LastName = "";
            this.Phone = "";
         this.Email = "";
         this.AccountNumber = "";
         this.PINCODE = "";
         this.AccountBalance = 0;
         this.Mode = enMode.AddNew;

        }

        ClientsBusiness(int ID , string FirstName, string LastName, string Email,string Phone, string AccountNumber, string PINCODE , float AccountBalance)
        {
            this.ClientID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            this.AccountNumber = AccountNumber;
            this.PINCODE = PINCODE;
            this.AccountBalance = AccountBalance;
            this.Mode = enMode.Update;


        }


        public static ClientsBusiness FindClient(int ID)
        {
         string FirstName = "";
         string LastName = "";
            string Phone = "";
         string Email = "";
         string AccountNumber = "";
         string PINCODE = "";
            float AccountBalance = 0;

            if(ClientsData.getClinet(ID,ref FirstName,ref LastName,ref Email,ref AccountNumber,ref Phone,ref PINCODE,ref AccountBalance))
                {
                return new ClientsBusiness(ID, FirstName, LastName, Email,Phone, AccountNumber, PINCODE, AccountBalance);

            }
            else
            {
                return null;
                      }



        }










    }
}
