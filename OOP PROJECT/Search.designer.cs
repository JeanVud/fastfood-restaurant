namespace OOP_PROJECT
{
    partial class Search
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CheckOut = new System.Windows.Forms.Button();
            this.lbCustomize = new System.Windows.Forms.Label();
            this.lbLocations = new System.Windows.Forms.Label();
            this.MainPage = new System.Windows.Forms.Label();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.lbPlaceHdr = new System.Windows.Forms.Label();
            this.tablelaySeach = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tablelaySeach.SuspendLayout();
            this.SuspendLayout();
            // 
            // lst_total
            // 
            this.lst_total.Size = new System.Drawing.Size(10, 233);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 85);
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
            this.CheckOut.Size = new System.Drawing.Size(10, 21);
            this.CheckOut.TabIndex = 1;
            this.CheckOut.Text = "CHECK-OUT";
            this.CheckOut.UseVisualStyleBackColor = false;
            // 
            // lbCustomize
            // 
            this.lbCustomize.AutoSize = true;
            this.lbCustomize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCustomize.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomize.Location = new System.Drawing.Point(880, 79);
            this.lbCustomize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCustomize.Name = "lbCustomize";
            this.lbCustomize.Size = new System.Drawing.Size(100, 19);
            this.lbCustomize.TabIndex = 1;
            this.lbCustomize.Text = "CUSTOMIZE";
            // 
            // lbLocations
            // 
            this.lbLocations.AutoSize = true;
            this.lbLocations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLocations.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocations.Location = new System.Drawing.Point(612, 79);
            this.lbLocations.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLocations.Name = "lbLocations";
            this.lbLocations.Size = new System.Drawing.Size(104, 19);
            this.lbLocations.TabIndex = 1;
            this.lbLocations.Text = "LOCATIONS";
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
            // lbPlaceHdr
            // 
            this.lbPlaceHdr.AutoSize = true;
            this.lbPlaceHdr.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPlaceHdr.ForeColor = System.Drawing.Color.Gray;
            this.lbPlaceHdr.Location = new System.Drawing.Point(530, 146);
            this.lbPlaceHdr.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbPlaceHdr.Name = "lbPlaceHdr";
            this.lbPlaceHdr.Size = new System.Drawing.Size(299, 26);
            this.lbPlaceHdr.TabIndex = 9;
            this.lbPlaceHdr.Text = "Enter a word or short phrase";
            // 
            // tablelaySeach
            // 
            this.tablelaySeach.ColumnCount = 2;
            this.tablelaySeach.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.90701F));
            this.tablelaySeach.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.09299F));
            this.tablelaySeach.Controls.Add(this.txtSearch, 0, 0);
            this.tablelaySeach.Controls.Add(this.btnSearch, 1, 0);
            this.tablelaySeach.Location = new System.Drawing.Point(337, 181);
            this.tablelaySeach.Name = "tablelaySeach";
            this.tablelaySeach.RowCount = 1;
            this.tablelaySeach.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablelaySeach.Size = new System.Drawing.Size(613, 60);
            this.tablelaySeach.TabIndex = 10;
            // 
            // txtSearch
            // 
            this.txtSearch.AllowDrop = true;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 23F);
            this.txtSearch.Location = new System.Drawing.Point(3, 3);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(538, 54);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 6F);
            this.btnSearch.Image = global::OOP_PROJECT.Properties.Resources.icons8_search_40;
            this.btnSearch.Location = new System.Drawing.Point(547, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(63, 54);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.tablelaySeach);
            this.Controls.Add(this.lbPlaceHdr);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "Search";
            this.Text = "Search";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_KeyDown);
            this.Controls.SetChildIndex(this.lbPlaceHdr, 0);
            this.Controls.SetChildIndex(this.tablelaySeach, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tablelaySeach.ResumeLayout(false);
            this.tablelaySeach.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbPlaceHdr;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CheckOut;
        private System.Windows.Forms.Label lbCustomize;
        private System.Windows.Forms.Label lbLocations;
        private System.Windows.Forms.Label MainPage;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.TableLayoutPanel tablelaySeach;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}