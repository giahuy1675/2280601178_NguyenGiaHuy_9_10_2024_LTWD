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
    public partial class Form1 : Form
    {
        private Model1 dbContext;
        public Form1()
        {
            InitializeComponent();
            dbContext = new Model1();
        }
        private void LoadDataGrid()
        {
            try
            {
                using (var context = new Model1())
                {
                    var students = context.Students.Include("Faculty").Select(s => new
                    {
                        s.StudentID,
                        s.FullName,
                        s.AverageScore,
                        FacultyName = s.Faculty.FacultyName
                    }).ToList();

                    dtgv_ThongTinSinhVien.DataSource = students;
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: Không tìm thấy dữ liệu. {ex.Message}");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: Dữ liệu không hợp lệ. {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi không xác định khi tải dữ liệu: {ex.Message}");
            }
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

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Model1())
                {
                    var newStudent = new Student
                    {
                        StudentID = txb_MSSV.Text,
                        FullName = txb_HoTen.Text,
                        AverageScore = double.TryParse(txb_Diem.Text, out double score) ? score : 0,
                        FacultyID = (cmb_Khoa.SelectedItem as Faculty).FacultyID
                    };

                    context.Students.Add(newStudent);
                    context.SaveChanges();
                    LoadDataGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm sinh viên: {ex.Message}");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Model1())
                {
                    var studentID = txb_MSSV.Text;
                    var student = context.Students.FirstOrDefault(s => s.StudentID == studentID);

                    if (student != null)
                    {
                        student.FullName = txb_HoTen.Text;
                        student.AverageScore = double.TryParse(txb_Diem.Text, out double score) ? score : student.AverageScore;
                        student.FacultyID = (cmb_Khoa.SelectedItem as Faculty).FacultyID;

                        context.SaveChanges();
                        LoadDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Sinh viên không tồn tại!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sửa sinh viên: {ex.Message}");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Model1())
                {
                    var studentID = txb_MSSV.Text;
                    var student = context.Students.FirstOrDefault(s => s.StudentID == studentID);

                    if (student != null)
                    {
                        context.Students.Remove(student);
                        context.SaveChanges();
                        LoadDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Sinh viên không tồn tại!");
                    }
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show($"Lỗi: Không tìm thấy sinh viên. {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi không xác định khi xóa sinh viên: {ex.Message}");
            }
        }


        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgv_ThongTinSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgv_ThongTinSinhVien.Rows[e.RowIndex];

                txb_MSSV.Text = row.Cells["StudentID"].Value?.ToString() ?? string.Empty;
                txb_HoTen.Text = row.Cells["FullName"].Value?.ToString() ?? string.Empty;
                txb_Diem.Text = row.Cells["AverageScore"].Value?.ToString() ?? string.Empty;

                // Dùng FacultyName thay cho FacultyID
                var facultyName = row.Cells["FacultyName"].Value?.ToString();
                if (!string.IsNullOrEmpty(facultyName))
                {
                    cmb_Khoa.SelectedIndex = cmb_Khoa.FindStringExact(facultyName);
                }
                else
                {
                    cmb_Khoa.SelectedIndex = -1; // Không chọn gì nếu FacultyName null
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Model1())
                {
                    var faculties = context.Faculties.ToList();
                    if (faculties.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy khoa nào.");
                        return;
                    }

                    cmb_Khoa.DataSource = faculties;
                    cmb_Khoa.DisplayMember = "FacultyName";
                    cmb_Khoa.ValueMember = "FacultyID";
                }
                LoadDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu ban đầu: {ex.Message}");
            }
        }

        private void quảnLíKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFalculty Khoa = new frmFalculty();
            Khoa.ShowDialog();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimKiemSinhVien TimKiem = new frmTimKiemSinhVien();
            TimKiem.ShowDialog();
        }
    }
}
