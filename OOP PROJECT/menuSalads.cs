﻿using System;
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
    public partial class Salads : BasePage
    {
        Panel pnlHeader = new Panel();
        //Dish d = new Dish();
        //List<Dish> menulist = new List<Dish>();

        public Salads()
        {
            InitializeComponent();
            this.AutoScroll = true;

            // Header
            BasePage bpage = new BasePage();
            Panel p = bpage.GetHeaderPanel();

            pnlHeader.Location = new Point(0, p.Location.Y + p.Size.Height);
            pnlHeader.Size = new Size(1265, 490);
            pnlHeader.BackgroundImage = OOP_PROJECT.Properties.Resources._7_SALADS;
            this.Controls.Add(pnlHeader);

            Salads f = this;
            Burger.DisplayMenuItems(Program.menuSalads, pnlHeader.Bottom, f);

        }

    }
}