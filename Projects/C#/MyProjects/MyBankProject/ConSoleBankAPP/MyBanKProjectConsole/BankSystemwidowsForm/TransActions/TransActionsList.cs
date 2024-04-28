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
    public partial class TransActionsList : Form
    {


        public TransActionsList()
        {
            InitializeComponent();
        }


        void LoadTransActionList()
        {

            lblUserName.Text = Global.CurrentUser.UserName;

            dgvTransActionsList.DataSource = UserBussinees.GetTransActionList();

        }
        
        void  loadData()
        {
            LoadTransActionList();

            LoadTotalBancesList();
        }


        void LoadTotalBancesList()
        {
            dgvTotalBanlances.DataSource = ClientsBusiness.GetTotalBalances();
        }



        private void TransActionsList_Load(object sender, EventArgs e)
        {
            loadData();

        }
        

        private void transferToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int id = (int)dgvTotalBanlances.CurrentRow.Cells[0].Value;

            TransferPopWindow transfer = new TransferPopWindow(id);
            transfer.ShowDialog();
            loadData();

        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)dgvTotalBanlances.CurrentRow.Cells[0].Value;
            DepositePopWidow frm = new DepositePopWidow(id);
            frm.ShowDialog();
            loadData();

        }

        private void withDrawToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            int id = (int)dgvTotalBanlances.CurrentRow.Cells[0].Value;
            WithDrawPopWindow frm = new WithDrawPopWindow(id);
            frm.ShowDialog();
            loadData();

        }

        

        
        void LoadLists()
        {
            LoadTotalBancesList();
            LoadTransActionList();
        }





        //////////////////////////DepositTab//////////////////////

        void LoadDepositTab()
        {
            lblUserName.Text = Global.CurrentUser.UserName;
            int ClientDepositID=0;

            if(int.TryParse(txtClientDepositID.Text,out int result))
            {
                ClientDepositID = result;
            }

            ClientsBusiness _client = ClientsBusiness.FindClient(ClientDepositID);

            if (_client != null)
            {
                lblClientName.Text = _client.FirstName;
                lblAccountBalance.Text = _client.AccountBalance.ToString() + "$";



            }
           
        }

        private void maskedTextBox1_ChangeUICues(object sender, UICuesEventArgs e)
        {
            LoadDepositTab();
        }

        void SaveDeposit()
        {
            int ClientDepositID = 0;

            if (int.TryParse(txtClientDepositID.Text, out int result))
            {
                ClientDepositID = result;
            }

            float Amount = Convert.ToSingle(txtAmount.Text);
            ClientsBusiness _client = ClientsBusiness.FindClient(ClientDepositID); 

            if(_client!=null)
            {

            if (_client.Deposite(Amount, Global.CurrentUser.User_ID))
            {
                MessageBox.Show("The Operations Is Done ", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro, The Operations Is Not Done ", "info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            else
            {
                MessageBox.Show("The CLient Is NotExit ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


            LoadDepositTab();
            LoadLists();
        }


        private void btnDepositSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you Sure", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                SaveDeposit();
            }
        }

        private void txtClientDepositID_TextChanged(object sender, EventArgs e)
        {
            LoadDepositTab();

        }

        void ClearDeposit()
        {
            txtClientDepositID.Clear();
            txtAmount.Clear();
            lblClientName.Text = "??";
            lblAccountBalance.Text = "??";
        }


        private void btnClearDeposit_Click(object sender, EventArgs e)
        {
            ClearDeposit();
        }


        ////////////////////////WithDrawTab///////////////////////



        void LoadWithDrawTab()
        {
           
            int ClientWihtDrawtID = 0;

            if (int.TryParse(txtWithDrawClientID.Text, out int result))
            {
                ClientWihtDrawtID = result;
            }

            ClientsBusiness _client = ClientsBusiness.FindClient(ClientWihtDrawtID);

            if (_client != null)
            {
                lblWithDrawTabClientName.Text = _client.FirstName;
                lblWithDrawTabClientBalance.Text = _client.AccountBalance.ToString() + "$";



            }

        }

        
        

         void SaveWithDraw()
        {

            int ClientWihtDrawtID = 0;

            if (int.TryParse(txtWithDrawClientID.Text, out int result))
            {
                ClientWihtDrawtID = result;
            }
            float Amount = Convert.ToSingle(txtAmountWithDraw.Text);
            ClientsBusiness _client = ClientsBusiness.FindClient(ClientWihtDrawtID);

            if (_client != null)
            {


                if (Amount > _client.AccountBalance)
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

            }

                LoadWithDrawTab();
            LoadLists();

        }



        private void btnWithDrawSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you Sure", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                SaveWithDraw();
            }
        }

     

        private void txtWithDrawClientID_TextChanged(object sender, EventArgs e)
        {
            LoadWithDrawTab();

        }


        void ClearWithDraw()
        {
            txtWithDrawClientID.Clear();
            txtAmountWithDraw.Clear();
            lblWithDrawTabClientBalance.Text = "??";
            lblWithDrawTabClientName.Text = "??";

        }


        private void btnClearWithDraw_Click(object sender, EventArgs e)
        {
            ClearWithDraw();
        }





        /////////////////////////TransFer/////////////////////




        void loadDataToTransFer()
        {
            lblUserName.Text = Global.CurrentUser.UserName;


            int ClientTransferID = 0;

            if (int.TryParse(txtSenderIDTransFerTab.Text, out int result))
            {
                ClientTransferID = result;
            }



            ClientsBusiness _client = ClientsBusiness.FindClient(ClientTransferID);

            if (_client != null)
            {

                lblTransferTabClientName.Text = _client.FirstName;
                lblTransferTabClientBalance.Text = _client.AccountBalance.ToString() + "$";



            }
            
           

            int RecvierTransFerID = 0;
            if(int.TryParse(txtTransferReciverID.Text,out int Result))
            {
                RecvierTransFerID = Result;
            }

            ClientsBusiness Reciver = ClientsBusiness.FindClient(RecvierTransFerID);
            if(Reciver!=null)
            {
                lblReciverTranferTabName.Text = Reciver.FirstName;
                lblReciverTranferTabBalance.Text = Reciver.AccountBalance.ToString();
            }

        }


        void SaveToTransFer()
        {
            int ClientTransferID = 0;

            if (int.TryParse(txtSenderIDTransFerTab.Text, out int result))
            {
                ClientTransferID = result;
            }

            ClientsBusiness _client = ClientsBusiness.FindClient(ClientTransferID);

            float Amount = Convert.ToSingle(txtTransFerAmount.Text);

            int ReciverID = 0;

            if (int.TryParse(txtTransferReciverID.Text, out int Reciverresult))
            {
                ReciverID = Reciverresult;
            }

            ClientsBusiness Reciver = ClientsBusiness.FindClient(ReciverID);

            if (_client != null)
            {



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
            }
            else
            {
                MessageBox.Show("the Client Doesn't Exist", "Erro", MessageBoxButtons.OK);

            }

            loadDataToTransFer();
            LoadLists();
        }

        private void txtSenderIDTransFerTab_TextChanged(object sender, EventArgs e)
        {
            loadDataToTransFer();
        }

        private void txtTransferReciverID_TextChanged(object sender, EventArgs e)
        {
            loadDataToTransFer();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveToTransFer();
        }

        void ClearTransFer()
        {
            txtSenderIDTransFerTab.Clear();
            txtTransferReciverID.Clear();
            txtTransFerAmount.Clear();
            lblTransferTabClientBalance.Text = "??";
            lblTransferTabClientName.Text = "??";
            lblReciverTranferTabName.Text = "??";
            lblReciverTranferTabBalance.Text = "??";
        }


        private void btnClearTransFer_Click(object sender, EventArgs e)
        {
            ClearTransFer();
        }

    }
}
