using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_Án_1.View
{
    public partial class THONGKEQUAN : Form
    {
        public THONGKEQUAN()
        {
            InitializeComponent();
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
            panel1.Controls.Add(qlchucnang);
            panel1.Tag = qlchucnang;
            qlchucnang.BringToFront();
            qlchucnang.Show();
        }

        private void thốngKêMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenQuanlychucnang(new ThongKE());
        }

        private void thốngKêHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenQuanlychucnang(new ThongKEhoaDon());
        }
    }
}
