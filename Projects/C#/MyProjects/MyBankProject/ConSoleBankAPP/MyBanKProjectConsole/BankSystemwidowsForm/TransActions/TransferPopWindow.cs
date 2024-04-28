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
    public partial class TransferPopWindow : Form
    {


        int _clientID;
        ClientsBusiness _client;


        public TransferPopWindow(int ID)
        {
            InitializeComponent();
            _clientID = ID;
        }



        void loadDataToTransFer()
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


        
        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       



        void Save()
        {
            float Amount = Convert.ToSingle(txtAmount.Text);
            int ReciverID = Convert.ToInt16(txtReciverID.Text);
            ClientsBusiness Reciver = ClientsBusiness.FindClient(ReciverID);

            if (Amount > _client.AccountBalance)
            {
                MessageBox.Show("The Amount Is bigger than Your Balance ", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {

                if (_client.Transfer(Amount, Reciver, Global.CurrentUser.User_ID))
                {
                    MessageBox.Show("The Operations Is Done ", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro, The Operations Is Not Done ", "info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


            loadDataToTransFer();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void TransferPopWindow_Load(object sender, EventArgs e)
        {
            loadDataToTransFer();

        }
    }
}
