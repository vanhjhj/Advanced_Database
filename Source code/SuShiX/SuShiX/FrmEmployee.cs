using System;
using System.Windows.Forms;

namespace SuShiX
{
    public partial class FrmEmployee : Form
    {
        // Biến private lưu trữ userID
        private string userID;

        // Getter để chỉ cho phép đọc userID từ bên ngoài nếu cần
        public string UserID
        {
            get { return userID; }
            private set { userID = value; }
        }

        // Constructor nhận userID khi khởi tạo form
        public FrmEmployee(string userID)
        {
            InitializeComponent();
            this.UserID = userID;
            this.Width = AppConfig.formWidth;
            this.Height = AppConfig.formHeight;

            // Sử dụng userID để thực hiện các tác vụ
            LoadEmployeeData();
        }

        // Hàm tải dữ liệu Employee dựa trên userID
        private void LoadEmployeeData()
        {
            MessageBox.Show($"Chào mừng Nhân Viên với ID: {UserID}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Ví dụ truy vấn dữ liệu nhân viên bằng userID
            // string query = $"SELECT * FROM NhanVien WHERE MaTK = '{UserID}'";
            // Thực thi truy vấn và hiển thị dữ liệu
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmEmployeeOrder frmEmployeeOrder = new FrmEmployeeOrder(userID);
            frmEmployeeOrder.ShowDialog();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            this.Close();
        }
    }
}
