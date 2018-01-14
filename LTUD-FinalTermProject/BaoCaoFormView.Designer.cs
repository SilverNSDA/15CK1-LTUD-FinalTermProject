namespace LTUD_FinalTermProject
{
    partial class BaoCaoFormView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioMatDoPhong = new System.Windows.Forms.RadioButton();
            this.radioDoanhThuLoai = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.dateTimeNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.buttonBaoCao = new System.Windows.Forms.Button();
            this.dataGridViewBaoCao = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // radioMatDoPhong
            // 
            this.radioMatDoPhong.AutoSize = true;
            this.radioMatDoPhong.Checked = true;
            this.radioMatDoPhong.Location = new System.Drawing.Point(84, 46);
            this.radioMatDoPhong.Name = "radioMatDoPhong";
            this.radioMatDoPhong.Size = new System.Drawing.Size(94, 17);
            this.radioMatDoPhong.TabIndex = 1;
            this.radioMatDoPhong.TabStop = true;
            this.radioMatDoPhong.Text = "Mật Độ Phòng";
            this.radioMatDoPhong.UseVisualStyleBackColor = true;
            this.radioMatDoPhong.Click += new System.EventHandler(this.radioMatDoPhong_Click);
            // 
            // radioDoanhThuLoai
            // 
            this.radioDoanhThuLoai.AutoSize = true;
            this.radioDoanhThuLoai.Location = new System.Drawing.Point(340, 46);
            this.radioDoanhThuLoai.Name = "radioDoanhThuLoai";
            this.radioDoanhThuLoai.Size = new System.Drawing.Size(102, 17);
            this.radioDoanhThuLoai.TabIndex = 2;
            this.radioDoanhThuLoai.TabStop = true;
            this.radioDoanhThuLoai.Text = "Doanh Thu Loại";
            this.radioDoanhThuLoai.UseVisualStyleBackColor = true;
            this.radioDoanhThuLoai.Click += new System.EventHandler(this.radioDoanhThuLoai_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Từ ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đến ngày:";
            // 
            // dateTimeNgayBatDau
            // 
            this.dateTimeNgayBatDau.CustomFormat = " dd MMM,yyyy HH:mm:ss";
            this.dateTimeNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeNgayBatDau.Location = new System.Drawing.Point(198, 73);
            this.dateTimeNgayBatDau.Name = "dateTimeNgayBatDau";
            this.dateTimeNgayBatDau.Size = new System.Drawing.Size(200, 20);
            this.dateTimeNgayBatDau.TabIndex = 5;
            // 
            // dateTimeNgayKetThuc
            // 
            this.dateTimeNgayKetThuc.CustomFormat = " dd MMM,yyyy HH:mm:ss";
            this.dateTimeNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeNgayKetThuc.Location = new System.Drawing.Point(198, 106);
            this.dateTimeNgayKetThuc.Name = "dateTimeNgayKetThuc";
            this.dateTimeNgayKetThuc.Size = new System.Drawing.Size(200, 20);
            this.dateTimeNgayKetThuc.TabIndex = 6;
            // 
            // buttonBaoCao
            // 
            this.buttonBaoCao.Location = new System.Drawing.Point(405, 142);
            this.buttonBaoCao.Name = "buttonBaoCao";
            this.buttonBaoCao.Size = new System.Drawing.Size(76, 23);
            this.buttonBaoCao.TabIndex = 7;
            this.buttonBaoCao.Text = "Báo Cáo";
            this.buttonBaoCao.UseVisualStyleBackColor = true;
            this.buttonBaoCao.Click += new System.EventHandler(this.buttonBaoCao_Click);
            // 
            // dataGridViewBaoCao
            // 
            this.dataGridViewBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBaoCao.Location = new System.Drawing.Point(2, 179);
            this.dataGridViewBaoCao.Name = "dataGridViewBaoCao";
            this.dataGridViewBaoCao.ReadOnly = true;
            this.dataGridViewBaoCao.Size = new System.Drawing.Size(521, 207);
            this.dataGridViewBaoCao.TabIndex = 8;
            // 
            // BaoCaoFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 389);
            this.Controls.Add(this.dataGridViewBaoCao);
            this.Controls.Add(this.buttonBaoCao);
            this.Controls.Add(this.dateTimeNgayKetThuc);
            this.Controls.Add(this.dateTimeNgayBatDau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioDoanhThuLoai);
            this.Controls.Add(this.radioMatDoPhong);
            this.Name = "BaoCaoFormView";
            this.Text = "Báo cáo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBaoCao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioMatDoPhong;
        private System.Windows.Forms.RadioButton radioDoanhThuLoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeNgayBatDau;
        private System.Windows.Forms.DateTimePicker dateTimeNgayKetThuc;
        private System.Windows.Forms.Button buttonBaoCao;
        private System.Windows.Forms.DataGridView dataGridViewBaoCao;
    }
}