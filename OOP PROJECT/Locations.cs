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
    public partial class Locations : BasePage
    {
        public Locations()
        {
            InitializeComponent();
            pnlSuVanHanh.BringToFront();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
           
        }

        private void Locations_Load(object sender, EventArgs e)
        {
            //SidePanel.Height = button1.Height;
            //SidePanel.Top = button1.Top;
            //pnlLocations.Show();
            //pnlSuVanHanh.Hide();
            //pnlAnDuongVuong.Hide();
            //pnlPhanVanTri.Hide();
            //pnlPhamVanDong.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            pnlSuVanHanh.Show();
            pnlAnDuongVuong.Hide();
            pnlPhanVanTri.Hide();
            pnlPhamVanDong.Hide();
        }

        private void btnAnDuongVuong_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = btnAnDuongVuong.Top;
            pnlSuVanHanh.Hide();
            pnlAnDuongVuong.Show();
            pnlPhanVanTri.Hide();
            pnlPhamVanDong.Hide();
        }

        private void btnPhanVanTri_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnAnDuongVuong.Height;
            SidePanel.Top = btnPhanVanTri.Top;
            pnlSuVanHanh.Hide();
            pnlAnDuongVuong.Hide();
            pnlPhanVanTri.Show();
            pnlPhamVanDong.Hide();
        }

        private void btnPhamVanDong_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnPhamVanDong.Height;
            SidePanel.Top = btnPhamVanDong.Top;
            pnlSuVanHanh.Hide();
            pnlAnDuongVuong.Hide();
            pnlPhanVanTri.Hide();
            pnlPhamVanDong.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
