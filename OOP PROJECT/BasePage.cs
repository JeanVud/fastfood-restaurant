using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_PROJECT
{
    public partial class BasePage : FormFormatting
    {
        // attributes

        // constructors
        public BasePage()
        {
            InitializeComponent();
            this.Font = new Font("Century Gothic", 13, FontStyle.Regular);
            this.Size = new Size(1300, 700);
            this.AutoScroll = true;

            //Username
            //lbUser.Text = Program.username;

            //Checkout panel
            pnlCO.Location = new Point(870, 110);

            //total.Location = new Point(pnlCO.Location.X + 30, pnlCO.Location.Y + 30);
            //total.Size = new Size(320, 300);

            pnlCO.Controls.Add(lst_total);
            this.Controls.Add(pnlCO);
            pnlCO.Hide();
        }

        // get-set
        public Panel GetHeaderPanel()
        {
            return pnlHeader;
        }
        public Panel PanelCheckOut
        {
            get { return pnlCO; }
        }


        private void MainPage_Click(object sender, EventArgs e)
        {
            MainPage mainpage = new MainPage();
            mainpage.Show();
        }

        private void CheckOut_Click(object sender, EventArgs e)
        {

            int calories = 0;
            int tot = 0;
            if (pnlCO.Visible)
            {
                pnlCO.Hide();
            }
            else
            {
                if (lst_total.Items.Count == 0)
                {
                    for (int i = 0; i < Program.order.list.Count; i++)
                    {
                        string[] arr = new string[3];
                        //add items to ListView
                        arr[0] = Program.order.list[i].Name;
                        arr[1] = Program.order.items[i].ToString();
                        arr[2] = (Program.order.list[i].Price * Program.order.items[i]).ToString();
                        ListViewItem itm = new ListViewItem(arr);
                        lst_total.Items.Add(itm);
                    }
                    lbCalories.Text = calories.ToString() + "cal";
                    lbTotal.Text = tot.ToString() + " VND";
                }
                for (int i = 0; i < Program.order.list.Count; i++)
                {
                    calories += Program.order.list[i].Calories;
                    tot += Program.order.list[i].Price * Program.order.items[i];
                }
                lbCalories.Text = calories.ToString() + "cal";
                lbTotal.Text = tot.ToString() + " VND";
                pnlCO.Show();
                pnlCO.BringToFront();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlCO.Hide();
        }

        private void btnCheckPlease_Click(object sender, EventArgs e)
        {
            CheckOut co = new CheckOut();
            co.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbLocations_Click(object sender, EventArgs e)
        {
            Locations lct = new Locations();
            this.Hide();
            lct.Show();
        }

        private void lbCustomize_Click(object sender, EventArgs e)
        {
            Customize lct = new Customize();
            this.Hide();
            lct.Show();
        }

        private void lbSearch_Click(object sender, EventArgs e)
        {
            Search sch = new Search();
            this.Hide();
            sch.Show();
        }
    }
}