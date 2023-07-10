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
using Đồ_Án_1.Bus;
namespace Đồ_Án_1.View
{
    public partial class HOADONNHAP : Form
    {
        HDN_HDX_BUS hdn = new HDN_HDX_BUS();
        CHITIETHOADON_NHAP_XUAT_BUS ct_n_x = new CHITIETHOADON_NHAP_XUAT_BUS();
        public HOADONNHAP()
        {
            InitializeComponent();
        }
        public void Xuat()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var context = new Entities1();
            var result = from c in context.HoaDonNhaps
                         select new
                         {
                             Hoa_Don_Nhap_ID = c.HoaDonNhapID,
                             Ngay_Nhap=c.Ngaynhap,
                             Ngay_Nhan=c.Ngaynhan,
                             Nhan_Vien_ID=c.NhanVienID,
                             Kho_ID=c.KhoID,
                             Trang_Thai=c.Trangthai,
                             Tong_Tien=c.Tongtien,

                         };
            dataGridView1.DataSource = result.ToList();
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void HoaDonNhap_Load(object sender, EventArgs e)
        {
            Xuat();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HoaDonNhap dn = new HoaDonNhap();
            dn.HoaDonNhapID = textBox1.Text;
            dn.Ngaynhap = dateTimePicker1.Value;
            dn.Ngaynhan = dtmNgayBan.Value;
            dn.NhanVienID = comboBox1.Text;
            dn.KhoID = comboBox2.Text;
            dn.Trangthai = textBox6.Text;
            dn.Tongtien = int.Parse(textBox7.Text.Trim());
            hdn.Add_N(dn);
            MessageBox.Show("Thêm thành công");
            Xuat();
            Xoa();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HoaDonNhap dn = new HoaDonNhap();
            dn.HoaDonNhapID = textBox1.Text;
            dn.NhanVienID = comboBox1.Text;
            dn.Ngaynhap = dateTimePicker1.Value;
            dn.Ngaynhan = dtmNgayBan.Value;
            dn.KhoID = comboBox2.Text;
            dn.Trangthai = textBox6.Text;
            dn.Tongtien = int.Parse(textBox7.Text.Trim());
            hdn.Update_N(dn);
            MessageBox.Show("Sửa thành công");
            Xuat();
        }

        private void button3_Click(object sender, EventArgs e)
        {                      
                hdn.Delete_N(textBox1.Text);
                MessageBox.Show("Xóa thành công");           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Xuat();
        }
        public void Xoa()
        {
            textBox1.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[dong].Cells["Hoa_Don_Nhap_ID"].Value.ToString();
            dataGridView1.Rows[dong].Cells["Ngay_Nhap"].Value.ToString();
            dataGridView1.Rows[dong].Cells["Ngay_Nhan"].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[dong].Cells["Nhan_Vien_ID"].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[dong].Cells["Kho_ID"].Value.ToString();
            textBox6.Text = dataGridView1.Rows[dong].Cells["Trang_Thai"].Value.ToString();
            textBox7.Text = dataGridView1.Rows[dong].Cells["Tong_Tien"].Value.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CHITIET_HDN hd = new CHITIET_HDN();
            hd.HoaDonNhapID = textBox11.Text;
            hd.nguyenlieuID = textBox9.Text;
            var sl = int.Parse(textBox10.Text.Trim());
            hd.Soluong = int.Parse(textBox10.Text.Trim());
            var dg = int.Parse(textBox8.Text.Trim());
            var sldh = sl * dg;
            hd.DonGia = sldh;
            ct_n_x.Add_ctN(hd);
            MessageBox.Show("Thêm thành công");
            Xuat_Xuat();
        }
        public void Xuat_Xuat()
        {
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var context = new Entities1();
            var result = from c in context.CHITIET_HDN
                         select new
                         {
                             Hoa_Don_Xuat_ID = c.HoaDonNhapID,
                             Nguyen_Lieu_ID = c.nguyenlieuID,
                             So_Luong = c.Soluong,
                             Don_Gia = c.DonGia,
                         };
            dataGridView2.DataSource = result.ToList();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = dataGridView2.CurrentRow.Index;
            textBox11.Text = dataGridView2.Rows[dong].Cells["Hoa_Don_Xuat_ID"].Value.ToString();
            textBox9.Text = dataGridView2.Rows[dong].Cells["Nguyen_Lieu_ID"].Value.ToString();
            textBox10.Text = dataGridView2.Rows[dong].Cells["So_Luong"].Value.ToString();
            textBox8.Text = dataGridView2.Rows[dong].Cells["Don_Gia"].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ct_n_x.Delete_ctN(textBox11.Text);
            Xuat_Xuat();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CHITIET_HDN hd = new CHITIET_HDN();
            hd.HoaDonNhapID = textBox11.Text;
            hd.nguyenlieuID = textBox9.Text;
            var sl = int.Parse(textBox10.Text.Trim());
            hd.Soluong = int.Parse(textBox10.Text.Trim());
            var dg = int.Parse(textBox8.Text.Trim());
            var sldh = sl * dg;
            hd.DonGia = sldh;
            ct_n_x.Update_ctN(hd);
            MessageBox.Show("Sửa thành công");
            Xuat_Xuat();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Xuat_Xuat();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox11.Text = textBox1.Text;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
