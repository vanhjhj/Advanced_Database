using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuShiX
{
    public partial class FrmEmployeeOrder : Form
    {
        // Biến private lưu trữ userID
        private string userID;
        private string connectionString = AppConfig.connectionString;
        // Getter để chỉ cho phép đọc userID từ bên ngoài nếu cần
        public string UserID
        {
            get { return userID; }
            private set { userID = value; }
        }
        public FrmEmployeeOrder(string userID)
        {
            InitializeComponent();
            this.userID = userID;
            this.Width = AppConfig.formWidth;
            this.Height = AppConfig.formHeight;
            LoadMenuInfo();
            dgvOrderDetails.RowHeadersVisible = false;
            btnOrder.Enabled = false; // Mặc định nút Order sẽ bị tắt cho đến khi có món ăn được chọn
        }
        private void LoadMenuInfo()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("USP_ThucDonChoDatBanTrucTiep", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số đầu vào
                        cmd.Parameters.Add(new SqlParameter("@TkLap", SqlDbType.VarChar) { Value = userID });

                        // Thêm tham số đầu ra
                        SqlParameter tenCNParam = new SqlParameter
                        {
                            ParameterName = "@TenCN",
                            SqlDbType = SqlDbType.NVarChar,
                            Size = 50,
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(tenCNParam);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dtMenu = new DataTable();
                            dtMenu.Load(reader);

                            // Gán DataTable vào DataGridView
                            dgvOrderDetails.DataSource = dtMenu;

                            // Đảm bảo cột "Choice" được thêm vào và checkbox được thiết lập
                            foreach (DataGridViewRow row in dgvOrderDetails.Rows)
                            {
                                if (row.Cells["Choice"] is DataGridViewCheckBoxCell checkBoxCell)
                                {
                                    checkBoxCell.Value = false; // Mặc định checkbox chưa được chọn
                                }
                            }
                        }

                        // Lấy giá trị của tham số đầu ra sau khi thực hiện stored procedure
                        string tenCN = tenCNParam.Value?.ToString();
                        if (!string.IsNullOrEmpty(tenCN))
                        {
                            // Hiển thị tên chi nhánh trong Label
                            lblBranchName.Text = "Đặt Bàn Trực Tiếp\n" + tenCN;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải thực đơn: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvOrderDetails_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Kiểm tra nếu có thay đổi ở cột "Số Lượng"
                if (dgvOrderDetails.Columns[e.ColumnIndex].Name == "Amount")
                {
                    var amountCell = dgvOrderDetails.Rows[e.RowIndex].Cells["Amount"];
                    var priceCell = dgvOrderDetails.Rows[e.RowIndex].Cells["Price"];
                    var totalAmountCell = dgvOrderDetails.Rows[e.RowIndex].Cells["TotalAmount"];

                    // Kiểm tra nếu người dùng đã nhập giá trị vào Số Lượng
                    if (amountCell.Value != null)
                    {
                        // Kiểm tra xem giá trị có phải là một số nguyên hợp lệ không
                        if (int.TryParse(amountCell.Value.ToString(), out int amount))
                        {
                            // Nếu là số nguyên, tính thành tiền = Đơn Giá * Số Lượng
                            if (priceCell.Value != null)
                            {
                                decimal price = Convert.ToDecimal(priceCell.Value);
                                totalAmountCell.Value = amount * price;
                            }
                        }
                        else
                        {
                            // Nếu không phải số nguyên, hiển thị thông báo lỗi và reset giá trị Số Lượng
                            MessageBox.Show("Số Lượng phải là một số nguyên hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            amountCell.Value = null; // Reset giá trị của Số Lượng
                        }
                    }
                }
            }
        }

        // Hàm xử lý sự kiện khi người dùng click vào ô checkbox
        private void dgvOrderDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvOrderDetails.Columns[e.ColumnIndex].Name == "Choice")
            {
                // Kiểm tra xem ô checkbox đã được click hay chưa
                DataGridViewCheckBoxCell checkBoxCell = dgvOrderDetails.Rows[e.RowIndex].Cells["Choice"] as DataGridViewCheckBoxCell;

                if (checkBoxCell != null)
                {
                    // Gọi CommitEdit để chắc chắn giá trị của checkbox được cập nhật
                    dgvOrderDetails.CommitEdit(DataGridViewDataErrorContexts.Commit);

                    // Đọc giá trị của checkbox sau khi người dùng click
                    bool isChecked = Convert.ToBoolean(checkBoxCell.Value);
                    // bật Amount và Note khi chọn món ăn
                    dgvOrderDetails.Rows[e.RowIndex].Cells["Amount"].ReadOnly = !isChecked;
                    dgvOrderDetails.Rows[e.RowIndex].Cells["Note"].ReadOnly = !isChecked;

                    // Cập nhật trạng thái của nút "Order"
                    UpdateButtonState();
                }
            }
        }
        private void UpdateButtonState()
        {
            // Đếm số lượng ô "Choice" được chọn
            int selectedCount = 0;
            foreach (DataGridViewRow row in dgvOrderDetails.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["Choice"] as DataGridViewCheckBoxCell;
                if (checkBoxCell != null && Convert.ToBoolean(checkBoxCell.Value))
                {
                    selectedCount++;
                }
            }

            // Kiểm tra điều kiện bật/tắt nút "Order"
            btnOrder.Enabled = selectedCount > 0; // Bật nút Order nếu có ít nhất 1 ô được chọn, ngược lại tắt
        }

        // Hàm xử lý sự kiện khi người dùng muốn tạo phiếu đặt bàn trực tuyến
        private void HandleOfflineReservation()
        {
            // Kiểm tra nếu có ít nhất 1 món ăn được chọn và số lượng của món ăn đó phải hợp lệ
            bool hasSelectedDish = false;
            DataTable dtCTPD = new DataTable();  // DataTable để chứa danh sách món ăn
            dtCTPD.Columns.Add("DishName", typeof(string)); // Tên món ăn
            dtCTPD.Columns.Add("Amount", typeof(int));     // Số lượng
            dtCTPD.Columns.Add("Price", typeof(int));      // Đơn giá
            dtCTPD.Columns.Add("TotalAmount", typeof(int)); // Thành tiền
            dtCTPD.Columns.Add("Note", typeof(string));    // Ghi chú món ăn

            foreach (DataGridViewRow row in dgvOrderDetails.Rows)
            {
                // Kiểm tra nếu cột "Choice" (checkbox) đã được chọn và có giá trị hợp lệ
                if (row.Cells["Choice"] is DataGridViewCheckBoxCell checkBoxCell)
                {
                    if (checkBoxCell.Value != null && (bool)checkBoxCell.Value)  // Kiểm tra nếu món ăn được chọn
                    {
                        // Kiểm tra nếu cột "Amount" (Số Lượng) đã được nhập
                        var amountCell = row.Cells["Amount"];
                        if (amountCell.Value == null || string.IsNullOrEmpty(amountCell.Value.ToString()) || Convert.ToInt32(amountCell.Value) <= 0)
                        {
                            MessageBox.Show("Vui lòng nhập số lượng cho món ăn đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;  // Dừng lại nếu Số Lượng không hợp lệ
                        }

                        // Lấy các thông tin cần thiết
                        string dishName = row.Cells["DishName"].Value.ToString();
                        int amount = Convert.ToInt32(amountCell.Value);
                        int price = Convert.ToInt32(row.Cells["Price"].Value);
                        int totalAmount = amount * price;
                        string note = row.Cells["Note"].Value?.ToString();

                        // Thêm món ăn vào DataTable
                        dtCTPD.Rows.Add(dishName, amount, price, totalAmount, note);

                        // Đánh dấu là có ít nhất 1 món ăn được chọn
                        hasSelectedDish = true;
                    }
                }
            }

            if (!hasSelectedDish)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 món ăn và nhập số lượng cho món ăn đó.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Nếu kiểm tra tất cả các điều kiện hợp lệ, tiếp tục xử lý đơn hàng
            try
            {
                // Tạo kết nối với cơ sở dữ liệu
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Mở kết nối
                    connection.Open();

                    // Tạo command để gọi thủ tục
                    using (SqlCommand cmd = new SqlCommand("USP_DatBanTrucTiep", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số vào thủ tục
                        cmd.Parameters.AddWithValue("@TkLap", userID);  // ID Nhân viên lập đơn

                        // Thêm tham số TVP
                        SqlParameter tvpParameter = new SqlParameter("@CTPD", SqlDbType.Structured)
                        {
                            TypeName = "dbo.CTPDType",  // Tên kiểu TVP đã tạo trong SQL Server
                            Value = dtCTPD
                        };
                        cmd.Parameters.Add(tvpParameter);

                        // Thực thi thủ tục
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Đặt bàn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu đơn hàng: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            HandleOfflineReservation();
            FrmEmployee frmEmployee = new FrmEmployee(userID);
            this.Hide();
            frmEmployee.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FrmEmployee frmEmployee = new FrmEmployee(userID);
            this.Hide();
            frmEmployee.ShowDialog();
            this.Close();
        }
    }
}
