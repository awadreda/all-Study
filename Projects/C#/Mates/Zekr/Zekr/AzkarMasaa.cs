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

namespace Zekr
{
    public partial class AzkarMasaa : Form
    {
        public AzkarMasaa()
        {
            InitializeComponent();
        }

        Font GetFont()
        {
            PrivateFontCollection privateFonts1 = new PrivateFontCollection();
            privateFonts1.AddFontFile(@"D:\Z-fonts\ArbFONTS-Hacen Tunisia.ttf");

            Font ThickFont = new Font(privateFonts1.Families[0], 12);

            return ThickFont;
        }

        // class el azkar
        class ZekrMasaaInfo
        {
            public Image ZekrImage;
        }

        LinkedList<ZekrMasaaInfo> AzkarElMasaa = new LinkedList<ZekrMasaaInfo>();

        short[] NumberOfRepit = { 1, 1, 3, 3, 3, 1, 1, 3, 4, 1, 7, 3, 1, 1, 3, 3, 3, 1, 3, 1, 1, 3, 10, 3, 3, 3, 3, 100, 1, 100 };

        short Count = 0;

        void GetAzkarData()
        {
            for (byte i = 1; i <= 30; i++)
            {
                ZekrMasaaInfo Zekr = new ZekrMasaaInfo();
                Zekr.ZekrImage = Image.FromFile($@"D:\Raod map !!\k الكورس الرابع عشر\Project !!\Zekr\صور مستخدمة\M\{i}.png");
                AzkarElMasaa.AddLast(Zekr);
            }
        }

        private void AzkarMasaa_Load(object sender, EventArgs e)
        {
            lblTittlebage.Font = GetFont();
            lblTittlebage.Font = new Font(lblTittlebage.Font.FontFamily, 30);

            lblCountRepit.Font = GetFont();
            lblCountRepit.Font = new Font(lblTittlebage.Font.FontFamily, 24);

            GetAzkarData();
        }

        private void btnNextZekr_Click(object sender, EventArgs e)
        {
            var Temp = AzkarElMasaa;


            if (AzkarElMasaa.Count > 0)
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









    }
}
