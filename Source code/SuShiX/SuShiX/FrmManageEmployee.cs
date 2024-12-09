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
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SuShiX
{
    public partial class FrmManageEmployee : Form
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
        public FrmManageEmployee(string userID)
        {
            InitializeComponent();
            this.UserID = userID;
            this.Width = AppConfig.formWidth;
            this.Height = AppConfig.formHeight;
            LoadComboBoxData();
            dgvEmployee.RowHeadersVisible = false;
        }

        private void LoadComboBoxData()
        {

            // Câu lệnh SQL để lấy dữ liệu
            string query = "SELECT TenBP FROM BoPhan";

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
                        MessageBox.Show("Không có dữ liệu nào từ bảng BoPhan.");
                        return;
                    }

                    // Thêm tùy chọn "Tất cả"
                    DataRow allRow = dataTable.NewRow();
                    allRow["TenBP"] = "Tất cả";
                    dataTable.Rows.InsertAt(allRow, 0);

                    // Gán dữ liệu vào ComboBox
                    cbbDepartment.DataSource = dataTable;
                    cbbDepartment.DisplayMember = "TenBP"; // Hiển thị tên bộ phận
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }

            // ẩn các nút 
            btnUpdate.Enabled = false;
            btnAssign.Enabled = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmManager frmManager = new FrmManager(userID);
            this.Hide();
            frmManager.ShowDialog();
            this.Close();
        }


        private void btnAssign_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvEmployee.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Choice"].Value))
                {
                    string selectedMaTK = row.Cells["MaTK"].Value.ToString();

                    FrmAssignEmployee frmAssignEmployee = new FrmAssignEmployee(UserID, selectedMaTK);
                    this.Hide();
                    frmAssignEmployee.ShowDialog();
                    this.Close();

                    break; // Dừng vòng lặp khi đã tìm được dòng được chọn
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEmployee frmAddEmployee = new AddEmployee(UserID);
            this.Hide();
            frmAddEmployee.ShowDialog();
            this.Close();
        }

        private void cbbDepartment_SelectedValueChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu không có giá trị được chọn trong combobox
            if (cbbDepartment.SelectedItem == null)
            {
                return;
            }

            // Lấy giá trị từ DataRowView (ví dụ lấy tên bộ phận từ cột "TenBP")
            DataRowView selectedRow = cbbDepartment.SelectedItem as DataRowView;
            string department = selectedRow?["TenBP"]?.ToString(); // Thay "TenBP" bằng tên cột bạn cần

            // Nếu không có bộ phận được chọn, không làm gì cả
            if (string.IsNullOrEmpty(department))
            {
                return;
            }

            // Gọi phương thức LoadEmployeeData với tên bộ phận
            LoadEmployeeData(department);
        }
        
        private void LoadEmployeeData(string department)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open(); // Mở kết nối trước khi sử dụng

                // Xác định tên Stored Procedure cần gọi
                string procedureName = department == "Tất cả"
                    ? "USP_XemThongTinNhanVienCuaTatCaBoPhan"
                    : "USP_XemThongTinNhanVienCuaMotBoPhan";

                using (SqlCommand command = new SqlCommand(procedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Truyền tham số
                    command.Parameters.Add(new SqlParameter("@MaTK", SqlDbType.VarChar) { Value = this.userID });
                    if (department != "Tất cả")
                    {
                        command.Parameters.Add(new SqlParameter("@TenBP", SqlDbType.NVarChar) { Value = department });
                    }

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dgvEmployee.DataSource = dt;

                        // Đảm bảo cột "Choice" được thêm vào và checkbox được thiết lập
                        foreach (DataGridViewRow row in dgvEmployee.Rows)
                        {
                            if (row.Cells["Choice"] is DataGridViewCheckBoxCell checkBoxCell)
                            {
                                checkBoxCell.Value = false; // Mặc định checkbox chưa được chọn
                            }
                        }
                    }
                }
            }
        }
        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvEmployee.Columns[e.ColumnIndex].Name == "Choice")
            {
                // Kiểm tra xem ô checkbox đã được click hay chưa
                DataGridViewCheckBoxCell checkBoxCell = dgvEmployee.Rows[e.RowIndex].Cells["Choice"] as DataGridViewCheckBoxCell;

                if (checkBoxCell != null)
                {
                    //đặt giá trị của các ô checkbox khác thành false
                    foreach (DataGridViewRow row in dgvEmployee.Rows)
                    {
                        if (row != null && row.Index != e.RowIndex)
                        {
                            row.Cells["Choice"].Value = false;
                        }
                    }

                    // Gọi CommitEdit để chắc chắn giá trị của checkbox được cập nhật
                    dgvEmployee.CommitEdit(DataGridViewDataErrorContexts.Commit);

                    // Cập nhật trạng thái của nút 
                    UpdateButtonStatus();

                }
            }
        }

        //Hàm cập nhật trạng thái nút khi có dữ liệu được chọn
        private void UpdateButtonStatus()
        {
            // Kiểm tra xem có dòng nào được chọn không
            bool isSelected = false;
            foreach (DataGridViewRow row in dgvEmployee.Rows)
            {
                if (row != null && Convert.ToBoolean(row.Cells["Choice"].Value))
                {
                    isSelected = true;
                    break;
                }
            }

            // Cập nhật trạng thái của các nút
            btnUpdate.Enabled = isSelected;
            btnAssign.Enabled = isSelected;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            foreach (DataGridViewRow row in dgvEmployee.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Choice"].Value)) 
                {
                    string selectedMaTK = row.Cells["MaTK"].Value.ToString(); 

                    FrmManageIn4Employee frmManageIn4Employee = new FrmManageIn4Employee(UserID, selectedMaTK);
                    this.Hide();
                    frmManageIn4Employee.ShowDialog();
                    this.Close();

                    break; // Dừng vòng lặp khi đã tìm được dòng được chọn
                }
            }
        }
    }
}
