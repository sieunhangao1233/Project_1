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
    public partial class HoaDon : Form
    {
        HoaDon_BUS hoab = new HoaDon_BUS();
        CHITIETHOADON_BUS cthd = new CHITIETHOADON_BUS();
        List<CHITIET_HOADON> danhSachTam = new List<CHITIET_HOADON>();
        public HoaDon()
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
            dataGridView1.Controls.Add(qlchucnang);
            dataGridView1.Tag = qlchucnang;
            qlchucnang.BringToFront();
            qlchucnang.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            HOADON hd = new HOADON();
            hd.HoaDonID = textBox1.Text;
            hd.NhanVienID = comboBox1.Text;
            hd.BanID = comboBox2.Text;
            hd.TrangThai = comboBox4.Text;
            hd.Giamgia = int.Parse(textBox5.Text.Trim());
            hd.NgayTao = dateTimePicker1.Value;
            hd.Tongtien = int.Parse(textBox6.Text.Trim());
            hoab.Them(hd);
            MessageBox.Show("Thêm thành công");
        }
        public void Xuat()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var context = new Entities1();
            var result = from c in context.HOADONs
                         select new
                         {
                             Hoa_Don_ID = c.HoaDonID,
                             Nhan_Vien_ID = c.NhanVienID,
                             Ban_ID = c.BanID,
                             Trang_Thai = c.TrangThai,
                             Giam_Gia = c.Giamgia,
                             Tong_Tien = c.Tongtien,
                             Ngay_Tao = c.NgayTao,
                         };
            dataGridView1.DataSource = result.ToList();
        }
        public void Xoa()
        {
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                var context = new Entities1();
                var result = from c in context.HOADONs
                             where (c.BanID.IndexOf(textBox7.Text) >= 0)
                             select new
                             {
                                 Hoa_Don_ID = c.HoaDonID,
                                 Nhan_Vien_ID = c.NhanVienID,
                                 Ban_ID = c.BanID,
                                 Trang_Thai = c.TrangThai,
                                 Giam_Gia = c.Giamgia,
                                 Tong_Tien = c.Tongtien,
                                 Ngay_Tao = c.NgayTao,
                             };
                dataGridView1.DataSource = result.ToList();
            }
            catch
            {
                dataGridView1.DataSource = null;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            HOADON hd = new HOADON();
            hd.HoaDonID = textBox1.Text;
            hd.NhanVienID = comboBox1.Text;
            hd.BanID = comboBox2.Text;
            hd.TrangThai = comboBox4.Text;
            hd.Giamgia = int.Parse(textBox5.Text.Trim());
            var gg = int.Parse(textBox5.Text.Trim());
            var Tongtien = int.Parse(textBox6.Text.Trim());
            var cong = Tongtien * gg / 100;
            hd.Tongtien = cong;
            hd.NgayTao = dateTimePicker1.Value;
            hoab.Sua(hd);
            MessageBox.Show("Sửa thành công");
            Xoa();
            Xuat();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Xuat();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            Xuat();
            CTHD();
            DanhSachMonAn f = new DanhSachMonAn();
            f.Show();
        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int dong = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[dong].Cells["Hoa_Don_ID"].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[dong].Cells["Nhan_Vien_ID"].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[dong].Cells["Ban_ID"].Value.ToString();
            comboBox4.Text = dataGridView1.Rows[dong].Cells["Trang_Thai"].Value.ToString();
            textBox5.Text = dataGridView1.Rows[dong].Cells["Giam_Gia"].Value.ToString();
            textBox6.Text = dataGridView1.Rows[dong].Cells["Tong_Tien"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[dong].Cells["Ngay_Tao"].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {// replace this with the ID of the bill that has been paid

            var context = new Entities1();
            var bill = context.HOADONs.FirstOrDefault(b => b.HoaDonID == textBox1.Text); // retrieve the bill entity
            if (bill != null)
            {
                bill.TrangThai = "Đã thanh toán"; // mark the bill as paid
                context.SaveChanges(); // save the changes to the database
            }
            PhieuThanhToanHoaDon f = new PhieuThanhToanHoaDon();
            f.Show();

        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            CHITIET_HOADON ct = new CHITIET_HOADON();
            ct.HoaDonID = textBox3.Text;
            ct.monanID = comboBox3.Text;
            var sl = int.Parse(comboBox5.Text.Trim());
            var dg = int.Parse(textBox2.Text.Trim());
            var tong = sl * dg;
            ct.Dongia = tong;

            // Kiểm tra xem món ăn này đã được chọn trước đó chưa dựa trên monanID
            if (danhSachTam.Any(x => x.monanID == ct.monanID))
            {
                MessageBox.Show("Món ăn này đã được chọn.");
                return;
            }

            // Thêm món ăn vào danh sách tạm thời
            danhSachTam.Add(ct);

            // Cập nhật DataGridView hiển thị danh sách các món ăn đã chọn 
            dataGridView2.Columns.Add("HoaDonID", "Hóa Đơn ID");
            dataGridView2.Columns.Add("monanID", "Món Ăn ID");
            dataGridView2.Columns.Add("DonGia", "Đơn Giá"); 
            dataGridView2.Rows.Add(ct.HoaDonID,ct.monanID,ct.Dongia);
            ThemMonAnVaoDanhSachTam();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            CTHD();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = dataGridView2.CurrentRow.Index;
            dataGridView2.Rows[dong].Cells["Hoa_Don_ID"].Value.ToString();
            textBox2.Text = dataGridView2.Rows[dong].Cells["Don_Gia"].Value.ToString();
        }
        public void CTHD()
        {
            try
            {
                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    var context = new Entities1();
                    var result = from c in context.CHITIET_HOADON
                                     //join p in context.HOADONs on c.HoaDonID equals p.HoaDonID
                                     //join q in context.MONANs on p.NhanVienID equals q.NhanVienID
                                 where (c.HoaDonID.IndexOf(textBox3.Text) >= 0)
                                 select new
                                 {
                                     Hoa_Don_ID = c.HoaDonID,
                                     Don_Gia=c.Dongia,

                                 };
                    dataGridView2.DataSource = result.ToList();
                decimal Tong = result.Sum(o => o.Don_Gia.Value);
                textBox6.Text = $"{Tong:#,##0}";
            }
            catch
            {
                dataGridView2.DataSource = null;
            }

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            textBox3.Text = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox6.Text = textBox2.Text;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            CTHD();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        { // 
            CHITIET_HOADON ct = new CHITIET_HOADON();
            ct.HoaDonID = textBox3.Text;
            ct.monanID = comboBox3.Text;
            var sl = int.Parse(comboBox5.Text.Trim());
            var dg = int.Parse(textBox2.Text.Trim());
            var tong = sl * dg;
            ct.Dongia = tong;
            cthd.Them(ct);
            MessageBox.Show("Thêm thành công");
            CTHD();
        }
        int tongTien = 0; // Khởi tạo biến lưu tổng tiền
        private void ThemMonAnVaoDanhSachTam()
        {
            CHITIET_HOADON ct = new CHITIET_HOADON();
            ct.HoaDonID = textBox3.Text;

            // Tạo một đối tượng MONAN mới để lưu thông tin về món ăn được chọn
            MONAN monAn = new MONAN();
            monAn.TenMon = comboBox3.Text;
            // Gán các thuộc tính khác của đối tượng MONAN nếu có
            ct.monanID = monAn.monanID;

            var sl = int.Parse(comboBox5.Text.Trim());
            var dg = int.Parse(textBox2.Text.Trim());
            var tong = sl * dg;
            ct.Dongia = tong;

            // Thêm món ăn vào danh sách tạm thời
            danhSachTam.Add(ct);

            // Cập nhật tổng tiền
            tongTien += tong;

            // Hiển thị tổng tiền
            textBox6.Text = tongTien.ToString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
