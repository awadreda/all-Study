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
using BankSystemwidowsForm.TransActions;

using BankSystemwidowsForm.CLients;


namespace BankSystemwidowsForm
{
    public partial class frmClientsScreen : Form
    {
        public enum enmode { Addnew = 1, Update };
        private enmode _Mode;
        int CLientID;

        ClientsBusiness client;


        public frmClientsScreen()
        {
            InitializeComponent();
        }




        void SearchClient()
        {
            int id;
            if (int.TryParse(txtClientID.Text, out int index))
            {
                id = index;
            }
            else
            {
                MessageBox.Show("Enter validNumber", "Info", MessageBoxButtons.OK);
                txtClientID.Clear();
                return;
            }


            if (ClientsBusiness.isClientExistbyID(id))
            {
                client = ClientsBusiness.FindClient(id);

                fillClientCard();

            }
            else
            {
                MessageBox.Show("The Client Doen't Exist ", "info", MessageBoxButtons.OK);
            }
        }


        void MakeBokesReadOnlyForFIndScreen()
        {


            txtFirstName.ReadOnly = true;
            txtLastName.ReadOnly = true;
            txtPhone.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtPinCode.ReadOnly = true;
            txtAcountNumber.ReadOnly = true;
            txtAccountBanlance.ReadOnly = true;
        }


        void fillClientCard()
        {
            if (client != null)
            {
                pCard.Visible = true;
                pCard.Enabled = true;
                MakeBokesReadOnlyForFIndScreen();

                lblClientID.Text = client.ClientID.ToString();
                txtFirstName.Text = client.FirstName;
                txtLastName.Text = client.LastName;
                txtPhone.Text = client.Phone;
                txtEmail.Text = client.Email;
                txtPinCode.Text = client.PINCODE;
                txtAcountNumber.Text = client.AccountNumber;
                txtAccountBanlance.Text = client.AccountBalance.ToString();



            }
            else
            {
                MessageBox.Show("The Client Doen't Exist ", "info", MessageBoxButtons.OK);
            }
        }


