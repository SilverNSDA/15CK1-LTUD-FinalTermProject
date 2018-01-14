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
    public partial class PhieuThueFormView : Form
    {
        public PhieuThueFormView()
        {


            IninitializeDGV();
            InitializeComponent();
        }
        public void IninitializeDGV()
        {

            dgvCTPhieuThue.Columns.Add("ID", "ID");
            dgvCTPhieuThue.Columns.Add("MaPhieuThue", "MaPhieuThue");
            dgvCTPhieuThue.Columns.Add("MaKhachHang", "MaKhachHang");
            var source = new BindingSource();
            source.DataSource = DataUtil.DSCT_PhieuThue();
            dgvCTPhieuThue.DataSource = source;



            dgvPhieuThue.Columns.Add("ID", "ID");
            dgvPhieuThue.Columns.Add("MaPhong", "MaPhong");
            dgvPhieuThue.Columns.Add("NgayBatDau", "NgayBatDau");
            var source1 = new BindingSource();
            source.DataSource = DataUtil.DSPhieuThue();
            dgvPhieuThue.DataSource = source1;
        }
        private void PopulateDGVPhong(List<Phong> s)
        {
            var source = new BindingSource();
            source.DataSource = s;
            dgvPhieuThue.DataSource = source;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
