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
    public partial class TaoPhieuThueFormView : Form
    {
        public TaoPhieuThueFormView()
        {
            IninitializeDGV();
            InitializeComponent();
        }
        public void IninitializeDGV()
        {

            dgvKH.Columns.Add("ID", "MaKhachHang");
            dgvKH.Columns.Add("HoTen", "HoTenKhachHang");
            dgvKH.Columns.Add("DiaChi", "DiaChi");
            dgvKH.Columns.Add("LoaiKH", "LoaiKhachHang");
            dgvKH.Columns.Add("CMND", "CMND");
            var source = new BindingSource();
            source.DataSource = DataUtil.DSKhachHang();
            dgvKH.DataSource = source;
        }
        private void PopulateDGVPhong(List<KhachHang> s)
        {
            var source = new BindingSource();
            source.DataSource = s;
            dgvKH.DataSource = source;
        }
    }
}
