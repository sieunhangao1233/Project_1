﻿using System;
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
    public partial class MonAn : Form
    {
        MonAnBUS manb = new MonAnBUS();
        List<MONAN> monan;
        public MonAn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                MONAN ma = new MONAN();
                ma.monanID = txtMamon.Text;
                ma.TenMon = txtTenmon.Text;
                ma.LoaiMon = comboBox2.Text;
                ma.DonGia = int.Parse(txtDonGia.Text.Trim());
                ma.TrangThai = txtTrangThai.Text;
                ma.NhanVienID = comboBox1.Text;
                ma.Ngaytao = dateTimePicker1.Text;
                manb.Add(ma);
                MessageBox.Show("Thêm thành công");
                Xoa();
                Xuat();
            }

        
        }
        public void Xoa()
        {
            txtMamon.Clear();
            txtTenmon.Clear();
            txtDonGia.Clear();
            txtTrangThai.Clear();
        }

        public void Xuat()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var context = new Entities1();
            var result = from c in context.MONANs
                         select new
                         {
                            MaMonAn=c.monanID,
                            TenMon=c.TenMon,
                            LoaiMon=c.LoaiMon,
                            DonGia=c.DonGia,
                            TrangThai=c.TrangThai,
                            NhanVienID=c.NhanVienID,
                            NgayTao=c.Ngaytao,
                         };
            dataGridView1.DataSource = result.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MONAN ma = new MONAN();
            ma.monanID = txtMamon.Text;
            ma.TenMon = txtTenmon.Text;
            ma.LoaiMon = comboBox2.Text;
            ma.DonGia = int.Parse(txtDonGia.Text.Trim());
            ma.TrangThai = txtTrangThai.Text;
            ma.NhanVienID = comboBox1.Text;
            ma.Ngaytao = dateTimePicker1.Text;
            manb.Update(ma);
            MessageBox.Show("Sửa thành công");
            Xoa();
            Xuat();
        }

        private void MonAn_Load(object sender, EventArgs e)
        {
            Xuat();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = dataGridView1.CurrentRow.Index;
            txtMamon.Text = dataGridView1.Rows[dong].Cells["MaMonAn"].Value.ToString();
            txtTenmon.Text = dataGridView1.Rows[dong].Cells["TenMon"].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[dong].Cells["LoaiMon"].Value.ToString();
            txtDonGia.Text = dataGridView1.Rows[dong].Cells["DonGia"].Value.ToString();
            txtTrangThai.Text = dataGridView1.Rows[dong].Cells["TrangThai"].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[dong].Cells["NhanVienID"].Value.ToString();
            dataGridView1.Rows[dong].Cells["NgayTao"].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Xuat();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MONAN ma = new MONAN();
            manb.Delete(ma);
            MessageBox.Show("Xóa thành công");
            Xuat();
        }
       
        private void txtMamon_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
