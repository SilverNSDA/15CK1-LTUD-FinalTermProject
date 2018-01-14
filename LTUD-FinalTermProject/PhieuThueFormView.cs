﻿using System;
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
            dgvCTPhieuThue.Columns[0].Name = "ID";
            dgvCTPhieuThue.Columns[1].Name = "MaPhieuThue";
            dgvCTPhieuThue.Columns[2].Name = "MaKhachHang";

            dgvPhieuThue.Columns[0].Name = "ID";
            dgvPhieuThue.Columns[0].Name = "MaPhong";
            dgvPhieuThue.Columns[0].Name = "NgayBatDau";
            xuatpt();
            
            InitializeComponent();
        }
        public void xuatpt()
        {
            DataGridViewRow row = dgvCTPhieuThue.CurrentRow;
            var kh = DataUtil.DSCT_PhieuThue();
            foreach (var khh in kh)
            {
                row.Cells["ID"].Value = khh.ID;
                row.Cells["MaPhieuThue"].Value = khh.MaPhieuThue;
                row.Cells["MaKhachHang"].Value = khh.MaKhachHang;
               
            }
            DataGridViewRow row1 = dgvCTPhieuThue.CurrentRow;
            var khh1 = DataUtil.DSPhieuThue();
            foreach (var khh in khh1)
            {
                row.Cells["ID"].Value = khh.ID;
                row.Cells["MaPhong"].Value = khh.MaPhong;
                row.Cells["NgayBatDau"].Value = khh.NgayBatDau;

            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bntTaoPhieuThue_Click(object sender, EventArgs e)
        {
            PhieuThueFormView phieuthue = new PhieuThueFormView();
            phieuthue.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<PhieuThue> searchResult;
            searchResult = searchPhieuThue(txtTimMaPhieuThue.Text, dtNgayBD.Value, dtNgayKT.Value);
            populateDGVPhieuThue(searchResult);
        }
        private List<PhieuThue> searchPhieuThue(string maphieuthue = null,DateTime ngaybd, DateTime ngaykt)
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

        }
    }
}
