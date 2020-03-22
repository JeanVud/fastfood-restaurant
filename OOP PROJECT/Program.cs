using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Drawing;


namespace OOP_PROJECT
{

    static class Program
    {
        public static string username;
        public static Order order = new Order();
        public static Person client = new Person();
        public static List<Dish> dishlist = new List<Dish>();


        public static List<Dish> menuOriginals = new List<Dish>();
        public static List<Dish> menuSpecials = new List<Dish>();
        public static List<Dish> menuCombo = new List<Dish>();
        public static List<Dish> menuBurger = new List<Dish>();
        public static List<Dish> menuChicken = new List<Dish>();
        public static List<Dish> menuSnacks = new List<Dish>();
        public static List<Dish> menuDesserts = new List<Dish>();
        public static List<Dish> menuDrinks = new List<Dish>();
        public static List<Dish> menuSalads = new List<Dish>();
        public static List<Dish> menuViet = new List<Dish>();
        public static List<Dish> menuMexican = new List<Dish>();


        public static List<Control> ctlList = new List<Control>();
        public static List<EventHandler> evthdlrList = new List<EventHandler>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DocFile("C:/Users/ASUS/Desktop/New folder (6)/OOP PROJECT/RefTextFiles/dishes2.TXT");
            DocFileMenu();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Customize());
        }
        static void DocFileMenu()
        {
            foreach (Dish dish in dishlist)
            {
                switch (dish.Menu)
                {
                    case "originals":
                        menuOriginals.Add(dish);
                        break;
                    case "burger":
                        menuBurger.Add(dish);
                        break;
                    case "chicken":
                        menuChicken.Add(dish);
                        break;
                    case "combo":
                        menuCombo.Add(dish);
                        break;
                    case "dessert":
                        menuDesserts.Add(dish);
                        break;
                    case "drinks":
                        menuDrinks.Add(dish);
                        break;
                    case "mexican":
                        menuMexican.Add(dish);
                        break;
                    case "salads":
                        menuSalads.Add(dish);
                        break;
                    case "snacks":
                        menuSnacks.Add(dish);
                        break;
                    case "specials":
                        menuSpecials.Add(dish);
                        break;
                    case "viet":
                        menuViet.Add(dish);
                        break;

                }
            }
        }
        public static void DocFile(string filename)
        {
            StreamReader sw = new StreamReader(filename);   //mở tập tin
            string line;

            int i = 0;

            //Đọc dữ liệu từ tập tin
            sw.ReadLine();
            do
            {
                dishlist.Add(new Dish());
                //dish[i] = new Dish();
                line = sw.ReadLine();

                string[] words = line.Split('\t');
                dishlist[i].Name = words[0];                    //name
                dishlist[i].Menu = words[1];                    //menu
                dishlist[i].Course = words[2];                  //course
                dishlist[i].Preptime = int.Parse(words[3]);     //prep time
                dishlist[i].Calories = int.Parse(words[4]);     //calories

                string pr = words[5];                       //price
                pr.Remove(0, 1); //deletes the first quote
                pr.Remove(pr.Length - 1, 1);  //deletes the second quote
                pr.Replace(",", string.Empty);
                dishlist[i].Price = int.Parse(pr);

                string rawallergens = words[6];             //allergens
                StringBuilder sb = new StringBuilder(rawallergens);
                if (words[6].Contains('"'))
                {
                    sb.Remove(0, 1); //deletes the first quote
                    sb.Remove(sb.Length - 1, 1);  //deletes the second quote
                }
                rawallergens = sb.ToString();
                string[] allergy = rawallergens.Split(',');
                dishlist[i].Allergens = allergy;

                dishlist[i].Description = words[7];             //description

                string imgname = dishlist[i].Name.Replace(' ', '_');     //image
                dishlist[i].Image = (Image)Properties.Resources.ResourceManager.GetObject(imgname);


                i++;
            } while (!sw.EndOfStream);

            sw.Close();
        }
    }

}