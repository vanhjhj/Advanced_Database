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
    public partial class FrmUpdateOnlineOrders : Form
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
        public FrmUpdateOnlineOrders(string userID)
        {
            InitializeComponent();
            this.UserID = userID;
            this.Width = AppConfig.formWidth;
            this.Height = AppConfig.formHeight;
            DisableAllControls();
            LoadBranchName();
        }
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
            btnUpdateOrder.Enabled = true;
        }

        private void LoadBranchName()
        {
            string query = @"SELECT CN.TenCN 
                             FROM NhanVien NV 
                             JOIN ChiNhanh CN ON NV.MaCN = CN.MaCN
                             WHERE NV.MaTK = @MaTK";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MaTK", userID);  // Truyền tên khu vực vào tham số

                try
                {
                    connection.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    // Kiểm tra xem có dữ liệu trả về không
                    if (reader.HasRows)
                    {
                        // Lấy ra tên chi nhánh duy nhất
                        reader.Read();
                        string branchName = reader.GetString(0);
                        txbBranchName.Text = branchName;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy chi nhánh nào trong khu vực này hoặc nhân viên không thuộc chi nhánh mà khách hàng đặt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải dữ liệu địa chỉ chi nhánh: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
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
                // Enable trường số điện thoại khách hàng
                txbTelephoneNum.Enabled = true;
            }
        }

        private void LoadOrderList()
        {
            // Lấy giá trị từ các điều kiện cần thiết
            string phoneNumber = txbTelephoneNum.Text;
            string orderType = cbbOrderType.SelectedItem?.ToString();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("USP_DanhSachDatOnline", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@LoaiPhieuDat", orderType);
                        cmd.Parameters.AddWithValue("@MaTKNhanVien", userID);
                        cmd.Parameters.AddWithValue("@SDTKhachHang", phoneNumber);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Kiểm tra xem có dữ liệu trả về không
                            if (reader.HasRows)
                            {
                                // Khởi tạo một danh sách các địa chỉ chi nhánh
                                List<string> orderList = new List<string>();

                                while (reader.Read())
                                {
                                    // Đọc địa chỉ của từng chi nhánh
                                    string order = reader["MaPhieu"].ToString();
                                    orderList.Add(order);
                                }

                                // Gán dữ liệu vào ComboBox hoặc điều khiển thích hợp
                                cbbOrderList.DataSource = orderList;  // Cập nhật ComboBox với danh sách địa chỉ chi nhánh
                            }
                            else
                            {
                                MessageBox.Show("Khách hàng không đặt hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải thông tin phiếu đặt của khách hàng: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbTelephoneNum_Leave(object sender, EventArgs e)
        {
            string selectedOrderType = cbbOrderType.SelectedItem?.ToString();
            dgvOrderDetails.Enabled = true;

            // Kiểm tra loại phiếu đặt và thay đổi trạng thái các điều khiển tương ứng
            if (selectedOrderType == "Đặt Bàn Trực Tuyến")
            {
                // Bật Trực Tuyến
                pnlBookingOnline.Enabled = true;
                pnlShipping.Enabled = false;
                cbbOrderList.Enabled = true;
                txbGeneralNote.Enabled = true;
                LoadOrderList();
            }
            else if (selectedOrderType == "Giao Hàng Tận Nơi")
            {
                // Bật Giao Hàng
                pnlShipping.Enabled = true;
                pnlBookingOnline.Enabled = false;
                cbbOrderList.Enabled = true;
                txbGeneralNote.Enabled = true;
                LoadOrderList();
            }
        }

        private void LoadOrderDetails()
        {
            // Lấy giá trị phiếu đặt từ ComboBox cbbOrderList
            string selectedOrderID = cbbOrderList.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedOrderID))
            {
                MessageBox.Show("Vui lòng chọn một phiếu đặt để xem chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("USP_CTPD_Online", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số đầu vào
                        cmd.Parameters.AddWithValue("@MaPhieu", selectedOrderID);
                        cmd.Parameters.AddWithValue("@MaTKNhanVien", userID);

                        // Thêm các tham số đầu ra
                        SqlParameter ghiChuParam = new SqlParameter
                        {
                            ParameterName = "@GhiChu",
                            SqlDbType = SqlDbType.NVarChar,
                            Size = 200,
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(ghiChuParam);

                        SqlParameter slKhachParam = new SqlParameter
                        {
                            ParameterName = "@SLKhach",
                            SqlDbType = SqlDbType.Int,
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(slKhachParam);

                        SqlParameter thoiGianDenParam = new SqlParameter
                        {
                            ParameterName = "@ThoiGianDen",
                            SqlDbType = SqlDbType.DateTime,
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(thoiGianDenParam);

                        SqlParameter diaChiParam = new SqlParameter
                        {
                            ParameterName = "@DiaChi",
                            SqlDbType = SqlDbType.NVarChar,
                            Size = 200,
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(diaChiParam);

                        SqlParameter sdtNguoiNhanParam = new SqlParameter
                        {
                            ParameterName = "@SDTNguoiNhan",
                            SqlDbType = SqlDbType.VarChar,
                            Size = 10,
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(sdtNguoiNhanParam);

                        // Đọc dữ liệu chi tiết phiếu đặt
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                DataTable dtOrderDetails = new DataTable();
                                dtOrderDetails.Load(reader);

                                // Kiểm tra các cột trước khi chỉnh sửa
                                if (dtOrderDetails.Columns.Contains("Amount"))
                                    dtOrderDetails.Columns["Amount"].ReadOnly = false;
                                if (dtOrderDetails.Columns.Contains("Note"))
                                    dtOrderDetails.Columns["Note"].ReadOnly = false;
                                if (dtOrderDetails.Columns.Contains("TotalAmount"))
                                    dtOrderDetails.Columns["TotalAmount"].ReadOnly = false;
                                if (dtOrderDetails.Columns.Contains("Choice"))
                                    dtOrderDetails.Columns["Choice"].ReadOnly = false;

                                // Tạo BindingSource để kết nối với DataGridView
                                BindingSource bindingSource = new BindingSource
                                {
                                    DataSource = dtOrderDetails
                                };

                                // Gán BindingSource cho DataGridView
                                dgvOrderDetails.DataSource = bindingSource;

                                // Xử lý cột Choice (checkbox)
                                foreach (DataGridViewRow row in dgvOrderDetails.Rows)
                                {
                                    var cellAmount = row.Cells["Amount"] as DataGridViewTextBoxCell; // Cột Amount
                                    var cellChoice = row.Cells["Choice"] as DataGridViewCheckBoxCell; // Cột Choice

                                    if (cellAmount.Value != null && !string.IsNullOrEmpty(cellAmount.Value.ToString()))
                                    {
                                        // Đánh dấu checkbox nếu có giá trị Amount
                                        cellChoice.Value = true;
                                    }
                                    else
                                    {
                                        cellChoice.Value = false;
                                        row.Cells["Amount"].ReadOnly = true;
                                        row.Cells["Note"].ReadOnly = true;
                                        row.Cells["TotalAmount"].ReadOnly = true;
                                    }
                                }
                            }
                            else
                            {
                                dgvOrderDetails.DataSource = null; // Xóa dữ liệu nếu không có kết quả
                                MessageBox.Show("Không tìm thấy chi tiết nào cho phiếu đặt này hoặc nhân viên không thuộc chi nhánh mà khách hàng đặt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                        // Lấy giá trị từ các tham số đầu ra
                        string ghiChu = ghiChuParam.Value as string;
                        int? slKhach = slKhachParam.Value as int?;
                        DateTime? thoiGianDen = thoiGianDenParam.Value as DateTime?;
                        string diaChi = diaChiParam.Value as string;
                        string sdtNguoiNhan = sdtNguoiNhanParam.Value as string;

                        // Chỉ hiển thị nếu giá trị không phải null
                        if (!string.IsNullOrEmpty(ghiChu))
                        {
                            txbGeneralNote.Text = ghiChu;
                        }

                        if (slKhach.HasValue)
                        {
                            nudCusNumber.Value = slKhach.Value;
                        }

                        if (thoiGianDen.HasValue)
                        {
                            dtpArrivalTime.Value = thoiGianDen.Value;
                        }

                        if (!string.IsNullOrEmpty(diaChi))
                        {
                            txbReceiverAddress.Text = diaChi;
                        }

                        if (!string.IsNullOrEmpty(sdtNguoiNhan))
                        {
                            txbReceiverPhoneNumber.Text = sdtNguoiNhan;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải chi tiết phiếu đặt: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cbbOrderList_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadOrderDetails();
        }
        // Handle value changes in the DataGridView's "Amount" column.
        private void dgvOrderDetails_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Check if the change occurred in the "Amount" column.
                if (dgvOrderDetails.Columns[e.ColumnIndex].Name == "Amount")
                {
                    var amountCell = dgvOrderDetails.Rows[e.RowIndex].Cells["Amount"];
                    var priceCell = dgvOrderDetails.Rows[e.RowIndex].Cells["Price"];
                    var totalAmountCell = dgvOrderDetails.Rows[e.RowIndex].Cells["TotalAmount"];

                    // Check if a value has been entered for Amount.
                    if (amountCell.Value != null)
                    {
                        // Check if the value is a valid integer.
                        if (int.TryParse(amountCell.Value.ToString(), out int amount))
                        {
                            // If valid, calculate TotalAmount = Price * Amount.
                            if (priceCell.Value != null)
                            {
                                decimal price = Convert.ToDecimal(priceCell.Value);
                                totalAmountCell.Value = amount * price;
                            }
                        }
                        else
                        {
                            // If invalid, show an error and reset the values.
                            MessageBox.Show("Số Lượng phải là một số nguyên hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            amountCell.Value = DBNull.Value;  // Set Amount to DBNull
                            totalAmountCell.Value = DBNull.Value;  // Set TotalAmount to DBNull
                        }
                    }
                    else
                    {
                        // If Amount is null, reset TotalAmount.
                        totalAmountCell.Value = DBNull.Value;
                    }
                }
            }
        }

        // Handle click on "Exit" button, close the current form and open the employee form.
        private void btnExit_Click(object sender, EventArgs e)
        {
            FrmEmployee frmEmployee = new FrmEmployee(userID);
            this.Hide();
            frmEmployee.ShowDialog();
            this.Close();
        }

        // Handle click on the "Choice" checkbox column in the DataGridView.
        private void dgvOrderDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvOrderDetails.Columns[e.ColumnIndex].Name == "Choice")
            {
                // Get the checkbox cell that was clicked.
                DataGridViewCheckBoxCell checkBoxCell = dgvOrderDetails.Rows[e.RowIndex].Cells["Choice"] as DataGridViewCheckBoxCell;

                if (checkBoxCell != null)
                {
                    // Commit the edit to make sure the checkbox value is updated.
                    dgvOrderDetails.CommitEdit(DataGridViewDataErrorContexts.Commit);

                    // Get the current checkbox value.
                    bool isChecked = Convert.ToBoolean(checkBoxCell.Value);

                    // Enable or disable "Amount" and "Note" based on whether the checkbox is checked.
                    dgvOrderDetails.Rows[e.RowIndex].Cells["Amount"].ReadOnly = !isChecked;
                    dgvOrderDetails.Rows[e.RowIndex].Cells["Note"].ReadOnly = !isChecked;
                    dgvOrderDetails.Rows[e.RowIndex].Cells["TotalAmount"].ReadOnly = !isChecked;

                    // If not checked, reset the values of "Amount", "Note", and "TotalAmount".
                    if (!isChecked)
                    {
                        dgvOrderDetails.Rows[e.RowIndex].Cells["TotalAmount"].Value = DBNull.Value;
                        dgvOrderDetails.Rows[e.RowIndex].Cells["Note"].Value = DBNull.Value;
                        dgvOrderDetails.Rows[e.RowIndex].Cells["Amount"].Value = DBNull.Value;                        
                    }
                }
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy các giá trị từ các điều khiển trong giao diện
                string MaPhieu = cbbOrderList.SelectedValue.ToString(); // Giả sử cbbOrderList là ComboBox chứa danh sách phiếu đặt
                string LoaiPhieuDat = cbbOrderType.SelectedItem?.ToString(); // Giả sử cbbOrderType là ComboBox chứa loại phiếu đặt
                string GhiChu = txbGeneralNote.Text; // Ghi chú từ TextBox
                int SLKhach = (int)nudCusNumber.Value; // Số lượng khách từ NumericUpDown
                DateTime ThoiGianDen = dtpArrivalTime.Value; // Thời gian đến từ DateTimePicker
                string DiaChi = txbReceiverAddress.Text; // Địa chỉ nhận từ TextBox
                string SDTNguoiNhan = txbReceiverPhoneNumber.Text; // Số điện thoại người nhận từ TextBox

                // Tạo DataTable để chuyển đổi dữ liệu CTPD
                DataTable CTPD = new DataTable();
                CTPD.Columns.Add("DishName", typeof(string));
                CTPD.Columns.Add("Amount", typeof(int));
                CTPD.Columns.Add("Price", typeof(int));
                CTPD.Columns.Add("TotalAmount", typeof(int));
                CTPD.Columns.Add("Note", typeof(string));

                // Lặp qua các dòng trong DataGridView dgvOrderDetails để thêm vào CTPD
                foreach (DataGridViewRow row in dgvOrderDetails.Rows)
                {
                    if (row.Cells["Amount"].Value != null && !string.IsNullOrEmpty(row.Cells["Amount"].Value.ToString()))
                    {
                        string dishName = row.Cells["DishName"].Value.ToString();
                        int amount = Convert.ToInt32(row.Cells["Amount"].Value);
                        int price = Convert.ToInt32(row.Cells["Price"].Value);
                        int totalAmount = Convert.ToInt32(row.Cells["TotalAmount"].Value);
                        string note = row.Cells["Note"].Value?.ToString() ?? string.Empty;

                        CTPD.Rows.Add(dishName, amount, price, totalAmount, note);
                    }
                }

                // Tạo tham số để gọi thủ tục
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Maphieu", MaPhieu),
                    new SqlParameter("@LoaiPhieuDat", LoaiPhieuDat),
                    new SqlParameter("@GhiChu", GhiChu),
                    new SqlParameter("@SLKhach", SLKhach),
                    new SqlParameter("@ThoiGianDen", ThoiGianDen),
                    new SqlParameter("@DiaChi", DiaChi),
                    new SqlParameter("@SDTNguoiNhan", SDTNguoiNhan),
                    new SqlParameter("@CTPD", CTPD) { SqlDbType = SqlDbType.Structured, TypeName = "dbo.CTPDType" }
                };

                // Gọi thủ tục lưu trữ để cập nhật phiếu đặt
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("USP_CapNhatPhieuDatOnline", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddRange(parameters);
                    cmd.ExecuteNonQuery();
                }

                // Thông báo thành công
                MessageBox.Show("Cập nhật phiếu đặt thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FrmEmployee frmEmployee = new FrmEmployee(userID);
            this.Hide();
            frmEmployee.ShowDialog();
            this.Close();
        }

    }
}
