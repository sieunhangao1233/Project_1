using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Đồ_Án_1.Data;
using Đồ_Án_1.Dao;
namespace Đồ_Án_1.View
{
    public partial class Đăng_kí : Form
    {
        UserDao dk = new UserDao();
        public Đăng_kí()
        {
            InitializeComponent();
        }

        private void Đăng_kí_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btRegiter_Click(object sender, EventArgs e)
        {
            if (txtAccount.Text == "")
            {
                MessageBox.Show("Tai khoan khong duoc de trong");
                txtAccount.Focus();
            }
            else if (txtEPasswork.Text == "")
            {
                MessageBox.Show("Mat khau khong duoc de trong");
                txtEPasswork.Focus();
            }
            else if (txtPasswork.Text == "")
            {
                MessageBox.Show("Nhap lai mat khau khong duoc de trong ");
                txtPasswork.Focus();
            }
            else if (txtPasswork.Text != txtEPasswork.Text)
            {
                MessageBox.Show("mat khau khong trung khop");
            }
            else
            {
                DANGNHAP ql = new DANGNHAP();
                ql.TaiKhoan = txtAccount.Text;
                ql.matkhau = txtPasswork.Text;
                ql.nhaplaimatkhau = txtEPasswork.Text;
                dk.Add(ql);
                MessageBox.Show("Dang ki thanh cong");

            }
        }
        private void Đăng_kí_FormClosed(object sender, FormClosedEventArgs e)
        {
            Fdangki f = new Fdangki();
            f.Show();
        }

        private void Đăng_kí_Load(object sender, EventArgs e)
        {

        }
    }
}
