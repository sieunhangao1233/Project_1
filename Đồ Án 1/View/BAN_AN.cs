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
    public partial class BAN_AN : Form
    {
        BAN_BUS banb = new BAN_BUS();
        public BAN_AN()
        {
            InitializeComponent();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text != "" && comboBox2.Text != null && comboBox3.Text != null && comboBox4.Text != null && comboBox1.Text != null)
            {
                BAN b = new BAN();
                b.BanID = comboBox2.Text;
                b.LoaiBan = comboBox3.Text;
                b.Tinhtrang = comboBox4.Text;
                b.SoLuong = int.Parse(comboBox1.Text.Trim());
                banb.Add(b);
                // Lưu thông tin đặt bàn vào cơ sở dữ liệu ở đây
                Xuat();
                MessageBox.Show("Đặt bàn thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
        }
        public void Xuat()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var context = new Entities1();
            var result = from c in context.BANs
                         select new
                         {
                             Ban_ID = c.BanID,
                             Loai_Ban = c.LoaiBan,
                             Tinh_Trang = c.Tinhtrang,
                             So_Luong = c.SoLuong,
                         };
            dataGridView1.DataSource = result.ToList();
        }

        private void btShow_Click(object sender, EventArgs e)
        {
            Xuat();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = dataGridView1.CurrentRow.Index;
            comboBox2.Text = dataGridView1.Rows[dong].Cells["Ban_ID"].Value.ToString();
            comboBox3.Text = dataGridView1.Rows[dong].Cells["Loai_Ban"].Value.ToString();
            comboBox4.Text = dataGridView1.Rows[dong].Cells["Tinh_Trang"].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[dong].Cells["So_Luong"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text != "" && comboBox2.Text != null && comboBox3.Text != null && comboBox4.Text != null && comboBox1.Text != null)
            {
                BAN b = new BAN();
                b.BanID = comboBox2.Text;
                b.LoaiBan = comboBox3.Text;
                b.Tinhtrang = comboBox4.Text;
                b.SoLuong = int.Parse(comboBox1.Text.Trim());
                banb.Update(b);
                // Lưu thông tin đặt bàn vào cơ sở dữ liệu ở đây
                Xuat();
                MessageBox.Show("Sửa bàn thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            banb.Delete(comboBox2.Text);
            Xuat();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                var context = new Entities1();
                var result = from c in context.BANs
                             where (c.BanID.IndexOf(comboBox2.Text) >= 0)
                             select new
                             {
                                 Ban_ID = c.BanID,
                                 Loai_Ban = c.LoaiBan,
                                 Tinh_Trang = c.Tinhtrang,
                                 So_Luong = c.SoLuong,
                             };
                dataGridView1.DataSource = result.ToList();
            }
            catch
            {
                dataGridView1.DataSource = null;
            }
        }
    }
}