        void FillClientEditCard()
        {

            if (client != null)
            {
                pEditCard.Visible = true;
                pEditCard.Enabled = true;


                txtpEditClientID.Text = client.ClientID.ToString();
                txtpEditFirstName.Text = client.FirstName;
                txtpEditLastName.Text = client.LastName;
                txtpEditPhone.Text = client.Phone;
                txtpEditEmail.Text = client.Email;
                txtpEditPinCode.Text = client.PINCODE;
                txtpEditAcountNumber.Text = client.AccountNumber;
                txtpEditAccountBanlance.Text = client.AccountBalance.ToString();



            }
            else
            {
                MessageBox.Show("The Client Doen't Exist ", "info", MessageBoxButtons.OK);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            SearchClient();
        }


        void RefreshListClients()
        {
            dgvListClients.DataSource = ClientsBusiness.GetClientList();

        }



        void LoadPage()
        {
            pListClient.Visible = true;
            pListClient.Enabled = true;
            //else Screens
            pEdit.Visible = false;
            pEdit.Enabled = false;
            pAddNew.Visible = false;
            pAddNew.Enabled = false;
            pDeleteScreen.Visible = false;
            pDeleteScreen.Enabled = false;
            pFindScreen.Visible = false;
            pFindScreen.Enabled = false;

            RefreshListClients();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPage();

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            MangeScreens((Button)sender);

        }


        void MangeScreens(Button b1)
        {
            if (b1.Tag.ToString() == "Find")
            {
                pFindScreen.Visible = true;
                pFindScreen.Enabled = true;
                //else Screens
                pEdit.Visible = false;
                pEdit.Enabled = false;
                pListClient.Visible = false;
                pListClient.Enabled = false;
                pAddNew.Visible = false;
                pAddNew.Enabled = false;
                pDeleteScreen.Visible = false;
                pDeleteScreen.Enabled = false;
            }
            else if (b1.Tag.ToString() == "List")
            {
                pListClient.Visible = true;
                pListClient.Enabled = true;
                //else Screens
                pEdit.Visible = false;
                pEdit.Enabled = false;
                pAddNew.Visible = false;
                pAddNew.Enabled = false;
                pDeleteScreen.Visible = false;
                pDeleteScreen.Enabled = false;
                pFindScreen.Visible = false;
                pFindScreen.Enabled = false;

            }
            else if (b1.Tag.ToString() == "Edit")
            {
                pEdit.Visible = true;
                pEdit.Enabled = true;
                ///
                pListClient.Visible = false;
                pListClient.Enabled = false;
                pFindScreen.Visible = false;
                pFindScreen.Enabled = false;
                pAddNew.Visible = false;
                pAddNew.Enabled = false;
                pDeleteScreen.Visible = false;
                pDeleteScreen.Enabled = false;

            }
            else if (b1.Tag.ToString() == "AddNew")
            {
                pListClient.Visible = false;
                pListClient.Enabled = false;
                pFindScreen.Visible = false;
                pFindScreen.Enabled = false;
                pEdit.Visible = false;
                pEdit.Enabled = false;
                pDeleteScreen.Visible = false;
                pDeleteScreen.Enabled = false;
                ////
                pAddNew.Visible = false;
                pAddNew.Visible = true;
                pAddNew.Enabled = true;
            }
            else if(b1.Tag.ToString()== "Delete")
            {

                pListClient.Visible = false;
                pListClient.Enabled = false;
                pFindScreen.Visible = false;
                pFindScreen.Enabled = false;
                pEdit.Visible = false;
                pEdit.Enabled = false;
                pAddNew.Visible = false;
                pAddNew.Enabled = false;
                ////
                pDeleteScreen.Visible = true;
                pDeleteScreen.Enabled = true;


            }


            else
            {
                pListClient.Visible = true;
                pListClient.Enabled = true;
                //else Screens
                pEdit.Visible = false;
                pEdit.Enabled = false;
                pAddNew.Visible = false;
                pAddNew.Enabled = false;
                //pDelete.Visible = false;
                //pDelete.Enabled = false;
                pFindScreen.Visible = false;
                pFindScreen.Enabled = false;
            }
        }

        private void btnListClients_Click(object sender, EventArgs e)
        {
            MangeScreens((Button)sender);
            RefreshListClients();
        }



        void SearchTOEdit()
        {
            if (rdFindByID.Checked == true)
            {
                int id;
                if (int.TryParse(txtSearchBox.Text, out int index))
                {
                    id = index;
                }
                else
                {
                    MessageBox.Show("Enter validNumber", "Info", MessageBoxButtons.OK);
                    txtSearchBox.Clear();
                    return;
                }





                if (ClientsBusiness.isClientExistbyID(id))
                {
                    client = ClientsBusiness.FindClient(id);

                    if (client != null)
                    {

                        FillClientEditCard();
                        btnSaveEdit.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("The Client is Not Fount  ", "info", MessageBoxButtons.OK);
                        txtSearchBox.Clear();

                        return;
                    }

                }
                else
                {
                    MessageBox.Show("The Client Doen't Exist ", "info", MessageBoxButtons.OK);
                    txtSearchBox.Clear();

                    return;
                }

            }
            else
            {

                string AccountNumber = txtSearchBox.Text;
                client = ClientsBusiness.FindClientByAccountNumber(AccountNumber);

                //fillClientCard();

                if (client != null)
                {

                    FillClientEditCard();
                    btnSaveEdit.Enabled = true;

                }
                else
                {

                    MessageBox.Show("The Client is Not Fount  ", "info", MessageBoxButtons.OK);
                    txtSearchBox.Clear();

                    return;

                }



            }
        }

        private void btnSearchToEdit_Click(object sender, EventArgs e)
        {
            SearchTOEdit();
        }

        void SaveEdit()
        {



            client.FirstName = txtpEditFirstName.Text;
            client.LastName = txtpEditLastName.Text;
            client.Phone = txtpEditPhone.Text;

            client.Email = txtpEditEmail.Text;
            client.PINCODE = txtpEditPinCode.Text;
            client.AccountNumber = txtpEditAcountNumber.Text;
            client.AccountBalance = Convert.ToSingle(txtpEditAccountBanlance.Text);

            if (client.Save())
            {
                MessageBox.Show("Saved", "Done", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Somthing wrong , Not Saved", "Not Done", MessageBoxButtons.OK);

            }



        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to save ", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                SaveEdit();
            }

        }

       

        private void pEdit_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pFindScreen_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void pAddNewCard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddNewTrunPanl_Click(object sender, EventArgs e)
        {

        }

        void RestAddNew()
        {
            txtAddFirstName.Clear();
            txtAddLastName.Clear();
            txtAddEmail.Clear();
            txtAddPhone.Clear();
            txtAddPinCode.Clear();
            txtAddAccountBanlance.Clear();
            txtAddAcountNumber.Clear();


        }

        void Cancel()
        {
            RestAddNew();

            pAddNewCard.Visible = false;
            pAddNewCard.Enabled = false;
            btnSaveAddNEw.Enabled = false;


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();

        }

        private void btnAddNewTrunPanl_Click_1(object sender, EventArgs e)
        {
            btnSaveAddNEw.Enabled = true;
            pAddNewCard.Visible = true;
            pAddNewCard.Enabled = true;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            RestAddNew();
        }

        void SaveAddNew()
        {
            ClientsBusiness NewClient= new ClientsBusiness();

           NewClient.FirstName =        txtAddFirstName.Text;
           NewClient.LastName =         txtAddLastName.Text;
           NewClient.Phone =            txtAddPhone.Text;
                                        
           NewClient.Email =            txtAddEmail.Text;
           NewClient.PINCODE =          txtAddPinCode.Text;
           NewClient.AccountNumber =    txtAddAcountNumber.Text;
            NewClient.AccountBalance =   Convert.ToSingle(txtAddAccountBanlance.Text);

            if (NewClient.Save())
            {
                MessageBox.Show("The Client is Added", "Done", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Somthing wrong , Not Saved", "Not Done", MessageBoxButtons.OK);

            }




        }

        private void btnSaveAddNEw_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are sure to add this CLient","confim",MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                SaveAddNew();

            }

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Cancel();
        }

