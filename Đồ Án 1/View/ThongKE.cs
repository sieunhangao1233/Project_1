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
using Đồ_Án_1.Dao;
namespace Đồ_Án_1.View
{
    public partial class ThongKE : Form
    {
        MonAnBUS monanb = new MonAnBUS();
        MonAnDAO monand = new MonAnDAO();
        public ThongKE()
        {
            InitializeComponent();
        }

        private void tsThoat_Click(object sender, EventArgs e)
        {
            DialogResult q = MessageBox.Show("Bạn Có Muốn Thoát Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (q.Equals(DialogResult.Yes))
            {
                this.Close();
            }
        }
        //Thống kê món ăn
//Thống kê số lượng món ăn
//Thống kê số lượng món ăn sắp hết

        private void tsThongKe_Click(object sender, EventArgs e)
        {
            if (cbKieuThongKe.Text == "Thống kê tất cả món ăn")
            {
                ShowMatHang(1);
                return;
            }

            else if (cbKieuThongKe.Text == "Thống kê món ăn còn")
            {
                ShowMatHang(0);
                return;
            }
            else if (cbKieuThongKe.Text == "Thống kê món ăn hết")
            {
                ShowMatHang(2);
                return;
            }
            else
                MessageBox.Show("Bạn phải nhập kiêu thống kê");
        }

        private void tsLamMoi_Click(object sender, EventArgs e)
        {
            cbKieuThongKe.Text = "";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ThongKE_Load(sender, e);
        }

        private void ThongKE_Load(object sender, EventArgs e)
        {


        }
        private void ShowMatHang(int dieukien)
        {
            var sp = monanb.GetList().OrderBy(x => x.monanID);
            if (dieukien == 0)
            {
                var resuilt = sp.Where(x => x.TrangThai== "Còn");
                dataGridView1.DataSource = resuilt.ToList();
                return;
            }
            if (dieukien == 1)
            {
                Xuat();
            }
            if(dieukien == 2)
            {
                dataGridView1.DataSource = sp.Where(x => x.TrangThai =="Het").ToList();
            }

        }
        public void Xuat()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var context = new Entities1();
            var result = from c in context.MONANs
                         select new
                         {
                             MaMonAn = c.monanID,
                             TenMon = c.TenMon,
                             LoaiMon = c.LoaiMon,
                             DonGia = c.DonGia,
                             TrangThai = c.TrangThai,
                             NhanVienID = c.NhanVienID,
                             NgayTao = c.Ngaytao,
                         };
            dataGridView1.DataSource = result.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows[dong].Cells["MaMonAn"].Value.ToString();
            dataGridView1.Rows[dong].Cells["TenMon"].Value.ToString();
            dataGridView1.Rows[dong].Cells["LoaiMon"].Value.ToString();
            dataGridView1.Rows[dong].Cells["DonGia"].Value.ToString();
            dataGridView1.Rows[dong].Cells["TrangThai"].Value.ToString();
            dataGridView1.Rows[dong].Cells["NhanVienID"].Value.ToString();
            dataGridView1.Rows[dong].Cells["NgayTao"].Value.ToString();
        }
    }
}
