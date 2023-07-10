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
    public partial class NguynLieu : Form
    {
        NguyenLieu_BUS nlieu = new NguyenLieu_BUS();
        List<NGUYENLIEU> nguyenlieu;
        public NguynLieu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NGUYENLIEU nl = new NGUYENLIEU();
            nl.nguyenieuID = textBox1.Text;
            nl.tenNL = textBox2.Text;
            nl.DonGia = textBox3.Text;
            nl.LoaiNL = textBox4.Text;
            nlieu.Add(nl);
            MessageBox.Show("Thêm thành công");
            Xuat();
            Xoa();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NGUYENLIEU nl = new NGUYENLIEU();
            nl.nguyenieuID = textBox1.Text;
            nl.tenNL = textBox2.Text;
            nl.DonGia = textBox3.Text;
            nl.LoaiNL = textBox4.Text;
            nlieu.Update(nl);
            MessageBox.Show("Sửa thành công");
            Xuat();
            Xoa();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NGUYENLIEU nl = new NGUYENLIEU();
            nlieu.Delete(nl);
            MessageBox.Show("Xóa thành công");
            Xuat();
            Xoa();
        }
        public void Xuat()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var context = new Entities1();
            var result = from c in context.NGUYENLIEUx
                         select new
                         {
                          NguyenLieu_ID=c.nguyenieuID,
                          Ten_Nguyen_Lieu=c.tenNL,
                          Don_Gia=c.DonGia,
                          Loai_Nguyen_Lieu=c.LoaiNL,
                         };
            dataGridView1.DataSource = result.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Xuat();
        }
        public void Xoa()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[dong].Cells["NguyenLieu_ID"].Value.ToString();
            textBox2.Text = dataGridView1.Rows[dong].Cells["Ten_Nguyen_Lieu"].Value.ToString();
            textBox3.Text = dataGridView1.Rows[dong].Cells["Don_Gia"].Value.ToString();
            textBox4.Text = dataGridView1.Rows[dong].Cells["Loai_Nguyen_Lieu"].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                var context = new Entities1();
                var result = from c in context.NGUYENLIEUx
                             where (c.nguyenieuID.IndexOf(textBox5.Text) >= 0)
                        select new
                        {
                            NguyenLieu_ID = c.nguyenieuID,
                            Ten_Nguyen_Lieu = c.tenNL,
                            Don_Gia = c.DonGia,
                            Loai_Nguyen_Lieu = c.LoaiNL,
                        };
                dataGridView1.DataSource = result.ToList();
                Xoa();
            }
            else if (radioButton2.Checked)
            {
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                var context = new Entities1();
                var result = from c in context.NGUYENLIEUx
                             where (c.tenNL.IndexOf(textBox5.Text) >= 0)
                        select new
                        {
                            NguyenLieu_ID = c.nguyenieuID,
                            Ten_Nguyen_Lieu = c.tenNL,
                            Don_Gia = c.DonGia,
                            Loai_Nguyen_Lieu = c.LoaiNL,
                        };
                dataGridView1.DataSource = result.ToList();
                Xoa();
            }
            else
                MessageBox.Show("Thông báo", "Vui long nhập lại thông tin!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NguynLieu_Load(object sender, EventArgs e)
        {
            Xuat();        }
    }
}
