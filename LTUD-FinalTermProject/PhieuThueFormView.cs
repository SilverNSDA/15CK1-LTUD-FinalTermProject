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
            InitializeComponent();
            IninitializeDGV();
            
        }
        public void IninitializeDGV()
        {
            dgvCTPhieuThue.Columns.Add("ID", "ID");
            dgvCTPhieuThue.Columns.Add("MaPhieuThue", "MaPhieuThue");
            dgvCTPhieuThue.Columns.Add("MaKhachHang", "MaKhachHang");
            var source = new BindingSource();
            source.DataSource = DataUtil.DSCT_PhieuThue();
            dgvCTPhieuThue.DataSource = source;
            dgvCTPhieuThue.MultiSelect = false;
            dgvCTPhieuThue.SelectionMode = DataGridViewSelectionMode.FullRowSelect;



            dgvPhieuThue.Columns.Add("ID", "ID");
            dgvPhieuThue.Columns.Add("MaPhong", "MaPhong");
            dgvPhieuThue.Columns.Add("NgayBatDau", "NgayBatDau");
            var source1 = new BindingSource();
            source.DataSource = DataUtil.DSPhieuThue();
            dgvPhieuThue.DataSource = source1;
            dgvPhieuThue.MultiSelect = false;
            dgvPhieuThue.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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

        private void bntTaoPhieuThue_Click(object sender, EventArgs e)
        {
            TaoPhieuThueFormView phieuthue = new TaoPhieuThueFormView();
            phieuthue.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<PhieuThue> searchResult;
            searchResult = searchPhieuThue( dtNgayBD.Value, dtNgayKT.Value, txtTimMaPhieuThue.Text);
            populateDGVPhieuThue(searchResult);
        }
        private List<PhieuThue> searchPhieuThue(DateTime ngaybd, DateTime ngaykt, string maphieuthue = null)
        {
            var dpt = DataUtil.DSPhieuThue();
            List<PhieuThue> result = new List<PhieuThue>();
            if(maphieuthue == null)
            {
                foreach(var pt in dpt)
                {
                    if(pt.NgayBatDau <= ngaykt && pt.NgayBatDau >= ngaybd)
                    {
                        result.Add(pt);
                    }
                }
            }
            else if(maphieuthue != null)
            {
                foreach(var pt in dpt)
                {
                    if(pt.ID == maphieuthue && pt.NgayBatDau <= ngaykt && pt.NgayBatDau >= ngaybd)
                    {
                        result.Add(pt);
                    }
                }
            }
            return result;
        }
        private void populateDGVPhieuThue(List<PhieuThue> searchResult)
        {
            var source = new BindingSource();
            source.DataSource = searchResult;
            dgvPhieuThue.DataSource = source;
        }

        private void dgvPhieuThue_SelectionChanged(object sender, EventArgs e)
        {
            var row = dgvPhieuThue.SelectedRows[0];
            var dt = row.DataBoundItem as PhieuThue;
            if (dt != null)
            {
                txtMaPhieuThue.Text = dt.ID;
                cbMaPhong.SelectedItem = dt.MaPhong;
                dtNgayBD.Value = dt.NgayBatDau;
                var phong = DataUtil.DSPhong();
                foreach (var p in phong)
                {
                    if (p.ID == dt.MaPhong)
                    {
                        txtLoaiPhong.Text = p.ID;
                        var lp = DataUtil.DSLoaiPhong();
                        foreach (var l in lp)
                        {
                            if (l.ID == p.LoaiPhong)
                            {
                                txtDonGia.Text = l.DonGia.ToString();
                                break;
                            }
                        }
                        break;
                    }
                }
                var ctpt = DataUtil.DSCT_PhieuThue();
                List<CT_PhieuThue> r = new List<CT_PhieuThue>();
                foreach(var ct in ctpt)
                {
                    if (ct.MaPhieuThue == dt.ID)
                        r.Add(ct);
                }
                var source = new BindingSource();
                source.DataSource = r;
                dgvCTPhieuThue.DataSource = source;
            }
            else
            {
                var source = new BindingSource();
                dgvCTPhieuThue.DataSource = source;
            }

        }
    }
}
