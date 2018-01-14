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
            InitializeComboBox();
            
        }
        public void IninitializeDGV()
        {

            //dgvDanhMucPhong.Columns.Add("ID", "MaPhong");
            //dgvDanhMucPhong.Columns.Add("LoaiPhong", "LoaiPhong");
            //dgvDanhMucPhong.Columns.Add("GhiChu", "GhiChu");
            var source = new BindingSource();
            source.DataSource = DataUtil.DSPhong();
            dgvDanhMucPhong.DataSource = source;
            dgvDanhMucPhong.MultiSelect = false;
            dgvDanhMucPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public void InitializeComboBox()
        {
            var lp = DataUtil.DSLoaiPhong();
            cbTimLoaiPhong.ValueMember = "ID";
            cbTimLoaiPhong.DisplayMember = "ID";
            cbTimLoaiPhong.DataSource = lp;
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
        private List<Phong> SearchPhong(string loaiPhong=null , string maPhong=null)
        {
            if (maPhong.Trim() == "")
                maPhong = null;
            if (loaiPhong.Trim() == "")
                loaiPhong = null;
            List<Phong> result = new List<Phong>();
            var dt = DataUtil.DSPhong();
            if (loaiPhong == null && maPhong==null)
            {
                result = dt;
            }else if (loaiPhong == null && maPhong != null)
            {
                foreach(var p in dt)
                {
                    if (p.ID.Trim() == maPhong.Trim())
                        result.Add(p);
                }
            }else if (loaiPhong != null && maPhong == null)
            {
                foreach(var p in dt)
                {
                    if (p.LoaiPhong.Trim() == loaiPhong.Trim())
                        result.Add(p);
                }
            }else if(loaiPhong!=null && maPhong != null)
            {
                foreach(var p in dt)
                {
                    if (p.LoaiPhong.Trim() == loaiPhong.Trim() && p.ID.Trim() == maPhong.Trim())
                        result.Add(p);
                }
            }



            return result;


        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
            string tb1 = txtTimMaPhong.Text;
            string cb1 = cbTimLoaiPhong.Text;

            var result = SearchPhong(cb1,tb1);
            PopulateDGVPhong(result);
        }
        private void PopulateDGVPhong(List<Phong> s)
        {
            var source = new BindingSource();
            source.DataSource = s;
            dgvDanhMucPhong.DataSource = source;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            PopulateDGVPhong(DataUtil.DSPhong());
        }
    }
}
