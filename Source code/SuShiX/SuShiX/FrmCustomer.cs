using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SuShiX
{
    public partial class FrmCustomer : Form
    {
        // Biến private lưu trữ userID
        private string userID;

        // Connection string cho cơ sở dữ liệu
        private readonly string connectionString = @"Server=HOANGVU\SQLEXPRESS;Database=QUAN_LY_NHA_HANG;Trusted_Connection=True;";

        // Getter để chỉ cho phép đọc userID từ bên ngoài nếu cần
        public string UserID
        {
            get { return userID; }
            private set { userID = value; }
        }

        public FrmCustomer()
        {
            InitializeComponent();
        }

        // Constructor nhận userID khi khởi tạo form
        public FrmCustomer(string userID)
        {
            InitializeComponent();
            this.UserID = userID;

            // Sử dụng userID để thực hiện các tác vụ
            LoadCustomerData();
        }

        // Hàm tải dữ liệu khách hàng dựa trên userID
        private void LoadCustomerData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Tạo đối tượng SqlCommand để gọi thủ tục
                    using (SqlCommand cmd = new SqlCommand("USP_XemThongTinKhachHang", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số @MaTK
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
                                txbFullName.Text = reader["HoTen"].ToString();
                                txbPhoneNumber.Text = reader["SDT"].ToString();
                                txbEmail.Text = reader["Email"].ToString();
                                txbIdNumber.Text = reader["CCCD"].ToString();
                                cbbGender.Text = reader["GioiTinh"].ToString();
                                txbCardNumber.Text = reader["MaThe"].ToString();
                                txbCertifiedDate.Text = reader["NgayLap"] != DBNull.Value ? Convert.ToDateTime(reader["NgayLap"]).ToString("dd/MM/yyyy") : "";
                                txbStartedCycle.Text = reader["NgayBDChuKy"] != DBNull.Value ? Convert.ToDateTime(reader["NgayBDChuKy"]).ToString("dd/MM/yyyy") : "";
                                txbTotalPoint.Text = reader["TongDiem"].ToString();
                                txbReservedPoint.Text = reader["TongDiemDuyTri"].ToString();
                                txbCardType.Text = reader["TenLoaiThe"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy thông tin khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        // Hàm cập nhật thông tin khách hàng
        private void UpdateCustomerInfo()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Kiểm tra tính duy nhất của các thuộc tính trước khi cập nhật
                    if (!IsUniqueValue(conn, "TaiKhoan", "TenTK", txbUsername.Text.Trim(), userID))
                    {
                        MessageBox.Show("Tên tài khoản đã tồn tại, vui lòng chọn tên khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (!IsUniqueValue(conn, "KhachHang", "SDT", txbPhoneNumber.Text.Trim(), userID))
                    {
                        MessageBox.Show("Số điện thoại đã tồn tại, vui lòng chọn số khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (!IsUniqueValue(conn, "KhachHang", "Email", txbEmail.Text.Trim(), userID))
                    {
                        MessageBox.Show("Email đã tồn tại, vui lòng chọn email khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (!IsUniqueValue(conn, "KhachHang", "CCCD", txbIdNumber.Text.Trim(), userID))
                    {
                        MessageBox.Show("CCCD đã tồn tại, vui lòng chọn CCCD khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Nếu không có trùng lặp, tiến hành cập nhật thông tin
                    using (SqlCommand cmd = new SqlCommand("USP_CapNhatThongTinKhachHang", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số
                        cmd.Parameters.AddWithValue("@MaTK", userID);
                        cmd.Parameters.AddWithValue("@TenTK", txbUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@MatKhau", txbPassword.Text.Trim());
                        cmd.Parameters.AddWithValue("@HoTen", txbFullName.Text.Trim());
                        cmd.Parameters.AddWithValue("@SDT", txbPhoneNumber.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", txbEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@CCCD", txbIdNumber.Text.Trim());
                        cmd.Parameters.AddWithValue("@GioiTinh", cbbGender.SelectedItem.ToString());

                        // Thực thi thủ tục
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật thông tin: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hàm kiểm tra tính duy nhất
        private bool IsUniqueValue(SqlConnection conn, string tableName, string columnName, string value, string currentUserID)
        {
            try
            {
                string query = $@"
                    SELECT COUNT(*)
                    FROM {tableName}
                    WHERE {columnName} = @Value AND MaTK != @CurrentUserID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Value", value);
                    cmd.Parameters.AddWithValue("@CurrentUserID", currentUserID);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count == 0; // True nếu không có bản ghi trùng lặp
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi kiểm tra tính duy nhất của {columnName}: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Sự kiện nhấn vào nút cập nhật
        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            UpdateCustomerInfo();
        }

        // Sự kiện nhấn vào icon hiển thị/ẩn mật khẩu
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
    }
}
