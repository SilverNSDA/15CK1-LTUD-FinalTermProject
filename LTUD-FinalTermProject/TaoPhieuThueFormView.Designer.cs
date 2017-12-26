namespace LTUD_FinalTermProject
{
    partial class TaoPhieuThueFormView
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMaPhong = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnXoaKH = new System.Windows.Forms.Button();
            this.ThemKH = new System.Windows.Forms.Button();
            this.btnTao = new System.Windows.Forms.Button();
            this.btnHuyTao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnHuyTao);
            this.splitContainer1.Panel2.Controls.Add(this.btnTao);
            this.splitContainer1.Panel2.Controls.Add(this.ThemKH);
            this.splitContainer1.Panel2.Controls.Add(this.btnXoaKH);
            this.splitContainer1.Panel2.Controls.Add(this.listBox1);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Size = new System.Drawing.Size(506, 360);
            this.splitContainer1.SplitterDistance = 129;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTinhTrang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbMaPhong);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TẠO PHIẾU THUÊ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phòng:";
            // 
            // cbMaPhong
            // 
            this.cbMaPhong.FormattingEnabled = true;
            this.cbMaPhong.Location = new System.Drawing.Point(82, 42);
            this.cbMaPhong.Name = "cbMaPhong";
            this.cbMaPhong.Size = new System.Drawing.Size(121, 21);
            this.cbMaPhong.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tình trạng phòng:";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(367, 42);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(100, 20);
            this.txtTinhTrang.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Khách hàng:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(65, 39);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(384, 95);
            this.listBox1.TabIndex = 5;
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.Location = new System.Drawing.Point(136, 140);
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.Size = new System.Drawing.Size(107, 23);
            this.btnXoaKH.TabIndex = 6;
            this.btnXoaKH.Text = "Xoá khách hàng";
            this.btnXoaKH.UseVisualStyleBackColor = true;
            // 
            // ThemKH
            // 
            this.ThemKH.Location = new System.Drawing.Point(258, 140);
            this.ThemKH.Name = "ThemKH";
            this.ThemKH.Size = new System.Drawing.Size(107, 23);
            this.ThemKH.TabIndex = 7;
            this.ThemKH.Text = "Thêm khách hàng";
            this.ThemKH.UseVisualStyleBackColor = true;
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(329, 187);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(75, 23);
            this.btnTao.TabIndex = 8;
            this.btnTao.Text = "Tạo";
            this.btnTao.UseVisualStyleBackColor = true;
            // 
            // btnHuyTao
            // 
            this.btnHuyTao.Location = new System.Drawing.Point(413, 187);
            this.btnHuyTao.Name = "btnHuyTao";
            this.btnHuyTao.Size = new System.Drawing.Size(75, 23);
            this.btnHuyTao.TabIndex = 9;
            this.btnHuyTao.Text = "Huỷ";
            this.btnHuyTao.UseVisualStyleBackColor = true;
            // 
            // TaoPhieuThueFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 360);
            this.Controls.Add(this.splitContainer1);
            this.Name = "TaoPhieuThueFormView";
            this.Text = "TaoPhieuThueFormView";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMaPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.Button btnHuyTao;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Button ThemKH;
        private System.Windows.Forms.Button btnXoaKH;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
    }
}