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

namespace BankSystemwidowsForm.Main
{
    public partial class frmAddEditUser : Form
    {

        enum enPermissions { pAll=-1, pMangeClients=1, pTransActions = 2, pMangeUsers=4,pLogin=8 };



        enum enMode { AddnewUser=1,UpdateUser=2};
        private int _UserID;
        UserBussinees user;

        enMode mode;

        public frmAddEditUser(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;
            if(_UserID!=-1)
            {
                mode = enMode.UpdateUser;
            }
            else
            {
                mode = enMode.AddnewUser;
            }
        }



        int  Readpermissions()
        {
            int permissions = 0;

            if(chbpAll.Checked)
            {
                chbpMangeClients.Enabled = false;
                chpLogin.Enabled = false;
                chpMangeUsers.Enabled = false;
                chpTransActions.Enabled = false;

                return -1;

            }
            else
            {
                chbpMangeClients.Enabled =       true;
                chpLogin.Enabled =               true;
                chpMangeUsers.Enabled =          true;
                chpTransActions.Enabled =        true;

            }

            if(chpMangeUsers.Checked)
            {
                permissions += (int) enPermissions.pMangeUsers;
                

            }

            if(chbpMangeClients.Checked)
            {
                permissions += (int)enPermissions.pMangeClients;

            }

            if(chpTransActions.Checked)
            {
                permissions += (int)enPermissions.pTransActions;

            }

            if(chpLogin.Checked)
            {
                permissions += (int)enPermissions.pLogin;
                
            }

            


            return permissions;
        }


        bool checkPermission(enPermissions permission ,int  ueserPermission)
        {
            if (permission == enPermissions.pAll)
                return true;

            if(( (int)permission & ueserPermission) ==(int) permission)

            {
                return true;
            }
            else
            {
                return false;

            }
        }

        void UserPermissions(int userpermissions )
        {
            if(userpermissions   == -1)
            {
                chbpAll.Checked = true;
                chbpMangeClients.Enabled = false;
                chpLogin.Enabled = false;
                chpMangeUsers.Enabled = false;
                chpTransActions.Enabled = false;
                return;

            }

            if( checkPermission(enPermissions.pMangeClients,userpermissions) )
            {
                chbpMangeClients.Checked = true;
            }

            if(checkPermission(enPermissions.pMangeUsers,userpermissions))
            {
                chpMangeUsers.Checked = true;
            }

            if(checkPermission(enPermissions.pTransActions,userpermissions))
            {
                chpTransActions.Checked = true;
            }

            if(checkPermission(enPermissions.pLogin,userpermissions))
            {
                chpLogin.Checked = true;
            }

           
        }

        void LoadData()
        {
            if(mode==enMode.AddnewUser)
            {
                lblMode.Text = "Add New User";
                user = new UserBussinees();
                return;
            }

            user = UserBussinees.FindUserByID(_UserID);


            lblMode.Text = "Edit User " + user.User_ID;


            lblUserID.Text     =     user.User_ID.ToString()      ;
            txtFirstName.Text  =   user.FirstName                  ;
            txtLastName.Text   =   user.LastName                  ;
            txtEmail.Text      =      user.Email                  ;
            txtPhone.Text      =      user.Phone                  ;
            txtUserName.Text   =   user.UserName                  ;
            txtPassword.Text   =   user.Password                  ;
                                                                  

            UserPermissions(user.Permission);
            
        }




      void  save()
        {

            user.FirstName = txtFirstName.Text;
            user.LastName = txtLastName.Text;
            user.Email = txtEmail.Text;
            user.Phone = txtPhone.Text;
            user.UserName = txtUserName.Text;
            user.Password = txtPassword.Text;
            user.Permission = Readpermissions();

                if(user.Save())
            {
                MessageBox.Show("the user is saved", "Confirm", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("the user is not Saved","Confirm",MessageBoxButtons.OK);
            }
            lblMode.Text = "Edit user " + user.User_ID.ToString();
            mode = enMode.UpdateUser;
            lblUserID.Text = _UserID.ToString();

        }




        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
           Readpermissions();

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblMode_Click(object sender, EventArgs e)
        {

        }

        private void txtAccountNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void chbpAll_CheckedChanged(object sender, EventArgs e)
        {
            Readpermissions();
        }

        private void chbpMangeClients_CheckedChanged(object sender, EventArgs e)
        {
            Readpermissions();
        }

        private void chpTransActions_CheckedChanged(object sender, EventArgs e)
        {
            Readpermissions();
        }

        private void chpMangeUsers_CheckedChanged(object sender, EventArgs e)
        {
            Readpermissions();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(" are you sure ","Confirm",MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                save();
            }
             
        }
    }
}
