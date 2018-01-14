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
    public partial class TaoKhachHangFormView : Form
    {
        public TaoKhachHangFormView()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var thongbao = MessageBox.Show("Dữ liệu bạn chưa lưu.", "Bạn có muốn thoát không?", MessageBoxButtons.YesNo);
            if(thongbao == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            var rnd = new Random();

            KhachHang kh = new KhachHang();
            kh.HoTen = txtHoTen.Text;
            kh.LoaiKhachHang = cbLoaiKH.SelectedValue.ToString();
            kh.CMND = txtCMND.Text;
            kh.DiaChi = txtDiaChi.Text;

            do
            {
                kh.ID = rnd.Next().ToString();
            } while (checkKhachHang(kh.ID) == true);

            DataUtil.ThemKhachHang(kh);
        }

        private bool checkKhachHang(string id)
        {
            var dt = DataUtil.DSKhachHang();
            foreach(var kh in dt)
            {
                if(id == kh.ID)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
