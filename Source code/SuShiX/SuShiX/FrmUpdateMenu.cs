using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SuShiX
{
    public partial class FrmUpdateMenu : Form
    {
        // Biến private lưu trữ userID
        private string userID;
        // Connection string cho cơ sở dữ liệu
        private string connectionString = AppConfig.connectionString;

        private HashSet<int> changedRows = new HashSet<int>(); // Lưu các dòng đã thay đổi

        public string UserID
        {
            get { return userID; }
            private set { userID = value; }
        }


        public FrmUpdateMenu(string userID)
        {
            InitializeComponent();
            this.UserID = userID;
            dgvMenu.RowHeadersVisible = false;
            LoadArea();
            LoadDataToGridView(); // Load dữ liệu ban đầu
            AddComboBoxToGridView();
            AdjustGridViewEditMode();
        }

        private void LoadArea()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT TenKV, MaKV FROM KhuVuc";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        dt.Columns.Add("TenKV", typeof(string));
                        dt.Rows.Add("Tất cả");

                        DataTable dbData = new DataTable();
                        adapter.Fill(dbData);
                        foreach (DataRow row in dbData.Rows)
                        {
                            dt.Rows.Add(row["TenKV"]);
                        }

                        cbbAreaName.DataSource = dt;
                        cbbAreaName.DisplayMember = "TenKV";
                        cbbAreaName.ValueMember = "TenKV";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải khu vực: " + ex.Message);
            }
        }

        private void LoadDataToGridView()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT TenMA, GiaHienTai, TinhTrangMonAn, TenMuc 
                                    FROM MonAn join Muc on MonAn.MaMuc=Muc.MaMuc";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        // Thêm cột ẩn lưu giá trị TenMA gốc
                        if (!dt.Columns.Contains("OriginalTenMA"))
                            dt.Columns.Add("OriginalTenMA", typeof(string));

                        foreach (DataRow row in dt.Rows)
                        {
                            row["OriginalTenMA"] = row["TenMA"];
                        }

                        dgvMenu.DataSource = dt;

                        // Ẩn cột OriginalTenMA
                        dgvMenu.Columns["OriginalTenMA"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void LoadDataAreaToGridView(string areaName)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT DISTINCT TenMA, GiaHienTai, N'Có' AS TinhTrangMonAn, TenMuc
                                    FROM ThucDon TD
                                    JOIN MonAn MA ON TD.MaMA = MA.MaMA
                                    JOIN ChiNhanh CN ON TD.MaCN = CN.MaCN
                                    JOIN KhuVuc KV ON KV.MaKV = CN.MaKV
                                    JOIN Muc on MA.MaMuc=Muc.MaMuc
                                    WHERE KV.TenKV = @AreaName
                                UNION 
                                    SELECT DISTINCT TenMA, GiaHienTai, N'Không' AS TinhTrangMonAn, TenMuc
                                    FROM MonAn MA JOIN Muc on MA.MaMuc=Muc.MaMuc
                                    WHERE MA.MaMA NOT IN (SELECT MA.MaMA
                                                        FROM ThucDon TD
                                                        JOIN MonAn MA ON TD.MaMA = MA.MaMA
                                                        JOIN ChiNhanh CN ON TD.MaCN = CN.MaCN
                                                        JOIN KhuVuc KV ON KV.MaKV = CN.MaKV
                                                        WHERE KV.TenKV = @AreaName)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@AreaName", areaName);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            // Thêm cột ẩn lưu giá trị TenMA gốc
                            if (!dt.Columns.Contains("OriginalTenMA"))
                                dt.Columns.Add("OriginalTenMA", typeof(string));

                            foreach (DataRow row in dt.Rows)
                            {
                                row["OriginalTenMA"] = row["TenMA"];
                            }

                            dgvMenu.DataSource = dt;

                            // Ẩn cột OriginalTenMA
                            dgvMenu.Columns["OriginalTenMA"].Visible = false;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu theo khu vực: " + ex.Message);
            }
        }



        private void cbbAreaName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedArea = cbbAreaName.SelectedValue.ToString();
            if (selectedArea == "Tất cả")
                LoadDataToGridView();
            else
                LoadDataAreaToGridView(selectedArea);
        }

        private void btnAddNewDish_Click(object sender, EventArgs e)
        {
            FrmAddNewDish frmAddDish = new FrmAddNewDish(this);
            if (frmAddDish.ShowDialog() == DialogResult.OK)
            {
                LoadDataToGridView(); // Reload dữ liệu
            }
        }

        private void FrmUpdateMenu_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }

        private void AddComboBoxToGridView()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT TenMuc FROM Muc";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Tạo ComboBox column
                        DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
                        comboBoxColumn.DataSource = dt;
                        comboBoxColumn.DisplayMember = "TenMuc";
                        comboBoxColumn.HeaderText = "Tên Mục";
                        comboBoxColumn.Name = "TenMuc";
                        comboBoxColumn.DataPropertyName = "TenMuc";

                        // Thêm cột vào dgvMenu
                        dgvMenu.Columns.Remove("TenMuc"); // Xóa cột cũ nếu đã tồn tại
                        dgvMenu.Columns.Add(comboBoxColumn);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm ComboBox: " + ex.Message);
            }
        }


        private void AdjustGridViewEditMode()
        {
            string selectedArea = cbbAreaName.SelectedValue.ToString();
            bool isEditable = selectedArea == "Tất cả";

            // Điều chỉnh quyền chỉnh sửa cho từng cột
            dgvMenu.Columns["TenMA"].ReadOnly = !isEditable;
            dgvMenu.Columns["GiaHienTai"].ReadOnly = !isEditable;
            dgvMenu.Columns["TinhTrangMonAn"].ReadOnly = false; // Luôn cho phép chỉnh sửa
            dgvMenu.Columns["TenMuc"].ReadOnly = !isEditable;
        }
        private void dgvMenu_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Đánh dấu dòng đã thay đổi
                changedRows.Add(e.RowIndex);
            }
        }


        private void btnEditMenu_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Xóa dữ liệu cũ trong bảng TempMenu (nếu có)
                    string deleteTempTableQuery = "DELETE FROM TempMenu;";
                    using (SqlCommand cmd = new SqlCommand(deleteTempTableQuery, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    // Chèn dữ liệu từ DataGridView vào TempMenu
                    foreach (int rowIndex in changedRows)
                    {
                        DataGridViewRow row = dgvMenu.Rows[rowIndex];

                        string originalTenMA = row.Cells["OriginalTenMA"].Value?.ToString();
                        string newTenMA = row.Cells["TenMA"].Value?.ToString();
                        string giaHienTai = row.Cells["GiaHienTai"].Value?.ToString();
                        string tinhTrang = row.Cells["TinhTrangMonAn"].Value?.ToString();
                        string tenMuc = row.Cells["TenMuc"].Value?.ToString();

                        string insertQuery = @"
                    INSERT INTO TempMenu (OriginalTenMA, NewTenMA, GiaHienTai, TinhTrangMonAn, TenMuc)
                    VALUES (@OriginalTenMA, @NewTenMA, @GiaHienTai, @TinhTrangMonAn, @TenMuc)";
                        using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@OriginalTenMA", originalTenMA);
                            cmd.Parameters.AddWithValue("@NewTenMA", newTenMA);
                            cmd.Parameters.AddWithValue("@GiaHienTai", Convert.ToDecimal(giaHienTai));
                            cmd.Parameters.AddWithValue("@TinhTrangMonAn", tinhTrang);
                            cmd.Parameters.AddWithValue("@TenMuc", tenMuc);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Gọi Stored Procedure
                    using (SqlCommand cmd = new SqlCommand("USP_UpdateMenu", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@AreaName", cbbAreaName.SelectedValue.ToString());
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Lưu thay đổi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reload dữ liệu từ database
                    LoadDataToGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu thay đổi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}

