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
using Đồ_Án_1.Dao;
using Đồ_Án_1.Data;
namespace Đồ_Án_1.View
{
    public partial class ThongKEhoaDon : Form
    {
        HoaDon_BUS hoadonb = new HoaDon_BUS();
        public ThongKEhoaDon()
        {
            InitializeComponent();
        }

        private void ThongKEhoaDon_Load(object sender, EventArgs e)
        {

        }

        private void tsThongKe_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePicker1.Value.Date;
            DateTime endDate = dateTimePicker2.Value.Date.AddDays(1).AddTicks(-1);

            var orders =hoadonb.GetList().Where(o => o.NgayTao >= startDate && o.NgayTao <= endDate).ToList();
            dataGridView1.DataSource = orders;

            decimal totalAmount = orders.Sum(o => o.Tongtien.Value);
            textBox1.Text = $"{totalAmount:#,##0}";
        }

        private void tsLamMoi_Click(object sender, EventArgs e)
        {
            
        }

        private void tsThoat_Click(object sender, EventArgs e)
        {
            DialogResult q = MessageBox.Show("Bạn Có Muốn Thoát Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (q.Equals(DialogResult.Yes))
            {
                this.Close();
            }
        }
        
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Xuat();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows[dong].Cells["Hoa_Don_ID"].Value.ToString();
            dataGridView1.Rows[dong].Cells["Nhan_Vien_ID"].Value.ToString();
            dataGridView1.Rows[dong].Cells["Ban_ID"].Value.ToString();
            dataGridView1.Rows[dong].Cells["Trang_Thai"].Value.ToString();
            dataGridView1.Rows[dong].Cells["Giam_Gia"].Value.ToString();
            dataGridView1.Rows[dong].Cells["Tong_Tien"].Value.ToString();
            dataGridView1.Rows[dong].Cells["Ngay_Tao"].Value.ToString();
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
                             Ngay_Tao=c.NgayTao,
                         };
            dataGridView1.DataSource = result.ToList();
        }
    }
}
