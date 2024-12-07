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
        }

        private void FrmManageEmployee_Load(object sender, EventArgs e)
        {

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
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmManager frmManager = new FrmManager(userID);
            this.Hide();
            frmManager.ShowDialog();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmManageIn4Employee frmManageIn4Employee = new FrmManageIn4Employee(UserID);
            this.Hide();
            frmManageIn4Employee.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAssignEmployee frmAssignEmployee = new FrmAssignEmployee(UserID);
            this.Hide();
            frmAssignEmployee.ShowDialog();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddEmployee frmAddEmployee = new FrmAddEmployee(UserID);
            this.Hide();
            frmAddEmployee.ShowDialog();
            this.Close();
        }
    }
}
