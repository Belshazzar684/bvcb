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
    public partial class frmQuanLyDiaDiem : Form
    {
        public frmQuanLyDiaDiem()
        {
            InitializeComponent();
            LoadDanhSachDiaDiem();
        }

        void LoadDanhSachDiaDiem()
        {
            dgwDsDiaDiem.Rows.Clear();

            DataTable dt = BLL.BLL_DiaDiem.SelectAllDiaDiem();
            foreach (DataRow row in dt.Rows)
            {
                dgwDsDiaDiem.Rows.Add(row.ItemArray[(int)Support.BLL.Support.IDDiaDiem.QuocGia], row.ItemArray[(int)Support.BLL.Support.IDDiaDiem.ThanhPho], row.ItemArray[(int)Support.BLL.Support.IDDiaDiem.MaDiaDiem]);
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            BLL.BLL_DiaDiem.InsertDiaDiem(txtQuocGia.Text, txtThanhPho.Text);
            LoadDanhSachDiaDiem();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dgwDsDiaDiem.SelectedRows.Count > 0)
            {
                BLL.BLL_DiaDiem.DeleteDiaDiem(dgwDsDiaDiem.SelectedRows[0].Cells["MaDiaDiem"].Value.ToString());
                LoadDanhSachDiaDiem();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (dgwDsDiaDiem.SelectedRows.Count > 0)
            {
                BLL.BLL_DiaDiem.UpdateDiaDiem(dgwDsDiaDiem.SelectedRows[0].Cells["MaDiaDiem"].Value.ToString(), txtQuocGia.Text, txtThanhPho.Text);
                LoadDanhSachDiaDiem();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để sửa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwDsDiaDiem.SelectedRows.Count > 0)
            {
                txtQuocGia.Text = dgwDsDiaDiem.SelectedRows[0].Cells["QuocGia"].Value.ToString();
                txtThanhPho.Text = dgwDsDiaDiem.SelectedRows[0].Cells["ThanhPho"].Value.ToString();
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }

        ///sự kiện click nút thêm từ file
        ///chức năng: thêm địa điểm từ file
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
                            if (table.Rows.Count >=2 && table.Columns.Count >= 2)
                            {
                                for (int i = 2; i < table.Rows.Count; i++)
                                {
                                    if (table.Rows[i] != null
                                        && !String.IsNullOrEmpty(table.Rows[i][0].ToString())
                                            && !String.IsNullOrEmpty(table.Rows[i][1].ToString()))
                                    {
                                        try
                                        {
                                            BLL.BLL_DiaDiem.InsertDiaDiem(table.Rows[i][0].ToString(), table.Rows[i][1].ToString());
                                            count++;
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
                            MessageBox.Show("Không thêm được dòng dữ liệu nào.");
                        else
                        {
                            LoadDanhSachDiaDiem();
                            MessageBox.Show("Có " + count.ToString() + " địa điểm được thêm vào.");
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
