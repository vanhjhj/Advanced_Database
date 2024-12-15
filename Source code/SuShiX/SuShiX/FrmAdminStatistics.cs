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
    public partial class FrmAdminStatistics : Form
    {
        private string selectedArea = "";        // Biến lưu khu vực đã chọn
        private string selectedBranchName = "";  // Biến lưu chi nhánh đã chọn
        private string userID;                   // Biến lưu ID người dùng
        private DateTime startDate;              // Biến lưu ngày bắt đầu
        private DateTime endDate;                // Biến lưu ngày kết thúc
        private readonly string connectionString = AppConfig.connectionString;  // Chuỗi kết nối đến CSDL

        public string UserID
        {
            get { return userID; }
            private set { userID = value; }
        }

        public FrmAdminStatistics(string userID)
        {
            InitializeComponent();
            this.userID = userID;

            // Thiết lập kích thước form
            this.Width = AppConfig.formWidth;
            this.Height = AppConfig.formHeight;

            // Gán giá trị ban đầu cho các biến ngày tháng
            this.startDate = dtpStartDate.Value;
            this.endDate = dtpEndDate.Value;

            // Tải danh sách khu vực và chi nhánh
            LoadListBranchArea();
            LoadListBranchName();
        }

        // Tải danh sách khu vực từ CSDL
        private void LoadListBranchArea()
        {
            string query = @"
            SELECT TenKV
            FROM KhuVuc
            ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dtArea = new DataTable();
                        dtArea.Load(reader);

                        List<string> area = new List<string> { "Tất cả" };  // Thêm "All" vào đầu danh sách
                        foreach (DataRow row in dtArea.Rows)
                        {
                            area.Add(row["TenKV"].ToString());
                        }

                        cbbArea.DataSource = area;  // Gán dữ liệu vào combobox khu vực
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải danh sách khu vực: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Tải danh sách chi nhánh từ CSDL
        private void LoadListBranchName()
        {
            string query = @"
            SELECT cn.TenCN
            FROM ChiNhanh cn
            JOIN KhuVuc kv ON kv.MaKV = cn.MaKV
            WHERE (@TenKV IS NULL OR kv.TenKV LIKE @TenKV)
            ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    if (string.IsNullOrEmpty(selectedArea))
                        cmd.Parameters.AddWithValue("TenKV", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@TenKV", selectedArea);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dtBranchName = new DataTable();
                            dtBranchName.Load(reader);

                            List<string> branch = new List<string> { "Tất cả" };  // Thêm "All" vào đầu danh sách
                            foreach (DataRow row in dtBranchName.Rows)
                            {
                                branch.Add(row["TenCN"].ToString());
                            }

                            cbbBranchName.DataSource = branch;  // Gán dữ liệu vào combobox chi nhánh
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi tải danh sách chi nhánh: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Tải thống kê từ CSDL
        private void LoadStatistics()
        {
            //MessageBox.Show($"UserID: {userID}, StartDate: {startDate}, EndDate: {endDate}, Area: {selectedArea}, BranchName: {selectedBranchName}");

            string procedureName = @"USP_QuanLyThongKeBoiAdmin"; // Tên thủ tục trong CSDL
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(procedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số đầu vào cho thủ tục
                    command.Parameters.AddWithValue("@MaTK", userID);
                    command.Parameters.AddWithValue("@NgayBD", startDate);
                    command.Parameters.AddWithValue("@NgayKT", endDate);

                    // Thêm tham số cho khu vực
                    if (string.IsNullOrEmpty(selectedArea))
                    {
                        command.Parameters.AddWithValue("@TenKV", DBNull.Value); // Nếu không có khu vực chọn
                    }
                    else if (selectedArea == "Tất cả")
                    {
                        command.Parameters.AddWithValue("@TenKV", DBNull.Value); // Nếu chọn "Tất cả"
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@TenKV", selectedArea); // Truyền Khu Vực
                    }

                    // Thêm tham số cho chi nhánh
                    if (string.IsNullOrEmpty(selectedBranchName))
                    {
                        command.Parameters.AddWithValue("@TenCN", DBNull.Value); // Nếu không có chi nhánh chọn
                    }
                    else if (selectedBranchName == "Tất cả")
                    {
                        command.Parameters.AddWithValue("@TenCN", DBNull.Value); // Nếu chọn "Tất cả"
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@TenCN", selectedBranchName); // Truyền Tên Chi Nhánh
                    }

                    // Thêm tham số đầu ra
                    SqlParameter totalAmountParam = new SqlParameter
                    {
                        ParameterName = "@TongSoLuongBan",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(totalAmountParam);

                    SqlParameter totalRevenueParam = new SqlParameter
                    {
                        ParameterName = "@TongDoanhThu",
                        SqlDbType = SqlDbType.BigInt,
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(totalRevenueParam);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        { 
                            DataTable dtStatistics = new DataTable();
                            dtStatistics.Load(reader);
                            dgvStatistics.DataSource = dtStatistics; // Gán dữ liệu vào DataGridView

                        }

                        if (totalAmountParam.Value != DBNull.Value)
                        {
                            txbTotalAmount.Text = totalAmountParam.Value.ToString();
                        }
                        else
                        {
                            txbTotalAmount.Text = "0"; // Giá trị mặc định khi NULL
                        }

                        // Kiểm tra và gán giá trị cho tổng doanh thu
                        if (totalRevenueParam.Value != DBNull.Value)
                        {
                            txbTotalRevenue.Text = Convert.ToInt64(totalRevenueParam.Value).ToString("N0") + " VNĐ";
                        }
                        else
                        {
                            txbTotalRevenue.Text = "0 VNĐ"; // Giá trị mặc định khi NULL
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi tải dữ liệu thống kê: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        // Khi người dùng chọn khu vực từ combobox
        private void cbbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedArea = cbbArea.SelectedItem.ToString();
            LoadListBranchName();
        }

        // Khi người dùng chọn chi nhánh từ combobox
        private void cbbBranchName_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedBranchName = cbbBranchName.SelectedItem.ToString();
        }

        // Khi người dùng nhấn nút "Xem thống kê"
        private void button1_Click(object sender, EventArgs e)
        {
            LoadStatistics();  
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            startDate = dtpStartDate.Value;
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            endDate = dtpEndDate.Value;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmAdmin frmAdmin = new FrmAdmin(userID);
            this.Hide();
            frmAdmin.ShowDialog();
            this.Close();
        }



        //private void pictureBox1_Click(object sender, EventArgs e)
        //{
        //    FrmManager frmAdmin = new FrmAdmin(userID);
        //    this.Hide();
        //    frmAdmin.ShowDialog();
        //    this.Close();
        //}
    }
}
