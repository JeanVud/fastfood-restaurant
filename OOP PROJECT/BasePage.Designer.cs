namespace OOP_PROJECT
{
    partial class BasePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasePage));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lbUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CheckOut = new System.Windows.Forms.Button();
            this.lbCustomize = new System.Windows.Forms.Label();
            this.lbLocations = new System.Windows.Forms.Label();
            this.MainPage = new System.Windows.Forms.Label();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.lbMotto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlCO = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbCalories = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lst_total = new System.Windows.Forms.ListView();
            this.Dish = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Items = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCheckPlease = new System.Windows.Forms.Button();
            this.lbSearch = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlCO.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(96)))), ((int)(((byte)(85)))));
            this.pnlHeader.Controls.Add(this.lbSearch);
            this.pnlHeader.Controls.Add(this.lbUser);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.CheckOut);
            this.pnlHeader.Controls.Add(this.lbCustomize);
            this.pnlHeader.Controls.Add(this.lbLocations);
            this.pnlHeader.Controls.Add(this.MainPage);
            this.pnlHeader.Controls.Add(this.lbWelcome);
            this.pnlHeader.ForeColor = System.Drawing.Color.White;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1265, 120);
            this.pnlHeader.TabIndex = 5;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(1079, 9);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(88, 41);
            this.lbUser.TabIndex = 4;
            this.lbUser.Text = "User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(900, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome,";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OOP_PROJECT.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // CheckOut
            // 
            this.CheckOut.BackColor = System.Drawing.Color.White;
            this.CheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckOut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CheckOut.FlatAppearance.BorderSize = 0;
            this.CheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckOut.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOut.ForeColor = System.Drawing.Color.Green;
            this.CheckOut.Location = new System.Drawing.Point(1125, 65);
            this.CheckOut.Name = "CheckOut";
            this.CheckOut.Size = new System.Drawing.Size(125, 46);
            this.CheckOut.TabIndex = 1;
            this.CheckOut.Text = "CHECK-OUT";
            this.CheckOut.UseVisualStyleBackColor = false;
            this.CheckOut.Click += new System.EventHandler(this.CheckOut_Click);
            // 
            // lbCustomize
            // 
            this.lbCustomize.AutoSize = true;
            this.lbCustomize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCustomize.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomize.Location = new System.Drawing.Point(866, 78);
            this.lbCustomize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCustomize.Name = "lbCustomize";
            this.lbCustomize.Size = new System.Drawing.Size(100, 19);
            this.lbCustomize.TabIndex = 1;
            this.lbCustomize.Text = "CUSTOMIZE";
            this.lbCustomize.Click += new System.EventHandler(this.lbCustomize_Click);
            // 
            // lbLocations
            // 
            this.lbLocations.AutoSize = true;
            this.lbLocations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLocations.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocations.Location = new System.Drawing.Point(679, 79);
            this.lbLocations.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLocations.Name = "lbLocations";
            this.lbLocations.Size = new System.Drawing.Size(104, 19);
            this.lbLocations.TabIndex = 1;
            this.lbLocations.Text = "LOCATIONS";
            this.lbLocations.Click += new System.EventHandler(this.lbLocations_Click);
            // 
            // MainPage
            // 
            this.MainPage.AutoSize = true;
            this.MainPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainPage.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPage.Location = new System.Drawing.Point(339, 78);
            this.MainPage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MainPage.Name = "MainPage";
            this.MainPage.Size = new System.Drawing.Size(106, 19);
            this.MainPage.TabIndex = 1;
            this.MainPage.Text = "MAIN PAGE";
            this.MainPage.Click += new System.EventHandler(this.MainPage_Click);
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.Location = new System.Drawing.Point(123, 3);
            this.lbWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(155, 108);
            this.lbWelcome.TabIndex = 0;
            this.lbWelcome.Text = "The\r\nChopping\r\nBites";
            // 
            // lbMotto
            // 
            this.lbMotto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMotto.AutoSize = true;
            this.lbMotto.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMotto.ForeColor = System.Drawing.Color.White;
            this.lbMotto.Location = new System.Drawing.Point(45, 5);
            this.lbMotto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMotto.Name = "lbMotto";
            this.lbMotto.Size = new System.Drawing.Size(287, 27);
            this.lbMotto.TabIndex = 0;
            this.lbMotto.Text = "© It\'s Finger-lickin\' Good";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lbMotto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 623);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 38);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::OOP_PROJECT.Properties.Resources.icons8_instagram_96;
            this.pictureBox4.Location = new System.Drawing.Point(415, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(33, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::OOP_PROJECT.Properties.Resources.icons8_twitter_96;
            this.pictureBox3.Location = new System.Drawing.Point(376, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OOP_PROJECT.Properties.Resources.icons8_facebook_96;
            this.pictureBox2.Location = new System.Drawing.Point(337, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pnlCO
            // 
            this.pnlCO.BackColor = System.Drawing.Color.White;
            this.pnlCO.Controls.Add(this.tableLayoutPanel1);
            this.pnlCO.Controls.Add(this.lst_total);
            this.pnlCO.Controls.Add(this.btnCheckPlease);
            this.pnlCO.Location = new System.Drawing.Point(870, 110);
            this.pnlCO.Name = "pnlCO";
            this.pnlCO.Size = new System.Drawing.Size(380, 380);
            this.pnlCO.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.21F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.79F));
            this.tableLayoutPanel1.Controls.Add(this.lbCalories, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbTotal, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 264);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(349, 55);
            this.tableLayoutPanel1.TabIndex = 3;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lbCalories
            // 
            this.lbCalories.AutoSize = true;
            this.lbCalories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCalories.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCalories.Location = new System.Drawing.Point(85, 28);
            this.lbCalories.Name = "lbCalories";
            this.lbCalories.Size = new System.Drawing.Size(260, 26);
            this.lbCalories.TabIndex = 4;
            this.lbCalories.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(85, 1);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(260, 26);
            this.lbTotal.TabIndex = 3;
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Calories";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lst_total
            // 
            this.lst_total.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Dish,
            this.Items,
            this.Price});
            this.lst_total.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_total.Location = new System.Drawing.Point(14, 14);
            this.lst_total.Name = "lst_total";
            this.lst_total.Size = new System.Drawing.Size(349, 246);
            this.lst_total.TabIndex = 0;
            this.lst_total.UseCompatibleStateImageBehavior = false;
            this.lst_total.View = System.Windows.Forms.View.Details;
            // 
            // Dish
            // 
            this.Dish.Text = "Dish";
            this.Dish.Width = 205;
            // 
            // Items
            // 
            this.Items.Text = "Items";
            this.Items.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Items.Width = 58;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Price.Width = 82;
            // 
            // btnCheckPlease
            // 
            this.btnCheckPlease.BackColor = System.Drawing.Color.Green;
            this.btnCheckPlease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckPlease.Font = new System.Drawing.Font("Rockwell", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckPlease.ForeColor = System.Drawing.Color.White;
            this.btnCheckPlease.Location = new System.Drawing.Point(14, 325);
            this.btnCheckPlease.Name = "btnCheckPlease";
            this.btnCheckPlease.Size = new System.Drawing.Size(148, 33);
            this.btnCheckPlease.TabIndex = 1;
            this.btnCheckPlease.Text = "Check Please!";
            this.btnCheckPlease.UseVisualStyleBackColor = false;
            this.btnCheckPlease.Click += new System.EventHandler(this.btnCheckPlease_Click);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSearch.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.Location = new System.Drawing.Point(521, 79);
            this.lbSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(75, 19);
            this.lbSearch.TabIndex = 5;
            this.lbSearch.Text = "SEARCH";
            this.lbSearch.Click += new System.EventHandler(this.lbSearch_Click);
            // 
            // BasePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.pnlCO);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(100, 0);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "BasePage";
            this.Text = "BasePage";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlCO.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lbCustomize;
        private System.Windows.Forms.Label lbLocations;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Label lbMotto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label MainPage;
        private System.Windows.Forms.Button CheckOut;
        private System.Windows.Forms.Panel pnlCO;
        public System.Windows.Forms.ListView lst_total;
        private System.Windows.Forms.Button btnCheckPlease;
        private System.Windows.Forms.ColumnHeader Dish;
        private System.Windows.Forms.ColumnHeader Items;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbCalories;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSearch;
    }
}