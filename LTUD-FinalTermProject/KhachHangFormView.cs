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
    public partial class KhachHangFormView : Form
    {
        public KhachHangFormView()
        {
            InitializeComponent();
            IninitializeDGV();


        }
        public void IninitializeDGV()
        {

            dgvKhachHang.Columns.Add("ID", "MaKhachHang");
            dgvKhachHang.Columns.Add("HoTen", "HoTenKhachHang");
            dgvKhachHang.Columns.Add("DiaChi", "DiaChi");
            dgvKhachHang.Columns.Add("LoaiKH", "LoaiKhachHang");
            dgvKhachHang.Columns.Add("CMND", "CMND");
            var source = new BindingSource();
            source.DataSource = DataUtil.DSKhachHang();
            dgvKhachHang.DataSource = source;
        }
        private void PopulateDGVPhong(List<KhachHang> s)
        {
            var source = new BindingSource();
            source.DataSource = s;
            dgvKhachHang.DataSource = source;
        }

        private void buttonThemKH_Click(object sender, EventArgs e)
        {

        }
    }
}