        private void pAddNew_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEditScreen_Click(object sender, EventArgs e)
        {
            MangeScreens((Button)sender);
        }

        private void btnAddNewSCreen_Click(object sender, EventArgs e)
        {
            MangeScreens((Button)sender);
        }



        //// Delete Screen
        
            
            void SearchToDelete()
        {
            int id;
            if (int.TryParse(txtClientIDForDelete.Text, out int index))
            {
                id = index;
            }
            else
            {
                MessageBox.Show("Enter validNumber", "Info", MessageBoxButtons.OK);
                txtClientIDForDelete.Clear();
                return;
            }


            if (ClientsBusiness.isClientExistbyID(id))
            {

                ClientsBusiness Deletleclient = ClientsBusiness.FindClient(id);

                fillClientCradToDelete(Deletleclient);
                btnDelete.Enabled = true;

            }
            else
            {
                MessageBox.Show("The Client Doen't Exist ", "info", MessageBoxButtons.OK);
            }
        }


        void MakeBokesReadOnlyForDeleteScreen()
        {
            

            txtDeleteFirstName.ReadOnly = true;
            txtDeleteLastName.ReadOnly = true;
            txtDeletePhone.ReadOnly = true;
            txtDeleteEmail.ReadOnly = true;
            txtDeletePinCode.ReadOnly = true;
            txtDeleteAcountNumber.ReadOnly = true;
            txtDeleteAccountBanlance.ReadOnly = true;
        }




