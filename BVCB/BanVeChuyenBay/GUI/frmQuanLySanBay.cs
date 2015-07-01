using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanVeChuyenBay;
using BanVeChuyenBay.SqlHelper;
using System.Diagnostics;

namespace BanVeChuyenBay.GUI
{
    public partial class frmQuanLySanBay : Form
    {
        public frmQuanLySanBay()
        {
            InitializeComponent();
            LoadDanhSachSanBay();
        }

        void LoadDanhSachSanBay()
        {
            dataGridView1.Rows.Clear();

            DataTable dt = BLL.BLL_SanBay.SelectAllSanBay();
            DataTable dtDiaDiem = new DataTable();
            foreach(DataRow row in dt.Rows)
            {
                dtDiaDiem = BLL.BLL_DiaDiem.SelectDiaDiem(row.ItemArray[(int)Support.BLL.Support.IDSanBay.MaDiaDiem].ToString());
                dataGridView1.Rows.Add(row.ItemArray[(int)Support.BLL.Support.IDSanBay.MaSanBay], row.ItemArray[(int)Support.BLL.Support.IDSanBay.TenSanBay], dtDiaDiem.Rows[0].ItemArray[(int)Support.BLL.Support.IDDiaDiem.QuocGia], dtDiaDiem.Rows[0].ItemArray[(int)Support.BLL.Support.IDDiaDiem.ThanhPho]);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            frmXoaSanBay form = new frmXoaSanBay();
            form.Show();

            LoadDanhSachSanBay();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            frmSuaSanBay form = new frmSuaSanBay();
            form.Show();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            frmThemSanBay form = new frmThemSanBay();
            form.Show();

            LoadDanhSachSanBay();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            LoadDanhSachSanBay();
        }

        ///sự kiện click nút thêm từ file
        ///chức năng: thêm sân bay từ file
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
                            if (table.Rows.Count >= 2 && table.Columns.Count >= 3)
                            {
                                for (int i = 2; i < table.Rows.Count; i++)
                                {
                                    if (table.Rows[i] != null
                                        && !String.IsNullOrEmpty(table.Rows[i][0].ToString())
                                            && !String.IsNullOrEmpty(table.Rows[i][1].ToString())
                                            && !String.IsNullOrEmpty(table.Rows[i][2].ToString()))
                                    {
                                        try
                                        {
                                            if (BLL.BLL_SanBay.KiemTraSanBay(table.Rows[i][0].ToString()) == 0)
                                            {
                                                BLL.BLL_SanBay.InsertSanBay(table.Rows[i][0].ToString(),
                                                    table.Rows[i][1].ToString(), table.Rows[i][2].ToString());
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
                            MessageBox.Show("Không thêm được sân bay nào.");
                        else
                        {
                            LoadDanhSachSanBay();
                            MessageBox.Show("Có " + count.ToString() + " sân bay được thêm vào.");
                            BLL.BLL_LogNguoiDung.InsertLogNguoiDung(frmMain.TenDangNhap, DateTime.Now, "Thêm" + count.ToString() + "sân bay từ File");

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
