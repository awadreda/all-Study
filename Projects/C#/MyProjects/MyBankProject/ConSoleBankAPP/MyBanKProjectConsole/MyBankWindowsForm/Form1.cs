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

namespace MyBankWindowsForm
{
    public partial class Form1 : Form
    {

        public enum enMode { addNew=1,Upadate=2};
        private enMode _mode;

        int _ClientID;
        ClientsBusiness Client;

        public Form1()
        {
            InitializeComponent();
        }

        


        private void btnFind_Click(object sender, EventArgs e)
        {
        

        }

        private void txtIDToFInd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void clientInfoToFind_Load(object sender, EventArgs e)
        {

        }
    }
}
