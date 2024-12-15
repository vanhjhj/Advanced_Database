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
    public partial class FrmUpdateMenu : Form
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

        public FrmUpdateMenu(string userID)
        {
            InitializeComponent();
            this.UserID = userID;
            this.Width = AppConfig.formWidth;
            this.Height = AppConfig.formHeight;
            dgvMenu.RowHeadersVisible = false;
            LoadArea();
        }

        private void LoadArea()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Lấy dữ liệu từ bảng KhuVuc
                    string query = "SELECT DISTINCT TenKV FROM KhuVuc";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();

                            // Thêm giá trị mặc định "Tất cả" vào DataTable
                            dt.Columns.Add("TenKV", typeof(string));
                            dt.Rows.Add("Tất cả");

                            // Nạp dữ liệu từ CSDL
                            DataTable dbData = new DataTable();
                            adapter.Fill(dbData);

                            // Ghép dữ liệu từ CSDL vào DataTable đã có giá trị mặc định
                            foreach (DataRow row in dbData.Rows)
                            {
                                dt.Rows.Add(row["TenKV"]);
                            }

                            // Gán DataTable vào ComboBox
                            cbbAreaName.DataSource = dt;
                            cbbAreaName.DisplayMember = "TenKV"; // Hiển thị tên khu vực
                            cbbAreaName.ValueMember = "TenKV";   // Giá trị tương ứng
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void cbbAreaName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedArea = cbbAreaName.SelectedValue.ToString(); // Lấy giá trị được chọn

            if (selectedArea == "Tất cả")
            {
                LoadDataToGridView(); // Load toàn bộ dữ liệu
            }
            else
            {
                LoadDataAreaToGridView(selectedArea); // Load danh sách chi nhánh theo khu vực
            }
        }



        private void LoadDataToGridView()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Lấy dữ liệu từ bảng KhuVuc
                    string query = "SELECT TenMA,GiaHienTai,TinhTrangMonAn,MaMuc FROM MonAn";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvMenu.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void LoadDataAreaToGridView(string AreaName)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Lấy dữ liệu từ bảng KhuVuc
                    string query = @"SELECT DISTINCT TenMA, GiaHienTai, N'Có' AS TinhTrangMonAn, MaMuc
                                    FROM ThucDon TD
                                    JOIN MonAn MA ON TD.MaMA = MA.MaMA
                                    JOIN ChiNhanh CN ON TD.MaCN = CN.MaCN
                                    JOIN KhuVuc KV ON KV.MaKV = CN.MaKV
                                    WHERE KV.TenKV = @AreaName
                                UNION 
                                SELECT DISTINCT TenMA, GiaHienTai, N'Không' AS TinhTrangMonAn, MaMuc
                                    FROM MonAn MA
                                    WHERE MA.MaMA NOT IN (SELECT MA.MaMA
                                                        FROM ThucDon TD
                                                        JOIN MonAn MA ON TD.MaMA = MA.MaMA
                                                        JOIN ChiNhanh CN ON TD.MaCN = CN.MaCN
                                                        JOIN KhuVuc KV ON KV.MaKV = CN.MaKV
                                                        WHERE KV.TenKV = @AreaName)";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Gán giá trị cho tham số @AreaName
                        cmd.Parameters.AddWithValue("@AreaName", AreaName);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvMenu.DataSource = dt; // Gán dữ liệu vào DataGridView
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void lblEndDate_Click(object sender, EventArgs e)
        {

        }

        private void pnlStatisticsInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblBranchName_Click(object sender, EventArgs e)
        {

        }

        private void FrmUpdateMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
