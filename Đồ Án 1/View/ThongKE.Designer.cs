
namespace Đồ_Án_1.View
{
    partial class ThongKE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKE));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbThongKesp = new System.Windows.Forms.Label();
            this.groupBoxdanhsach = new System.Windows.Forms.GroupBox();
            this.groupBoxthongkesp = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsThongKe = new System.Windows.Forms.ToolStripButton();
            this.tsLamMoi = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsThoat = new System.Windows.Forms.ToolStripButton();
            this.cbKieuThongKe = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxdanhsach.SuspendLayout();
            this.groupBoxthongkesp.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(2, 5);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.splitContainer1.Panel1.Controls.Add(this.lbThongKesp);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxdanhsach);
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxthongkesp);
            this.splitContainer1.Size = new System.Drawing.Size(1088, 522);
            this.splitContainer1.SplitterDistance = 73;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 2;
            // 
            // lbThongKesp
            // 
            this.lbThongKesp.AutoSize = true;
            this.lbThongKesp.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongKesp.Location = new System.Drawing.Point(341, 16);
            this.lbThongKesp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbThongKesp.Name = "lbThongKesp";
            this.lbThongKesp.Size = new System.Drawing.Size(307, 36);
            this.lbThongKesp.TabIndex = 0;
            this.lbThongKesp.Text = "THỐNG KÊ MÓN ĂN";
            // 
            // groupBoxdanhsach
            // 
            this.groupBoxdanhsach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBoxdanhsach.Controls.Add(this.dataGridView1);
            this.groupBoxdanhsach.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxdanhsach.Location = new System.Drawing.Point(0, 138);
            this.groupBoxdanhsach.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxdanhsach.Name = "groupBoxdanhsach";
            this.groupBoxdanhsach.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxdanhsach.Size = new System.Drawing.Size(1088, 305);
            this.groupBoxdanhsach.TabIndex = 1;
            this.groupBoxdanhsach.TabStop = false;
            this.groupBoxdanhsach.Text = "Danh sách";
            // 
            // groupBoxthongkesp
            // 
            this.groupBoxthongkesp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBoxthongkesp.Controls.Add(this.toolStrip1);
            this.groupBoxthongkesp.Controls.Add(this.cbKieuThongKe);
            this.groupBoxthongkesp.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxthongkesp.Location = new System.Drawing.Point(0, 10);
            this.groupBoxthongkesp.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxthongkesp.Name = "groupBoxthongkesp";
            this.groupBoxthongkesp.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxthongkesp.Size = new System.Drawing.Size(1088, 118);
            this.groupBoxthongkesp.TabIndex = 0;
            this.groupBoxthongkesp.TabStop = false;
            this.groupBoxthongkesp.Text = "Thống kê";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsThongKe,
            this.tsLamMoi,
            this.toolStripButton1,
            this.tsThoat});
            this.toolStrip1.Location = new System.Drawing.Point(4, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1080, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsThongKe
            // 
            this.tsThongKe.Image = ((System.Drawing.Image)(resources.GetObject("tsThongKe.Image")));
            this.tsThongKe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsThongKe.Name = "tsThongKe";
            this.tsThongKe.Size = new System.Drawing.Size(94, 25);
            this.tsThongKe.Text = "Thống kê";
            this.tsThongKe.Click += new System.EventHandler(this.tsThongKe_Click);
            // 
            // tsLamMoi
            // 
            this.tsLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("tsLamMoi.Image")));
            this.tsLamMoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLamMoi.Name = "tsLamMoi";
            this.tsLamMoi.Size = new System.Drawing.Size(91, 28);
            this.tsLamMoi.Text = "Làm mới";
            this.tsLamMoi.Click += new System.EventHandler(this.tsLamMoi_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(81, 28);
            this.toolStripButton1.Text = "Trở lại";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsThoat
            // 
            this.tsThoat.Image = ((System.Drawing.Image)(resources.GetObject("tsThoat.Image")));
            this.tsThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsThoat.Name = "tsThoat";
            this.tsThoat.Size = new System.Drawing.Size(71, 28);
            this.tsThoat.Text = "Thoát";
            this.tsThoat.Click += new System.EventHandler(this.tsThoat_Click);
            // 
            // cbKieuThongKe
            // 
            this.cbKieuThongKe.FormattingEnabled = true;
            this.cbKieuThongKe.Items.AddRange(new object[] {
            "Thống kê tất cả món ăn",
            "Thống kê món ăn còn",
            "Thống kê món ăn hết"});
            this.cbKieuThongKe.Location = new System.Drawing.Point(21, 69);
            this.cbKieuThongKe.Margin = new System.Windows.Forms.Padding(4);
            this.cbKieuThongKe.Name = "cbKieuThongKe";
            this.cbKieuThongKe.Size = new System.Drawing.Size(351, 27);
            this.cbKieuThongKe.TabIndex = 1;
            this.cbKieuThongKe.Tag = "";
            this.cbKieuThongKe.Text = "Chọn kiểu thống kê";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1069, 271);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ThongKE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 533);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ThongKE";
            this.Text = "ThongKE";
            this.Load += new System.EventHandler(this.ThongKE_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxdanhsach.ResumeLayout(false);
            this.groupBoxthongkesp.ResumeLayout(false);
            this.groupBoxthongkesp.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lbThongKesp;
        private System.Windows.Forms.GroupBox groupBoxdanhsach;
        private System.Windows.Forms.GroupBox groupBoxthongkesp;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsThongKe;
        private System.Windows.Forms.ToolStripButton tsLamMoi;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton tsThoat;
        private System.Windows.Forms.ComboBox cbKieuThongKe;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}