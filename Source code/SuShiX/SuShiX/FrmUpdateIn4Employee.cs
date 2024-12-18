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
    public partial class FrmUpdateIn4Employee : Form
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

        public FrmUpdateIn4Employee(string userID)
        {
            InitializeComponent();
            this.UserID = userID;
            this.Width = AppConfig.formWidth;
            this.Height = AppConfig.formHeight;
            LoadEmployeeData();
        }

        private void LoadEmployeeData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("USP_XemThongTinNhanVien", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new SqlParameter("@MaTK", SqlDbType.NVarChar)
                        {
                            Value = this.UserID
                        });

                        // Thực thi lệnh và lấy dữ liệu
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Gán dữ liệu vào các textbox
                                txbUsername.Text = reader["TenTK"].ToString();
                                txbPassword.Text = reader["MatKhau"].ToString();
                                txbFullName.Text = reader["Hoten"].ToString();
                                dtpDateOfBirth.Value = reader["NgaySinh"] != DBNull.Value ? Convert.ToDateTime(reader["NgaySinh"]) : DateTime.Now;
                                cbbGender.Text = reader["GioiTinh"].ToString();
                                txbPhoneNumber.Text = reader["SDT"].ToString();
                                txbStartDate.Text = reader["NgayVaoLam"] != DBNull.Value && DateTime.TryParse(reader["NgayVaoLam"].ToString(), out DateTime NgayVaoLam)? NgayVaoLam.ToString("dd/MM/yyyy"): "";
                                txbEndDate.Text = reader["NgayNghiViec"] != DBNull.Value && DateTime.TryParse(reader["NgayNghiViec"].ToString(), out DateTime NgayNghiViec) ? NgayNghiViec.ToString("dd/MM/yyyy") : "";
                                txbAddress.Text = reader["DiaChi"].ToString();
                                txbDepartment.Text = reader["MaBP"].ToString();
                                txbBranch.Text = reader["MaCN"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy thông tin nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateEmployeeInfo()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Gọi thủ tục cập nhật thông tin khách hàng
                    using (SqlCommand cmd = new SqlCommand("USP_CapNhatThongTinNhanVien", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số
                        cmd.Parameters.AddWithValue("@MaTK", userID);
                        cmd.Parameters.AddWithValue("@TenTK", txbUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@MatKhau", txbPassword.Text.Trim());
                        cmd.Parameters.AddWithValue("@Hoten", txbFullName.Text.Trim());
                        cmd.Parameters.AddWithValue("@NgaySinh", dtpDateOfBirth.Value);
                        cmd.Parameters.AddWithValue("@GioiTinh", cbbGender.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@SDT", txbPhoneNumber.Text.Trim());
                        cmd.Parameters.AddWithValue("@DiaChi", txbAddress.Text.Trim());

                        // Thực thi thủ tục
                        cmd.ExecuteNonQuery();

                        // Nếu không có lỗi, thông báo thành công
                        MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show($"Lỗi khi cập nhật thông tin: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật thông tin: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmUpdateIn4Employee_Load(object sender, EventArgs e)
        {

        }

        private void pbDisplayPassword_Click(object sender, EventArgs e)
        {
            if (txbPassword.UseSystemPasswordChar)
            {
                txbPassword.UseSystemPasswordChar = false;
                pbDisplayPassword.Image = Properties.Resources.eye_open; // Icon mắt mở
            }
            else
            {
                txbPassword.UseSystemPasswordChar = true;
                pbDisplayPassword.Image = Properties.Resources.eye_close; // Icon mắt đóng
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateEmployeeInfo();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
