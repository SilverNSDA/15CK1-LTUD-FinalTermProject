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
    public partial class KhachHangFormView : Form
    {
        public KhachHangFormView()
        {
            InitializeComponent();
            
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
    }
}
