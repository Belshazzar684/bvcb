using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanVeChuyenBay.GUI
{
    public partial class frmTraCuuChuyenBay : Form
    {
        DataTable DSSanBay;
        public frmTraCuuChuyenBay()
        {
            InitializeComponent();

            DSSanBay = BLL.BLL_SanBay.SelectAllSanBay();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            #region Old code
            /*
            DataTable lichchuyenbay = BLL.BLL_LichChuyenBay.SelectTraCuuWithDateTime(dtpTuNgay.Value, dtpDenNgay.Value);
            DataRow[] rows = null;

            
            if (cbSanBayDi.Text.Equals(""))
                rows = lichchuyenbay.Select();
            else
                rows = lichchuyenbay.Select("SanBayDi='" + txtTenSanBayDi.Text + "'");

            
            if (rows.Count() == 0)
            {
                MessageBox.Show("Không tìm thấy", "Thông báo");
                return;
            }

            
            for(int i = 0; i < rows.Count(); i++)
            {
                if (cbSanBayDen.Text.Equals("")) 
                    dgwDSChuyenBay.Rows.Add(rows[i].ItemArray[1], rows[i].ItemArray[2], rows[i].ItemArray[3], rows[i].ItemArray[4], rows[i].ItemArray[7], rows[i].ItemArray[6]);
                else if(rows[i].ItemArray[2].Equals(txtTenSanBayDen.Text))
                    dgwDSChuyenBay.Rows.Add(rows[i].ItemArray[1], rows[i].ItemArray[2], rows[i].ItemArray[3], rows[i].ItemArray[4], rows[i].ItemArray[7], rows[i].ItemArray[6]);
            }
             */
            #endregion
            try
            {
                dgwDSChuyenBay.Rows.Clear();
                string maChuyenBay = String.Empty;
                string maSanBayDi = String.Empty;
                string maSanBayDen = String.Empty;
                DateTime? ngayKhoiHanhMin = new DateTime();
                DateTime? ngayKhoiHanhMax = new DateTime();
                double? giaVeMin = 0.0f;
                double? giaVeMax = 0.0f;
                bool? tinhTrangGheTrong = true;

                if (chbMaChuyenBay.Checked)
                    maChuyenBay = txtMaChuyenBay.Text;
                else
                    maChuyenBay = null;
                if (chbSanBayDi.Checked)
                    maSanBayDi = cbSanBayDi.Text;
                else
                    maSanBayDi = null;
                if (chbSanBayDen.Checked)
                    maSanBayDen = cbSanBayDen.Text;
                else
                    maSanBayDen = null;
                if (chbNgayKhoiHanh.Checked)
                {
                    ngayKhoiHanhMin = dtpTuNgay.Value;
                    ngayKhoiHanhMax = dtpDenNgay.Value;
                }
                else
                {
                    ngayKhoiHanhMin = null;
                    ngayKhoiHanhMax = null;
                }
                if (chbGiaVe.Checked)
                {
                    giaVeMin = txtGiaVeMin.Value;
                    giaVeMax = txtGiaVeMax.Value;
                }
                else
                {
                    giaVeMin = null;
                    giaVeMax = null;
                }
                if (chbTinhTrang.Checked)
                {
                    if (rbtnConGhe.Checked)
                        tinhTrangGheTrong = true;
                    else
                        tinhTrangGheTrong = false;
                }
                else
                    tinhTrangGheTrong = null;

                DataTable data = BLL.BLL_LichChuyenBay.SearchLichChuyenBay(maChuyenBay, maSanBayDi, maSanBayDen,
                    ngayKhoiHanhMin, ngayKhoiHanhMax, giaVeMin, giaVeMax, tinhTrangGheTrong);
                if (data == null)
                    MessageBox.Show("Có lỗi xảy ra trong quá trình truy vấn dữ liệu", "Thông báo");
                else if (data.Rows.Count == 0)
                    MessageBox.Show("Không có lịch chuyến bay nào phù hợp", "Thông báo");
                else
                {
                    foreach (DataRow row in data.Rows)
                    {
                        dgwDSChuyenBay.Rows.Add(row["MaChuyenBay"].ToString(), row["SanBayDi"].ToString(),
                            row["SanBayDen"].ToString(), row["KhoiHanh"].ToString(), row["ThoiGianBay"].ToString(),
                            row["SoGheTrong"].ToString(), row["GiaVe"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Có lỗi xảy ra trong quá trình truy vấn dữ liệu", "Thông báo");
            }
        }

        private void cbSanBayDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!cbSanBayDi.Text.Equals(""))
            {
                DataRow[] row = DSSanBay.Select("MaSanBay='" + cbSanBayDi.Text + "'");

                txtTenSanBayDi.Text = row[0].ItemArray[(int)Support.BLL.Support.IDSanBay.TenSanBay].ToString();
            }
        }

        private void cbSanBayDen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cbSanBayDen.Text.Equals(""))
            {
                DataRow[] row = DSSanBay.Select("MaSanBay='" + cbSanBayDen.Text + "'");

                txtTenSanBayDen.Text = row[0].ItemArray[(int)Support.BLL.Support.IDSanBay.TenSanBay].ToString();
            }
        }

        private void cbSanBayDi_MouseClick(object sender, MouseEventArgs e)
        {
            cbSanBayDi.Items.Clear();
            txtTenSanBayDi.Text = "";
            foreach (DataRow row in DSSanBay.Rows)
            {
                cbSanBayDi.Items.Add(row.ItemArray[(int)Support.BLL.Support.IDSanBay.MaSanBay]);
            }
        }

        private void cbSanBayDen_MouseClick(object sender, MouseEventArgs e)
        {
            cbSanBayDen.Items.Clear();
            txtTenSanBayDen.Text = "";
            foreach (DataRow row in DSSanBay.Rows)
            {
                cbSanBayDen.Items.Add(row.ItemArray[(int)Support.BLL.Support.IDSanBay.MaSanBay]);
            }
        }

        ///sự kiện nhập ở textbox txtMaChuyenBay
        ///chức năng: chặn các ký tự đặc biệt
        ///mô tả:
        private void txtMaChuyenBay_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                int keyCode = (int)e.KeyChar;
                if ((keyCode >= 48 && keyCode <= 57)
                    || (keyCode >= 65 && keyCode <= 90)
                    || (keyCode >= 97 && keyCode <= 122)
                    || (keyCode == 8))
                    e.Handled = false;
                else
                    e.Handled = true;
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
            }
        }

        ///sự kiện thay đổi ngày ở dtpTuNgay
        ///chức năng: thay đổi giá trị ngày ở dtpDenNgay
        ///mô tả:
        private void dtpTuNgay_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtpTuNgay.Value > dtpDenNgay.Value)
                    dtpDenNgay.Value = dtpTuNgay.Value;
                dtpDenNgay.MinDate = dtpTuNgay.Value;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        ///sự kiện thay đổi giá tiền ở txtGiaVeMin
        ///chức năng: thay đổi giá tiền ở txtGiaVeMax
        ///mô tả:
        private void txtGiaVeMin_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtGiaVeMin.Value > txtGiaVeMax.Value)
                    txtGiaVeMax.Value = txtGiaVeMin.Value;
                txtGiaVeMax.MinValue = txtGiaVeMin.Value;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
