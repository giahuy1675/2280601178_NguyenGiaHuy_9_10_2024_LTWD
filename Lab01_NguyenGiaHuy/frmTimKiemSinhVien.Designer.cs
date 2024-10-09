namespace Lab01_NguyenGiaHuy
{
    partial class frmTimKiemSinhVien
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
            this.dtgv_ThongTinSinhVien = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Khoa = new System.Windows.Forms.ComboBox();
            this.txb_Diem = new System.Windows.Forms.TextBox();
            this.txb_HoTen = new System.Windows.Forms.TextBox();
            this.txb_MSSV = new System.Windows.Forms.TextBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_TroVe = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.txb_TongSinhVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ThongTinSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_ThongTinSinhVien
            // 
            this.dtgv_ThongTinSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_ThongTinSinhVien.Location = new System.Drawing.Point(245, 70);
            this.dtgv_ThongTinSinhVien.Name = "dtgv_ThongTinSinhVien";
            this.dtgv_ThongTinSinhVien.Size = new System.Drawing.Size(431, 368);
            this.dtgv_ThongTinSinhVien.TabIndex = 19;
            this.dtgv_ThongTinSinhVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_ThongTinSinhVien_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Họ tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Điểm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Khoa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "MSSV";
            // 
            // cmb_Khoa
            // 
            this.cmb_Khoa.FormattingEnabled = true;
            this.cmb_Khoa.Location = new System.Drawing.Point(78, 207);
            this.cmb_Khoa.Name = "cmb_Khoa";
            this.cmb_Khoa.Size = new System.Drawing.Size(161, 21);
            this.cmb_Khoa.TabIndex = 13;
            this.cmb_Khoa.SelectedIndexChanged += new System.EventHandler(this.cmb_Khoa_SelectedIndexChanged);
            // 
            // txb_Diem
            // 
            this.txb_Diem.Location = new System.Drawing.Point(78, 166);
            this.txb_Diem.Name = "txb_Diem";
            this.txb_Diem.Size = new System.Drawing.Size(161, 20);
            this.txb_Diem.TabIndex = 12;
            this.txb_Diem.TextChanged += new System.EventHandler(this.txb_Diem_TextChanged);
            // 
            // txb_HoTen
            // 
            this.txb_HoTen.Location = new System.Drawing.Point(78, 117);
            this.txb_HoTen.Name = "txb_HoTen";
            this.txb_HoTen.Size = new System.Drawing.Size(161, 20);
            this.txb_HoTen.TabIndex = 11;
            this.txb_HoTen.TextChanged += new System.EventHandler(this.txb_HoTen_TextChanged);
            // 
            // txb_MSSV
            // 
            this.txb_MSSV.Location = new System.Drawing.Point(78, 70);
            this.txb_MSSV.Name = "txb_MSSV";
            this.txb_MSSV.Size = new System.Drawing.Size(161, 20);
            this.txb_MSSV.TabIndex = 10;
            this.txb_MSSV.TextChanged += new System.EventHandler(this.txb_MSSV_TextChanged);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(25, 276);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(88, 33);
            this.btn_TimKiem.TabIndex = 20;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // btn_TroVe
            // 
            this.btn_TroVe.Location = new System.Drawing.Point(25, 333);
            this.btn_TroVe.Name = "btn_TroVe";
            this.btn_TroVe.Size = new System.Drawing.Size(88, 33);
            this.btn_TroVe.TabIndex = 21;
            this.btn_TroVe.Text = "Trở về";
            this.btn_TroVe.UseVisualStyleBackColor = true;
            this.btn_TroVe.Click += new System.EventHandler(this.btn_TroVe_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(119, 276);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(88, 33);
            this.btn_Xoa.TabIndex = 22;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // txb_TongSinhVien
            // 
            this.txb_TongSinhVien.Location = new System.Drawing.Point(119, 403);
            this.txb_TongSinhVien.Name = "txb_TongSinhVien";
            this.txb_TongSinhVien.Size = new System.Drawing.Size(120, 20);
            this.txb_TongSinhVien.TabIndex = 23;
            this.txb_TongSinhVien.TextChanged += new System.EventHandler(this.txb_TongSinhVien_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Kết quả tìm kiếm";
            // 
            // frmTimKiemSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_TongSinhVien);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_TroVe);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.dtgv_ThongTinSinhVien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Khoa);
            this.Controls.Add(this.txb_Diem);
            this.Controls.Add(this.txb_HoTen);
            this.Controls.Add(this.txb_MSSV);
            this.Name = "frmTimKiemSinhVien";
            this.Text = "frmTimKiemSinhVien";
            this.Load += new System.EventHandler(this.frmTimKiemSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_ThongTinSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_ThongTinSinhVien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Khoa;
        private System.Windows.Forms.TextBox txb_Diem;
        private System.Windows.Forms.TextBox txb_HoTen;
        private System.Windows.Forms.TextBox txb_MSSV;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Button btn_TroVe;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.TextBox txb_TongSinhVien;
        private System.Windows.Forms.Label label2;
    }
}