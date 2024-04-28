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
    public partial class WithDrawPopWindow : Form
    {


        int _clientID;
        ClientsBusiness _client;


        public WithDrawPopWindow(int ID)
        {
            InitializeComponent();
            _clientID = ID;
        }



        void loadDataToWithDraw()
        {
            lblUserName.Text = Global.CurrentUser.UserName;

            _client = ClientsBusiness.FindClient(_clientID);

            if (_client != null)
            {
                lblClientID.Text = _client.ClientID.ToString();
                lblClientName.Text = _client.FirstName;
                lblAccountBalance.Text = _client.AccountBalance.ToString() + "$";



            }
            else
            {
                MessageBox.Show("the Client Doesn't Exist", "Erro", MessageBoxButtons.OK);
            }


        }


        void Save()
        {
            float Amount = Convert.ToSingle(txtAmount.Text);


            if(Amount>_client.AccountBalance)
            {
                MessageBox.Show("The Amount Is bigger than Your Balance ", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {

            if (_client.WithDraw(Amount, Global.CurrentUser.User_ID))
            {
                MessageBox.Show("The Operations Is Done ", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro, The Operations Is Not Done ", "info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            }


            loadDataToWithDraw();
        }



        private void WithDrawPopWindow_Load(object sender, EventArgs e)
        {
            loadDataToWithDraw();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you Sure", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Save();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)

        {
            this.Close();
        }
    }
}
