using System;
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

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Gọi Stored Procedure
                    using (SqlCommand cmd = new SqlCommand("USP_ThemMonAnMoi", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số cho Stored Procedure
                        cmd.Parameters.AddWithValue("@TenMA", txbTenMA.Text.Trim());
                        cmd.Parameters.AddWithValue("@GiaHienTai", giaHienTai);
                        cmd.Parameters.AddWithValue("@MaMuc", maMuc);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Thêm món ăn mới thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        // Nút quay lại
        private void pbReturn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
