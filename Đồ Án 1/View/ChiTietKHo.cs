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
    public partial class CTkho : Form
    {
        CHITIETKHo_NL_BUS bu = new CHITIETKHo_NL_BUS();
        public CTkho()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KHO_NL kl = new KHO_NL();
            kl.KhoID = textBox1.Text;
            kl.nguyenlieuID = textBox2.Text;
            kl.SoLuong = int.Parse(textBox3.Text.Trim());
            kl.GhiChu = textBox4.Text;
            bu.Add(kl);
            MessageBox.Show("Thêm thành công");
            Xuat();
            Xoa();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KHO_NL kl = new KHO_NL();
            bu.Delete(kl);
            MessageBox.Show("Xóa thành công");
            Xuat();
        }
        public void Xuat()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var context = new Entities1();
            var result = from c in context.KHO_NL
                         select new
                         {
                             KHO_ID=c.KhoID,
                             Nguyen_Lieu_ID=c.nguyenlieuID,
                             So_Luong=c.SoLuong,
                             Ghi_Chu=c.GhiChu,
                         };
            dataGridView1.DataSource = result.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KHO_NL kl = new KHO_NL();
            kl.KhoID = textBox1.Text;
            kl.nguyenlieuID = textBox2.Text;
            kl.SoLuong = int.Parse(textBox3.Text.Trim());
            kl.GhiChu = textBox4.Text;
            bu.Updete(kl);
            MessageBox.Show("Thêm thành công");
            Xuat();
            Xoa();
        }
        public void Xoa()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[dong].Cells["KHO_ID"].Value.ToString();
            textBox2.Text = dataGridView1.Rows[dong].Cells["Nguyen_Lieu_ID"].Value.ToString();
            textBox3.Text = dataGridView1.Rows[dong].Cells["So_Luong"].Value.ToString();
            textBox4.Text = dataGridView1.Rows[dong].Cells["Ghi_Chu"].Value.ToString();
        }
    }
}
