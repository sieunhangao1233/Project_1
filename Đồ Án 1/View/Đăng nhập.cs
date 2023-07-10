using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Đồ_Án_1.View;
using Đồ_Án_1.Dao;
using Đồ_Án_1.Data;
namespace Đồ_Án_1
{
    public partial class Fdangki : Form
    {
        Entities1 dk = new Entities1();
        public Fdangki()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string taikhoan = txtAccount.Text;
            string matkhau = txtPasswork.Text;
            kiemtradangnhap(taikhoan, matkhau);
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            Đăng_kí f = new Đăng_kí();
            f.Show();
            this.Hide();
        }

        private void Fdangki_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                e.Cancel = true;
        }
        private void kiemtradangnhap(string taikhoan, string matkhau)
        {
            var user = dk.DANGNHAPs.Where(u => u.TaiKhoan.Equals(taikhoan)).ToList();
            if (user.Count() > 0)
            {
                if (user[0].matkhau.Equals(matkhau))
                {
                    Quản_lý_chức_năng  f = new Quản_lý_chức_năng();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Mat khau khong dung");
                }
            }
            else
            {
                MessageBox.Show("Tren he thong khong co tai khoan");
            }
        }

        private void Fdangki_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btLogin_Click_1(object sender, EventArgs e)
        {
            Quản_lý_chức_năng f = new Quản_lý_chức_năng();
            f.Show();
            this.Hide();
        }

        private void txtAccount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
