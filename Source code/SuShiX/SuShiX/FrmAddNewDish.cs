using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SuShiX
{
    public partial class FrmAddNewDish : Form
    {
        private string connectionString = AppConfig.connectionString;
        private FrmUpdateMenu parentForm;
        private string maMuc;

        public FrmAddNewDish(FrmUpdateMenu parent)
        {
            InitializeComponent();
            this.parentForm = parent;
            LoadComboBoxTenMuc();
            LoadAreaList();
        }
       
        // Load dữ liệu vào ComboBox
        private void LoadComboBoxTenMuc()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT MaMuc, TenMuc FROM Muc";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        cbbTenMuc.DataSource = dt;
                        cbbTenMuc.DisplayMember = "TenMuc"; // Hiển thị Tên Mục
                        cbbTenMuc.ValueMember = "MaMuc";   // Giá trị MaMuc
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load Tên Mục: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAreaList()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT MaKV, TenKV FROM KhuVuc";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Gán dữ liệu vào CheckedListBox
                        clbAreaList.DataSource = dt;
                        clbAreaList.DisplayMember = "TenKV";
                        clbAreaList.ValueMember = "MaKV";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải khu vực: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Sự kiện khi chọn Tên Mục trong ComboBox
        private void cbbTenMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTenMuc.SelectedValue != null)
            {
                maMuc = cbbTenMuc.SelectedValue.ToString();
            }
            else
            {
                maMuc = null;
            }
        }

        // Xử lý thêm món ăn mới
        private void btnOK_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(txbTenMA.Text) ||
                !int.TryParse(txbGiaHienTai.Text, out int giaHienTai) ||
                string.IsNullOrEmpty(maMuc))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin và chọn Tên Mục!",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy danh sách các khu vực đã chọn
            List<string> selectedAreas = new List<string>();
            foreach (DataRowView item in clbAreaList.CheckedItems)
            {
                selectedAreas.Add(item["MaKV"].ToString());
            }

            if (selectedAreas.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một khu vực!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string maMA = ""; // Sử dụng string cho mã món ăn

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Thêm món ăn vào bảng MonAn và lấy MaMA
                    using (SqlCommand cmd = new SqlCommand("USP_ThemMonAnMoi", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TenMA", txbTenMA.Text.Trim());
                        cmd.Parameters.AddWithValue("@GiaHienTai", giaHienTai);
                        cmd.Parameters.AddWithValue("@MaMuc", maMuc);

                        // Thêm tham số OUTPUT cho MaMA
                        SqlParameter outputMaMA = new SqlParameter("@NewMaMA", SqlDbType.VarChar, 10)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(outputMaMA);

                        cmd.ExecuteNonQuery();

                        // Lấy giá trị MaMA từ tham số OUTPUT
                        maMA = outputMaMA.Value.ToString();
                    }

                    // Thêm món ăn vào ThucDon cho các khu vực đã chọn
                    foreach (string maKV in selectedAreas)
                    {
                        string insertThucDonQuery = @"
                INSERT INTO ThucDon (MaCN, MaMA, TinhTrangGiaoHang, TinhTrangPhucVu)
                SELECT CN.MaCN, @MaMA, N'Có', N'Có'
                FROM ChiNhanh CN
                WHERE CN.MaKV = @MaKV";

                        using (SqlCommand cmd = new SqlCommand(insertThucDonQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaMA", maMA);
                            cmd.Parameters.AddWithValue("@MaKV", maKV);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Thêm món ăn mới thành công vào các khu vực đã chọn!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Lỗi SQL: " + sqlEx.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm món ăn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void pbReturn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
