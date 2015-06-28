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
        ///mô tả: chọn file excel chứa dữ liệu và hiển thị lên lưới
        private void btnThemTuFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "Excel files (*.xls, *.xlsx)|*.xls;*.xlsx";
                dlg.Multiselect = false;
                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string filePath = dlg.FileName;
                    List<string> data = Utilities.Instance.ReadFileExcel(filePath);
                    if (data == null)
                        MessageBox.Show("Đọc file thất bại");
                    else
                    {
                        for (int i = 0; i * 2 < data.Count; i++)
                        {
                            if (!String.IsNullOrEmpty(data[2*i]) && !String.IsNullOrEmpty(data[2*i + 1]))
                                dgwDsDiaDiem.Rows.Add(data[2*i], data[2*i + 1]);
                        }
                        MessageBox.Show("Đọc file thành công");
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Có lỗi trong quá trình đọc file");
            }
        }
    }
}
