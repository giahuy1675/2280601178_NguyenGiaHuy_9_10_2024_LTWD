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
    public partial class frmFalculty : Form
    {
        public frmFalculty()
        {
            InitializeComponent();
        }

        private void LoadFacultyData()
        {
            try
            {
                using (var context = new Model1())
                {
                    var faculties = context.Faculties.Select(f => new
                    {
                        f.FacultyID,
                        f.FacultyName,
                        f.TotalProfessor
                    }).ToList();

                    dtgvThongTinGS.DataSource = faculties;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}");
            }
        }


        private void txb_MaKhoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_TenKhoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_TongGS_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Model1())
                {
                    // Tạo đối tượng Faculty mới
                    var newFaculty = new Faculty
                    {
                        FacultyID = int.Parse(txb_MaKhoa.Text),
                        FacultyName = txb_TenKhoa.Text,
                        TotalProfessor = string.IsNullOrWhiteSpace(txb_TongGS.Text) ? (int?)null : int.Parse(txb_TongGS.Text)
                    };

                    // Thêm khoa vào context và lưu thay đổi
                    context.Faculties.Add(newFaculty);
                    context.SaveChanges();

                    MessageBox.Show("Thêm khoa thành công!");
                    LoadFacultyData(); // Cập nhật lại DataGridView sau khi thêm
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm khoa: {ex.Message}");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Model1())
                {
                    // Lấy mã khoa cần sửa
                    int facultyID = int.Parse(txb_MaKhoa.Text);

                    // Tìm khoa theo mã khoa
                    var faculty = context.Faculties.FirstOrDefault(f => f.FacultyID == facultyID);

                    if (faculty != null)
                    {
                        // Cập nhật thông tin khoa
                        faculty.FacultyName = txb_TenKhoa.Text;
                        faculty.TotalProfessor = string.IsNullOrWhiteSpace(txb_TongGS.Text) ? (int?)null : int.Parse(txb_TongGS.Text);

                        context.SaveChanges(); // Lưu thay đổi
                        MessageBox.Show("Cập nhật thông tin khoa thành công!");
                        LoadFacultyData(); // Cập nhật lại DataGridView sau khi sửa
                    }
                    else
                    {
                        MessageBox.Show("Khoa không tồn tại!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sửa khoa: {ex.Message}");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Model1())
                {
                    // Lấy mã khoa cần xóa
                    int facultyID = int.Parse(txb_MaKhoa.Text);

                    // Tìm khoa theo mã khoa
                    var faculty = context.Faculties.FirstOrDefault(f => f.FacultyID == facultyID);

                    if (faculty != null)
                    {
                        // Xóa khoa khỏi context và lưu thay đổi
                        context.Faculties.Remove(faculty);
                        context.SaveChanges();

                        MessageBox.Show("Xóa khoa thành công!");
                        LoadFacultyData(); // Cập nhật lại DataGridView sau khi xóa
                    }
                    else
                    {
                        MessageBox.Show("Khoa không tồn tại!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa khoa: {ex.Message}");
            }
        }

        private void dtgvThongTinGS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmFalculty_Load(object sender, EventArgs e)
        {
            LoadFacultyData();
        }
    }
}
