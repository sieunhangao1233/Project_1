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
    public partial class Nhân_Viên : Form
    {
        NhanVienBUS nvb = new NhanVienBUS();
        List<NHANVIEN> nhanvien;
        public Nhân_Viên()
        {
            InitializeComponent();
        }

        private void Nhân_Viên_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NHANVIEN nv = new NHANVIEN();
            nv.NhanVienID = txtID.Text;
            nv.Hoten = txtName.Text;
            nv.Gioitinh = comboBox1.Text;
            nv.Chucvu = txtPos.Text;
            nv.Quequan = txtHome.Text;
            nv.Sdt = txtPhon.Text;
            nv.CCCD = txtCiti.Text;
            nv.NgayLam = dateTimePicker1.Text;
            nvb.Add(nv);
            MessageBox.Show("Thêm thành công");
            Xuat();
            Xoa();
        }
        private void Nhân_Viên_Load(object sender, EventArgs e)
        {
            Xuat();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = dataGridView1.CurrentRow.Index;
            txtID.Text = dataGridView1.Rows[dong].Cells["NhanVienID"].Value.ToString();
            txtName.Text = dataGridView1.Rows[dong].Cells["Hoten"].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[dong].Cells["Gioitinh"].Value.ToString();
            txtPos.Text = dataGridView1.Rows[dong].Cells["Chucvu"].Value.ToString();
            txtHome.Text = dataGridView1.Rows[dong].Cells["Quequan"].Value.ToString();
            txtPhon.Text = dataGridView1.Rows[dong].Cells["Sdt"].Value.ToString();
            txtCiti.Text = dataGridView1.Rows[dong].Cells["CCCD"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[dong].Cells["NgayLam"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NHANVIEN nv = new NHANVIEN();
            nv.NhanVienID = txtID.Text;
            nv.Hoten = txtName.Text;
            nv.Gioitinh = comboBox1.Text;
            nv.Chucvu = txtPos.Text;
            nv.Quequan = txtHome.Text;
            nv.Sdt = txtPhon.Text;
            nv.CCCD = txtCiti.Text;
            nv.NgayLam = dateTimePicker1.Text;
            nvb.Update(nv);
            MessageBox.Show("Sửa thành công");
            Xuat();
            Xoa();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên " + txtName.Text + " ?", "Xóa nhân viên", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                nvb.Detele(txtID.Text);
                Xuat();
            };
        }
        public void Xuat()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var context = new Entities1();
            var result = from c in context.NHANVIENs
                         select new
                         {
                             NhanVienID = c.NhanVienID,
                             Hoten = c.Hoten,
                             GioiTinh = c.Gioitinh,
                             ChucVu = c.Chucvu,
                             QueQuan = c.Quequan,
                             SDT = c.Sdt,
                             CCCD = c.CCCD,
                             NgayLam = c.NgayLam,
                         };
            dataGridView1.DataSource = result.ToList();
        }

        private void btShow_Click(object sender, EventArgs e)
        {
            Xuat();
        }
        public void Xoa()
        {
            txtID.Clear();
            txtName.Clear();
            txtPos.Clear();
            txtHome.Clear();
            txtPhon.Clear();
            txtCiti.Clear();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                var context = new Entities1();
                var result = from c in context.NHANVIENs
                             where (c.NhanVienID.IndexOf(txtSeaech.Text) >= 0)
                             select new
                             {
                                 NhanVienID = c.NhanVienID,
                                 Hoten = c.Hoten,
                                 GioiTinh = c.Gioitinh,
                                 ChucVu = c.Chucvu,
                                 QueQuan = c.Quequan,
                                 SDT = c.Sdt,
                                 CCCD = c.CCCD,
                                 NgayLam = c.NgayLam,
                             };
                dataGridView1.DataSource = result.ToList();
                Xoa();
            }
            catch
            {
                dataGridView1.DataSource = null;
            }
        }
    }
}
