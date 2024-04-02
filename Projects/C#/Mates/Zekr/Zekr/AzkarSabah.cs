using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using Zekr.Properties;


namespace Zekr
{
    public partial class AzkarSabah : Form
    {
        public AzkarSabah()
        {
            InitializeComponent();
        }

        // get my font
        Font GetFont()
        {
            PrivateFontCollection privateFonts1 = new PrivateFontCollection();
            privateFonts1.AddFontFile(@"D:\Z-fonts\ArbFONTS-Hacen Tunisia.ttf");

            Font ThickFont = new Font(privateFonts1.Families[0], 12); 

            return ThickFont;
        }

        // class el azkar
        class ZekrSabahInfo
        {
           public Image ZekrImage;
        }

        LinkedList<ZekrSabahInfo> AzkarElSabah = new LinkedList<ZekrSabahInfo>();

        short[] NumberOfRepit = { 1,3,3,3,1,1,3,4,1,7,3,1,1,3,3,3,1,3,1,1,3,10,3,3,3,3,1,1,100,100,100 };

        short Count = 0;
       

        // get iamges azkar
        void GetAzkarData()
        {
            for (byte i = 1; i <= 31; i++)
            {
                ZekrSabahInfo Zekr = new ZekrSabahInfo();
                Zekr.ZekrImage = Image.FromFile($@"D:\Raod map !!\k الكورس الرابع عشر\Project !!\Zekr\صور مستخدمة\S\{i}.png");
                AzkarElSabah.AddLast(Zekr);
            }
        }

        // start form
        private void AzkarSabah_Load(object sender, EventArgs e)
        {      
            lblTittlebage.Font = GetFont();
            lblTittlebage.Font = new Font(lblTittlebage.Font.FontFamily, 30);

            lblCountRepit.Font = GetFont();
            lblCountRepit.Font = new Font(lblTittlebage.Font.FontFamily, 26);

            GetAzkarData();

        }

       // click next
        private void btnNextZekr_Click(object sender, EventArgs e)
        {
            var Temp = AzkarElSabah;


            if (AzkarElSabah.Count > 0)
            {        
                lblTittlebage.Visible = false;

                // set location button
                btnNextZekr.Location = new Point(419, 385);

                // set image
                pboxZekrImage.Image = Temp.First.Value.ZekrImage;
                Temp.Remove(Temp.First);

                // set label

                lblCountRepit.Visible = true;
                string i = NumberOfRepit[Count].ToString();
                lblCountRepit.Text = $"عدد التكرار {i}";
                Count++;
            }
            else
            {

                btnNextZekr.Enabled = false;

            }    
        }

        private void lblTittlebage_Click(object sender, EventArgs e)
        {

        }
    }
}
