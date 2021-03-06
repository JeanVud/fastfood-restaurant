﻿namespace OOP_PROJECT
{
    partial class SignUp
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
            this.placehdrtxtEmail = new OOP_PROJECT.PlaceHolderTextBox();
            this.placehdrtxtPassword = new OOP_PROJECT.PlaceHolderTextBox();
            this.txtDay = new OOP_PROJECT.PlaceHolderComboBox();
            this.txtMonth = new OOP_PROJECT.PlaceHolderComboBox();
            this.txtYear = new OOP_PROJECT.PlaceHolderComboBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnPasswordHideShow = new OOP_PROJECT.BorderlessButton();
            this.placehdrtxtName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // placehdrtxtEmail
            // 
            this.placehdrtxtEmail.Font = new System.Drawing.Font("Rockwell", 12F);
            this.placehdrtxtEmail.ForeColor = System.Drawing.Color.Gray;
            this.placehdrtxtEmail.Location = new System.Drawing.Point(547, 209);
            this.placehdrtxtEmail.Multiline = true;
            this.placehdrtxtEmail.Name = "placehdrtxtEmail";
            this.placehdrtxtEmail.PlaceHolderText = "Email";
            this.placehdrtxtEmail.Size = new System.Drawing.Size(237, 42);
            this.placehdrtxtEmail.TabIndex = 1;
            this.placehdrtxtEmail.Text = "Email";
            // 
            // placehdrtxtPassword
            // 
            this.placehdrtxtPassword.Font = new System.Drawing.Font("Rockwell", 12F);
            this.placehdrtxtPassword.ForeColor = System.Drawing.Color.Gray;
            this.placehdrtxtPassword.Location = new System.Drawing.Point(547, 251);
            this.placehdrtxtPassword.Multiline = true;
            this.placehdrtxtPassword.Name = "placehdrtxtPassword";
            this.placehdrtxtPassword.PlaceHolderText = "Password";
            this.placehdrtxtPassword.Size = new System.Drawing.Size(237, 42);
            this.placehdrtxtPassword.TabIndex = 1;
            this.placehdrtxtPassword.Text = "Password";
            // 
            // txtDay
            // 
            this.txtDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtDay.Font = new System.Drawing.Font("Bookman Old Style", 14F);
            this.txtDay.ForeColor = System.Drawing.Color.Gray;
            this.txtDay.FormattingEnabled = true;
            this.txtDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.txtDay.Location = new System.Drawing.Point(547, 300);
            this.txtDay.Name = "txtDay";
            this.txtDay.PlaceHolderComboText = "Day";
            this.txtDay.Size = new System.Drawing.Size(54, 29);
            this.txtDay.TabIndex = 5;
            // 
            // txtMonth
            // 
            this.txtMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMonth.Font = new System.Drawing.Font("Bookman Old Style", 14F);
            this.txtMonth.ForeColor = System.Drawing.Color.Gray;
            this.txtMonth.FormattingEnabled = true;
            this.txtMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.txtMonth.Location = new System.Drawing.Point(600, 300);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.PlaceHolderComboText = "Month";
            this.txtMonth.Size = new System.Drawing.Size(109, 29);
            this.txtMonth.TabIndex = 5;
            // 
            // txtYear
            // 
            this.txtYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtYear.Font = new System.Drawing.Font("Bookman Old Style", 14F);
            this.txtYear.ForeColor = System.Drawing.Color.Gray;
            this.txtYear.FormattingEnabled = true;
            this.txtYear.Items.AddRange(new object[] {
            "1960",
            "1961",
            "1962",
            "1963",
            "1964",
            "1965",
            "1966",
            "1967",
            "1968",
            "1969",
            "1970",
            "1971",
            "1972",
            "1973",
            "1974",
            "1975",
            "1976",
            "1977",
            "1978",
            "1979",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017"});
            this.txtYear.Location = new System.Drawing.Point(710, 300);
            this.txtYear.Name = "txtYear";
            this.txtYear.PlaceHolderComboText = "Year";
            this.txtYear.Size = new System.Drawing.Size(74, 29);
            this.txtYear.TabIndex = 5;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.White;
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(96)))), ((int)(((byte)(85)))));
            this.btnSignUp.Location = new System.Drawing.Point(547, 332);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(237, 43);
            this.btnSignUp.TabIndex = 6;
            this.btnSignUp.Text = "SIGN UP";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnPasswordHideShow
            // 
            this.btnPasswordHideShow.BackgroundImage = global::OOP_PROJECT.Properties.Resources.hide;
            this.btnPasswordHideShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPasswordHideShow.FlatAppearance.BorderSize = 0;
            this.btnPasswordHideShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasswordHideShow.Location = new System.Drawing.Point(745, 254);
            this.btnPasswordHideShow.Name = "btnPasswordHideShow";
            this.btnPasswordHideShow.Size = new System.Drawing.Size(33, 35);
            this.btnPasswordHideShow.TabIndex = 9;
            this.btnPasswordHideShow.UseVisualStyleBackColor = true;
            this.btnPasswordHideShow.Click += new System.EventHandler(this.borderlessButton1_Click);
            // 
            // placehdrtxtName
            // 
            this.placehdrtxtName.Location = new System.Drawing.Point(546, 170);
            this.placehdrtxtName.Multiline = true;
            this.placehdrtxtName.Name = "placehdrtxtName";
            this.placehdrtxtName.Size = new System.Drawing.Size(238, 42);
            this.placehdrtxtName.TabIndex = 12;
            this.placehdrtxtName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.placehdrtxtName1_MouseClick);
            this.placehdrtxtName.Leave += new System.EventHandler(this.placehdrtxtName1_Leave);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.White;
            this.lbName.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.Gray;
            this.lbName.Location = new System.Drawing.Point(548, 181);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(53, 19);
            this.lbName.TabIndex = 13;
            this.lbName.Text = "Name";
            this.lbName.Click += new System.EventHandler(this.lbName_Click);
            this.lbName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbName_MouseClick);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.placehdrtxtName);
            this.Controls.Add(this.btnPasswordHideShow);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.placehdrtxtPassword);
            this.Controls.Add(this.placehdrtxtEmail);
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PlaceHolderTextBox placehdrtxtEmail;
        private PlaceHolderTextBox placehdrtxtPassword;
        private PlaceHolderComboBox txtDay;
        private PlaceHolderComboBox txtMonth;
        private PlaceHolderComboBox txtYear;
        private System.Windows.Forms.Button btnSignUp;
        private BorderlessButton btnPasswordHideShow;
        private System.Windows.Forms.TextBox placehdrtxtName;
        private System.Windows.Forms.Label lbName;
    }
}