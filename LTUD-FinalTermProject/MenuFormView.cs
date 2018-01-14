using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTUD_FinalTermProject
{
    public partial class MenuFormView : Form
    {
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;

        public MenuFormView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnDanhMucPhong = new System.Windows.Forms.Button();
            this.btnPhieuThuePhong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh mục phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phiếu thuê phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Khách hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Báo cáo";
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Location = new System.Drawing.Point(289, 35);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(75, 23);
            this.btnKhachHang.TabIndex = 5;
            this.btnKhachHang.Text = "button1";
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(156, 121);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(75, 23);
            this.btnBaoCao.TabIndex = 6;
            this.btnBaoCao.Text = "button2";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnDanhMucPhong
            // 
            this.btnDanhMucPhong.Location = new System.Drawing.Point(15, 35);
            this.btnDanhMucPhong.Name = "btnDanhMucPhong";
            this.btnDanhMucPhong.Size = new System.Drawing.Size(75, 23);
            this.btnDanhMucPhong.TabIndex = 7;
            this.btnDanhMucPhong.Text = "button3";
            this.btnDanhMucPhong.UseVisualStyleBackColor = true;
            this.btnDanhMucPhong.Click += new System.EventHandler(this.btnDanhMucPhong_Click);
            // 
            // btnPhieuThuePhong
            // 
            this.btnPhieuThuePhong.Location = new System.Drawing.Point(156, 35);
            this.btnPhieuThuePhong.Name = "btnPhieuThuePhong";
            this.btnPhieuThuePhong.Size = new System.Drawing.Size(75, 23);
            this.btnPhieuThuePhong.TabIndex = 8;
            this.btnPhieuThuePhong.Text = "button4";
            this.btnPhieuThuePhong.UseVisualStyleBackColor = true;
            this.btnPhieuThuePhong.Click += new System.EventHandler(this.btnPhieuThuePhong_Click);
            // 
            // MenuFormView
            // 
            this.ClientSize = new System.Drawing.Size(387, 261);
            this.Controls.Add(this.btnPhieuThuePhong);
            this.Controls.Add(this.btnDanhMucPhong);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.btnKhachHang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "MenuFormView";
            this.Text = "Quản lý khách sạn - Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            BaoCaoFormView baocao = new BaoCaoFormView();
            baocao.Show();

        }

        private void btnDanhMucPhong_Click(object sender, EventArgs e)
        {
            DanhMucPhongFormView danhmucphong = new DanhMucPhongFormView();
            danhmucphong.Show();
        }

        private void btnPhieuThuePhong_Click(object sender, EventArgs e)
        {
            PhieuThueFormView phieuthuephong = new PhieuThueFormView();
            phieuthuephong.Show();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            KhachHangFormView khachhang = new KhachHangFormView();
            khachhang.Show();
        }
    }
}
