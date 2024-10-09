using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_NguyenGiaHuy
{
    public partial class frmTimKiemSinhVien : Form
    {
        public frmTimKiemSinhVien()
        {
            InitializeComponent();
        }

        private void txb_MSSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_HoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_Diem_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_Khoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Model1()) // Model1 là DbContext của bạn
                {
                    // Lấy giá trị từ các textbox và combobox
                    string mssv = txb_MSSV.Text.Trim();
                    string hoTen = txb_HoTen.Text.Trim();
                    string khoa = cmb_Khoa.SelectedItem?.ToString();
                    string diemStr = txb_Diem.Text.Trim();

                    // Kiểm tra giá trị điểm nhập vào
                    bool isValidScore = int.TryParse(diemStr, out int diem);

                    // Truy vấn sinh viên theo các tiêu chí tìm kiếm
                    var sinhVienQuery = context.Students.AsQueryable();

                    if (!string.IsNullOrEmpty(mssv))
                    {
                        sinhVienQuery = sinhVienQuery.Where(sv => sv.StudentID.Contains(mssv));
                    }

                    if (!string.IsNullOrEmpty(hoTen))
                    {
                        sinhVienQuery = sinhVienQuery.Where(sv => sv.FullName.Contains(hoTen));
                    }

                    if (!string.IsNullOrEmpty(khoa))
                    {
                        sinhVienQuery = sinhVienQuery.Where(sv => sv.Faculty.FacultyName == khoa);
                    }

                    if (isValidScore)
                    {
                        sinhVienQuery = sinhVienQuery.Where(sv => sv.AverageScore >= diem);
                    }

                    // Thực hiện truy vấn và hiển thị kết quả
                    var sinhVienList = sinhVienQuery.Select(sv => new
                    {
                        sv.StudentID,
                        sv.FullName,
                        FacultyName = sv.Faculty.FacultyName,
                        sv.AverageScore
                    }).ToList();

                    dtgv_ThongTinSinhVien.DataSource = sinhVienList;

                    // Cập nhật tổng số sinh viên tìm thấy
                    txb_TongSinhVien.Text = sinhVienList.Count.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm sinh viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dtgv_ThongTinSinhVien.SelectedRows.Count > 0)
            {
                // Lấy MSSV của sinh viên được chọn
                string mssv = dtgv_ThongTinSinhVien.SelectedRows[0].Cells["StudentID"].Value.ToString();

                try
                {
                    using (var context = new Model1())
                    {
                        var student = context.Students.FirstOrDefault(sv => sv.StudentID == mssv);

                        if (student != null)
                        {
                            // Xóa sinh viên
                            context.Students.Remove(student);
                            context.SaveChanges();
                            MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Cập nhật lại DataGridView sau khi xóa
                            btn_TimKiem_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sinh viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa sinh viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_TroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txb_TongSinhVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgv_ThongTinSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmTimKiemSinhVien_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Model1()) // Model1 là tên DbContext của bạn
                {
                    // Lấy danh sách các khoa từ cơ sở dữ liệu
                    var khoaList = context.Faculties.Select(f => f.FacultyName).ToList();

                    // Gán danh sách khoa vào combobox
                    cmb_Khoa.DataSource = khoaList;
                    cmb_Khoa.SelectedIndex = -1; // Đặt combobox ở trạng thái chưa chọn gì
                }

                // Đặt DataGridView thành null (không hiển thị dữ liệu ban đầu)
                dtgv_ThongTinSinhVien.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách khoa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
