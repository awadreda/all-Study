﻿namespace Bank_Presentation_Layer_Windows_App.ClientScreen.ClientHome.Withdraw
{
    partial class frm_WithdrawSecondScreen
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
            this.pnl_NextButton = new System.Windows.Forms.Panel();
            this.btn_Confirme = new System.Windows.Forms.Button();
            this.pnl_CheckSpam = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_SendEmail = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_VerificationKey = new System.Windows.Forms.TextBox();
            this.pnl_NextButton.SuspendLayout();
            this.pnl_CheckSpam.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_NextButton
            // 
            this.pnl_NextButton.Controls.Add(this.btn_Confirme);
            this.pnl_NextButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_NextButton.Location = new System.Drawing.Point(0, 513);
            this.pnl_NextButton.Name = "pnl_NextButton";
            this.pnl_NextButton.Size = new System.Drawing.Size(930, 98);
            this.pnl_NextButton.TabIndex = 73;
            // 
            // btn_Confirme
            // 
            this.btn_Confirme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Confirme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.btn_Confirme.FlatAppearance.BorderSize = 0;
            this.btn_Confirme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(114)))), ((int)(((byte)(175)))));
            this.btn_Confirme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.btn_Confirme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirme.Font = new System.Drawing.Font("Arial", 11F);
            this.btn_Confirme.ForeColor = System.Drawing.Color.White;
            this.btn_Confirme.Location = new System.Drawing.Point(93, 34);
            this.btn_Confirme.Name = "btn_Confirme";
            this.btn_Confirme.Size = new System.Drawing.Size(758, 44);
            this.btn_Confirme.TabIndex = 2;
            this.btn_Confirme.Text = "Confirme";
            this.btn_Confirme.UseVisualStyleBackColor = false;
            this.btn_Confirme.Click += new System.EventHandler(this.btn_Confirme_Click);
            // 
            // pnl_CheckSpam
            // 
            this.pnl_CheckSpam.Controls.Add(this.label4);
            this.pnl_CheckSpam.Controls.Add(this.label5);
            this.pnl_CheckSpam.Controls.Add(this.label3);
            this.pnl_CheckSpam.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_CheckSpam.Location = new System.Drawing.Point(0, 470);
            this.pnl_CheckSpam.Name = "pnl_CheckSpam";
            this.pnl_CheckSpam.Size = new System.Drawing.Size(930, 43);
            this.pnl_CheckSpam.TabIndex = 72;
            this.pnl_CheckSpam.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(456, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "spam,";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.label5.Location = new System.Drawing.Point(500, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(363, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "   if it does not exist press resend button";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.label3.Location = new System.Drawing.Point(77, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(398, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "if you do not find the email , check first your ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_SendEmail);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lbl_Amount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_VerificationKey);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 470);
            this.panel1.TabIndex = 71;
            // 
            // btn_SendEmail
            // 
            this.btn_SendEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SendEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.btn_SendEmail.FlatAppearance.BorderSize = 0;
            this.btn_SendEmail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(114)))), ((int)(((byte)(175)))));
            this.btn_SendEmail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(59)))), ((int)(((byte)(90)))));
            this.btn_SendEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SendEmail.Font = new System.Drawing.Font("Arial", 11F);
            this.btn_SendEmail.ForeColor = System.Drawing.Color.White;
            this.btn_SendEmail.Location = new System.Drawing.Point(93, 284);
            this.btn_SendEmail.Name = "btn_SendEmail";
            this.btn_SendEmail.Size = new System.Drawing.Size(758, 44);
            this.btn_SendEmail.TabIndex = 0;
            this.btn_SendEmail.Text = "Send Email";
            this.btn_SendEmail.UseVisualStyleBackColor = false;
            this.btn_SendEmail.Click += new System.EventHandler(this.btn_SendEmail_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.label6.Location = new System.Drawing.Point(135, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(672, 23);
            this.label6.TabIndex = 68;
            this.label6.Text = "Press Send Email Button and you will get confimation key on your email box";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.2F);
            this.label2.Location = new System.Drawing.Point(88, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 27);
            this.label2.TabIndex = 67;
            this.label2.Text = "Verification Key :";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 19.2F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(58, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(475, 37);
            this.label8.TabIndex = 62;
            this.label8.Text = "Verification and Confermation";
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.Font = new System.Drawing.Font("Arial", 14.2F, System.Drawing.FontStyle.Bold);
            this.lbl_Amount.Location = new System.Drawing.Point(239, 152);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(72, 29);
            this.lbl_Amount.TabIndex = 65;
            this.lbl_Amount.Text = "100 $";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.2F);
            this.label1.Location = new System.Drawing.Point(134, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 27);
            this.label1.TabIndex = 64;
            this.label1.Text = "Amount :";
            // 
            // tb_VerificationKey
            // 
            this.tb_VerificationKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_VerificationKey.BackColor = System.Drawing.Color.White;
            this.tb_VerificationKey.Font = new System.Drawing.Font("Arial", 12.2F);
            this.tb_VerificationKey.ForeColor = System.Drawing.Color.Black;
            this.tb_VerificationKey.Location = new System.Drawing.Point(93, 434);
            this.tb_VerificationKey.Name = "tb_VerificationKey";
            this.tb_VerificationKey.Size = new System.Drawing.Size(758, 31);
            this.tb_VerificationKey.TabIndex = 1;
            // 
            // frm_WithdrawSecondScreen
            // 
            this.AcceptButton = this.btn_Confirme;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(226)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(930, 720);
            this.Controls.Add(this.pnl_NextButton);
            this.Controls.Add(this.pnl_CheckSpam);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_WithdrawSecondScreen";
            this.Text = "frm_WithdrawSecondScreen";
            this.Load += new System.EventHandler(this.frm_WithdrawSecondScreen_Load);
            this.pnl_NextButton.ResumeLayout(false);
            this.pnl_CheckSpam.ResumeLayout(false);
            this.pnl_CheckSpam.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_NextButton;
        private System.Windows.Forms.Button btn_Confirme;
        private System.Windows.Forms.Panel pnl_CheckSpam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_SendEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_Amount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_VerificationKey;
    }
}