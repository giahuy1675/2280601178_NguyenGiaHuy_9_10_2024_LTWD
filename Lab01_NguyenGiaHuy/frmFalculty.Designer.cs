namespace Lab01_NguyenGiaHuy
{
    partial class frmFalculty
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
            this.txb_MaKhoa = new System.Windows.Forms.TextBox();
            this.txb_TongGS = new System.Windows.Forms.TextBox();
            this.txb_TenKhoa = new System.Windows.Forms.TextBox();
            this.dtgvThongTinGS = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongTinGS)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_MaKhoa
            // 
            this.txb_MaKhoa.Location = new System.Drawing.Point(93, 79);
            this.txb_MaKhoa.Name = "txb_MaKhoa";
            this.txb_MaKhoa.Size = new System.Drawing.Size(175, 20);
            this.txb_MaKhoa.TabIndex = 0;
            this.txb_MaKhoa.TextChanged += new System.EventHandler(this.txb_MaKhoa_TextChanged);
            // 
            // txb_TongGS
            // 
            this.txb_TongGS.Location = new System.Drawing.Point(93, 155);
            this.txb_TongGS.Name = "txb_TongGS";
            this.txb_TongGS.Size = new System.Drawing.Size(175, 20);
            this.txb_TongGS.TabIndex = 2;
            this.txb_TongGS.TextChanged += new System.EventHandler(this.txb_TongGS_TextChanged);
            // 
            // txb_TenKhoa
            // 
            this.txb_TenKhoa.Location = new System.Drawing.Point(93, 117);
            this.txb_TenKhoa.Name = "txb_TenKhoa";
            this.txb_TenKhoa.Size = new System.Drawing.Size(175, 20);
            this.txb_TenKhoa.TabIndex = 3;
            this.txb_TenKhoa.TextChanged += new System.EventHandler(this.txb_TenKhoa_TextChanged);
            // 
            // dtgvThongTinGS
            // 
            this.dtgvThongTinGS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvThongTinGS.Location = new System.Drawing.Point(274, 78);
            this.dtgvThongTinGS.Name = "dtgvThongTinGS";
            this.dtgvThongTinGS.Size = new System.Drawing.Size(378, 360);
            this.dtgvThongTinGS.TabIndex = 4;
            this.dtgvThongTinGS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvThongTinGS_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tổng GS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên khoa";
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(40, 204);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(98, 38);
            this.btn_Them.TabIndex = 8;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(41, 248);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(98, 38);
            this.btn_Xoa.TabIndex = 9;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(155, 204);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(98, 38);
            this.btn_Sua.TabIndex = 10;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(181, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 46);
            this.label4.TabIndex = 11;
            this.label4.Text = "Quản lí giáo sư";
            // 
            // frmFalculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvThongTinGS);
            this.Controls.Add(this.txb_TenKhoa);
            this.Controls.Add(this.txb_TongGS);
            this.Controls.Add(this.txb_MaKhoa);
            this.Name = "frmFalculty";
            this.Text = "frmFalculty";
            this.Load += new System.EventHandler(this.frmFalculty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongTinGS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_MaKhoa;
        private System.Windows.Forms.TextBox txb_TongGS;
        private System.Windows.Forms.TextBox txb_TenKhoa;
        private System.Windows.Forms.DataGridView dtgvThongTinGS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Label label4;
    }
}