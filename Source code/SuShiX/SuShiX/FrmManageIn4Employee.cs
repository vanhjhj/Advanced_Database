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
    public partial class FrmManageIn4Employee : Form
    {
        // Biến private lưu trữ userID
        private string userID;

        // Connection string cho cơ sở dữ liệu
        private string connectionString = AppConfig.connectionString;

        //Biến private lưu trữ mã nhân viên
        private string employeeID;

        // Getter để chỉ cho phép đọc userID từ bên ngoài nếu cần
        public string UserID
        {
            get { return userID; }
            private set { userID = value; }
        }

        public FrmManageIn4Employee(string userID, string employeeID)
        {
            InitializeComponent();
            this.UserID = userID;
            this.Width = AppConfig.formWidth;
            this.Height = AppConfig.formHeight;
            this.employeeID = employeeID;
            LoadEmployeeData();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmManageEmployee frmManageEmployee = new FrmManageEmployee(userID);
            this.Hide();
            frmManageEmployee.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateEmployeeInfo();
        }

        private void LoadEmployeeData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Tạo đối tượng SqlCommand để gọi thủ tục
                    using (SqlCommand cmd = new SqlCommand("USP_XemThongTinNhanVienTuQuanLy", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số @MaTK
                        cmd.Parameters.Add(new SqlParameter("@MaTK", SqlDbType.NVarChar)
                        {
                            Value = this.employeeID
                        });

                        // Thực thi lệnh và lấy dữ liệu
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txbEmployeeID.Text = this.employeeID;
                                txbFullName.Text = reader["Hoten"].ToString();
                                dtpDateOfBirth.Value = reader["NgaySinh"] != DBNull.Value ? Convert.ToDateTime(reader["NgaySinh"]) : new DateTime(1900, 1, 1);
                                cbbGender.Text = reader["GioiTinh"].ToString();
                                txbPhoneNumber.Text = reader["SDT"].ToString();
                                dtpStartDate.Value = reader["NgayVaoLam"] != DBNull.Value ? Convert.ToDateTime(reader["NgayVaoLam"]) : new DateTime(1900, 1, 1);
                                dtpEndDate.Value = reader["NgayNghiViec"] != DBNull.Value ? Convert.ToDateTime(reader["NgayNghiViec"]) : new DateTime(1900, 1, 1);
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
                    using (SqlCommand cmd = new SqlCommand("USP_CapNhatThongTinNhanVienTuQuanLy", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số
                        cmd.Parameters.AddWithValue("@MaTK", this.employeeID);
                        cmd.Parameters.AddWithValue("@Hoten", txbFullName.Text.Trim());
                        cmd.Parameters.AddWithValue("@NgaySinh", dtpDateOfBirth.Value);
                        cmd.Parameters.AddWithValue("@GioiTinh", cbbGender.SelectedItem.ToString());
                        if (dtpEndDate.Value == new DateTime(1900, 1, 1))
                        {
                            cmd.Parameters.AddWithValue("@NgayNghiViec", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@NgayNghiViec", dtpEndDate.Value);
                        }
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

        private void FrmManageIn4Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            //close parent form
            this.Owner.Close();
            this.Close();
        }
    }
}
