using System;
using System.Windows.Forms;

namespace SuShiX
{
    public partial class FrmCustomer : Form
    {
        // Biến private lưu trữ userID
        private string userID;

        // Getter để chỉ cho phép đọc userID từ bên ngoài nếu cần
        public string UserID
        {
            get { return userID; }
            private set { userID = value; }
        }

        public FrmCustomer()
        {
            InitializeComponent();
        }

        // Constructor nhận userID khi khởi tạo form
        public FrmCustomer(string userID)
        {
            InitializeComponent();
            this.UserID = userID;

            // Sử dụng userID để thực hiện các tác vụ
            LoadCustomerData();
        }

        // Hàm tải dữ liệu khách hàng dựa trên userID
        private void LoadCustomerData()
        {
            MessageBox.Show($"Chào mừng khách hàng với ID: {UserID}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Ví dụ truy vấn dữ liệu khách hàng bằng userID
            // Sử dụng userID trong truy vấn cơ sở dữ liệu hoặc thao tác khác
            // string query = $"SELECT * FROM KhachHang WHERE MaTK = '{UserID}'";
            // Thực thi truy vấn và hiển thị dữ liệu
        }

        // Ví dụ một hàm khác sử dụng userID
        private void SomeOtherFunction()
        {
            // Bạn có thể sử dụng UserID ở đây mà không lo bị sửa đổi ngoài ý muốn
            Console.WriteLine($"User ID hiện tại là: {UserID}");
        }
    }
}
