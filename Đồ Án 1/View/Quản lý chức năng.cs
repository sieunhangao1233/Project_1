using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_Án_1.View
{
    public partial class Quản_lý_chức_năng : Form
    {
        public Quản_lý_chức_năng()
        {
            InitializeComponent();
        }
        private Form Quanlychucnang;
        private void OpenQuanlychucnang(Form qlchucnang)
        {
            if (Quanlychucnang != null)
            {
                Quanlychucnang.Close();
            }
            Quanlychucnang = qlchucnang;
            qlchucnang.TopLevel = false;
            qlchucnang.FormBorderStyle = FormBorderStyle.None;
            qlchucnang.Dock = DockStyle.Fill;
            panel3.Controls.Add(qlchucnang);
            panel3.Tag = qlchucnang;
            qlchucnang.BringToFront();
            qlchucnang.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenQuanlychucnang(new Nhân_Viên());
            label1.Text = button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenQuanlychucnang(new HoaDon());
            label1.Text = button2.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Quanlychucnang != null)
            {
                Quanlychucnang.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenQuanlychucnang(new MonAn());
            label1.Text = button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenQuanlychucnang(new HOADONNHAP());
            label1.Text = button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenQuanlychucnang(new HoaDonXuat_View());
            label1.Text = button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenQuanlychucnang(new BAN_AN());
            label1.Text = button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenQuanlychucnang(new NguynLieu());
            label1.Text = button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenQuanlychucnang(new Kho());
            label1.Text = button8.Text;
        }
        private void Quản_lý_chức_năng_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenQuanlychucnang(new THONGKEQUAN());
            label1.Text = button9.Text;
        }
    }
}
