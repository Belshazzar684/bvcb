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
    public partial class frmQuanLyTuyenBay : Form
    {
        public frmQuanLyTuyenBay()
        {
            InitializeComponent();
            LoadDanhSachTuyenBay();
        }

        void LoadDanhSachTuyenBay()
        {
            dataGridView1.Rows.Clear();

            DataTable dt = BLL.BLL_TuyenBay.SelectAllTuyenBay();
            foreach(DataRow row in dt.Rows)
            {
                dataGridView1.Rows.Add(row.ItemArray[(int)Support.BLL.Support.IDTuyenBay.MaTuyenBay], row.ItemArray[(int)Support.BLL.Support.IDTuyenBay.MaSanBayDi], row.ItemArray[(int)Support.BLL.Support.IDTuyenBay.MaSanBayDen]);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            frmThemTuyenBay form = new frmThemTuyenBay();
            form.Show();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            frmXoaTuyenBay form = new frmXoaTuyenBay();
            form.Show();
        }

      
        private void buttonX1_Click(object sender, EventArgs e)
        {
            LoadDanhSachTuyenBay();
        }


        ///sự kiện click nút thêm từ file
        ///chức năng: thêm tuyến bay từ file
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
                            if (table.Rows.Count >= 2 && table.Columns.Count >= 2)
                            {
                                for (int i = 2; i < table.Rows.Count; i++)
                                {
                                    if (table.Rows[i] != null
                                        && !String.IsNullOrEmpty(table.Rows[i][0].ToString())
                                            && !String.IsNullOrEmpty(table.Rows[i][1].ToString()))
                                    {
                                        try
                                        {
                                            if (BLL.BLL_TuyenBay.KiemTraTuyenBay(table.Rows[i][0].ToString(), table.Rows[i][1].ToString()) == 0)
                                            {
                                                BLL.BLL_TuyenBay.InsertTuyenBay(table.Rows[i][0].ToString(), table.Rows[i][1].ToString());
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
                            MessageBox.Show("Không thêm được tuyến bay nào.");
                        else
                        {
                            LoadDanhSachTuyenBay();
                            MessageBox.Show("Có " + count.ToString() + " tuyến bay được thêm vào.");
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
