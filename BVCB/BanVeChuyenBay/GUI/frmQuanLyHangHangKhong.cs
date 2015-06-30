using BanVeChuyenBay.SqlHelper;
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
    public partial class frmQuanLyHangHangKhong : Form
    {
        public frmQuanLyHangHangKhong()
        {
            InitializeComponent();
        }

        ///sự kiện click btThem
        ///chức năng: hiển thị frmThemHangHangKhong
        ///mô tả:
        private void btThem_Click(object sender, EventArgs e)
        {
            new frmThemHangHangKhong().Show();
        }

        ///sự kiện click btSua
        ///chức năng: hiển thị frmSuaHangHangKhong
        ///mô tả:
        private void btSua_Click(object sender, EventArgs e)
        {
            new frmSuaHangHangKhong().Show();
        }

        ///sự kiện click nút thêm từ file
        ///chức năng: thêm hãng hàng không từ file
        ///mô tả: chọn file excel chứa dữ liệu và thêm vào csdl
        private void btnThemTuFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (frmDinhDangFileNhap.Instance.CheckRemind)
                {
                    frmDinhDangFileNhap.Instance.CheckOk = false;
                    frmDinhDangFileNhap.Instance.ShowDialog();
                    if (!frmDinhDangFileNhap.Instance.CheckOk)
                        return;
                }

                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "Excel files (*.xls, *.xlsx)|*.xls;*.xlsx";
                dlg.Multiselect = false;
                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string filePath = dlg.FileName;
                    DataTableCollection tables = Utilities.Instance.ReadFileExcel(filePath);
                    if (tables == null)
                        MessageBox.Show("Đọc file thất bại");
                    else
                    {
                        int count = 0;
                        foreach (DataTable table in tables)
                        {
                            if (table.Rows.Count >= 2 && table.Columns.Count >= 1)
                            {
                                for (int i = 2; i < table.Rows.Count; i++)
                                {
                                    if (table.Rows[i] != null
                                        && !String.IsNullOrEmpty(table.Rows[i][0].ToString()))
                                    {
                                        try
                                        {
                                            //if (BLL.BLL_HangHangKhong.KiemTraHang(table.Rows[i][0].ToString()) == 0)
                                            {
                                                //BLL.BLL_HangHangKhong.InsertHangHangKhong(table.Rows[i][0].ToString());
                                                count++;
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            Debug.WriteLine(ex.Message);
                                        }
                                    }
                                }
                            }
                        }
                        if (count == 0)
                            MessageBox.Show("Không thêm được hãng hàng không nào.");
                        else
                        {
                            //LoadDSHangHangKhong();
                            MessageBox.Show("Có " + count.ToString() + " hãng hàng không được thêm vào.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Có lỗi trong quá trình thêm dữ liệu");
            }
        }
    }
}
