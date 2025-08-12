namespace AccountRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StudNumLbl = new System.Windows.Forms.Label();
            this.tBx_StudNum = new System.Windows.Forms.TextBox();
            this.btn_Next = new System.Windows.Forms.Button();
            this.tBx_LastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBx_Age = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBx_FirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBx_ContactNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tBx_MidName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tBx_Program = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rTBx_Address = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StudNumLbl
            // 
            this.StudNumLbl.AutoSize = true;
            this.StudNumLbl.BackColor = System.Drawing.Color.Transparent;
            this.StudNumLbl.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudNumLbl.ForeColor = System.Drawing.Color.White;
            this.StudNumLbl.Location = new System.Drawing.Point(21, 55);
            this.StudNumLbl.Name = "StudNumLbl";
            this.StudNumLbl.Size = new System.Drawing.Size(87, 23);
            this.StudNumLbl.TabIndex = 0;
            this.StudNumLbl.Text = "Student No.";
            // 
            // tBx_StudNum
            // 
            this.tBx_StudNum.BackColor = System.Drawing.Color.Lavender;
            this.tBx_StudNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBx_StudNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBx_StudNum.Location = new System.Drawing.Point(21, 75);
            this.tBx_StudNum.Name = "tBx_StudNum";
            this.tBx_StudNum.Size = new System.Drawing.Size(155, 22);
            this.tBx_StudNum.TabIndex = 1;
            this.tBx_StudNum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_Next
            // 
            this.btn_Next.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Next.Font = new System.Drawing.Font("Poppins SemiBold", 10F);
            this.btn_Next.ForeColor = System.Drawing.Color.White;
            this.btn_Next.Location = new System.Drawing.Point(235, 443);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(94, 31);
            this.btn_Next.TabIndex = 2;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = false;
            // 
            // tBx_LastName
            // 
            this.tBx_LastName.BackColor = System.Drawing.Color.Lavender;
            this.tBx_LastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBx_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBx_LastName.Location = new System.Drawing.Point(21, 151);
            this.tBx_LastName.Name = "tBx_LastName";
            this.tBx_LastName.Size = new System.Drawing.Size(155, 22);
            this.tBx_LastName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // tBx_Age
            // 
            this.tBx_Age.BackColor = System.Drawing.Color.Lavender;
            this.tBx_Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBx_Age.Location = new System.Drawing.Point(22, 227);
            this.tBx_Age.Name = "tBx_Age";
            this.tBx_Age.Size = new System.Drawing.Size(155, 22);
            this.tBx_Age.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Age:";
            // 
            // tBx_FirstName
            // 
            this.tBx_FirstName.BackColor = System.Drawing.Color.Lavender;
            this.tBx_FirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBx_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBx_FirstName.Location = new System.Drawing.Point(211, 151);
            this.tBx_FirstName.Name = "tBx_FirstName";
            this.tBx_FirstName.Size = new System.Drawing.Size(155, 22);
            this.tBx_FirstName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(213, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "First Name";
            // 
            // tBx_ContactNum
            // 
            this.tBx_ContactNum.BackColor = System.Drawing.Color.Lavender;
            this.tBx_ContactNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBx_ContactNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBx_ContactNum.Location = new System.Drawing.Point(211, 227);
            this.tBx_ContactNum.Name = "tBx_ContactNum";
            this.tBx_ContactNum.Size = new System.Drawing.Size(155, 22);
            this.tBx_ContactNum.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(212, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Contact No.";
            // 
            // tBx_MidName
            // 
            this.tBx_MidName.BackColor = System.Drawing.Color.Lavender;
            this.tBx_MidName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBx_MidName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBx_MidName.Location = new System.Drawing.Point(399, 151);
            this.tBx_MidName.Name = "tBx_MidName";
            this.tBx_MidName.Size = new System.Drawing.Size(155, 22);
            this.tBx_MidName.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(398, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Middle Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(212, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Program";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tBx_Program
            // 
            this.tBx_Program.BackColor = System.Drawing.Color.Lavender;
            this.tBx_Program.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tBx_Program.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBx_Program.FormattingEnabled = true;
            this.tBx_Program.Location = new System.Drawing.Point(211, 75);
            this.tBx_Program.Name = "tBx_Program";
            this.tBx_Program.Size = new System.Drawing.Size(155, 24);
            this.tBx_Program.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(24, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Address:";
            // 
            // rTBx_Address
            // 
            this.rTBx_Address.BackColor = System.Drawing.Color.Lavender;
            this.rTBx_Address.Location = new System.Drawing.Point(28, 297);
            this.rTBx_Address.Name = "rTBx_Address";
            this.rTBx_Address.Size = new System.Drawing.Size(530, 111);
            this.rTBx_Address.TabIndex = 16;
            this.rTBx_Address.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins ExtraBold", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(668, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 60);
            this.label1.TabIndex = 17;
            this.label1.Text = "REGISTRATION";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Poppins ExtraBold", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(701, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(201, 60);
            this.label9.TabIndex = 18;
            this.label9.Text = "ACCOUNT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(972, 507);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rTBx_Address);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tBx_Program);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tBx_MidName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tBx_ContactNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tBx_FirstName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBx_Age);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBx_LastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.tBx_StudNum);
            this.Controls.Add(this.StudNumLbl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StudNumLbl;
        private System.Windows.Forms.TextBox tBx_StudNum;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.TextBox tBx_LastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBx_Age;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBx_FirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBx_ContactNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBx_MidName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox tBx_Program;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rTBx_Address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
    }
}