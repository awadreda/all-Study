using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class frmHistory : Form
    {
        string[] _Array;
        public frmHistory(string[] array)
        {
            InitializeComponent();
            _Array = array;
        }

        private void frmHistory_Load(object sender, EventArgs e)
        {
            if (_Array[0]==null)
            {
                ListViewItem item = new ListViewItem("Empty!");
                listView1.Items.Add(item);
                return;
            }
            for (int i = 0; i < _Array.Length; i++)
            {
                if (_Array[i] != "")
                {
                    ListViewItem Item = new ListViewItem(_Array[i]);
                    listView1.Items.Add(Item);
                }
            }
        }
    }
}
