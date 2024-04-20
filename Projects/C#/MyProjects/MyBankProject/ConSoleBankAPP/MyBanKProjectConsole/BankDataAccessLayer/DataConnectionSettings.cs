using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDataAccessLayer
{
    public static class DataConnectionSettings
    {

        private static string _ConnectionString = "Server=.;Database= MyBankDB ;User Id=sa;Password=sa123456;";

        public static string ConnectionString
        {
            get
                {

                return _ConnectionString;
            }
        }





    }
}
