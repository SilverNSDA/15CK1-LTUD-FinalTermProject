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
    public partial class DanhMucPhongFormView : Form
    {
        public DanhMucPhongFormView()
        {
            InitializeComponent();
            dgvDanhMucPhong.Columns[0].Name = "ID";
            dgvDanhMucPhong.Columns[0].Name = "LoaiPhong";
            dgvDanhMucPhong.Columns[0].Name = "GhiChu";
            xuat();
        }
        public void xuat()
        {
            DataGridViewRow row = dgvDanhMucPhong.CurrentRow;
            var lp = DataUtil.DSPhong();
            foreach (var khh in lp)
            {
                row.Cells["ID"].Value = khh.ID;
                row.Cells["LoaiPhong"].Value = khh.LoaiPhong;
                row.Cells["GhiChu"].Value = khh.GhiChu;
            }
        }
    }
}
