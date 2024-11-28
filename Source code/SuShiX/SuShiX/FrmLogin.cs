using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SuShiX
{
    public partial class FrmLogin : Form
    {
        string userID = ""; // Lưu trữ MaTK
        string username = "";
        string password = "";
        string accountType = "";
        string connectionString = AppConfig.connectionString;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Mở form FrmCusRegister
            FrmCusRegister registerForm = new FrmCusRegister();

            // Ẩn form hiện tại (FrmLogin)
            this.Hide();

            // Hiển thị form FrmCusRegister
            registerForm.ShowDialog();

            // Đóng Form Login
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ các TextBox
            username = txbUsername.Text.Trim();
            password = txbPassword.Text.Trim();

            // Gọi Stored Procedure để kiểm tra thông tin đăng nhập
            string department = "";
            if (ValidateLogin(username, password, ref userID, ref accountType, ref department))
            {
                // Điều hướng đến form phù hợp
                if (accountType == "Khách Hàng")
                {
                    FrmHomepageCustomer customerForm = new FrmHomepageCustomer(userID);
                    this.Hide();
                    customerForm.ShowDialog();
                }
                else if (accountType == "Nhân Viên")
                {
                    if (department == "Quản Lý")
                    {
                        FrmManager managerForm = new FrmManager(userID);
                        this.Hide();
                        managerForm.ShowDialog();
                    }
                    else if (department == "Chủ Chuỗi Nhà Hàng")
                    {
                        FrmAdmin adminForm = new FrmAdmin(userID);
                        this.Hide();
                        adminForm.ShowDialog();
                    }
                    else
                    {
                        FrmEmployee employeeForm = new FrmEmployee(userID);
                        this.Hide();
                        employeeForm.ShowDialog();
                    }
                }

                // Đóng Form Login
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ValidateLogin(string username, string password, ref string userID, ref string accountType, ref string department)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("USP_DangNhap", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số đầu vào
                        command.Parameters.AddWithValue("@TenTK", username);
                        command.Parameters.AddWithValue("@MatKhau", password);

                        // Thêm tham số đầu ra
                        SqlParameter outputMaTK = new SqlParameter("@MaTK", SqlDbType.NVarChar, 10)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputMaTK);

                        SqlParameter outputLoaiTK = new SqlParameter("@LoaiTK", SqlDbType.NVarChar, 50)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputLoaiTK);

                        SqlParameter outputTenBP = new SqlParameter("@TenBP", SqlDbType.NVarChar, 50)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(outputTenBP);

                        // Thực thi Stored Procedure
                        command.ExecuteNonQuery();

                        // Lấy kết quả đầu ra
                        userID = outputMaTK.Value == DBNull.Value ? null : outputMaTK.Value.ToString();
                        accountType = outputLoaiTK.Value == DBNull.Value ? null : outputLoaiTK.Value.ToString();
                        department = outputTenBP.Value == DBNull.Value ? null : outputTenBP.Value.ToString();

                        // Nếu LoaiTK không null, thông tin đăng nhập hợp lệ
                        return userID != null;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Lỗi SQL: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi hệ thống: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return false;
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

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
