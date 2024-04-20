using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankbusinessLayer;

namespace MyBankWindowsForm
{
    public partial class UserIformation : UserControl
    {
        public UserIformation(int ClientID)
        {
            InitializeComponent();
            if (ClientID == -1)
            {
                _mode = enMode.addNew;
            }
            else
            {
                _mode = enMode.Upadate;
            }
        }

        public enum enMode { addNew = 1, Upadate = 2 };
        private enMode _mode;

        int _ClientID;
        ClientsBusiness Client;

     


        void FillUserControl()
        {
            if (_mode == enMode.addNew)
            {

                return;
            }

            ClientsBusiness client = ClientsBusiness.FindClient(_ClientID);
            if (Client == null)
            {
                MessageBox.Show("The Client is not Found", "Info", MessageBoxButtons.OK);
                return
                    ;
            }

            lblClientID.Text = client.ClientID.ToString();
            txtFirstName.Text = client.FirstName;
            txtLastName.Text = client.LastName;
            txtPhone.Text = client.Phone;
            txtEmail.Text = client.Email;
            txtPinCode.Text = client.PINCODE;
            txtAcountNumber.Text = client.AccountNumber;
            txtAccountBanlance.Text = client.AccountBalance.ToString();

        }


        private void UserIformation_Load(object sender, EventArgs e)
        {

        }
    }
}
