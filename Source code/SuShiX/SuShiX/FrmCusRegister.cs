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

        public FrmCusRegister()
        {
            InitializeComponent();
        }

        // Hàm kiểm tra tính unique của thông tin
        private string CheckUnique()
        {
            string connectionString = @"Server=HOANGVU\SQLEXPRESS;Database=QUAN_LY_NHA_HANG;Trusted_Connection=True;";
            string query = @"
                SELECT CASE 
                    WHEN EXISTS (SELECT 1 FROM TaiKhoan WHERE TenTK = @TenTK) THEN 'Tên tài khoản'
                    WHEN EXISTS (SELECT 1 FROM KhachHang WHERE SDT = @SDT) THEN 'Số điện thoại'
                    WHEN EXISTS (SELECT 1 FROM KhachHang WHERE CCCD = @CCCD) THEN 'CCCD'
                    WHEN EXISTS (SELECT 1 FROM KhachHang WHERE Email = @Email) THEN 'Email'
                    ELSE NULL
                END AS ConflictField";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm tham số
                    command.Parameters.AddWithValue("@TenTK", TenTK);
                    command.Parameters.AddWithValue("@SDT", SDT);
                    command.Parameters.AddWithValue("@CCCD", CCCD);
                    command.Parameters.AddWithValue("@Email", Email);

                    connection.Open();
                    object result = command.ExecuteScalar();
                    connection.Close();

                    return result?.ToString(); // Trả về trường bị trùng hoặc NULL nếu không có
                }
            }
        }

        // Hàm đăng ký tài khoản
        private void RegisterUser()
        {
            // Kiểm tra thông tin có bị trùng lặp không
            string conflictField = CheckUnique();

            if (!string.IsNullOrEmpty(conflictField))
            {
                MessageBox.Show($"{conflictField} đã tồn tại. Vui lòng nhập thông tin khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = @"Server=HOANGVU\SQLEXPRESS;Database=QUAN_LY_NHA_HANG;Trusted_Connection=True;";
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
                    SqlParameter outputParam = new SqlParameter
                    {
                        ParameterName = "@MaTK",
                        SqlDbType = SqlDbType.NVarChar,
                        Size = 10,
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputParam);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    // Lấy MaTK được trả về
                    string userId = outputParam.Value.ToString();

                    MessageBox.Show("Đăng ký tài khoản thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Chuyển sang FrmCustomer với userId
                    FrmCustomer customerForm = new FrmCustomer(userId);
                    this.Hide();
                    customerForm.ShowDialog();
                    this.Show();
                    this.Close();
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

            // Gọi hàm đăng ký
            RegisterUser();
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

        }

        private void pbReturn_Click_1(object sender, EventArgs e)
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
