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
    public partial class DanhSachMonAn : Form
    {
        public DanhSachMonAn()
        {
            InitializeComponent();
        }
        MonAnBUS manb = new MonAnBUS();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows[dong].Cells["MaMonAn"].Value.ToString();
            dataGridView1.Rows[dong].Cells["TenMon"].Value.ToString();
            dataGridView1.Rows[dong].Cells["DonGia"].Value.ToString();
            dataGridView1.Rows[dong].Cells["TrangThai"].Value.ToString();
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
                             DonGia = c.DonGia,
                             TrangThai = c.TrangThai,
                         };
            dataGridView1.DataSource = result.ToList();
        }

        private void DanhSachMonAn_Load(object sender, EventArgs e)
        {
            Xuat();
        }
    }
}
