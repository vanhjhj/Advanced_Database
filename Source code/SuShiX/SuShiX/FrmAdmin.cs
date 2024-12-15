using System;
using System.Windows.Forms;

namespace SuShiX
{
    public partial class FrmAdmin : Form
    {
        // Biến private lưu trữ userID
        private string userID;

        // Getter để chỉ cho phép đọc userID từ bên ngoài nếu cần
        public string UserID
        {
            get { return userID; }
            private set { userID = value; }
        }

        public FrmAdmin()
        {
            InitializeComponent();
        }

        // Constructor nhận userID khi khởi tạo form
        public FrmAdmin(string userID)
        {
            InitializeComponent();
            this.UserID = userID;
            this.Width = AppConfig.formWidth;
            this.Height = AppConfig.formHeight;

            // Sử dụng userID để thực hiện các tác vụ
            //LoadAdminData();
        }

        // Hàm tải dữ liệu Admin dựa trên userID
        private void LoadAdminData()
        {
            MessageBox.Show($"Chào mừng Admin với ID: {UserID}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Ví dụ truy vấn dữ liệu Admin bằng userID
            // string query = $"SELECT * FROM NhanVien WHERE MaTK = '{UserID}' AND BoPhan = 'Admin'";
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

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            FrmAdminStatistics frmAdminStatistics = new FrmAdminStatistics(userID);
            this.Hide();
            frmAdminStatistics.ShowDialog();
            this.Close();
        }

        private void btnUpdateSalary_Click(object sender, EventArgs e)
        {
            FrmUpdateSalary frmUpdateSalary = new FrmUpdateSalary(userID);
            this.Hide();
            frmUpdateSalary.ShowDialog();
            this.Close();
        }

        private void btnUpdatePromotion_Click(object sender, EventArgs e)
        {
            FrmPromotionManagement frmPromotionManagement = new FrmPromotionManagement(userID);
            this.Hide();
            frmPromotionManagement.ShowDialog();
            this.Close();
        }

        private void btnUpdateIn4_Click(object sender, EventArgs e)
        {
            FrmUpdateIn4Employee frmUpdateIn4Employee = new FrmUpdateIn4Employee(userID);
            frmUpdateIn4Employee.Owner = this;
            this.Hide();
            frmUpdateIn4Employee.ShowDialog();
        }
    }
}
