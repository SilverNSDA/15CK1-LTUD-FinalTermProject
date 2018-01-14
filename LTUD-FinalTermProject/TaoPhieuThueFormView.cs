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
        private List<KhachHang> src = new List<KhachHang>();
        public TaoPhieuThueFormView()
        {
            
            InitializeComponent();
            IninitializeDGV();
            InitializeComboBox();
        }
        public void IninitializeDGV()
        {

            //dgvKH.Columns.Add("ID", "MaKhachHang");
            //dgvKH.Columns.Add("HoTen", "HoTenKhachHang");
            //dgvKH.Columns.Add("DiaChi", "DiaChi");
            //dgvKH.Columns.Add("LoaiKH", "LoaiKhachHang");
            //dgvKH.Columns.Add("CMND", "CMND");
            var source = new BindingSource();
            //source.DataSource = DataUtil.DSKhachHang();
            source.DataSource = src;
            dgvKH.DataSource = source;
            dgvKH.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public void InitializeComboBox()
        {
            var p = DataUtil.DSPhong();
            cbMaPhong.ValueMember = "ID";
            cbMaPhong.DisplayMember = "ID";
            cbMaPhong.DataSource = p;
        }
        private void PopulateDGV(List<KhachHang> s)
        {
            var source = new BindingSource();
            source.DataSource = s;
            dgvKH.DataSource = source;
        }
        private ToolTip tt;
        private void txtTinhTrang_MouseHover(object sender, EventArgs e)
        {
            tt = new ToolTip();
            tt.InitialDelay = 0;
            tt.IsBalloon = false;
            //tt.Show(String.Empty, txtTinhTrang);
            tt.Show("Chức năng chưa hoàn thiện", txtTinhTrang,0);
        }

        private void txtTinhTrang_MouseLeave(object sender, EventArgs e)
        {
            tt.Hide(txtTinhTrang);
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgvKH.SelectedRows)
            {
                dgvKH.Rows.Remove(row);
                src.Remove(row.DataBoundItem as KhachHang);
            }
        }

        private void ThemKH_Click(object sender, EventArgs e)
        {
            ChonKhachHangFormView view = new ChonKhachHangFormView();
            view.Selected = new List<KhachHang>();
            foreach(DataGridViewRow row in dgvKH.Rows)
            {
                var x = row.DataBoundItem as KhachHang;
                view.Selected.Add(x);
            }
            view.ShowDialog();
            if (view.Adding.Count>0)
            {
                foreach (var item in view.Adding)
                    src.Add(item);
                PopulateDGV(src);
            }

        }

        private void btnHuyTao_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            if (dgvKH.Rows[0].DataBoundItem as KhachHang == null)
                MessageBox.Show("Phiếu thuê không thể không có khách hàng");
            else
            {

                var pt = new PhieuThue();
                pt.ID = GetPTID();
                pt.NgayBatDau = DateTime.Now;
                pt.MaPhong = cbMaPhong.SelectedValue.ToString().Trim();
                DataUtil.ThemPhieuThue(pt);
                foreach (DataGridViewRow row in dgvKH.Rows)
                {
                    var kh = row.DataBoundItem as KhachHang;
                    if (kh != null)
                    {
                        var ct = new CT_PhieuThue();
                        ct.ID = GetCTPTID();
                        ct.MaKhachHang = kh.ID;
                        ct.MaPhieuThue = pt.ID;
                        DataUtil.ThemCT_PhieuThue(ct);
                    }
                }
            }
        }
        private string GetCTPTID()
        {
            var rnd = new Random();
            var dt = DataUtil.DSCT_PhieuThue();
            while (true)
            {
                var x = rnd.Next();
                var xString = x.ToString();
                foreach (var pt in dt)
                {
                    if (xString.Trim() != pt.ID.Trim())
                        return xString;
                }
            }
        }
        private string GetPTID()
        {
            var rnd = new Random();
            var dt = DataUtil.DSPhieuThue();
            while (true)
            {
                var x = rnd.Next();
                var xString = x.ToString();
                foreach(var pt in dt)
                {
                    if (xString.Trim() != pt.ID.Trim())
                        return xString;
                }
            }
        }
    }
}
