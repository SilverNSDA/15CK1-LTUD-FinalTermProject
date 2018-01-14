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
    public partial class BaoCaoFormView : Form
    {
        public BaoCaoFormView()
        {
            InitializeComponent();
        }

        private void buttonBaoCao_Click(object sender, EventArgs e)
        {
            if(radioDoanhThuLoai.Checked)
            {
                DataUtil.BaoCaoDoanhThu(dateTimeNgayBatDau.Value, dateTimeNgayKetThuc.Value);
                dgvBaoCaoDoanhThu();
            }
            else
            {
                DataUtil.BaoCaoMatDo(dateTimeNgayBatDau.Value, dateTimeNgayKetThuc.Value);
                dgvBaoCaoMatDo();
            }
        }
        private void dgvBaoCaoMatDo ()
        {
            dataGridViewBaoCao.Columns.Clear();
            //dataGridViewBaoCao.Columns.Add("ID", "ID");
            //dataGridViewBaoCao.Columns.Add("MaPhong","Mã phòng");
            //dataGridViewBaoCao.Columns.Add("NgayBatDau", "Ngày bắt đầu");
            //dataGridViewBaoCao.Columns.Add("NgayKetThuc", "Ngày kết thúc");
            //dataGridViewBaoCao.Columns.Add("MatDo", "Mật độ");
            var source = new BindingSource();
            source.DataSource = DataUtil.DSMD_SuDungPhong();
            dataGridViewBaoCao.DataSource = source;
        }

        private void dgvBaoCaoDoanhThu()
        {
            dataGridViewBaoCao.Columns.Clear();
            //dataGridViewBaoCao.Columns.Add("ID", "ID");
            //dataGridViewBaoCao.Columns.Add("MaLoaiPhong", "Mã loại phòng");
            //dataGridViewBaoCao.Columns.Add("NgayBatDau", "Ngày bắt đầu");
            //dataGridViewBaoCao.Columns.Add("NgayKetThuc", "Ngày kết thúc");
            //dataGridViewBaoCao.Columns.Add("DoanhThu", "Doanh thu");
            var source = new BindingSource();
            source.DataSource = DataUtil.DSDT_TheoLoaiPhong();
            dataGridViewBaoCao.DataSource = source;
        }

        private void radioDoanhThuLoai_Click(object sender, EventArgs e)
        {
            radioDoanhThuLoai.Checked = true;
            radioMatDoPhong.Checked = false;
        }

        private void radioMatDoPhong_Click(object sender, EventArgs e)
        {
            radioDoanhThuLoai.Checked = false;
            radioMatDoPhong.Checked = true;
        }
    }
}
