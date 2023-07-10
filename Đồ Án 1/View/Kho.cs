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
    public partial class Kho : Form
    {
        KHO_BUS khoB = new KHO_BUS();
        List<KHO> kho;
        public Kho()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Kho_Load(object sender, EventArgs e)
        {
            Hien();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KHO k = new KHO();
            k.KhoID = textBox1.Text;
            k.TenKho = textBox2.Text;
            k.NhanVienID_QL = textBox3.Text;
            k.Trangthai = textBox4.Text;
            khoB.Update(k);
            Hien();
            Xoa();
            MessageBox.Show("Sửa thành công");
        }
        public void Hien()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var context = new Entities1();
            var result = from c in context.KHOes
                         select new
                         {
                             Kho_ID=c.KhoID,
                             Ten_Kho=c.TenKho,
                             Nhan_Vien_QL=c.NhanVienID_QL,
                             Trang_Thai=c.Trangthai,
                         };
            dataGridView1.DataSource = result.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KHO k = new KHO();
            khoB.Delete(k);
            MessageBox.Show("Xóa thành công");
            Hien();
            Xoa();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KHO k = new KHO();
            k.KhoID = textBox1.Text;
            k.TenKho = textBox2.Text;
            k.NhanVienID_QL = textBox3.Text;
            k.Trangthai = textBox4.Text;
            khoB.Add(k);
            Hien();
            Xoa();
            MessageBox.Show("Sửa thành công");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hien();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int dong = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[dong].Cells["Kho_ID"].Value.ToString();
            textBox2.Text = dataGridView1.Rows[dong].Cells["Ten_Kho"].Value.ToString();
            textBox3.Text = dataGridView1.Rows[dong].Cells["Nhan_Vien_QL"].Value.ToString();
            textBox4.Text = dataGridView1.Rows[dong].Cells["Trang_Thai"].Value.ToString();
        }
        public void Xoa()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                List<KHO> data;
                data = khoB.GetKHOs(textBox5.Text);
                dataGridView1.DataSource = data;
            }
            catch
            {
                dataGridView1.DataSource = null;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenQuanlychucnang(new CTkho());
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
    }
}

