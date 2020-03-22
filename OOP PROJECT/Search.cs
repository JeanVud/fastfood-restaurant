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
    public partial class Search : BasePage
    {
        public Search()
        {
            InitializeComponent();
            lbPlaceHdr.Location = new Point(tablelaySeach.Left + txtSearch.Width - lbPlaceHdr.Width, tablelaySeach.Top+14);
            lbPlaceHdr.BringToFront();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            lbPlaceHdr.Hide();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            lbPlaceHdr.Hide();
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                lbPlaceHdr.Show();
                lbPlaceHdr.BringToFront();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string s = txtSearch.Text.ToLower();
            
            if (s!="")
            {
                if (Program.ctlList.Count != 0)
                    Burger.DisposeControl(this);

                List<Dish> result = new List<Dish>();
                string[] words = s.Split(' ');
                foreach (string word in words)
                {
                    foreach(Dish dish in Program.dishlist)
                    {
                        string name = dish.Name.ToLower();
                        string description = dish.Description.ToLower();
                        if (name.Contains(word) || description.Contains(word))
                            result.Add(dish);
                    }
                }
                result = result.Distinct().ToList();
                
                Search f = this;                
                Burger.DisplayMenuItems(result, tablelaySeach.Bottom, f);   

            }

        }

        private void ClearOutSearchResults()
        {
            foreach(Control control in Controls)
            {
                if (control.Name != "lbPlaceHdr" && control is Label)
                    this.Controls.Remove(control);
                if (control.Name != "txtSearch" && control is TextBox)
                    this.Controls.Remove(control);
                if (control.Name != "txtSebtnSearcharch" && control is Button)
                    this.Controls.Remove(control);
                if (control is Panel)
                    this.Controls.Remove(control);
                if (control is PictureBox)
                    this.Controls.Remove(control);
            }
        }

        private void Search_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearch_Click(sender, e);
                txtSearch.Text = "";
            }
        }
    }
}
