namespace Zekr
{
    partial class AzkarMasaa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AzkarMasaa));
            this.lblCountRepit = new System.Windows.Forms.Label();
            this.lblTittlebage = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnNextZekr = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.pboxZekrImage = new System.Windows.Forms.PictureBox();
            this.pboxBackGround = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxZekrImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBackGround)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCountRepit
            // 
            this.lblCountRepit.AutoSize = true;
            this.lblCountRepit.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountRepit.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblCountRepit.Location = new System.Drawing.Point(193, 376);
            this.lblCountRepit.Name = "lblCountRepit";
            this.lblCountRepit.Size = new System.Drawing.Size(20, 25);
            this.lblCountRepit.TabIndex = 24;
            this.lblCountRepit.Text = "-";
            this.lblCountRepit.Visible = false;
            // 
            // lblTittlebage
            // 
            this.lblTittlebage.BackColor = System.Drawing.Color.Transparent;
            this.lblTittlebage.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittlebage.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblTittlebage.Location = new System.Drawing.Point(310, 232);
            this.lblTittlebage.Name = "lblTittlebage";
            this.lblTittlebage.Size = new System.Drawing.Size(186, 41);
            this.lblTittlebage.TabIndex = 23;
            this.lblTittlebage.Text = "المساء اذكار";
            // 
            // btnNextZekr
            // 
            this.btnNextZekr.BackColor = System.Drawing.Color.Transparent;
            this.btnNextZekr.BorderRadius = 20;
            this.btnNextZekr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextZekr.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNextZekr.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNextZekr.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNextZekr.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNextZekr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNextZekr.FillColor = System.Drawing.Color.DarkCyan;
            this.btnNextZekr.FillColor2 = System.Drawing.Color.DarkCyan;
            this.btnNextZekr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextZekr.ForeColor = System.Drawing.Color.Black;
            this.btnNextZekr.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnNextZekr.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNextZekr.Location = new System.Drawing.Point(355, 398);
            this.btnNextZekr.Margin = new System.Windows.Forms.Padding(5);
            this.btnNextZekr.Name = "btnNextZekr";
            this.btnNextZekr.PressedColor = System.Drawing.Color.Gold;
            this.btnNextZekr.ShadowDecoration.BorderRadius = 20;
            this.btnNextZekr.ShadowDecoration.Depth = 15;
            this.btnNextZekr.ShadowDecoration.Enabled = true;
            this.btnNextZekr.Size = new System.Drawing.Size(90, 39);
            this.btnNextZekr.TabIndex = 22;
            this.btnNextZekr.Text = "التالي";
            this.btnNextZekr.Click += new System.EventHandler(this.btnNextZekr_Click);
            // 
            // pboxZekrImage
            // 
            this.pboxZekrImage.BackColor = System.Drawing.Color.White;
            this.pboxZekrImage.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pboxZekrImage.ErrorImage")));
            this.pboxZekrImage.Location = new System.Drawing.Point(0, 128);
            this.pboxZekrImage.Name = "pboxZekrImage";
            this.pboxZekrImage.Size = new System.Drawing.Size(800, 229);
            this.pboxZekrImage.TabIndex = 20;
            this.pboxZekrImage.TabStop = false;
            // 
            // pboxBackGround
            // 
            this.pboxBackGround.Image = ((System.Drawing.Image)(resources.GetObject("pboxBackGround.Image")));
            this.pboxBackGround.ImageRotate = 0F;
            this.pboxBackGround.Location = new System.Drawing.Point(0, 0);
            this.pboxBackGround.Name = "pboxBackGround";
            this.pboxBackGround.Size = new System.Drawing.Size(800, 127);
            this.pboxBackGround.TabIndex = 21;
            this.pboxBackGround.TabStop = false;
            // 
            // AzkarMasaa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCountRepit);
            this.Controls.Add(this.lblTittlebage);
            this.Controls.Add(this.btnNextZekr);
            this.Controls.Add(this.pboxZekrImage);
            this.Controls.Add(this.pboxBackGround);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AzkarMasaa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AzkarMasaa";
            this.Load += new System.EventHandler(this.AzkarMasaa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxZekrImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBackGround)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCountRepit;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTittlebage;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnNextZekr;
        private System.Windows.Forms.PictureBox pboxZekrImage;
        private Guna.UI2.WinForms.Guna2PictureBox pboxBackGround;
    }
}