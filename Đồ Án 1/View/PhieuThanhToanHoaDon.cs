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
using COMExcel = Microsoft.Office.Interop.Excel;
namespace Đồ_Án_1.View
{
    public partial class PhieuThanhToanHoaDon : Form
    {
        public PhieuThanhToanHoaDon()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                var context = new Entities1();
                var result = from c in context.HOADONs
                             join p in context.MONANs on c.NhanVienID equals p.NhanVienID
                             join d in context.BANs on c.BanID equals d.BanID
                             where (d.BanID.IndexOf(textBox1.Text) >= 0)
                             select new
                             {
                                 Hoa_Don_ID = c.HoaDonID,
                                 Ten_Mon = p.TenMon,
                                 Trang_Thai=c.TrangThai,
                                 Don_Gia = p.DonGia,
                                 Tong_Tien = c.Tongtien,
                                 Ten_Ban = d.BanID
                             };
                dataGridView1.DataSource = result.ToList();
                decimal Tong =result.Sum(o => o.Tong_Tien.Value);
                textBox2.Text = $"{Tong:#,##0}";
            }
            catch
            {
                dataGridView1.DataSource = null;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows[dong].Cells["Hoa_Don_ID"].Value.ToString();
            dataGridView1.Rows[dong].Cells["Ten_Mon"].Value.ToString();
            dataGridView1.Rows[dong].Cells["Trang_Thai"].Value.ToString();
            dataGridView1.Rows[dong].Cells["Don_Gia"].Value.ToString();
            textBox2.Text=dataGridView1.Rows[dong].Cells["Tong_Tien"].Value.ToString();
            dataGridView1.Rows[dong].Cells["Ten_Ban"].Value.ToString();
        }
        public void Xuat()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var context = new Entities1();
            var result = from c in context.HOADONs
             join p in context.MONANs on c.NhanVienID equals p.NhanVienID
             join d in context.BANs on c.BanID equals d.BanID
             select new
             {
                 Hoa_Don_ID = c.HoaDonID,
                 Ten_Mon = p.TenMon,
                 Don_Gia = p.DonGia,
                 Tong_Tien = c.Tongtien,
                 Ten_Ban = d.BanID
             };

            dataGridView1.DataSource = result.ToList();
        }
        private void PhieuThanhToanHoaDon_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (float.TryParse(comboBox1.Text.Trim(), out float kh) && float.TryParse(textBox2.Text.Trim(), out float tt))
            {
                float Tong = kh - tt;
                textBox5.Text = Tong.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập giá trị số hợp lệ.");
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;

            int hang = 0, cot = 0;

            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Quản lý quán ăn lẩu, nướng Kadan";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Nhân Hoà - Mỹ Hào  - Hưng Yên";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: (03)389337710";
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN ";
            // Biểu diễn thông tin chung của hóa đơn bán

            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = textBox1.Text;
            exRange.Range["B7:B7"].Value = "Tổng tiền:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = textBox2.Text;
            exRange.Range["B8:B8"].Value = "Khách hàng:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = comboBox1.Text;
            exRange.Range["B9:B9"].Value = "Tiền thừa:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = textBox5.Text;
            exRange.Range["B10:B10"].Value = "Nhân viên:";
            exRange.Range["E10"].MergeCells = true;
            exRange.Range["E10"].Value = textBox3.Text;

            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:G11"].Font.Bold = true;
            exRange.Range["A11:G11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:G11"].ColumnWidth = 12;
            exRange.Range["C5"].Value = "Mã hóa đơn";
            exRange.Range["E5"].Value = "Đơn giá";
            exApp.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
