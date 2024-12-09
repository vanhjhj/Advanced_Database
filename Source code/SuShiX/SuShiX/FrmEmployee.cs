using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SuShiX
{
    public partial class FrmEmployee : Form
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

        // Constructor nhận userID khi khởi tạo form
        public FrmEmployee(string userID)
        {
            InitializeComponent();
            this.UserID = userID;
            this.Width = AppConfig.formWidth;
            this.Height = AppConfig.formHeight;

            // Sử dụng userID để thực hiện các tác vụ
           // LoadEmployeeData();
        }

        // Hàm tải dữ liệu Employee dựa trên userID
        private void LoadEmployeeData()
        {
            MessageBox.Show($"Chào mừng Nhân Viên với ID: {UserID}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Ví dụ truy vấn dữ liệu nhân viên bằng userID
            // string query = $"SELECT * FROM NhanVien WHERE MaTK = '{UserID}'";
            // Thực thi truy vấn và hiển thị dữ liệu
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmEmployeeOrder frmEmployeeOrder = new FrmEmployeeOrder(userID);
            frmEmployeeOrder.ShowDialog();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            this.Close();
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmUpdateOrders frmUpdateOrders = new FrmUpdateOrders(userID);
            frmUpdateOrders.ShowDialog();
            this.Close();
        }

        private void btnCreateCard_Click(object sender, EventArgs e)
        {
            FrmCreateAndReissueCard frmCreateAndReissueCard = new FrmCreateAndReissueCard();

            if(frmCreateAndReissueCard.ShowDialog() == DialogResult.OK)
            {
                string userName = frmCreateAndReissueCard.userName;

                //Gọi procedure tạo thẻ

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlCommand cmd = new SqlCommand("USP_DangKyTheThanhVien", connection))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@TenTKKH", userName);
                            cmd.Parameters.AddWithValue("@TkLap", userID);

                            SqlParameter outputMaThe = new SqlParameter("@MaThe", SqlDbType.VarChar, 10)
                            {
                                Direction = ParameterDirection.Output
                            };
                            cmd.Parameters.Add(outputMaThe);

                            cmd.ExecuteNonQuery();

                            string cardID = outputMaThe.Value.ToString();
                            MessageBox.Show($"Tạo thẻ thành công, mã thẻ: {cardID}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReissueCard_Click(object sender, EventArgs e)
        {
            FrmCreateAndReissueCard frmCreateAndReissueCard = new FrmCreateAndReissueCard();

            if (frmCreateAndReissueCard.ShowDialog() == DialogResult.OK)
            {
                string userName = frmCreateAndReissueCard.userName;

                //Gọi procedure cấp lại thẻ

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlCommand cmd = new SqlCommand("USP_CapLaiTheThanhVien", connection))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@TenTKKH", userName);
                            cmd.Parameters.AddWithValue("@TkLap", userID);

                            SqlParameter outputMaThe = new SqlParameter("@MaThe", SqlDbType.VarChar, 10)
                            {
                                Direction = ParameterDirection.Output
                            };
                            cmd.Parameters.Add(outputMaThe);

                            cmd.ExecuteNonQuery();

                            string cardID = outputMaThe.Value.ToString();
                            MessageBox.Show($"Cấp lại thẻ thành công, mã thẻ: {cardID}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdateIn4_Click(object sender, EventArgs e)
        {

        }
        private void btnUpdateCardRank_Click(object sender, EventArgs e)
        {
            //gọi procedue cập nhật hạng thẻ
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("USP_CapNhatHangTheThanhVien", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaTK", userID);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật hạng thẻ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
