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
    public partial class FrmAssignEmployee : Form
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
        public FrmAssignEmployee(string userID, string employeeID)
        {
            InitializeComponent();
            this.UserID = userID;
            this.Width = AppConfig.formWidth;
            this.Height = AppConfig.formHeight;
            this.employeeID = employeeID;
            LoadEmployeeData();
        }

        private void FrmAssignEmployee_Load(object sender, EventArgs e)
        {

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
            AssignEmployee();
        }

        private void LoadEmployeeData()
        {
            // Câu lệnh SQL để lấy tên chi nhánh của quản lý
            string query = "SELECT TenCN FROM ChiNhanh WHERE QuanLy=@MaTK";
            txbEmployeeID.Text = this.employeeID;

            try
            {
                // Kết nối tới database và lấy dữ liệu
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Thêm tham số vào câu lệnh SQL
                        cmd.Parameters.Add(new SqlParameter("@MaTK", SqlDbType.VarChar) { Value = this.userID }); // employeeID là mã quản lý của bạn

                        // Thực thi câu lệnh và lấy kết quả
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Hiển thị tên chi nhánh vào TextBox
                                txbLastBranch.Text = reader["TenCN"].ToString(); // Lấy tên chi nhánh từ kết quả
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy thông tin cho mã quản lý này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Hiển thị lỗi nếu có vấn đề xảy ra
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadComboBoxData();
            dtpStartDate.Value = new DateTime(1900, 1, 1);
            dtpEndDate.Value = new DateTime(1900, 1, 1);
        }

        private void LoadComboBoxData()
        {

            // Câu lệnh SQL để lấy dữ liệu
            string query = "SELECT TenCN FROM ChiNhanh";

            try
            {
                // Kết nối tới database và lấy dữ liệu
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Kiểm tra nếu không có dữ liệu
                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có dữ liệu nào từ bảng ChiNhanh.");
                        return;
                    }

                    // Gán dữ liệu vào ComboBox
                    cbbNewBranch.DataSource = dataTable;
                    cbbNewBranch.DisplayMember = "TenCN";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }
        
        private void AssignEmployee()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Gọi thủ tục cập nhật thông tin khách hàng
                    using (SqlCommand cmd = new SqlCommand("USP_DieuDongNhanVien", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số
                        cmd.Parameters.AddWithValue("@MaTK", this.userID);
                        cmd.Parameters.AddWithValue("@MaTKNV", this.employeeID);
                        cmd.Parameters.AddWithValue("@TenCNMoi", cbbNewBranch.Text.Trim());
                        if (dtpStartDate.Value == new DateTime(1900, 1, 1))
                        {
                            cmd.Parameters.AddWithValue("@NgayBD", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@NgayBD", dtpStartDate.Value);
                        }
                        if (dtpEndDate.Value == new DateTime(1900, 1, 1))
                        {
                            cmd.Parameters.AddWithValue("@NgayKT", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@NgayKT", dtpEndDate.Value);
                        }

                        // Thực thi thủ tục
                        cmd.ExecuteNonQuery();

                        // Nếu không có lỗi, thông báo thành công
                        MessageBox.Show("Điều động nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show($"Lỗi khi điều động nhân viên: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi điều động nhân viên: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
