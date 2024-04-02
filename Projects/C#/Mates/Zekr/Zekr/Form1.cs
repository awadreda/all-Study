using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zekr.Properties;

namespace Zekr
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static class MyFonts
        {
            //الخط العريض
            public static Font ThickFont;

            // الخط الرفيع
            public static Font ThinFont;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PrivateFontCollection privateFonts1 = new PrivateFontCollection();
            privateFonts1.AddFontFile(@"D:\Z-fonts\ArbFONTS-Hacen Tunisia.ttf");

            MyFonts.ThickFont = new Font(privateFonts1.Families[0], 12);


            PrivateFontCollection privateFont2 = new PrivateFontCollection();
            privateFont2.AddFontFile(@"D:\Z-fonts\Changa-Regular.ttf");

            MyFonts.ThinFont = new Font(privateFont2.Families[0], 12);

            //**********************************

            // staRT APP

            // left button
            btnHomeBage.Font = MyFonts.ThickFont;
            btnAkarBage.Font = MyFonts.ThickFont;
            btnTazkirBage.Font = MyFonts.ThickFont;
            btnMasbahaBage.Font = MyFonts.ThickFont;

            // home bage
            lblAyaaCenter.Font = MyFonts.ThickFont;
            lblNameDeveloper.Font = MyFonts.ThickFont;
            lblSubjectApp.Font = MyFonts.ThickFont;



            // azkar bage
            lblTitttleCenterAzkar.Font = MyFonts.ThickFont;
            lblTitttleCenterAzkar.Font = new Font(lblTitttleCenterAzkar.Font.FontFamily, 22);
            btnAzkarMasaa.Font = MyFonts.ThickFont;
            btnAzkarSabah.Font = MyFonts.ThickFont;

            pnlAzkarBage.Location = new Point(141, 87);
            pnlHomeBage.Location = new Point(141, 87);
            pnlSebhaBage.Location = new Point(141, 87);
            pnlTazkerBage.Location = new Point(141, 87);


            lblSelectTypeZekr.Font = MyFonts.ThickFont;
            lblSleepFor_M.Font = MyFonts.ThickFont;
            lblSelectTypeZekr.Font = new Font(lblSelectTypeZekr.Font.FontFamily, 17);
            lblSleepFor_M.Font = new Font(lblSleepFor_M.Font.FontFamily, 17);
            cmbTypeZekr.Font = MyFonts.ThickFont;
            nmrcCountMinute.Font = MyFonts.ThickFont;
            btnDone.Font = MyFonts.ThickFont;
            btnReset.Font = MyFonts.ThickFont;

        }


        //#################################################
        // main Buttin \/

        private void btnHomeBage_Click(object sender, EventArgs e)
        {
            imgIconBages.Image = Resources.Home3;
            pnlHomeBage.Visible = true;
            pnlAzkarBage.Visible = false;
            pnlSebhaBage.Visible = false;
            pnlTazkerBage.Visible = false;
        }

        private void btnAkarBage_Click(object sender, EventArgs e)
        {
            imgIconBages.Image = Resources.book;
            pnlHomeBage.Visible = false;
            pnlAzkarBage.Visible = true;
            pnlSebhaBage.Visible = false;
            pnlTazkerBage.Visible = false;
        }

        private void btnTazkirBage_Click(object sender, EventArgs e)
        {
            imgIconBages.Image = Resources.notic;
            pnlSebhaBage.Visible = false;
            pnlHomeBage.Visible = false;
            pnlAzkarBage.Visible = false;
            pnlTazkerBage.Visible = true;
        }

        private void btnMasbahaBage_Click(object sender, EventArgs e)
        {
             imgIconBages.Image= Resources.sebha;
            pnlSebhaBage.Visible = true;
            pnlHomeBage.Visible = false;
            pnlAzkarBage.Visible = false;
            pnlTazkerBage.Visible = false;
        }

        private void btnGetContact_Click(object sender, EventArgs e)
        {
            Form form = new ContactForm();
            form.ShowDialog();
        }

        //####################################################
        // azkar bage

        private void btnAzkarSabah_Click(object sender, EventArgs e)
        {
            Form form = new AzkarSabah();
            form.ShowDialog();
        }

        private void btnAzkarMasaa_Click(object sender, EventArgs e)
        {
            Form form = new AzkarMasaa();
            form.ShowDialog();
        }

        //####################################################
        //####################################################
        //Sebha Counter \/ add & clear

        int Counter = 0;

        private void btnClearCount_Click(object sender, EventArgs e)
        {
            Counter = 0;
            lblNumberOfCount.Text = Counter.ToString();
        }

        private void btnAddTasbeh_Click(object sender, EventArgs e)
        {
            Counter++;
            lblNumberOfCount.Text = Counter.ToString();
        }

        //####################################################


        //####################################################
        // Notific bage \/ 

        short MinuteOfSleep = 0;
        byte IndexOfChoose;
        private string GetPeriodSleepString(short Minute)
        {
            if (Minute == 1)
            {
                return "دقيقة";

            }
            if (Minute == 2)
            {
                return "دقيقتان";
            }
            if (Minute >= 3)
            {
                return $"{Minute} دقائق";
            }
            return "";
        }
        private void timerNotifice_Tick(object sender, EventArgs e)
        {
            NtfcNoticTazker.Icon = SystemIcons.Application;
            NtfcNoticTazker.BalloonTipIcon = ToolTipIcon.Info;
            NtfcNoticTazker.BalloonTipTitle = "تطبيق ذكر";
            NtfcNoticTazker.BalloonTipText = cmbTypeZekr.Items[IndexOfChoose].ToString();
            NtfcNoticTazker.ShowBalloonTip(1000);
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (nmrcCountMinute.Value != 0 && cmbTypeZekr.SelectedIndex >= 0)
            {
                // minute of sleep
                MinuteOfSleep = (short)nmrcCountMinute.Value;
                // index of choose in Combo box
                IndexOfChoose = (byte)cmbTypeZekr.SelectedIndex;
                // format minute
                string MessageMinute = GetPeriodSleepString(MinuteOfSleep);

                timerNotifice.Interval = MinuteOfSleep * 60 * 1000;

                // this line for tring
               // timerNotifice.Interval = 3000;

                timerNotifice.Enabled = true;


                MessageBox.Show($"تم تعيين ({cmbTypeZekr.Items[IndexOfChoose].ToString()}) " +
                    $", و سيتم ارسالها كل {MessageMinute}", "تم التعيين بنجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            timerNotifice.Stop();
            cmbTypeZekr.SelectedIndex = -1;
            nmrcCountMinute.Value = 0;
        }

        private void pnlTazkerBage_Paint(object sender, PaintEventArgs e)
        {

        }
        //####################################################





    }
}