        void fillClientCradToDelete(ClientsBusiness xclient)
        {
            if (xclient != null)
            {
                pDeleteCard.Visible = true;
                pDeleteCard.Enabled = true;
                MakeBokesReadOnlyForDeleteScreen();


                lblDeleteClientID.Text =        xclient.ClientID.ToString();
                txtDeleteFirstName.Text =       xclient.FirstName;
                txtDeleteLastName.Text =        xclient.LastName;
                txtDeletePhone.Text =           xclient.Phone;
                txtDeleteEmail.Text =           xclient.Email;
                txtDeletePinCode.Text =         xclient.PINCODE;
                txtDeleteAcountNumber.Text =    xclient.AccountNumber;
                txtDeleteAccountBanlance.Text = xclient.AccountBalance.ToString();



            }
            else
            {
                MessageBox.Show("The Client Doesn't Exist ", "info", MessageBoxButtons.OK);
            }



        }


        void DeleteClient(int ClientId)
        {

            if (ClientsBusiness.isClientExistbyID(ClientId))
            {

                if(ClientsBusiness.DeleteClientByID(ClientId))
                {
                    MessageBox.Show("Deleted ya brans", "Confirm", MessageBoxButtons.OK);
                    AfterDelelted();

                }
                else
                {
                    MessageBox.Show("The Client is not Deleted ", "info", MessageBoxButtons.OK);

                }

            }
            else
            {
                MessageBox.Show("The Client Doen't Exist ", "info", MessageBoxButtons.OK);

            }




        }



        

        private void btnSearchforDelete_Click(object sender, EventArgs e)
        {
            SearchToDelete();


        }


        void ClearPDeleteCard()
        {
            lblDeleteClientID.Text = "???";           
             txtDeleteFirstName.Clear();            
              txtDeleteLastName.Clear();              
                 txtDeletePhone.Clear();               
                 txtDeleteEmail.Clear();               
               txtDeletePinCode.Clear();            
          txtDeleteAcountNumber.Clear();       
       txtDeleteAccountBanlance.Clear();  
                               


        }

        void AfterDelelted()
        {
            ClearPDeleteCard();
            pDeleteCard.Enabled = false;
            pDeleteCard.Visible = false;
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            

            if(MessageBox.Show("Are you sure to delete this client","Confirm",MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
               DeleteClient(Convert.ToInt16(lblDeleteClientID.Text));

               


            }
            else
            {
                MessageBox.Show("Not Deleted", "Confirm", MessageBoxButtons.OK);
            }

        }

        

        private void btnDeleteScreen_Click(object sender, EventArgs e)
        {
            MangeScreens((Button)sender);
        }

        private void dgvListClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       //ContaxtMinue


        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("are you sure","confirm",MessageBoxButtons.OKCancel)==DialogResult.OK)
            {

            DeleteClient((int)dgvListClients.CurrentRow.Cells[0].Value);
            }
            RefreshListClients();

        }

        private void editClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditFormClinet frm = new frmAddEditFormClinet( (int)dgvListClients.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            RefreshListClients();
        }



        private void pListClient_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtpEditPinCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditFormClinet frm = new frmAddEditFormClinet(-1);
            frm.ShowDialog();
            RefreshListClients();

        }

        private void depToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)dgvListClients.CurrentRow.Cells[0].Value;
            DepositePopWidow frm = new DepositePopWidow(id);
            frm.ShowDialog();
            RefreshListClients();
        }

        private void withDrawToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int id = (int)dgvListClients.CurrentRow.Cells[0].Value;
            WithDrawPopWindow frm = new WithDrawPopWindow(id);
            frm.ShowDialog();
            RefreshListClients();

        }

        private void transActionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)dgvListClients.CurrentRow.Cells[0].Value;

            TransferPopWindow transfer = new TransferPopWindow(id);
            transfer.ShowDialog();
            RefreshListClients();
  
        }
    }
}
