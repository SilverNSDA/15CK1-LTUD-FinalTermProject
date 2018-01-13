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
            dgvKH.Columns[0].Name = "ID";
            dgvKH.Columns[1].Name = "HoTen";
            dgvKH.Columns[2].Name = "DiaChi";
            dgvKH.Columns[3].Name = "LoaiKH";
            dgvKH.Columns[4].Name = "CMND";
            xuat();
            InitializeComponent();
        }
        public void xuat()
        {
            DataGridViewRow row = dgvKH.CurrentRow;
            var kh = DataUtil.DSKhachHang();
            foreach (var khh in kh)
            {
                row.Cells["ID"].Value = khh.ID;
                row.Cells["HoTen"].Value = khh.HoTen;
                row.Cells["DiaChi"].Value = khh.DiaChi;
                row.Cells["LoaiKH"].Value = khh.LoaiKhachHang;
                row.Cells["CMND"].Value = khh.CMND;
            }
        }
    }
}
