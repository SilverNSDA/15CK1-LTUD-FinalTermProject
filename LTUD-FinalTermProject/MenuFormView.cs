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

        public MenuFormView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnDanhMucPhong = new System.Windows.Forms.Button();
            this.btnPhieuThuePhong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Location = new System.Drawing.Point(77, 116);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(169, 23);
            this.btnKhachHang.TabIndex = 5;
            this.btnKhachHang.Text = "Khách hàng";
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(77, 145);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(169, 23);
            this.btnBaoCao.TabIndex = 6;
            this.btnBaoCao.Text = "Báo cáo";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnDanhMucPhong
            // 
            this.btnDanhMucPhong.Location = new System.Drawing.Point(77, 55);
            this.btnDanhMucPhong.Name = "btnDanhMucPhong";
            this.btnDanhMucPhong.Size = new System.Drawing.Size(169, 23);
            this.btnDanhMucPhong.TabIndex = 7;
            this.btnDanhMucPhong.Text = "Danh mục phòng";
            this.btnDanhMucPhong.UseVisualStyleBackColor = true;
            this.btnDanhMucPhong.Click += new System.EventHandler(this.btnDanhMucPhong_Click);
            // 
            // btnPhieuThuePhong
            // 
            this.btnPhieuThuePhong.Location = new System.Drawing.Point(77, 84);
            this.btnPhieuThuePhong.Name = "btnPhieuThuePhong";
            this.btnPhieuThuePhong.Size = new System.Drawing.Size(169, 23);
            this.btnPhieuThuePhong.TabIndex = 8;
            this.btnPhieuThuePhong.Text = "Phiếu thuê phòng";
            this.btnPhieuThuePhong.UseVisualStyleBackColor = true;
            this.btnPhieuThuePhong.Click += new System.EventHandler(this.btnPhieuThuePhong_Click);
            // 
            // MenuFormView
            // 
            this.ClientSize = new System.Drawing.Size(324, 194);
            this.Controls.Add(this.btnPhieuThuePhong);
            this.Controls.Add(this.btnDanhMucPhong);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.btnKhachHang);
            this.Name = "MenuFormView";
            this.Text = "Quản lý khách sạn - Menu";
            this.ResumeLayout(false);

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
