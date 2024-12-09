using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SuShiX
{
    public partial class FrmCusRegister : Form
    {
        // Các thuộc tính để lưu trữ dữ liệu nhập vào
        private string TenTK;
        private string MatKhau;
        private string HoTen;
        private string SDT;
        private string GioiTinh;
        private string CCCD;
        private string Email;
        private string connectionString = AppConfig.connectionString;

        public FrmCusRegister()
        {
            InitializeComponent();
            this.Width = AppConfig.formWidth;
            this.Height = AppConfig.formHeight;
        }

        // Hàm đăng ký tài khoản
        private void RegisterUser()
        {
            // Khai báo tham số để nhận kết quả từ stored procedure
            string procedureName = "USP_DangKy";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(procedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số
                    command.Parameters.AddWithValue("@TenTK", TenTK);
                    command.Parameters.AddWithValue("@MatKhau", MatKhau);
                    command.Parameters.AddWithValue("@HoTen", HoTen);
                    command.Parameters.AddWithValue("@SDT", SDT);
                    command.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                    command.Parameters.AddWithValue("@CCCD", CCCD);
                    command.Parameters.AddWithValue("@Email", Email);

                    // Thêm tham số output để nhận MaTK
                    SqlParameter outputMaTK = new SqlParameter
                    {
                        ParameterName = "@MaTK",
                        SqlDbType = SqlDbType.NVarChar,
                        Size = 10,
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputMaTK);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                        // Lấy MaTK được trả về
                        string userId = outputMaTK.Value.ToString();

                        MessageBox.Show("Đăng ký tài khoản thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (SqlException ex)
                    {
                        // Xử lý lỗi ném ra từ THROW
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        // Hàm xử lý sự kiện nhấn nút Đăng Ký
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Gán dữ liệu từ giao diện vào các thuộc tính
            TenTK = txbUsername.Text.Trim();
            MatKhau = txbPassword.Text.Trim();
            HoTen = txbFullname.Text.Trim();
            SDT = txbTelephone.Text.Trim();
            GioiTinh = cbbGender.SelectedItem != null ? cbbGender.SelectedItem.ToString() : "";
            CCCD = txbIdNumber.Text.Trim();
            Email = txbEmail.Text.Trim();

            // Kiểm tra các trường không được bỏ trống
            if (string.IsNullOrEmpty(TenTK) || string.IsNullOrEmpty(MatKhau) || string.IsNullOrEmpty(HoTen) ||
                string.IsNullOrEmpty(SDT) || string.IsNullOrEmpty(GioiTinh) || string.IsNullOrEmpty(CCCD) ||
                string.IsNullOrEmpty(Email))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem mật khẩu và nhập lại mật khẩu có khớp không
            if (MatKhau != txbPassword1.Text.Trim())
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Gọi hàm đăng ký
            RegisterUser();

            // Chuyển sang FrmLogin
            FrmLogin frmLogin = new FrmLogin();
            this.Hide();
            frmLogin.ShowDialog();
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

        private void pbDisplayPassword1_Click(object sender, EventArgs e)
        {
            if (txbPassword1.UseSystemPasswordChar)
            {
                txbPassword1.UseSystemPasswordChar = false;
                pbDisplayPassword1.Image = Properties.Resources.eye_open;
            }
            else
            {
                txbPassword1.UseSystemPasswordChar = true;
                pbDisplayPassword1.Image = Properties.Resources.eye_close;
            }
        }

        private void pbReturn_Click(object sender, EventArgs e)
        {
            //Open login form
            FrmLogin loginForm = new FrmLogin();

            //Hide register form
            this.Hide();

            //Show login form
            loginForm.ShowDialog();
        }
    }
}