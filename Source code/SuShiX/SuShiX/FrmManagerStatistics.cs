using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SuShiX
{
    public partial class FrmManagerStatistics : Form
    {
        private string selectedDishName;
        private string userID;
        private string branchName = "";
        private DateTime startDate;
        private DateTime endDate;
        private readonly string connectionString = AppConfig.connectionString;

        public string UserID
        {
            get { return userID; }
            private set { userID = value; }
        }

        public FrmManagerStatistics(string userID)
        {
            InitializeComponent();
            this.userID = userID;

            this.Width = AppConfig.formWidth;
            this.Height = AppConfig.formHeight;

            // Gán giá trị ban đầu cho các biến
            this.startDate = dtpStartDate.Value;
            this.endDate = dtpEndDate.Value;
            this.branchName = txbBranchName.Text;
            LoadBranchName();
            LoadDishList();
        }

        private void LoadBranchName()
        {
            // Câu lệnh SQL truy vấn địa chỉ tất cả chi nhánh thuộc khu vực
            string query = @"
                SELECT CN.TenCN 
                FROM NhanVien NV
                JOIN ChiNhanh CN ON CN.MaCN = NV.MaCN
                WHERE NV.MaTK = @MaTK";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MaTK", userID);  // Truyền tên khu vực vào tham số

                try
                {
                    connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) // Kiểm tra và đọc kết quả trả về
                        {
                            branchName = reader["TenCN"].ToString();
                            txbBranchName.Text = branchName; // Gán tên chi nhánh vào textbox
                            //MessageBox.Show(branchName);
                        }
                        else
                        {
                            txbBranchName.Text = ""; // Xóa nội dung nếu không có dữ liệu
                            MessageBox.Show("Không tìm thấy chi nhánh nào thuộc tài khoản này.",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải dữ liệu địa chỉ chi nhánh: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadDishList()
        {
            string query = @"
                SELECT DISTINCT ma.TenMA
                FROM NhanVien nv
                JOIN ThucDon td ON td.MaCN = nv.MaCN
                JOIN MonAn ma ON ma.MaMA = td.MaMA
                WHERE nv.MaTK = @MaTK
            ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MaTK", userID); // Sử dụng userID làm tham số MaTK
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dtDish = new DataTable();
                        dtDish.Load(reader);

                        List<string> dishes = new List<string>();
                        dishes.Add("");
                        foreach (DataRow row in dtDish.Rows)
                        {
                            foreach (DataColumn column in dtDish.Columns)
                            {
                                if (column.ColumnName == "TenMA")
                                {
                                    Console.WriteLine($"{column.ColumnName}: {row[column]}");
                                    dishes.Add(row[column].ToString());
                                    //MessageBox.Show(row[column].ToString());
                                }
                            }
                        }
                        cbbDishName.DataSource = dishes;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải danh sách món ăn: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadBranchStatistics()
        {
           // MessageBox.Show($"UserID: {userID}, StartDate: {startDate}, EndDate: {endDate}, DishName: {selectedDishName}");

            //string procedureName = @"EXEC USP_QuanLyThongKe @MaTK,@NgayBD,@NgayKT,@TenMA,@TongSoLuongBan,@TongDoanhThu";
            string procedureName = @"USP_QuanLyThongKe";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(procedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số đầu vào
                    command.Parameters.AddWithValue("@MaTK", userID);
                    command.Parameters.AddWithValue("@NgayBD", startDate);
                    command.Parameters.AddWithValue("@NgayKT", endDate);

                    if (string.IsNullOrEmpty(selectedDishName))
                    {
                        command.Parameters.AddWithValue("@TenMA", DBNull.Value); // Nếu không có món ăn chọn
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@TenMA", selectedDishName); // Truyền Tên Món Ăn
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
                            dgvStatistics.DataSource = dtStatistics;
                        }

                        // Kiểm tra totalAmountParam.Value trước khi gán giá trị
                        if (totalAmountParam.Value != DBNull.Value)
                        {
                            txbTotalAmount.Text = totalAmountParam.Value.ToString();
                        }
                        else
                        {
                            txbTotalAmount.Text = "0"; // Giá trị mặc định khi NULL
                        }

                        // Kiểm tra totalRevenueParam.Value trước khi chuyển đổi và gán giá trị
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

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            startDate = dtpStartDate.Value;
          //  LoadBranchStatistics();
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            endDate = dtpEndDate.Value;
          //  LoadBranchStatistics();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmManager frmManager = new FrmManager(userID);
            this.Hide();
            frmManager.ShowDialog();
            this.Close();
        }

        
        private void dgvStatistics_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //foreach (DataGridViewColumn column in dgvStatistics.Columns)
            //{
            //    MessageBox.Show(column.Name);  // Hiển thị tất cả các tên cột
            //}
            if (dgvStatistics.Columns.Contains("DishName"))
            {
            // Kiểm tra xem có phải là cột "Tên Món" và đảm bảo có chỉ số dòng hợp lệ
                if (e.ColumnIndex == dgvStatistics.Columns["DishName"].Index && e.RowIndex >= 0)
                {
                    var cell = dgvStatistics.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewComboBoxCell;

                    if (cell != null && cell.Value != null)
                    {
                        selectedDishName = cell.Value.ToString();

                    }
                }
            }

        }

        private void dgvStatistics_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedDishName = cbbDishName.SelectedItem.ToString();
        }

        private void lblBranchName_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadBranchStatistics();
        }
    }
}
