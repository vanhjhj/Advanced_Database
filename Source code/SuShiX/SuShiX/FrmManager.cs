using System;
using System.Windows.Forms;

namespace SuShiX
{
    public partial class FrmManager : Form
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
        public FrmManager(string userID)
        {
            InitializeComponent();
            this.UserID = userID;

            this.Width = AppConfig.formWidth;
            this.Height = AppConfig.formHeight;
            // Sử dụng userID để thực hiện các tác vụ
            //LoadManagerData();
        }

        // Hàm tải dữ liệu quản lý dựa trên userID
        private void LoadManagerData()
        {
            MessageBox.Show($"Chào mừng Quản Lý với ID: {UserID}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Ví dụ truy vấn dữ liệu quản lý bằng userID
            // string query = $"SELECT * FROM NhanVien WHERE MaTK = '{UserID}'";
            // Thực thi truy vấn và hiển thị dữ liệu
        }

        // Ví dụ một hàm khác sử dụng userID
        private void SomeOtherFunction()
        {
            // Bạn có thể sử dụng UserID ở đây mà không lo bị sửa đổi ngoài ý muốn
            Console.WriteLine($"User ID hiện tại là: {UserID}");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            this.Close();
        }

        private void btnManageMenu_Click(object sender, EventArgs e)
        {
            FrmManageMenu frmManageMenu = new FrmManageMenu(userID);
            this.Hide();
            frmManageMenu.ShowDialog();
            this.Close();
        }
    }
}
