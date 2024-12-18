using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuShiX
{
    public partial class FrmAddEmployee : Form
    {
        // Biến private lưu trữ userID
        private string userID;

        // Connection string cho cơ sở dữ liệu
        private string connectionString = AppConfig.connectionString;

        // Getter để chỉ cho phép đọc userID từ bên ngoài nếu cần
        public string UserID
        {
            get { return userID; }
            private set { userID = value; }
        }
        public FrmAddEmployee(string userID)
        {
            InitializeComponent();
            this.UserID = userID;
            this.Width = AppConfig.formWidth;
            this.Height = AppConfig.formHeight;
            LoadComboBoxData();
        }

        private void LoadComboBoxData()
        {

            // Câu lệnh SQL để lấy dữ liệu
            string query = "SELECT TenBP FROM BoPhan";

            try
            {
                // Kết nối tới database và lấy dữ liệu
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    DataRow[] filteredRows = dataTable.Select("TenBP <> 'Quản Lý'");
                    DataTable filteredTable = dataTable.Clone();

                    foreach (DataRow row in filteredRows)
                    {
                        filteredTable.ImportRow(row);
                    }

                    // Kiểm tra nếu không có dữ liệu
                    if (filteredTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có dữ liệu nào từ bảng BoPhan.");
                        return;
                    }

                    // Gán dữ liệu vào ComboBox
                    cbbDepartment.DataSource = filteredTable;
                    cbbDepartment.DisplayMember = "TenBP"; // Hiển thị tên bộ phận
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }
        private void FrmAddEmployee_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            if (string.IsNullOrEmpty(txbUserName.Text.Trim()) ||
            string.IsNullOrEmpty(txbPassword.Text.Trim()) ||
            string.IsNullOrEmpty(txbFullName.Text.Trim()) ||
            string.IsNullOrEmpty(txbPhoneNumber.Text.Trim()) ||
            string.IsNullOrEmpty(txbAddress.Text.Trim()) ||
            cbbGender.SelectedItem == null ||
            cbbDepartment.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Gọi thủ tục cập nhật thông tin khách hàng
                    using (SqlCommand cmd = new SqlCommand("USP_ThemNhanVien", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số
                        cmd.Parameters.AddWithValue("@MaTK", this.userID);
                        cmd.Parameters.AddWithValue("@TenTK", txbUserName.Text.Trim());
                        cmd.Parameters.AddWithValue("@MatKhau", txbPassword.Text.Trim());
                        cmd.Parameters.AddWithValue("@HoTen", txbFullName.Text.Trim());
                        cmd.Parameters.AddWithValue("@NgaySinh", dtpDateOfBirth.Value);
                        cmd.Parameters.AddWithValue("@GioiTinh", cbbGender.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("NgayVaoLam", dtpStartDate.Value);
                        if (dtpEndDate.Value.Date == DateTime.Now.Date)
                        {
                            cmd.Parameters.AddWithValue("@NgayNghiViec", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@NgayNghiViec", dtpEndDate.Value);
                        }
                        cmd.Parameters.AddWithValue("@SDT", txbPhoneNumber.Text.Trim());
                        cmd.Parameters.AddWithValue("@DiaChi", txbAddress.Text.Trim());

                        DataRowView selectedRow = cbbDepartment.SelectedItem as DataRowView;
                        string department = selectedRow?["TenBP"]?.ToString();

                        cmd.Parameters.AddWithValue("@TenBP", department);

                        // Thực thi thủ tục
                        cmd.ExecuteNonQuery();

                        // Nếu không có lỗi, thông báo thành công
                        MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrmManageEmployee frmManageEmployee = new FrmManageEmployee(this.UserID);
                        this.Hide();
                        frmManageEmployee.ShowDialog();
                        this.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                // Kiểm tra mã lỗi duy nhất và hiển thị thông báo chi tiết
                if (ex.Number == 50000)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show($"Lỗi khi thêm nhân viên: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm nhân viên: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmManageEmployee frmManageEmployee = new FrmManageEmployee(this.UserID);
            this.Hide();
            frmManageEmployee.ShowDialog();
            this.Close();
        }
        private void pbDisplayPassword_Click(object sender, EventArgs e)
        {
            if (txbPassword.UseSystemPasswordChar)
            {
                txbPassword.UseSystemPasswordChar = false;
                pbDisplayPassword.Image = Properties.Resources.eye_open;
            }
            else
            {
                txbPassword.UseSystemPasswordChar = true;
                pbDisplayPassword.Image = Properties.Resources.eye_close;
            }
        }
    }
}
