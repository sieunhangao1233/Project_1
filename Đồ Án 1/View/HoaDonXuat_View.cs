using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Đồ_Án_1.Bus;
using Đồ_Án_1.Data;
namespace Đồ_Án_1.View
{
    public partial class HoaDonXuat_View : Form
    {
        public HoaDonXuat_View()
        {
            InitializeComponent();
        }

        HDN_HDX_BUS nx = new HDN_HDX_BUS();
        CHITIETHOADON_NHAP_XUAT_BUS cthd = new CHITIETHOADON_NHAP_XUAT_BUS();
        private void button1_Click(object sender, EventArgs e)
        {
            HoaDonXuat dn = new HoaDonXuat();
            dn.HoaDonXuatID = textBox1.Text;
            dn.Ngayxuat = dtmNgayBan.Value;
            dn.Ngaynhan = dateTimePicker1.Value;
            dn.NhanVien_Xuat = comboBox1.Text;
            dn.NhanVien_Nhan = comboBox2.Text;
            dn.KhoID = comboBox3.Text;
            nx.Add_X(dn);
            MessageBox.Show("Thêm thành công");
            Xuat();
            Xoa();
        }
        public void Xuat()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var context = new Entities1();
            var result = from c in context.HoaDonXuats
                         select new
                         {
                             Hoa_Don_Xuat_ID = c.HoaDonXuatID,
                             Ngay_Xuat = c.Ngayxuat,
                             Ngay_Nhan = c.Ngaynhan,
                             Nhan_Vien_Xuat = c.NhanVien_Xuat,
                             Nhan_Vien_Nhan=c.NhanVien_Nhan,
                             Kho_ID = c.KhoID,
                         };
            dataGridView1.DataSource = result.ToList();
        }
        public void Xoa()
        {
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HoaDonXuat dn = new HoaDonXuat();
            dn.HoaDonXuatID = textBox1.Text;
            dn.NhanVien_Xuat = comboBox1.Text;
            dn.NhanVien_Nhan = comboBox2.Text;
            dn.KhoID = comboBox3.Text;
            nx.Update_X(dn);
            MessageBox.Show("Thêm thành công");
            Xuat();
            Xoa();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nx.Delete_X(textBox1.Text);
            MessageBox.Show("Xóa thành công");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Xuat();
        }

        private void HoaDonXuat_View_Load(object sender, EventArgs e)
        {
            Xuat();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[dong].Cells["Hoa_Don_Xuat_ID"].Value.ToString();
            dataGridView1.Rows[dong].Cells["Ngay_Xuat"].Value.ToString();
            dataGridView1.Rows[dong].Cells["Ngay_Nhan"].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[dong].Cells["Nhan_Vien_Xuat"].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[dong].Cells["Nhan_Vien_Nhan"].Value.ToString();
            comboBox3.Text = dataGridView1.Rows[dong].Cells["Kho_ID"].Value.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = dataGridView2.CurrentRow.Index;
            textBox11.Text = dataGridView2.Rows[dong].Cells["Hoa_Don_Xuat_ID"].Value.ToString();
            textBox9.Text = dataGridView2.Rows[dong].Cells["Nguyen_Lieu_ID"].Value.ToString();
            textBox10.Text = dataGridView2.Rows[dong].Cells["So_Luong"].Value.ToString();
            textBox8.Text = dataGridView2.Rows[dong].Cells["Don_Gia"].Value.ToString();
        }
        public void Xuat_Xuat()
        {
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var context = new Entities1();
            var result = from c in context.CHITIET_HDX
                         select new
                         {
                             Hoa_Don_Xuat_ID = c.HoaDonXuatID,
                             Nguyen_Lieu_ID = c.nguyenlieuID,
                             So_Luong = c.SoLuong,
                             Don_Gia = c.Dongia,
                         };
            dataGridView2.DataSource = result.ToList();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CHITIET_HDX hd = new CHITIET_HDX();
            hd.HoaDonXuatID = textBox11.Text;
            hd.nguyenlieuID = textBox9.Text;
            var sl = int.Parse(textBox10.Text.Trim());
            hd.SoLuong = int.Parse(textBox10.Text.Trim());
            var dg = int.Parse(textBox8.Text.Trim());
            var sldh = sl * dg;
            hd.Dongia = sldh;
            cthd.Add_ctX(hd);
            MessageBox.Show("Thêm thành công");
            Xuat_Xuat();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           cthd.Delete_ctX(textBox11.Text);
            Xuat_Xuat();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CHITIET_HDX hd = new CHITIET_HDX();
            hd.HoaDonXuatID = textBox11.Text;
            hd.nguyenlieuID = textBox9.Text;
            var sl = int.Parse(textBox10.Text.Trim());
            hd.SoLuong = int.Parse(textBox10.Text.Trim());
            var dg = int.Parse(textBox8.Text.Trim());
            var sldh = sl * dg;
            hd.Dongia = sldh;
            cthd.Update_ctX(hd);
            MessageBox.Show("Sửa thành công");
            Xuat_Xuat();
        }
    }
}
