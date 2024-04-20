namespace MyBankWindowsForm
{
    partial class Form1
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
            this.btnFindClient = new System.Windows.Forms.Button();
            this.FindPanal = new System.Windows.Forms.Panel();
            this.btnFind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDToFInd = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.clientIformation1 = new MyBankWindowsForm.ClientIformation();
            this.FindPanal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFindClient
            // 
            this.btnFindClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindClient.Location = new System.Drawing.Point(12, 129);
            this.btnFindClient.Name = "btnFindClient";
            this.btnFindClient.Size = new System.Drawing.Size(151, 45);
            this.btnFindClient.TabIndex = 0;
            this.btnFindClient.Text = "Find Client";
            this.btnFindClient.UseVisualStyleBackColor = true;
            // 
            // FindPanal
            // 
            this.FindPanal.Controls.Add(this.clientIformation1);
            this.FindPanal.Controls.Add(this.btnFind);
            this.FindPanal.Controls.Add(this.label1);
            this.FindPanal.Controls.Add(this.txtIDToFInd);
            this.FindPanal.Location = new System.Drawing.Point(208, 73);
            this.FindPanal.Name = "FindPanal";
            this.FindPanal.Size = new System.Drawing.Size(788, 630);
            this.FindPanal.TabIndex = 1;
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(311, 27);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(60, 38);
            this.btnFind.TabIndex = 16;
            this.btnFind.Text = "Search";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Find Client :";
            // 
            // txtIDToFInd
            // 
            this.txtIDToFInd.Location = new System.Drawing.Point(176, 37);
            this.txtIDToFInd.Name = "txtIDToFInd";
            this.txtIDToFInd.Size = new System.Drawing.Size(100, 20);
            this.txtIDToFInd.TabIndex = 14;
            this.txtIDToFInd.TextChanged += new System.EventHandler(this.txtIDToFInd_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(26, 399);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 36);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(50, 297);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(113, 36);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit Client";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // clientIformation1
            // 
            this.clientIformation1.Location = new System.Drawing.Point(37, 110);
            this.clientIformation1.Name = "clientIformation1";
            this.clientIformation1.Size = new System.Drawing.Size(717, 453);
            this.clientIformation1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 747);
            this.Controls.Add(this.FindPanal);
            this.Controls.Add(this.btnFindClient);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FindPanal.ResumeLayout(false);
            this.FindPanal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFindClient;
        private System.Windows.Forms.Panel FindPanal;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private ClientInfo clientInfoToFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDToFInd;
        private ClientIformation clientIformation1;
    }
}

