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
    public partial class Customize : BasePage
    {
        List<Dish> customizeList;
        List<string> menuchecked = new List<string>();
        bool done = false;
        public Customize()
        {
            InitializeComponent();

            //check all items in clbMenu
            for (int i = 0; i < clbMenu.Items.Count; i++)
                clbMenu.SetItemChecked(i, true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (done)
                Burger.DisposeControl(this);
            done = true;
            customizeList = new List<Dish>();
            
            #region PRICE 
            foreach (Dish dish in Program.dishlist)
                if (dish.Price <= trbarPrice.Value)
                    customizeList.Add(dish);
            #endregion

            //Calories
            List<Dish> templist = new List<Dish>(customizeList);
            foreach (Dish dish in templist)
                if (dish.Calories > trbarCalories.Value)
                    customizeList.Remove(dish);
            templist = new List<Dish>(customizeList);

            #region MENU TYPE
            templist = new List<Dish>(customizeList);
            foreach (Dish dish in templist)
                if (!checkDishInMenu(dish.Menu,clbMenu))
                    customizeList.Remove(dish);
            templist = new List<Dish>(customizeList);
            #endregion


            //Allergens -with tooltip
            templist = new List<Dish>(customizeList);
            foreach (Dish dish in templist)
                foreach (string ingredient in dish.Allergens)
                    for (int i = 0; i < clbAllergens.CheckedItems.Count; i++) 
                        if (ingredient==clbAllergens.CheckedItems[i].ToString().ToLower())
                        {
                            customizeList.Remove(dish);
                            break;
                        }

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    customizeList = customizeList.OrderBy(o => o.Name).ToList();
                    break;
                case 1:
                    customizeList = customizeList.OrderBy(o => o.Price).ToList();
                    break;
                case 2:
                    customizeList = customizeList.OrderBy(o => o.Calories).ToList();
                    break;
                case 3:
                    customizeList = customizeList.OrderBy(o => o.Preptime).ToList();
                    break;

            }

            Burger.DisplayMenuItems(customizeList, groupBox1.Bottom+20, this);

        }

        private bool checkDishInMenu(string str,CheckedListBox clb)
        {
            for (int i = 0; i < clb.CheckedItems.Count; i++)
                if (str == ((string)clb.CheckedItems[i]).ToLower())
                    return true;
            return false;
        }

        private void trbarPrice_Scroll(object sender, EventArgs e)
        {
            labelPrice.Text = trbarPrice.Value.ToString();
        }

        private void trbarCalories_Scroll(object sender, EventArgs e)
        {
            labelCalories.Text = trbarCalories.Value.ToString();
        }
    }
}
