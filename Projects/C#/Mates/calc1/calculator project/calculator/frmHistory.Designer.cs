namespace calculator
{
    partial class frmHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistory));
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.LimeGreen;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 59);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(549, 415);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "History";
            // 
            // frmHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(573, 487);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.Name = "frmHistory";
            this.Text = "History";
            this.Load += new System.EventHandler(this.frmHistory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
    }
}