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


namespace BankSystemwidowsForm.TransActions
{
    public partial class DepositePopWidow : Form
    {

        int _clientID;
        ClientsBusiness _client;

        public DepositePopWidow(int CLientID)
        {
            InitializeComponent();

            _clientID = CLientID;
        }



        void loadDateToDeposte()
        {
            lblUserName.Text = Global.CurrentUser.UserName;

            _client = ClientsBusiness.FindClient(_clientID);

            if (_client != null)
            {
                lblClientID.Text = _client.ClientID.ToString() ;
                lblClientName.Text = _client.FirstName;
                lblAccountBalance.Text = _client.AccountBalance.ToString() + "$";



            }
            else
            {
                MessageBox.Show("the Client Doesn't Exist", "Erro", MessageBoxButtons.OK);
            }




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DepositePopWidow_Load(object sender, EventArgs e)
        {
            loadDateToDeposte();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        void Save()
        {
            float Amount = Convert.ToSingle(txtAmount.Text);

            if(_client.Deposite(Amount, Global.CurrentUser.User_ID))
            {
                MessageBox.Show("The Operations Is Done ", "info", MessageBoxButtons.OK, MessageBoxIcon.Information) ;
            }
            else
            {
                MessageBox.Show("Erro, The Operations Is Not Done ", "info", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            loadDateToDeposte();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("are you Sure","Confirm",MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                Save();
            }

        }

        private void lblAccountBalance_Click(object sender, EventArgs e)
        {

        }
    }
}
