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
    public partial class FrmUpdateSalary : Form
    {

        private string userID;
        private string connectionString = AppConfig.connectionString;

        public string UserID
        {
            get { return userID; }
            private set { userID = value; }
        }

        public FrmUpdateSalary(string userID)
        {
            InitializeComponent();
            this.UserID = userID;
            this.Width = AppConfig.formWidth;
            this.Height = AppConfig.formHeight;
            LoadData();
            dataGridView1.RowHeadersVisible = false;
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT * FROM BoPhan";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

            //ẩn nút chỉnh sửa
            btnSave.Enabled = false;
        }

        //Hàm cập nhật trạng thái nút khi có dữ liệu được chọn
        private void UpdateButtonStatus()
        {
            // Kiểm tra xem có dòng nào được chọn không
            bool isSelected = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row != null && Convert.ToBoolean(row.Cells["Edit"].Value))
                {
                    isSelected = true;
                    break;
                }
            }

            // Cập nhật trạng thái của các nút
            btnSave.Enabled = isSelected;
        }

        private void HandleSaveChanges()
        {
            DataTable dtUpdateSalary = new DataTable();

            dtUpdateSalary.Columns.Add("MaBP", typeof(string));
            dtUpdateSalary.Columns.Add("TenBP", typeof(string));
            dtUpdateSalary.Columns.Add("Luong", typeof(string));

            bool hasChanges = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Kiểm tra nếu hàng đó đang được chỉnh sửa
                if (row.Cells["Edit"].Value != null && (bool)row.Cells["Edit"].Value)
                {
                    hasChanges = true;

                    dtUpdateSalary.Rows.Add(
                        row.Cells["MaBP"].Value,
                        row.Cells["TenBP"].Value,
                        row.Cells["Luong"].Value);
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

                    //Gọi stored procedure cập nhật lương
                    using (SqlCommand cmd = new SqlCommand("USP_CapNhatLuong", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@MaTK", userID);

                        SqlParameter tvpParam = new SqlParameter("@LuongThayDoi", SqlDbType.Structured)
                        {
                            TypeName = "dbo.LuongThayDoi",
                            Value = dtUpdateSalary
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                // Kiểm tra xem ô checkbox đã được click hay chưa
                DataGridViewCheckBoxCell checkBoxCell = dataGridView1.Rows[e.RowIndex].Cells["Edit"] as DataGridViewCheckBoxCell;

                if (checkBoxCell != null)
                {

                    // Gọi CommitEdit để chắc chắn giá trị của checkbox được cập nhật
                    dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);

                    // Cập nhật trạng thái của nút 
                    UpdateButtonStatus();
                }
            }
        }

        private void pbReturn_Click(object sender, EventArgs e)
        {
            //back to admin form
            FrmAdmin frmAdmin = new FrmAdmin(userID);
            this.Hide();
            frmAdmin.ShowDialog();
            this.Close();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Xử lý lưu thay đổi
            HandleSaveChanges();
            // Tải lại dữ liệu
            LoadData();
        }
    }
}
