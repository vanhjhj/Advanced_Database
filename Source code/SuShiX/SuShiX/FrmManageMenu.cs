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
            LoadMenuData();
        }

        private void LoadMenuData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Sử dụng tham số hóa truy vấn
                    string query = "SELECT td.MaMA, td.TinhTrangPhucVu, td.TinhTrangGiaoHang " +
                                   "FROM ThucDon td " +
                                   "JOIN ChiNhanh cn ON td.MaCN = cn.MaCN " +
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


        private void FrmManageMenu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmManager frmManager = new FrmManager(userID);
            this.Hide();
            frmManager.ShowDialog();
            this.Close();
        }

    }
}
