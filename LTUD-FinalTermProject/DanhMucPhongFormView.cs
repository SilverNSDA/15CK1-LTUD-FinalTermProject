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
            IninitializeDGV();
            
        }
        public void IninitializeDGV()
        {

            dgvDanhMucPhong.Columns.Add("ID", "MaPhong");
            dgvDanhMucPhong.Columns.Add("LoaiPhong", "LoaiPhong");
            dgvDanhMucPhong.Columns.Add("GhiChu", "GhiChu");
            var source = new BindingSource();
            source.DataSource = DataUtil.DSPhong();
            dgvDanhMucPhong.DataSource = source;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keydata)
        {
            if (keydata == Keys.Enter)
            {
                btnTimKiem.PerformClick();
                return true;
            }
            return false;
        }
        private List<Phong> SearchPhong(string tb1 , string cb1)
        {
           
            if (tb1 != null && cb1 == null)
            {
                List<Phong> maPhong = new List<Phong>();
                var dp = DataUtil.DSPhong();
                foreach (var i in dp)
                {
                    if (tb1 == i.ID)
                    {
                        maPhong.Add(i);
                    }
                }
                return maPhong;

            }
            if (tb1 == null && cb1 != null)
            {
                List<Phong> maLoaiPhong = new List<Phong>();
                var lp = DataUtil.DSPhong();
                foreach (var i in lp)
                {
                    if (cb1 == i.LoaiPhong)
                    {
                        maLoaiPhong.Add(i);
                    }
                }
                return maLoaiPhong;
            }
            else
            {
                List<Phong> maPhong = new List<Phong>();
                var dp = DataUtil.DSPhong();

                List<LoaiPhong> maLoaiPhong = new List<LoaiPhong>();
                var lp = DataUtil.DSLoaiPhong();


                foreach (var i in dp)
                {
                    if (tb1 == i.ID)
                    {
                        maPhong.Add(i);
                    }
                }

                foreach (var i in lp)
                {
                    if (cb1 == i.ID)
                    {
                        maLoaiPhong.Add(i);
                    }
                }
                return maPhong;
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
            string tb1 = txtTimMaPhong.Text;
            string cb1 = cbTimLoaiPhong.Text;

            SearchPhong(tb1,cb1);
        }
        private void PopulateDGVPhong(List<Phong> s)
        {
            var source = new BindingSource();
            source.DataSource = s;
            dgvDanhMucPhong.DataSource = source;
        }
    }
}
