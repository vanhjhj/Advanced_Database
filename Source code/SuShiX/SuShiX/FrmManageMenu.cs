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
    public partial class FrmManageMenu : Form
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
        public FrmManageMenu(string userID)
        {
            InitializeComponent();
            this.UserID = userID;
            this.Width = AppConfig.formWidth;
            this.Height = AppConfig.formHeight;
            LoadMenuData();
            dataGridView1.RowHeadersVisible = false;
        }

        private void LoadMenuData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Sử dụng tham số hóa truy vấn
                    string query = "SELECT ma.MaMA, ma.TenMA, td.TinhTrangPhucVu, td.TinhTrangGiaoHang\n" +
                                   "FROM ThucDon td\n" +
                                   "JOIN ChiNhanh cn ON td.MaCN = cn.MaCN\n" +
                                   "JOIN MonAn ma ON td.MaMA = ma.MaMA\n" +
                                   "WHERE cn.QuanLy = @UserID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Truyền giá trị userID vào tham số
                        cmd.Parameters.AddWithValue("@UserID", this.UserID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Xóa dữ liệu cũ trong DataGridView (nếu cần)
                            dataGridView1.Rows.Clear();
                            
                            // Điền dữ liệu vào DataGridView
                            while (reader.Read())
                            { 
                                dataGridView1.Rows.Add(
                                    reader["MaMA"].ToString(),
                                    reader["TenMA"].ToString(),
                                    reader["TinhTrangPhucVu"].ToString(),
                                    reader["TinhTrangGiaoHang"].ToString(),
                                    false 
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            // Kiểm tra nếu cột đang chỉnh sửa không phải là cột "Edit"
            if (dataGridView1.Columns[e.ColumnIndex].Name != "Edit")
            {
                // Lấy trạng thái checkbox từ cột "Edit" của hàng hiện tại
                bool isEditable = (bool)(dataGridView1.Rows[e.RowIndex].Cells["Edit"].Value ?? false);

                // Nếu checkbox chưa được chọn, hủy chỉnh sửa
                if (!isEditable)
                {
                    MessageBox.Show("Bạn cần chọn 'Chỉnh sửa' để thay đổi các trường!", "Thông báo");
                    e.Cancel = true;
                }
            }
        }

        private void HandleSaveChanges()
        {
            // Tạo DataTable để lưu trữ dữ liệu cần cập nhật
            DataTable dtUpdateMenu = new DataTable();
            dtUpdateMenu.Columns.Add("MaMA", typeof(string));
            dtUpdateMenu.Columns.Add("TinhTrangPhucVu", typeof(string));
            dtUpdateMenu.Columns.Add("TinhTrangGiaoHang", typeof(string));

            bool hasChanges = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Kiểm tra nếu hàng đó đang được chỉnh sửa
                if (row.Cells["Edit"].Value != null && (bool)row.Cells["Edit"].Value)
                {
                    hasChanges = true;
                    // Thêm dòng vào DataTable
                    dtUpdateMenu.Rows.Add(
                        row.Cells["MaMA"].Value.ToString(),
                        row.Cells["TinhTrangPhucVu"].Value.ToString(),
                        row.Cells["TinhTrangGiaoHang"].Value.ToString());
                }
            }

            if (!hasChanges)
            {
                MessageBox.Show("Không có thay đổi nào được thực hiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    //Gọi stored procedure cập nhật thực đơn
                    using (SqlCommand cmd = new SqlCommand("USP_CapNhatThucDon", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@MaTK", userID);

                        SqlParameter tvpParam = new SqlParameter("@ThucDonThayDoi", SqlDbType.Structured)
                        {
                            TypeName = "dbo.ThucDonThayDoi",
                            Value = dtUpdateMenu
                        };
                        cmd.Parameters.Add(tvpParam);

                        cmd.ExecuteNonQuery();

                        // Thông báo thành công
                        MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void pbReturn_Click(object sender, EventArgs e)
        {
            FrmManager frmManager = new FrmManager(userID);
            this.Hide();
            frmManager.ShowDialog();
            this.Close();
        }

        private void btnAddMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Xử lý lưu thay đổi
            HandleSaveChanges();
            // Tải lại dữ liệu
            LoadMenuData();
        }

    }
}
