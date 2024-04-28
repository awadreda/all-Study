namespace BankSystemwidowsForm.Users
{
    partial class UserScreen
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tListUsers = new System.Windows.Forms.TabPage();
            this.dgvListUser = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tFindUser = new System.Windows.Forms.TabPage();
            this.tAddNewUser = new System.Windows.Forms.TabPage();
            this.tEditUser = new System.Windows.Forms.TabPage();
            this.tDeleteUser = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tListUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListUser)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tListUsers);
            this.tabControl1.Controls.Add(this.tFindUser);
            this.tabControl1.Controls.Add(this.tAddNewUser);
            this.tabControl1.Controls.Add(this.tEditUser);
            this.tabControl1.Controls.Add(this.tDeleteUser);
            this.tabControl1.Location = new System.Drawing.Point(34, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(966, 692);
            this.tabControl1.TabIndex = 0;
            // 
            // tListUsers
            // 
            this.tListUsers.Controls.Add(this.dgvListUser);
            this.tListUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tListUsers.Location = new System.Drawing.Point(4, 22);
            this.tListUsers.Name = "tListUsers";
            this.tListUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tListUsers.Size = new System.Drawing.Size(958, 666);
            this.tListUsers.TabIndex = 0;
            this.tListUsers.Text = "List Users";
            this.tListUsers.UseVisualStyleBackColor = true;
            this.tListUsers.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dgvListUser
            // 
            this.dgvListUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListUser.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvListUser.Location = new System.Drawing.Point(-9, 12);
            this.dgvListUser.Name = "dgvListUser";
            this.dgvListUser.Size = new System.Drawing.Size(977, 643);
            this.dgvListUser.TabIndex = 2;
            this.dgvListUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListUser_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.editUserToolStripMenuItem,
            this.deleteUserToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(150, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.addNewToolStripMenuItem.Text = "Add New User";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // editUserToolStripMenuItem
            // 
            this.editUserToolStripMenuItem.Name = "editUserToolStripMenuItem";
            this.editUserToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.editUserToolStripMenuItem.Text = "Edit User";
            this.editUserToolStripMenuItem.Click += new System.EventHandler(this.editUserToolStripMenuItem_Click);
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.deleteUserToolStripMenuItem.Text = "Delete User";
            this.deleteUserToolStripMenuItem.Click += new System.EventHandler(this.deleteUserToolStripMenuItem_Click);
            // 
            // tFindUser
            // 
            this.tFindUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tFindUser.Location = new System.Drawing.Point(4, 22);
            this.tFindUser.Name = "tFindUser";
            this.tFindUser.Padding = new System.Windows.Forms.Padding(3);
            this.tFindUser.Size = new System.Drawing.Size(958, 666);
            this.tFindUser.TabIndex = 1;
            this.tFindUser.Text = "Find User";
            this.tFindUser.UseVisualStyleBackColor = true;
            // 
            // tAddNewUser
            // 
            this.tAddNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tAddNewUser.Location = new System.Drawing.Point(4, 22);
            this.tAddNewUser.Name = "tAddNewUser";
            this.tAddNewUser.Padding = new System.Windows.Forms.Padding(3);
            this.tAddNewUser.Size = new System.Drawing.Size(958, 666);
            this.tAddNewUser.TabIndex = 2;
            this.tAddNewUser.Text = "Add New User";
            this.tAddNewUser.UseVisualStyleBackColor = true;
            // 
            // tEditUser
            // 
            this.tEditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tEditUser.Location = new System.Drawing.Point(4, 22);
            this.tEditUser.Name = "tEditUser";
            this.tEditUser.Padding = new System.Windows.Forms.Padding(3);
            this.tEditUser.Size = new System.Drawing.Size(958, 666);
            this.tEditUser.TabIndex = 3;
            this.tEditUser.Text = "Edit User";
            this.tEditUser.UseVisualStyleBackColor = true;
            // 
            // tDeleteUser
            // 
            this.tDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDeleteUser.Location = new System.Drawing.Point(4, 22);
            this.tDeleteUser.Name = "tDeleteUser";
            this.tDeleteUser.Padding = new System.Windows.Forms.Padding(3);
            this.tDeleteUser.Size = new System.Drawing.Size(958, 666);
            this.tDeleteUser.TabIndex = 4;
            this.tDeleteUser.Text = "Delete User";
            this.tDeleteUser.UseVisualStyleBackColor = true;
            this.tDeleteUser.Click += new System.EventHandler(this.tDeleteUser_Click);
            // 
            // UserScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 730);
            this.Controls.Add(this.tabControl1);
            this.Name = "UserScreen";
            this.Text = "UserScreen";
            this.Load += new System.EventHandler(this.UserScreen_Load);
            this.tabControl1.ResumeLayout(false);
            this.tListUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListUser)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tListUsers;
        private System.Windows.Forms.TabPage tFindUser;
        private System.Windows.Forms.TabPage tAddNewUser;
        private System.Windows.Forms.TabPage tEditUser;
        private System.Windows.Forms.TabPage tDeleteUser;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvListUser;
    }
}