using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankbusinessLayer;

namespace BankSystemwidowsForm.CLients
{
    public partial class frmAddEditFormClinet : Form
    {
        enum enMode { Addnew=1,Udpate=2};

        private enMode mode;

        int _ClientID;
    private    ClientsBusiness _client;
        
        public frmAddEditFormClinet(int ClientID)
        {
            InitializeComponent();

            _ClientID = ClientID;

            if(_ClientID != -1)
            {
                mode = enMode.Udpate;
            }
            else
            {
                mode = enMode.Addnew;
            }
        }






        void LoadData()
        {
            if(mode==enMode.Addnew)
            {
                lblMode.Text = "Add New Client";
                _client = new ClientsBusiness();
                return;
            }

            _client = ClientsBusiness.FindClient(_ClientID);

            if(_client==null)
            {
                MessageBox.Show("the Form Will be Close Becase the CLient Is Not Here ","info ",MessageBoxButtons.OK);
                this.Close();

            }

            lblClientD.Text            = _client.ClientID.ToString();
            txtFirstName.Text           =         _client.FirstName;
            txtLastName.Text           =          _client.LastName;
            txtEmail.Text            =             _client.Email;
            txtPhone.Text              =             _client.Phone;
            txtPinCode.Text          =           _client.PINCODE;
            txtAccountNumber.Text      =     _client.AccountNumber;
            txtAccountBanlance.Text      =   _client.AccountBalance.ToString();
            
            
        }





        private void frmAddEditFormClinet_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtpDateOfBirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtpEditAccountBanlance_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }


        void Save()
        {
            _client.FirstName = txtFirstName.Text;
            _client.LastName                         =       txtLastName.Text                   ;
            _client.Email                            =       txtEmail.Text                        ;
            _client.Phone                            =       txtPhone.Text                       ;
            _client.PINCODE                          =       txtPinCode.Text                            ;
            _client.AccountNumber                    =        txtAccountNumber.Text                   ;   
            _client.AccountBalance        =                   Convert.ToSingle( txtAccountBanlance.Text                     );

            if(_client.Save())
            {
                MessageBox.Show("Data Saved Successfully.");
            }
            else
            {
                MessageBox.Show("Data is not Saved there is an erro");
            }
            lblMode.Text = "Edit Client " + _client.ClientID.ToString();
            mode = enMode.Udpate;
            lblClientD.Text = _client.ClientID.ToString();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblMode_Click(object sender, EventArgs e)
        {

        }
    }
}
