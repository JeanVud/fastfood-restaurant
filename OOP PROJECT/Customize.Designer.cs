namespace OOP_PROJECT
{
    partial class Customize
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
            this.button1 = new System.Windows.Forms.Button();
            this.clbMenu = new System.Windows.Forms.CheckedListBox();
            this.trbarCalories = new System.Windows.Forms.TrackBar();
            this.trbarPrice = new System.Windows.Forms.TrackBar();
            this.clbAllergens = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelCalories = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trbarCalories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbarPrice)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Rockwell", 13F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(853, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 43);
            this.button1.TabIndex = 7;
            this.button1.Text = "DONE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clbMenu
            // 
            this.clbMenu.CheckOnClick = true;
            this.clbMenu.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.clbMenu.FormattingEnabled = true;
            this.clbMenu.Items.AddRange(new object[] {
            "Originals",
            "Combo",
            "Specials",
            "Snacks",
            "Burger",
            "Chicken",
            "Salads",
            "Desserts",
            "Drinks",
            "Mexican",
            "Viet"});
            this.clbMenu.Location = new System.Drawing.Point(16, 61);
            this.clbMenu.MultiColumn = true;
            this.clbMenu.Name = "clbMenu";
            this.clbMenu.Size = new System.Drawing.Size(116, 164);
            this.clbMenu.TabIndex = 10;
            this.clbMenu.UseTabStops = false;
            // 
            // trbarCalories
            // 
            this.trbarCalories.Location = new System.Drawing.Point(152, 79);
            this.trbarCalories.Maximum = 3000;
            this.trbarCalories.Name = "trbarCalories";
            this.trbarCalories.Size = new System.Drawing.Size(421, 45);
            this.trbarCalories.TabIndex = 11;
            this.trbarCalories.Scroll += new System.EventHandler(this.trbarCalories_Scroll);
            // 
            // trbarPrice
            // 
            this.trbarPrice.LargeChange = 10000;
            this.trbarPrice.Location = new System.Drawing.Point(152, 180);
            this.trbarPrice.Maximum = 400000;
            this.trbarPrice.Name = "trbarPrice";
            this.trbarPrice.Size = new System.Drawing.Size(421, 45);
            this.trbarPrice.SmallChange = 1000;
            this.trbarPrice.TabIndex = 11;
            this.trbarPrice.Scroll += new System.EventHandler(this.trbarPrice_Scroll);
            // 
            // clbAllergens
            // 
            this.clbAllergens.CheckOnClick = true;
            this.clbAllergens.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.clbAllergens.FormattingEnabled = true;
            this.clbAllergens.Items.AddRange(new object[] {
            "Wheat",
            "Milk",
            "Egg",
            "Fish"});
            this.clbAllergens.Location = new System.Drawing.Point(636, 132);
            this.clbAllergens.MultiColumn = true;
            this.clbAllergens.Name = "clbAllergens";
            this.clbAllergens.Size = new System.Drawing.Size(179, 64);
            this.clbAllergens.TabIndex = 10;
            this.clbAllergens.UseTabStops = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.labelCalories);
            this.groupBox1.Controls.Add(this.labelPrice);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.clbAllergens);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.clbMenu);
            this.groupBox1.Controls.Add(this.trbarPrice);
            this.groupBox1.Controls.Add(this.trbarCalories);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 13F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Green;
            this.groupBox1.Location = new System.Drawing.Point(78, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(954, 242);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CUSTOMIZE";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sort by Name",
            "Sort by Price",
            "Sort by Calories",
            "Sort by Prep Time"});
            this.comboBox1.Location = new System.Drawing.Point(636, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 28);
            this.comboBox1.TabIndex = 13;
            // 
            // labelCalories
            // 
            this.labelCalories.AutoSize = true;
            this.labelCalories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCalories.Location = new System.Drawing.Point(579, 79);
            this.labelCalories.Name = "labelCalories";
            this.labelCalories.Size = new System.Drawing.Size(22, 24);
            this.labelCalories.TabIndex = 12;
            this.labelCalories.Text = "0";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPrice.Location = new System.Drawing.Point(579, 180);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(22, 24);
            this.labelPrice.TabIndex = 12;
            this.labelPrice.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "CALORIES";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(634, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "SORT RESULTS BY:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(634, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "PRICE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "PRICE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "PRICE";
            // 
            // Customize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Customize";
            this.Text = "Customize";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.trbarCalories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbarPrice)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar trbarCalories;
        public System.Windows.Forms.CheckedListBox clbMenu;
        private System.Windows.Forms.TrackBar trbarPrice;
        public System.Windows.Forms.CheckedListBox clbAllergens;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCalories;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
    }
}