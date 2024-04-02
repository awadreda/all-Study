namespace calculator
{
    partial class frmcalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcalculator));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtShowNumbers = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnHunderdPrecent = new System.Windows.Forms.Button();
            this.btnPowr = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnEqule = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "zero.png");
            this.imageList1.Images.SetKeyName(1, "one.png");
            this.imageList1.Images.SetKeyName(2, "two.png");
            this.imageList1.Images.SetKeyName(3, "three.png");
            this.imageList1.Images.SetKeyName(4, "four.png");
            this.imageList1.Images.SetKeyName(5, "five.png");
            this.imageList1.Images.SetKeyName(6, "six.png");
            this.imageList1.Images.SetKeyName(7, "seven.png");
            this.imageList1.Images.SetKeyName(8, "crossed.png");
            this.imageList1.Images.SetKeyName(9, "eight.png");
            this.imageList1.Images.SetKeyName(10, "nine.png");
            this.imageList1.Images.SetKeyName(11, "divide.png");
            this.imageList1.Images.SetKeyName(12, "dot.png");
            this.imageList1.Images.SetKeyName(13, "HundredPercent.png");
            this.imageList1.Images.SetKeyName(14, "plus.png");
            this.imageList1.Images.SetKeyName(15, "square-root-of-x-mathematical-signs.png");
            this.imageList1.Images.SetKeyName(16, "mathematics.png");
            this.imageList1.Images.SetKeyName(17, "history.png");
            // 
            // txtShowNumbers
            // 
            this.txtShowNumbers.BackColor = System.Drawing.Color.Yellow;
            this.txtShowNumbers.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtShowNumbers.Location = new System.Drawing.Point(3, 12);
            this.txtShowNumbers.Name = "txtShowNumbers";
            this.txtShowNumbers.ReadOnly = true;
            this.txtShowNumbers.Size = new System.Drawing.Size(372, 35);
            this.txtShowNumbers.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHistory);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnSqrt);
            this.panel1.Controls.Add(this.btnHunderdPrecent);
            this.panel1.Controls.Add(this.btnPowr);
            this.panel1.Controls.Add(this.btnMultiply);
            this.panel1.Controls.Add(this.btnDivide);
            this.panel1.Controls.Add(this.btnMinus);
            this.panel1.Controls.Add(this.btn9);
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.btnEqule);
            this.panel1.Controls.Add(this.btnPlus);
            this.panel1.Controls.Add(this.btnDot);
            this.panel1.Controls.Add(this.btnZero);
            this.panel1.Location = new System.Drawing.Point(3, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 430);
            this.panel1.TabIndex = 1;
            // 
            // btnHistory
            // 
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnHistory.ForeColor = System.Drawing.Color.Black;
            this.btnHistory.ImageIndex = 17;
            this.btnHistory.ImageList = this.imageList1;
            this.btnHistory.Location = new System.Drawing.Point(19, 28);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(162, 57);
            this.btnHistory.TabIndex = 25;
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.ImageList = this.imageList1;
            this.btnDelete.Location = new System.Drawing.Point(201, 28);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(71, 57);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "AC";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.btnSqrt.ForeColor = System.Drawing.Color.Black;
            this.btnSqrt.ImageIndex = 15;
            this.btnSqrt.ImageList = this.imageList1;
            this.btnSqrt.Location = new System.Drawing.Point(292, 28);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(71, 57);
            this.btnSqrt.TabIndex = 22;
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnHunderdPrecent
            // 
            this.btnHunderdPrecent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHunderdPrecent.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.btnHunderdPrecent.ForeColor = System.Drawing.Color.Black;
            this.btnHunderdPrecent.ImageList = this.imageList1;
            this.btnHunderdPrecent.Location = new System.Drawing.Point(110, 91);
            this.btnHunderdPrecent.Name = "btnHunderdPrecent";
            this.btnHunderdPrecent.Size = new System.Drawing.Size(71, 57);
            this.btnHunderdPrecent.TabIndex = 21;
            this.btnHunderdPrecent.Text = "%";
            this.btnHunderdPrecent.UseVisualStyleBackColor = true;
            this.btnHunderdPrecent.Click += new System.EventHandler(this.btnHunderdPrecent_Click);
            // 
            // btnPowr
            // 
            this.btnPowr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPowr.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.btnPowr.ForeColor = System.Drawing.Color.Black;
            this.btnPowr.ImageList = this.imageList1;
            this.btnPowr.Location = new System.Drawing.Point(19, 91);
            this.btnPowr.Name = "btnPowr";
            this.btnPowr.Size = new System.Drawing.Size(71, 57);
            this.btnPowr.TabIndex = 20;
            this.btnPowr.Text = "^";
            this.btnPowr.UseVisualStyleBackColor = true;
            this.btnPowr.Click += new System.EventHandler(this.GetOpFromUser);
            // 
            // btnMultiply
            // 
            this.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.btnMultiply.ForeColor = System.Drawing.Color.Black;
            this.btnMultiply.ImageList = this.imageList1;
            this.btnMultiply.Location = new System.Drawing.Point(201, 91);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(71, 57);
            this.btnMultiply.TabIndex = 19;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.GetOpFromUser);
            // 
            // btnDivide
            // 
            this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.btnDivide.ForeColor = System.Drawing.Color.Black;
            this.btnDivide.ImageList = this.imageList1;
            this.btnDivide.Location = new System.Drawing.Point(292, 91);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(71, 57);
            this.btnDivide.TabIndex = 18;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.GetOpFromUser);
            // 
            // btnMinus
            // 
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.btnMinus.ForeColor = System.Drawing.Color.Black;
            this.btnMinus.ImageList = this.imageList1;
            this.btnMinus.Location = new System.Drawing.Point(292, 163);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(71, 57);
            this.btnMinus.TabIndex = 17;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.GetOpFromUser);
            // 
            // btn9
            // 
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.btn9.ForeColor = System.Drawing.Color.Black;
            this.btn9.ImageList = this.imageList1;
            this.btn9.Location = new System.Drawing.Point(201, 163);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(71, 57);
            this.btn9.TabIndex = 15;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.GetNumberFromUser);
            // 
            // btn8
            // 
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.btn8.ForeColor = System.Drawing.Color.Black;
            this.btn8.ImageList = this.imageList1;
            this.btn8.Location = new System.Drawing.Point(110, 163);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(71, 57);
            this.btn8.TabIndex = 14;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.GetNumberFromUser);
            // 
            // btn7
            // 
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.btn7.ForeColor = System.Drawing.Color.Black;
            this.btn7.ImageList = this.imageList1;
            this.btn7.Location = new System.Drawing.Point(19, 163);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(71, 57);
            this.btn7.TabIndex = 13;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.GetNumberFromUser);
            // 
            // btn6
            // 
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.btn6.ForeColor = System.Drawing.Color.Black;
            this.btn6.ImageList = this.imageList1;
            this.btn6.Location = new System.Drawing.Point(201, 226);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(71, 57);
            this.btn6.TabIndex = 12;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.GetNumberFromUser);
            // 
            // btn5
            // 
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.btn5.ForeColor = System.Drawing.Color.Black;
            this.btn5.ImageList = this.imageList1;
            this.btn5.Location = new System.Drawing.Point(110, 226);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(71, 57);
            this.btn5.TabIndex = 11;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.GetNumberFromUser);
            // 
            // btn4
            // 
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.btn4.ForeColor = System.Drawing.Color.Black;
            this.btn4.ImageList = this.imageList1;
            this.btn4.Location = new System.Drawing.Point(19, 226);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(71, 57);
            this.btn4.TabIndex = 10;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.GetNumberFromUser);
            // 
            // btn3
            // 
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.btn3.ForeColor = System.Drawing.Color.Black;
            this.btn3.ImageList = this.imageList1;
            this.btn3.Location = new System.Drawing.Point(201, 298);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(71, 57);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.GetNumberFromUser);
            // 
            // btn2
            // 
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.btn2.ForeColor = System.Drawing.Color.Black;
            this.btn2.ImageList = this.imageList1;
            this.btn2.Location = new System.Drawing.Point(110, 298);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(71, 57);
            this.btn2.TabIndex = 8;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.GetNumberFromUser);
            // 
            // btn1
            // 
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.btn1.ForeColor = System.Drawing.Color.Black;
            this.btn1.ImageList = this.imageList1;
            this.btn1.Location = new System.Drawing.Point(19, 298);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(71, 57);
            this.btn1.TabIndex = 7;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.GetNumberFromUser);
            // 
            // btnEqule
            // 
            this.btnEqule.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEqule.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.btnEqule.ForeColor = System.Drawing.Color.Black;
            this.btnEqule.ImageList = this.imageList1;
            this.btnEqule.Location = new System.Drawing.Point(292, 298);
            this.btnEqule.Name = "btnEqule";
            this.btnEqule.Size = new System.Drawing.Size(71, 120);
            this.btnEqule.TabIndex = 6;
            this.btnEqule.Text = "=";
            this.btnEqule.UseVisualStyleBackColor = true;
            this.btnEqule.Click += new System.EventHandler(this.btnEqule_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.btnPlus.ForeColor = System.Drawing.Color.Black;
            this.btnPlus.ImageList = this.imageList1;
            this.btnPlus.Location = new System.Drawing.Point(292, 226);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(71, 57);
            this.btnPlus.TabIndex = 5;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.GetOpFromUser);
            // 
            // btnDot
            // 
            this.btnDot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.btnDot.ForeColor = System.Drawing.Color.Black;
            this.btnDot.ImageList = this.imageList1;
            this.btnDot.Location = new System.Drawing.Point(201, 361);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(71, 57);
            this.btnDot.TabIndex = 4;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnBot_Click);
            // 
            // btnZero
            // 
            this.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.btnZero.ForeColor = System.Drawing.Color.Black;
            this.btnZero.ImageList = this.imageList1;
            this.btnZero.Location = new System.Drawing.Point(19, 361);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(162, 57);
            this.btnZero.TabIndex = 3;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.GetNumberFromUser);
            // 
            // frmcalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(378, 527);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtShowNumbers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frmcalculator";
            this.Text = "calculator";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txtShowNumbers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnEqule;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnHunderdPrecent;
        private System.Windows.Forms.Button btnPowr;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnHistory;
    }
}

