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
<<<<<<< HEAD
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
=======
            xuat();
        }
        public void xuat()
        {
            dgvKhachHang.Columns[0].Name = "ID";
            dgvKhachHang.Columns[1].Name = "HoTen";
            dgvKhachHang.Columns[2].Name = "DiaChi";
            dgvKhachHang.Columns[3].Name = "LoaiKH";
            dgvKhachHang.Columns[4].Name = "CMND";
            DataGridViewRow row = dgvKhachHang.CurrentRow;
            var kh = DataUtil.DSKhachHang();
            foreach (var khh in kh)
            {
                row.Cells["ID"].Value = khh.ID;
                row.Cells["HoTen"].Value = khh.HoTen;
                row.Cells["DiaChi"].Value = khh.DiaChi;
                row.Cells["LoaiKH"].Value = khh.LoaiKhachHang;
                row.Cells["CMND"].Value = khh.CMND;
            }
>>>>>>> 1560121
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
            List<KhachHang> searchResult;
            //
            //
           
            searchResult = searchKhachHang(textTimMaKH.Text,comboTimLoaiKH.SelectedValue.ToString());
            populateDGVKhachHang(searchResult);
        }
        private List<KhachHang> searchKhachHang(string makh=null, string loaikh=null)
        {
            var dt = DataUtil.DSKhachHang();
            List<KhachHang> result= new List<KhachHang>();

            if(makh == null && loaikh != null)
            {
                foreach(var kh in dt)
                {
                    if(loaikh == kh.LoaiKhachHang)
                    {
                        result.Add(kh);
                    }
                }
            }
            else if(loaikh == null && makh != null)
                {
                    foreach (var kh in dt)
                    {
                        if (makh == kh.ID)
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
                    if (makh == kh.ID && loaikh == kh.LoaiKhachHang)
                    {
                        result.Add(kh);
                    }
                }
            }
            

            return result;

        }
        private void populateDGVKhachHang(List<KhachHang> searchResult)
        {
            
        }
    }
}
