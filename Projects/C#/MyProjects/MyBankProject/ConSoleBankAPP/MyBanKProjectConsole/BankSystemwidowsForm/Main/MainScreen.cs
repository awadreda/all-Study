using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankSystemwidowsForm.Users;
using BankbusinessLayer;
using BankSystemwidowsForm.TransActions;



namespace BankSystemwidowsForm.Main
{
    public partial class MainScreen : Form
    {

        enum enPermissions { pAll = -1, pMangeClients = 1, pTransActions = 2, pMangeUsers = 4, pLogin = 8 };


        public MainScreen()
        {
            InitializeComponent();
        }



        bool checkPermission(enPermissions permission, int ueserPermission)
        {
            if (permission == enPermissions.pAll)
                return true;

            if (((int)permission & ueserPermission) == (int)permission)

            {
                return true;
            }
            else
            {
                return false;

            }
        }




        private void btnMangeUsers_Click(object sender, EventArgs e)
        {

            if(checkPermission(enPermissions.pMangeUsers,Global.CurrentUser.Permission))
            {


            UserScreen user = new UserScreen();
            this.Hide();
            user.ShowDialog();
            this.Show();

            }
            else
            {
                MessageBox.Show("the Permission Denied ", "info", MessageBoxButtons.OK);
            }


        }



        private void btnMangeClients_Click(object sender, EventArgs e)
        {

            if (checkPermission(enPermissions.pMangeClients, Global.CurrentUser.Permission))
            {
                frmClientsScreen frmClientsScreen = new frmClientsScreen();
            this.Hide();
            frmClientsScreen.ShowDialog();
            this.Show();

            }
            else
            {
                MessageBox.Show("the Permission Denied ", "info", MessageBoxButtons.OK);

            }

        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Close();

            Application.Exit();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            UserBussinees.RegistLog(Global.CurrentUser.User_ID, 2);
            Global.CurrentUser = UserBussinees.FindUserNameAndPassword("", "");
        //    LoginScreen log = new LoginScreen();
          //  this.Hide();
     //  log.Show();
            this.Close();
        }

        void LoadData()
        {
            lblUserName.Text = Global.CurrentUser.UserName;
        }



        private void btnTransActions_Click(object sender, EventArgs e)
        {
            if(checkPermission(enPermissions.pTransActions,Global.CurrentUser.Permission))
            {
                TransActionsList trans = new TransActionsList();
                this.Hide();
                trans.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("the Permission Denied ", "info", MessageBoxButtons.OK);

            }
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
