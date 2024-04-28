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
using BankSystemwidowsForm.Main;


namespace BankSystemwidowsForm
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }






        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        void login()
        {
            
            string Username = txtUserName.Text;
            string password = txtPassword.Text;

            Global.CurrentUser = UserBussinees.FindUserNameAndPassword(Username, password);

            if(Global.CurrentUser==null)
            {
                MessageBox.Show("The UserName or the password are not Correct" ,"Info",MessageBoxButtons.OK);
            }
            else
            {
                MainScreen frm = new MainScreen();
                this.Hide();
                frm.ShowDialog();
                this.Show();
                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
