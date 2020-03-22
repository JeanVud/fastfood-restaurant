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
    public partial class Burger : BasePage
    {
        Panel pnlHeader = new Panel();
        //Dish d = new Dish();
        //List<Dish> menulist = new List<Dish>();

        public Burger()
        {
            InitializeComponent();
            this.AutoScroll = true;

            // Header
            BasePage bpage = new BasePage();
            Panel p = bpage.GetHeaderPanel();

            pnlHeader.Location = new Point(0, p.Location.Y + p.Size.Height);
            pnlHeader.Size = new Size(1265, 490);
            pnlHeader.BackgroundImage = OOP_PROJECT.Properties.Resources._6_Burgers;
            pnlHeader.BackColor = Color.Yellow;
            this.Controls.Add(pnlHeader);

            Burger f = this;

            DisplayMenuItems(Program.menuBurger, pnlHeader.Bottom, f);

        }

        static public void DisplayMenuItems(List<Dish> menulist, int pnlHeader, BasePage f)
        {

            Point coord = new Point(); // (x, y)
            //Point coord = new Point(); // (x, y)
            Size itemsize = new Size(500, 200); //Size of panel that wraps item details
            Size imagesize = new Size(200, 200);
            int margin = 40; //margin among items 

            int k = 1; //index of items in a line

            int leftX;
            int prevX = leftX = (1265 - itemsize.Width * 2 - margin) / 2; //left margin X
            int prevY = pnlHeader + 50; //left margin Y

            for (int i = 0; i < menulist.Count(); i++)
            {
                switch (k)
                {
                    case 1:
                        {
                            coord = new Point(prevX, prevY);
                            DisplayItem(i, coord, menulist, f);
                            prevX += itemsize.Width + margin;
                            k++;
                            break;
                        }
                    case 2:
                        {
                            coord = new Point(prevX, prevY);
                            DisplayItem(i, coord, menulist, f);
                            prevX = leftX;
                            prevY += itemsize.Height + margin + 100;
                            k = 1;
                            break;
                        }
                }
            }
        }

        static public void DisplayItem(int i, Point coord, List<Dish> menulist, BasePage f)
        {
            Size itemsize = new Size(500, 300); //Size of panel that wraps item details
            Size imagesize = new Size(300, 300);

            #region wrapper
            Panel wrapper = new Panel();
            wrapper.Size = itemsize;
            wrapper.Location = coord;
            wrapper.BackColor = Color.White;
            #endregion

            #region image
            PictureBox image = new PictureBox();
            wrapper.Controls.Add(image);
            image.Dock = DockStyle.Left;
            image.Size = imagesize;
            image.Image = menulist[i].Image;
            #endregion

            #region name
            Label name = new Label();
            wrapper.Controls.Add(name);
            //name.Size = new Size(150, 30);
            name.Location = new Point(image.Right + 5, image.Left + 5);
            name.MaximumSize = new Size(200, 0);
            name.AutoSize = true;
            name.Font = new Font("Rockwell", 16, FontStyle.Regular);
            name.ForeColor = Color.Green;
            name.BackColor = Color.White;
            //name.Location = new Point(image.Location.X + image.Size.Width+20, image.Location.Y + 20);
            name.Text = menulist[i].Name;
            //name.TabIndex = 0;
            #endregion            

            #region price
            Label price = new Label();
            wrapper.Controls.Add(price);
            price.Location = new Point(name.Bounds.Left, name.Bounds.Bottom + 10);
            price.Size = new Size(150, 20);
            price.Font = new Font("Rockwell", 12, FontStyle.Regular);
            price.ForeColor = Color.Black;
            price.BackColor = Color.White;
            price.Text = menulist[i].Price.ToString() + " VND";
            #endregion

            #region checkout
            Button checkout = new Button();
            wrapper.Controls.Add(checkout);
            checkout.Image = Properties.Resources.add_shopping_cart;
            checkout.Size = new Size(35, 35);
            checkout.BackColor = Color.White;
            checkout.FlatStyle = FlatStyle.Flat;
            checkout.FlatAppearance.BorderSize = 0;
            checkout.Location = new Point(image.Right + 5, image.Bottom - 50);
            EventHandler handlerCheckout = (sender, args) =>
            {
                if (f.lst_total.Items.Count == 0)
                {
                    for (int k = 0; k < Program.order.list.Count; k++)
                    {
                        string[] arr = new string[3];
                        //add items to ListView
                        arr[0] = Program.order.list[k].Name;
                        arr[1] = Program.order.items[k].ToString();
                        arr[2] = (Program.order.list[k].Price * Program.order.items[k]).ToString();
                        ListViewItem itm = new ListViewItem(arr);
                        f.lst_total.Items.Add(itm);
                    }
                }
                //http://csharp.net-informations.com/gui/cs-listview.htm

                //traverse the order list
                //if duplicate: returns index, if not duplicate: -1
                int index = CheckDuplicate(menulist[i]);
                if (index == -1)
                {

                    Program.order.list.Add(menulist[i]);
                    Program.order.items.Add(1);

                    string[] arr = new string[3];
                    ListViewItem itm;
                    //add items to ListView
                    arr[0] = menulist[i].Name;
                    arr[1] = 1.ToString();
                    arr[2] = menulist[i].Price.ToString();
                    itm = new ListViewItem(arr);
                    f.lst_total.Items.Add(itm);
                }
                else
                {
                    Program.order.items[index] += 1;

                    string[] arr = new string[3];
                    //add items to ListView
                    var lvi = f.lst_total.Items[index];
                    lvi.SubItems[1].Text = (int.Parse(lvi.SubItems[1].Text) + 1).ToString();
                    lvi.SubItems[2].Text = (int.Parse(lvi.SubItems[2].Text) * int.Parse(lvi.SubItems[1].Text)).ToString();
                    f.lst_total.Items[index] = lvi;
                }

            };
            checkout.Click += handlerCheckout;
            #endregion

            #region learnmore
            Button learnmore = new Button();
            wrapper.Controls.Add(learnmore);
            learnmore.Location = new Point(checkout.Right + 5, checkout.Top);
            learnmore.Size = new Size(145, 35);
            learnmore.BackColor = Color.Green;
            learnmore.ForeColor = Color.White;
            learnmore.FlatStyle = FlatStyle.Flat;
            learnmore.FlatAppearance.BorderSize = 0;
            learnmore.Text = "LEARN MORE";
            EventHandler handlerLearnmore = (sender, args) =>
            {
                LearnMore lm = new LearnMore(menulist[i]);
                lm.Show();
                lm.FormClosed += (s, e) => f.Show();
                
            };
            learnmore.Click += handlerLearnmore;

            #endregion

            #region add controls
            //this.Controls.Add(learnmore);
            //this.Controls.Add(name);
            //this.Controls.Add(price);
            //this.Controls.Add(checkout);
            //this.Controls.Add(image);
            f.Controls.Add(wrapper);
            #endregion

            #region add all created controls to control list
            Program.ctlList.Add(learnmore);
            Program.ctlList.Add(name);
            Program.ctlList.Add(price);
            Program.ctlList.Add(checkout);
            Program.ctlList.Add(image);
            Program.ctlList.Add(wrapper);
            #endregion

            #region add event handlers to eventhandler list
            if (Program.evthdlrList.Count == 0)
            {
                Program.evthdlrList.Add(handlerCheckout);
                Program.evthdlrList.Add(handlerLearnmore);
            }
            #endregion

        }
        static private int CheckDuplicate(Dish x)
        {
            for (int j = 0; j < Program.order.list.Count; j++)
            {
                if (Program.order.list[j].Name == x.Name)
                    return j;
            }
            return -1;
        }
        static public void DisposeControl(BasePage f)
        {
            foreach (Control ctl in Program.ctlList)
            {
                //checkout
                if (ctl.Size == new Size(35, 35) && ctl is Button)
                    ctl.Click -= Program.evthdlrList[0];
                //learnmore
                if (ctl.Size == new Size(145, 35) && ctl is Button)
                    ctl.Click -= Program.evthdlrList[1];
                f.Controls.Remove(ctl);
                ctl.Dispose();
            }
            Program.ctlList.Clear();
        }
    }
}