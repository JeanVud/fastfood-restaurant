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
    public partial class Mexican : BasePage
    {
        Panel pnlHeader = new Panel();
        //Dish d = new Dish();
        //List<Dish> menulist = new List<Dish>();

        public Mexican()
        {
            InitializeComponent();
            this.AutoScroll = true;

            // Header
            BasePage bpage = new BasePage();
            Panel p = bpage.GetHeaderPanel();

            pnlHeader.Location = new Point(0, p.Location.Y + p.Size.Height);
            pnlHeader.Size = new Size(1265, 490);
            pnlHeader.BackgroundImage = OOP_PROJECT.Properties.Resources.mn4;
            this.Controls.Add(pnlHeader);

            Mexican f = this;

            Burger.DisplayMenuItems(Program.menuMexican, pnlHeader.Bottom, f);

        }

    }
}