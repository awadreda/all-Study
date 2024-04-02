using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess_The_Word
{
   
    public partial class Form1 : Form
    {
        private String _Word = "donkey";// لازم الكلمة تكون من 6 حروف
        private string _WordFromUser;
        public Form1()
        {
            InitializeComponent();
        }

        void FillWordFromUserWithSpace()
        {
            _WordFromUser = "";
            for (byte i = 0; i < _Word.Length; i++)
            {
                _WordFromUser += " ";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillWordFromUserWithSpace();
        }

        bool CheckLetterIsRightAndInPlace(int Index, char[] arrWordFromUser, char[] arrWord)
        {
           
            return (arrWord[Index]== arrWordFromUser[Index]);
        }

        bool CheckLetterIsRightButNotInPlace(int Index, char[] arrWordFromUser, char[] arrWord)
        {

            for(byte i = 0; i<_Word.Length;i++)
            {
                if (_Word[i] == arrWordFromUser[Index])
                    return true;
            }

            return false;
        }

        private void ConvartArrWordFromUserToWordFromUser(char[] arrWordFromUser)
        {
            string WordFromUser = "";

            for(byte i =0;i<arrWordFromUser.Length;i++)
            {
                WordFromUser+= arrWordFromUser[i];
            }

            _WordFromUser = WordFromUser;
        }

        private void TextChange(object sender, EventArgs e)
        {
            if(((TextBox)sender).Tag.ToString()=="0")
            {
                FillWordFromUserWithSpace();
            }

            int Index  = Convert.ToInt32(((TextBox)sender).Tag);
            char ch = Convert.ToChar (((TextBox)sender).Text);

            char[] arrWordFromUser = _WordFromUser.ToCharArray();
            arrWordFromUser[Index] = ch;

           
            ConvartArrWordFromUserToWordFromUser(arrWordFromUser);

            char[] arrWord = _Word.ToCharArray();

            ((TextBox)sender).ForeColor = Color.White;
            ((TextBox)sender).Enabled = false;

            if (CheckLetterIsRightAndInPlace(Index,arrWordFromUser,arrWord))
            {              
                ((TextBox)sender).BackColor = Color.Green;
            }
            else if(CheckLetterIsRightButNotInPlace(Index, arrWordFromUser, arrWord))
            {
                ((TextBox)sender).BackColor = Color.Blue;
            }
            else
            {
                ((TextBox)sender).BackColor = Color.Black;
            }

            EnableAndDisablePanal();
        }
        private bool IsThereSpaceInWord()
        {

            for (byte i = 0; i < _WordFromUser.Length; i++)
            {
                if (_WordFromUser[i] == ' ')
                    return true;
            }
            return false;
        }
       private void EnableAndDisablePanal()
        {
            if(txt24.Text != string.Empty && !IsThereSpaceInWord())
            {

                panel4.Enabled = false;
                panel5.Enabled = true;
                return;
            }

            if (txt18.Text != string.Empty && !IsThereSpaceInWord())
            {


                panel3.Enabled = false;
                panel4.Enabled = true;
                return;
            }

            if (txt12.Text != string.Empty && !IsThereSpaceInWord())
            {

                panel2.Enabled = false;
                panel3.Enabled = true;
                return;
            }

            if (txt6.Text != string.Empty && !IsThereSpaceInWord())
            {
                
                panel1.Enabled = false;
                panel2.Enabled = true;
                return;
            }
        }

        private void btnTwoHint_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"The first letter is: {_Word[0]}","Hint 1",MessageBoxButtons.OK,MessageBoxIcon.Information);
            MessageBox.Show($"The last letter is: {_Word[_Word.Length-1]}", "Hint 1", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnCheckWord_Click(object sender, EventArgs e)
        {
            if (_WordFromUser == _Word)
            {
                MessageBox.Show($"You Win", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panel1.Enabled = false;
                panel2.Enabled = false;
                panel3.Enabled = false;
                panel4.Enabled = false;
                panel5.Enabled = false;
                return;
            }

            MessageBox.Show($"You haven't won yet", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
