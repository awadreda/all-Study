namespace BankSystemwidowsForm
{
    partial class testClientScreen
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
            this.pDeleteScreen = new System.Windows.Forms.Panel();
            this.txtClientIDForDelete = new System.Windows.Forms.MaskedTextBox();
            this.btnSearchforDelete = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pDeleteCard = new System.Windows.Forms.Panel();
            this.pbDeleteClinetImage = new System.Windows.Forms.PictureBox();
            this.txtDeleteAccountBanlance = new System.Windows.Forms.MaskedTextBox();
            this.txtDeleteAcountNumber = new System.Windows.Forms.TextBox();
            this.txtDeletePhone = new System.Windows.Forms.MaskedTextBox();
            this.txtDeletePinCode = new System.Windows.Forms.TextBox();
            this.txtDeleteLastName = new System.Windows.Forms.TextBox();
            this.txtDeleteEmail = new System.Windows.Forms.TextBox();
            this.txtDeleteFirstName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblClientID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pDeleteScreen.SuspendLayout();
            this.pDeleteCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeleteClinetImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pDeleteScreen
            // 
            this.pDeleteScreen.Controls.Add(this.btnDelete);
            this.pDeleteScreen.Controls.Add(this.txtClientIDForDelete);
            this.pDeleteScreen.Controls.Add(this.btnSearchforDelete);
            this.pDeleteScreen.Controls.Add(this.label9);
            this.pDeleteScreen.Controls.Add(this.pDeleteCard);
            this.pDeleteScreen.Location = new System.Drawing.Point(186, 39);
            this.pDeleteScreen.Name = "pDeleteScreen";
            this.pDeleteScreen.Size = new System.Drawing.Size(722, 625);
            this.pDeleteScreen.TabIndex = 2;
            // 
            // txtClientIDForDelete
            // 
            this.txtClientIDForDelete.Location = new System.Drawing.Point(255, 27);
            this.txtClientIDForDelete.Mask = "00000";
            this.txtClientIDForDelete.Name = "txtClientIDForDelete";
            this.txtClientIDForDelete.Size = new System.Drawing.Size(100, 20);
            this.txtClientIDForDelete.TabIndex = 2;
            this.txtClientIDForDelete.ValidatingType = typeof(int);
            this.txtClientIDForDelete.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtClientIDForDelete_MaskInputRejected);
            // 
            // btnSearchforDelete
            // 
            this.btnSearchforDelete.Location = new System.Drawing.Point(407, 26);
            this.btnSearchforDelete.Name = "btnSearchforDelete";
            this.btnSearchforDelete.Size = new System.Drawing.Size(64, 31);
            this.btnSearchforDelete.TabIndex = 2;
            this.btnSearchforDelete.Text = "Search";
            this.btnSearchforDelete.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(108, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 24);
            this.label9.TabIndex = 38;
            this.label9.Text = "Find Client";
            // 
            // pDeleteCard
            // 
            this.pDeleteCard.Controls.Add(this.pbDeleteClinetImage);
            this.pDeleteCard.Controls.Add(this.txtDeleteAccountBanlance);
            this.pDeleteCard.Controls.Add(this.txtDeleteAcountNumber);
            this.pDeleteCard.Controls.Add(this.txtDeletePhone);
            this.pDeleteCard.Controls.Add(this.txtDeletePinCode);
            this.pDeleteCard.Controls.Add(this.txtDeleteLastName);
            this.pDeleteCard.Controls.Add(this.txtDeleteEmail);
            this.pDeleteCard.Controls.Add(this.txtDeleteFirstName);
            this.pDeleteCard.Controls.Add(this.label8);
            this.pDeleteCard.Controls.Add(this.label7);
            this.pDeleteCard.Controls.Add(this.label6);
            this.pDeleteCard.Controls.Add(this.label5);
            this.pDeleteCard.Controls.Add(this.label4);
            this.pDeleteCard.Controls.Add(this.label3);
            this.pDeleteCard.Controls.Add(this.label2);
            this.pDeleteCard.Controls.Add(this.lblClientID);
            this.pDeleteCard.Controls.Add(this.label1);
            this.pDeleteCard.Enabled = false;
            this.pDeleteCard.Location = new System.Drawing.Point(18, 97);
            this.pDeleteCard.Name = "pDeleteCard";
            this.pDeleteCard.Size = new System.Drawing.Size(630, 427);
            this.pDeleteCard.TabIndex = 40;
            this.pDeleteCard.Visible = false;
            // 
            // pbDeleteClinetImage
            // 
            this.pbDeleteClinetImage.Location = new System.Drawing.Point(427, 191);
            this.pbDeleteClinetImage.Name = "pbDeleteClinetImage";
            this.pbDeleteClinetImage.Size = new System.Drawing.Size(170, 149);
            this.pbDeleteClinetImage.TabIndex = 54;
            this.pbDeleteClinetImage.TabStop = false;
            // 
            // txtDeleteAccountBanlance
            // 
            this.txtDeleteAccountBanlance.Location = new System.Drawing.Point(221, 375);
            this.txtDeleteAccountBanlance.Mask = "00000000000000000000";
            this.txtDeleteAccountBanlance.Name = "txtDeleteAccountBanlance";
            this.txtDeleteAccountBanlance.ReadOnly = true;
            this.txtDeleteAccountBanlance.Size = new System.Drawing.Size(150, 20);
            this.txtDeleteAccountBanlance.TabIndex = 53;
            // 
            // txtDeleteAcountNumber
            // 
            this.txtDeleteAcountNumber.Location = new System.Drawing.Point(221, 320);
            this.txtDeleteAcountNumber.Name = "txtDeleteAcountNumber";
            this.txtDeleteAcountNumber.ReadOnly = true;
            this.txtDeleteAcountNumber.Size = new System.Drawing.Size(100, 20);
            this.txtDeleteAcountNumber.TabIndex = 52;
            // 
            // txtDeletePhone
            // 
            this.txtDeletePhone.Location = new System.Drawing.Point(221, 210);
            this.txtDeletePhone.Mask = "000000000000";
            this.txtDeletePhone.Name = "txtDeletePhone";
            this.txtDeletePhone.ReadOnly = true;
            this.txtDeletePhone.Size = new System.Drawing.Size(100, 20);
            this.txtDeletePhone.TabIndex = 51;
            // 
            // txtDeletePinCode
            // 
            this.txtDeletePinCode.Location = new System.Drawing.Point(221, 265);
            this.txtDeletePinCode.Name = "txtDeletePinCode";
            this.txtDeletePinCode.ReadOnly = true;
            this.txtDeletePinCode.Size = new System.Drawing.Size(100, 20);
            this.txtDeletePinCode.TabIndex = 50;
            // 
            // txtDeleteLastName
            // 
            this.txtDeleteLastName.Location = new System.Drawing.Point(515, 101);
            this.txtDeleteLastName.Name = "txtDeleteLastName";
            this.txtDeleteLastName.ReadOnly = true;
            this.txtDeleteLastName.Size = new System.Drawing.Size(100, 20);
            this.txtDeleteLastName.TabIndex = 49;
            // 
            // txtDeleteEmail
            // 
            this.txtDeleteEmail.Location = new System.Drawing.Point(221, 155);
            this.txtDeleteEmail.Name = "txtDeleteEmail";
            this.txtDeleteEmail.ReadOnly = true;
            this.txtDeleteEmail.Size = new System.Drawing.Size(100, 20);
            this.txtDeleteEmail.TabIndex = 48;
            // 
            // txtDeleteFirstName
            // 
            this.txtDeleteFirstName.Location = new System.Drawing.Point(221, 96);
            this.txtDeleteFirstName.Name = "txtDeleteFirstName";
            this.txtDeleteFirstName.ReadOnly = true;
            this.txtDeleteFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtDeleteFirstName.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 24);
            this.label8.TabIndex = 46;
            this.label8.Text = "Account Banlance : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 24);
            this.label7.TabIndex = 45;
            this.label7.Text = "Acount Number :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 24);
            this.label6.TabIndex = 44;
            this.label6.Text = "PINCode :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 24);
            this.label5.TabIndex = 43;
            this.label5.Text = "Phone :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 42;
            this.label4.Text = "Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(347, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 24);
            this.label3.TabIndex = 41;
            this.label3.Text = "Last Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 24);
            this.label2.TabIndex = 40;
            this.label2.Text = "First Name :";
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientID.Location = new System.Drawing.Point(221, 41);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(43, 24);
            this.lblClientID.TabIndex = 39;
            this.lblClientID.Text = "???";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 38;
            this.label1.Text = "CLientID :";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(305, 554);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 43);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(12, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 635);
            this.panel1.TabIndex = 3;
            // 
            // testClientScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 691);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pDeleteScreen);
            this.Name = "testClientScreen";
            this.Text = "testClientScreen";
            this.Load += new System.EventHandler(this.testClientScreen_Load);
            this.pDeleteScreen.ResumeLayout(false);
            this.pDeleteScreen.PerformLayout();
            this.pDeleteCard.ResumeLayout(false);
            this.pDeleteCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeleteClinetImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pDeleteScreen;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.MaskedTextBox txtClientIDForDelete;
        private System.Windows.Forms.Button btnSearchforDelete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pDeleteCard;
        private System.Windows.Forms.PictureBox pbDeleteClinetImage;
        private System.Windows.Forms.MaskedTextBox txtDeleteAccountBanlance;
        private System.Windows.Forms.TextBox txtDeleteAcountNumber;
        private System.Windows.Forms.MaskedTextBox txtDeletePhone;
        private System.Windows.Forms.TextBox txtDeletePinCode;
        private System.Windows.Forms.TextBox txtDeleteLastName;
        private System.Windows.Forms.TextBox txtDeleteEmail;
        private System.Windows.Forms.TextBox txtDeleteFirstName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}