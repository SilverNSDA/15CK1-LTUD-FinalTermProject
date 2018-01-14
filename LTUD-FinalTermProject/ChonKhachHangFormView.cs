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
    public partial class ChonKhachHangFormView : Form
    {
        private List<KhachHang> _selected;
        internal List<KhachHang> Selected { get => _selected; set => _selected = value; }
        private List<KhachHang> _adding=new List<KhachHang>();
        internal List<KhachHang> Adding { get => _adding; set => _adding = value; }
        public ChonKhachHangFormView()
        {
            InitializeComponent();
        }
        private bool CheckSelected(KhachHang kh)
        {
            foreach(var s in Selected)
            {
                if (s != null)
                {
                    if (s.ID.Trim() == kh.ID.Trim())
                        return true;
                }
            }
            return false;
        }

        public void InitializeDGV()
        {
            var source = new BindingSource();
            var dt = DataUtil.DSKhachHang();
            var tmp = new List<KhachHang>();
            if (Selected.Count>0)
            {
                foreach (var s in dt)
                {
                    if (CheckSelected(s))
                    {
                        tmp.Add(s);
                    }
                }
                foreach (var s in tmp)
                {
                    dt.Remove(s);
                }
            }
            source.DataSource = dt;
            dgvKH.DataSource = source;
            dgvKH.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgvKH.SelectedRows)
            {

                Adding.Add(row.DataBoundItem as KhachHang);
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChonKhachHangFormView_Load(object sender, EventArgs e)
        {
            InitializeDGV();
        }
    }
}
