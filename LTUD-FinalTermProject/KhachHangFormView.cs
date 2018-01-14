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
            InitializeCombobox();


        }
        public void IninitializeDGV()
        {

            //dgvKhachHang.Columns.Add("ID", "MaKhachHang");
            //dgvKhachHang.Columns.Add("HoTen", "HoTenKhachHang");
            //dgvKhachHang.Columns.Add("DiaChi", "DiaChi");
            //dgvKhachHang.Columns.Add("LoaiKH", "LoaiKhachHang");
            //dgvKhachHang.Columns.Add("CMND", "CMND");
            var source = new BindingSource();
            source.DataSource = DataUtil.DSKhachHang();
            dgvKhachHang.DataSource = source;
            dgvKhachHang.MultiSelect = false;
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public void InitializeCombobox()
        {
            var lkh = DataUtil.DSLoaiKhachHang();
            comboTimLoaiKH.ValueMember = "ID";
            comboTimLoaiKH.DisplayMember = "TenLoai";
            comboTimLoaiKH.DataSource = lkh;
        }
        private void PopulateDGVPhong(List<KhachHang> s)
        {
            var source = new BindingSource();
            source.DataSource = s;
            dgvKhachHang.DataSource = source;
        }
        private void KhachHangFormView_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonThemKH_Click(object sender, EventArgs e)
        {
            TaoKhachHangFormView taokh = new TaoKhachHangFormView();
            taokh.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            var makh = textTimMaKH.Text.Trim();
            var loaikh = comboTimLoaiKH.SelectedValue.ToString().Trim();

            var searchResult = searchKhachHang(makh,loaikh);
            populateDGVKhachHang(searchResult);
        }
        private List<KhachHang> searchKhachHang(string makh=null, string loaikh=null)
        {
            if(makh == "")
            {
                makh = null;
            }
            var dt = DataUtil.DSKhachHang();
            List<KhachHang> result= new List<KhachHang>();

            if(makh == null && loaikh != null)
            {
                foreach(var kh in dt)
                {
                    if(loaikh == kh.LoaiKhachHang.Trim())
                    {
                        result.Add(kh);
                    }
                }
            }
            else if(loaikh == null && makh != null)
                {
                    foreach (var kh in dt)
                    {
                        if (makh == kh.ID.Trim())
                        {
                            result.Add(kh);
                        }
                    }
                }
            else if(makh ==null && loaikh == null) {
                result = dt;
            }
            else
            {
                foreach (var kh in dt)
                {
                    if (makh == kh.ID.Trim() && loaikh == kh.LoaiKhachHang.Trim())
                    {
                        result.Add(kh);
                    }
                }
            }
            

            return result;

        }
        private void populateDGVKhachHang(List<KhachHang> searchResult)
        {
            var source = new BindingSource();
            source.DataSource = searchResult;
            dgvKhachHang.DataSource = source;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            populateDGVKhachHang(DataUtil.DSKhachHang());
        }

        private void dgvKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count>0)
            {
                var row = dgvKhachHang.SelectedRows[0];
                var dt = row.DataBoundItem as KhachHang;
                if (dt == null)
                {
                    txtHoTen.Text = "";
                    txtDiaChi.Text = "";
                    txtCMND.Text = "";
                    cbLoaiKH.Text = "";
                }
                else
                {
                    txtHoTen.Text = dt.HoTen;
                    txtDiaChi.Text = dt.DiaChi;
                    txtCMND.Text = dt.CMND;
                    cbLoaiKH.Text = dt.LoaiKhachHang;
                }
            }
        }
    }
}
