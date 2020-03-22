using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace OOP_PROJECT
{
    public partial class SignUp : FormFormatting
    {
        string ConnectionStrin = @"Data Source=DESKTOP-HKJ2P6R\SQLEXPRESS;Initial Catalog=DANGKI;Integrated Security=True";
        public SignUp()
        {
            InitializeComponent();
            this.Font = new Font("Rockwell", 13, FontStyle.Regular);
            btnSignUp.Font = new Font("Rockwell", 18, FontStyle.Regular);

            placehdrtxtPassword.UseSystemPasswordChar = true;

            this.BackgroundImage = Properties.Resources.beach;
            Timer tm = new Timer();
            tm.Interval = 5000;
            tm.Tick += new EventHandler(changeImage);
            tm.Start();

        }

        private void changeImage(object sender, EventArgs e)
        {
            List<Bitmap> b1 = new List<Bitmap>();
            b1.Add(Properties.Resources.Tamales);
            b1.Add(Properties.Resources.Cheese_Chicken);
            b1.Add(Properties.Resources.Diet_Coke);
            int index = DateTime.Now.Second % b1.Count;
            this.BackgroundImage = b1[index];
        }



        private void borderlessButton1_Click(object sender, EventArgs e)
        {
            placehdrtxtPassword.UseSystemPasswordChar = !placehdrtxtPassword.UseSystemPasswordChar;
            bool val = placehdrtxtPassword.UseSystemPasswordChar;
            if (!val)
            {
                placehdrtxtPassword.PasswordChar = '*';
                btnPasswordHideShow.BackgroundImage = Properties.Resources.eye;
            }
            else
            {
                placehdrtxtPassword.PasswordChar = new char();
                btnPasswordHideShow.BackgroundImage = Properties.Resources.hide;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

            string str = placehdrtxtName.Text;
            string[] arr = str.Split(' ');
            Program.username = arr[arr.Length - 1];
            //CreateNewAccount();
            MainPage mainpage = new MainPage();
            mainpage.Show();
            this.Hide();

            using (SqlConnection sqlCon = new SqlConnection(ConnectionStrin))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("SignUp", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@name", placehdrtxtName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@ngay", txtDay.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@thang", txtMonth.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@nam", txtYear.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@email", placehdrtxtEmail.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@password", placehdrtxtPassword.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Registration Successed");
                Clear();

            }

            
        }
        void Clear()
        {
            placehdrtxtName.Text = txtDay.Text = txtMonth.Text = txtYear.Text = placehdrtxtEmail.Text = placehdrtxtPassword.Text = "";
        }

        private void btnTermsOfUse_Click(object sender, EventArgs e)
        {

        }

        private void placehdrtxtName1_MouseClick(object sender, MouseEventArgs e)
        {
            lbName.Hide();
        }

        private void lbName_MouseClick(object sender, MouseEventArgs e)
        {
            lbName.Hide();
        }

        private void placehdrtxtName1_Leave(object sender, EventArgs e)
        {
            if (placehdrtxtName.Text == null)
            {
                lbName.Show();
                lbName.BringToFront();
            }

        }

        private void lbName_Click(object sender, EventArgs e)
        {
            lbName.Hide();
        }


        
    }
    }



