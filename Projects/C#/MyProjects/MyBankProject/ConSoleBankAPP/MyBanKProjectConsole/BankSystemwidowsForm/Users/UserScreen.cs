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

namespace BankSystemwidowsForm.Users
{
    public partial class UserScreen : Form
    {
        public UserScreen()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tDeleteUser_Click(object sender, EventArgs e)
        {

        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser(-1);
            frm.ShowDialog();
            LoadUserSList();
        }



        private void UserScreen_Load(object sender, EventArgs e)
        {
            LoadUserSList();
        }


        void LoadUserSList()
        {
            dgvListUser.DataSource = UserBussinees.GetAllUsers();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser((int)dgvListUser.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            LoadUserSList();
        }



        void DeleteUser(int ID)
        {
            if(UserBussinees.DeleteUserbyID(ID))
            {
                MessageBox.Show("The User is deleted ", "confrim", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("The Deletion is Failed", "confrim", MessageBoxButtons.OK);
            }

            LoadUserSList();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("are you sure ", "confrim", MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                DeleteUser((int)dgvListUser.CurrentRow.Cells[0].Value);
            }
        }

        private void dgvListUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
