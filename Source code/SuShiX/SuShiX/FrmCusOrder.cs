using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SuShiX
{
    public partial class FrmCusOrder : Form
    {
        private string userID;
        private string connectionString = AppConfig.connectionString;
        private DateTime timeAccess; // Lưu thời gian khi form mở
        private DateTime totalTimeAccess; // Lưu thời gian khi nhấn nút Lập Phiếu

        // Hàm tắt tất cả các điều khiển
        private void DisableAllControls()
        {
            foreach (Control control in pnlGeneralOrderInfo.Controls)
            {
                if (control is TextBox || control is ComboBox || control is DateTimePicker || control is NumericUpDown)
                {
                    control.Enabled = false;
                }
            }

            // Tắt cả các điều khiển trong các panel liên quan
            pnlBookingOnline.Enabled = false;
            pnlShipping.Enabled = false;

            // Chỉ để loại phiếu đặt và nút quay lại mở
            lblOrderType.Enabled = true;
            cbbOrderType.Enabled = true;
            btnExit.Enabled = true;
            btnOrder.Enabled = false;
        }
        public FrmCusOrder(string userID)
        {
            InitializeComponent();
            this.userID = userID;
            this.Width = AppConfig.formWidth;
            this.Height = AppConfig.formHeight;

            // Đảm bảo khi form mở cbbOrderType chưa được chọn
            cbbOrderType.SelectedItem = null;

            // Disable tất cả các điều khiển ngay khi form được mở
            DisableAllControls();

            // Lưu thời gian truy cập khi form mở
            timeAccess = DateTime.Now;

            dgvOrderDetails.RowHeadersVisible = false;
        }

        // Hàm bật tất cả các điều khiển
        private void EnableAllControls()
        {
            foreach (Control control in pnlGeneralOrderInfo.Controls)
            {
                if (control is TextBox || control is ComboBox || control is DateTimePicker || control is NumericUpDown)
                {
                    control.Enabled = true;
                }
            }

            // Bật các panel liên quan
            pnlBookingOnline.Enabled = true;
            pnlShipping.Enabled = true;
        }

        // Hàm xử lý sự kiện thay đổi giá trị của cbbOrderType
        private void cbbOrderType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOrderType = cbbOrderType.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedOrderType))
            {
                // Nếu chưa chọn loại phiếu đặt, tắt tất cả các điều khiển
                DisableAllControls();
            }
            else
            {
                // Enable trường Tên Khu Vực và load dữ liệu từ bảng KhuVuc
                EnableAllControls();
                LoadAreaData();

                // Kiểm tra loại phiếu đặt và thay đổi trạng thái các điều khiển tương ứng
                if (selectedOrderType == "Đặt Bàn Trực Tuyến")
                {
                    txbReceiverAddress.Enabled = false;
                    txbReceiverPhoneNumber.Enabled = false;

                    dtpArrivalTime.Enabled = true;
                    nudCusNumber.Enabled = true;
                }
                else if (selectedOrderType == "Giao Hàng Tận Nơi")
                {
                    dtpArrivalTime.Enabled = false;
                    nudCusNumber.Enabled = false;

                    txbReceiverAddress.Enabled = true;
                    txbReceiverPhoneNumber.Enabled = true;
                }
            }
        }
        // Hàm tải dữ liệu Tên Khu Vực từ database
        private void LoadAreaData()
        {
            string query = "SELECT TenKV FROM KhuVuc";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Load dữ liệu vào ComboBox Tên Khu Vực
                cbbAreaName.DataSource = dataTable;
                cbbAreaName.DisplayMember = "TenKV";
                cbbAreaName.ValueMember = "TenKV";
            }
        }

        // Hàm xử lý sự kiện nhấn nút 'Quay Lại'
        private void btnExit_Click(object sender, EventArgs e)
        {
            FrmHomepageCustomer frmHomepageCustomer = new FrmHomepageCustomer(userID);
            this.Hide();
            frmHomepageCustomer.ShowDialog();
            this.Close();
        }

        // Hàm tải dữ liệu Địa Chỉ Chi Nhánh từ database
        private void LoadBranchAddressData(string areaName)
        {
            // Câu lệnh SQL truy vấn địa chỉ tất cả chi nhánh thuộc khu vực
            string query = @"
                SELECT CN.DiaChi 
                FROM ChiNhanh CN
                JOIN KhuVuc KV ON CN.MaKV = KV.MaKV
                WHERE KV.TenKV = @TenKV";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@TenKV", areaName.Trim());  // Truyền tên khu vực vào tham số

                try
                {
                    connection.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    // Kiểm tra xem có dữ liệu trả về không
                    if (reader.HasRows)
                    {
                        // Khởi tạo một danh sách các địa chỉ chi nhánh
                        List<string> branchAddresses = new List<string>();

                        while (reader.Read())
                        {
                            // Đọc địa chỉ của từng chi nhánh
                            string branchAddress = reader["DiaChi"].ToString();
                            branchAddresses.Add(branchAddress);
                        }

                        // Gán dữ liệu vào ComboBox hoặc điều khiển thích hợp
                        cbbBranchAddress.DataSource = branchAddresses;  // Cập nhật ComboBox với danh sách địa chỉ chi nhánh
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy chi nhánh nào trong khu vực này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải dữ liệu địa chỉ chi nhánh: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Hàm xử lý sự kiện khi chọn khu vực
        private void cbbAreaName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu ComboBox không trống và lấy giá trị đúng
            if (cbbAreaName.SelectedItem != null)
            {
                // Lấy giá trị TenKV từ DataRowView (chỉ lấy giá trị từ cột TenKV)
                string selectedArea = ((DataRowView)cbbAreaName.SelectedItem)["TenKV"].ToString().Trim();

                if (!string.IsNullOrEmpty(selectedArea))
                {
                    LoadBranchAddressData(selectedArea);  // Gọi hàm để tải dữ liệu địa chỉ chi nhánh
                }
            }
        }

        // Hàm tải thông tin chi nhánh từ database
        private void LoadBranchInfo(string orderType, string branchAddress)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("USP_ThongTinChiNhanh", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@DiaChiChiNhanh", branchAddress);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Gán dữ liệu vào các controls
                                txbBranchName.Text = reader["TenCN"].ToString();
                                txbBranchPhoneNumber.Text = reader["SDT"].ToString();
                                txbCarParking.Text = reader["BaiDoXeHoi"].ToString();
                                txbMotorbikeParking.Text = reader["BaiDoXeMay"].ToString();
                                txbTimeOpen.Text = reader["ThoiGianMoCua"].ToString() + " - " + reader["ThoiGianDongCua"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy thông tin chi nhánh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải thông tin chi nhánh: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hàm tải thông tin thực đơn của chi nhánh từ database
        private void LoadMenuInfo(string orderType, string branchAddress)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("USP_ThucDonChiNhanh", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@LoaiPhieuDat", SqlDbType.NVarChar) { Value = orderType });
                        cmd.Parameters.Add(new SqlParameter("@DiaChiChiNhanh", SqlDbType.NVarChar) { Value = branchAddress });

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
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải thực đơn: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hàm xử lý sự kiện khi chọn địa chỉ chi nhánh
        private void cbbBranchAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedBranchAddress = cbbBranchAddress.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedBranchAddress))
            {
                // Gọi hàm tải thông tin chi nhánh và thực đơn chi nhánh
                LoadBranchInfo(cbbOrderType.SelectedItem.ToString(), selectedBranchAddress);
                LoadMenuInfo(cbbOrderType.SelectedItem.ToString(), selectedBranchAddress);
            }
        }

        // Hàm cập nhật trạng thái của nút "Order"
        private void UpdateOrderButtonState()
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

                    // Cập nhật trạng thái "Amount" và "Note" dựa trên trạng thái checkbox
                    dgvOrderDetails.Rows[e.RowIndex].Cells["Amount"].ReadOnly = !isChecked;
                    dgvOrderDetails.Rows[e.RowIndex].Cells["Note"].ReadOnly = !isChecked;

                    // Nếu không được chọn, thiết lập lại giá trị Thành Tiền
                    if (!isChecked)
                    {
                        dgvOrderDetails.Rows[e.RowIndex].Cells["Amount"].Value = null;
                        dgvOrderDetails.Rows[e.RowIndex].Cells["Note"].Value = null;
                        dgvOrderDetails.Rows[e.RowIndex].Cells["TotalAmount"].Value = null;
                    }

                    // Cập nhật trạng thái của nút "Order"
                    UpdateOrderButtonState();
                }
            }
        }


        // Hàm xử lý sự kiện khi người dùng thay đổi giá trị của ô "Số Lượng"
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

        // Hàm xử lý sự kiện khi người dùng muốn tạo phiếu đặt bàn trực tuyến
        private void HandleOnlineReservation()
        {
            totalTimeAccess = DateTime.Now;

            // Tính số phút đã qua từ thời điểm truy cập đến thời điểm nhấn nút
            TimeSpan TgTruyCap = totalTimeAccess - timeAccess;
            int minutesSpent = (int)TgTruyCap.TotalMinutes;

            // Kiểm tra nếu số lượng khách >= 1
            if (nudCusNumber.Value < 1)
            {
                MessageBox.Show("Số lượng khách phải lớn hơn hoặc bằng 1.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
                    using (SqlCommand cmd = new SqlCommand("USP_DatBanTrucTuyen", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số vào thủ tục
                        cmd.Parameters.AddWithValue("@TkLap", userID);  // ID người dùng
                        cmd.Parameters.AddWithValue("@DiaChiChiNhanh", cbbBranchAddress.SelectedItem.ToString());  // Địa chỉ chi nhánh
                        cmd.Parameters.AddWithValue("@TdTruyCap", timeAccess);  // Thời điểm truy cập
                        cmd.Parameters.AddWithValue("@TgTruyCap", minutesSpent);  // Thời gian truy cập (Tính bằng phút)
                        cmd.Parameters.AddWithValue("@SLKhach", nudCusNumber.Value);  // Số lượng khách
                        cmd.Parameters.AddWithValue("@ThoiGianDen", dtpArrivalTime.Value);  // Thời gian đến
                        cmd.Parameters.AddWithValue("@GhiChu", txbGeneralNote.Text);  // Ghi chú

                        // Thêm tham số TVP
                        SqlParameter tvpParameter = new SqlParameter("@CTPD", SqlDbType.Structured)
                        {
                            TypeName = "dbo.CTPDType",  // Tên kiểu TVP đã tạo trong SQL Server
                            Value = dtCTPD  // DataTable chứa danh sách món ăn
                        };
                        cmd.Parameters.Add(tvpParameter);

                        // Thực thi thủ tục
                        cmd.ExecuteNonQuery();

                        // Thông báo thành công
                        MessageBox.Show("Đặt bàn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu đơn hàng: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hàm xử lý sự kiện khi người dùng muốn tạo phiếu giao hàng tận nơi
        private void HandleDeliveryOrder()
        {
            totalTimeAccess = DateTime.Now;

            // Tính số phút đã qua từ thời điểm truy cập đến thời điểm nhấn nút
            TimeSpan TgTruyCap = totalTimeAccess - timeAccess;
            int minutesSpent = (int)TgTruyCap.TotalMinutes;

            // Kiểm tra nếu địa chỉ người nhận và số điện thoại người nhận hợp lệ
            if (string.IsNullOrEmpty(txbReceiverAddress.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ người nhận.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txbReceiverPhoneNumber.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại người nhận.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
                    using (SqlCommand cmd = new SqlCommand("USP_GiaoHangTanNoi", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số vào thủ tục
                        cmd.Parameters.AddWithValue("@TkLap", userID);  // ID người dùng
                        cmd.Parameters.AddWithValue("@DiaChiChiNhanh", cbbBranchAddress.SelectedItem.ToString());  // Địa chỉ chi nhánh
                        cmd.Parameters.AddWithValue("@TdTruyCap", timeAccess);  // Thời điểm truy cập
                        cmd.Parameters.AddWithValue("@TgTruyCap", minutesSpent);  // Thời gian truy cập (Tính bằng phút)
                        cmd.Parameters.AddWithValue("@DiaChiNhan", txbReceiverAddress.Text);  // Địa chỉ nhận
                        cmd.Parameters.AddWithValue("@SDTNhan", txbReceiverPhoneNumber.Text);  // Số điện thoại người nhận
                        cmd.Parameters.AddWithValue("@GhiChu", txbGeneralNote.Text);  // Ghi chú

                        // Thêm tham số TVP
                        SqlParameter tvpParameter = new SqlParameter("@CTPD", SqlDbType.Structured)
                        {
                            TypeName = "dbo.CTPDType",  // Tên kiểu TVP đã tạo trong SQL Server
                            Value = dtCTPD  // DataTable chứa danh sách món ăn
                        };
                        cmd.Parameters.Add(tvpParameter);

                        // Thực thi thủ tục
                        cmd.ExecuteNonQuery();

                        // Thông báo thành công
                        MessageBox.Show("Đặt hàng giao hàng tận nơi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string orderType = cbbOrderType.SelectedItem?.ToString();
            if (orderType == "Đặt Bàn Trực Tuyến")
            {
                HandleOnlineReservation();
            }
            else if (orderType == "Giao Hàng Tận Nơi")
            {
                HandleDeliveryOrder();
            }
        }

        private void FrmCusOrder_Load(object sender, EventArgs e)
        {

        }
    }
}