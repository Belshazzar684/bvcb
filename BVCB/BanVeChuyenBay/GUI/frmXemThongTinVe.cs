using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanVeChuyenBay.GUI
{
    public partial class frmXemThongTinVe : Form
    {
        string MaKhachHang = null;
        public frmXemThongTinVe()
        {
            InitializeComponent();
        }

        public frmXemThongTinVe(string _MaKhachHang)
        {
            InitializeComponent();
            MaKhachHang = _MaKhachHang;
        }

        private void frmXemThongTinVe_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            if (MaKhachHang != null)
            {
                dataGridView1.DataSource = BLL.BLL_KhachHang.Select_ChiTietKhachHangAll(MaKhachHang);
            }
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataTable cb = BLL.BLL_LichChuyenBay.SelectAtLichChuyenBay(dataGridView1.Rows[e.RowIndex].Cells["MaChuyenBay"].Value.ToString());
            DateTime NgayBay = DateTime.Parse(cb.Rows[0]["KhoiHanh"].ToString());
            if (NgayBay.CompareTo(DateTime.Now) <= 0)
            {
                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells["HuyVe"];
                DataGridViewCheckBoxCell chkCell = cell as DataGridViewCheckBoxCell;
                chkCell.Value = false;
                chkCell.FlatStyle = FlatStyle.Flat;
                chkCell.Style.ForeColor = Color.DarkGray;
                cell.ReadOnly = true;

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn lưu những thay đổi", "Thông báo", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if ((bool)dataGridView1.Rows[i].Cells["HuyVe"].EditedFormattedValue == true)
                    {
                        BLL.BLL_CT_PhieuDatCho.DeleteCT_PhieuDatCho(dataGridView1.Rows[i].Cells["MaPhieuDat"].Value.ToString());
                        BLL.BLL_PhieuDatCho.DeletePhieuDatCho(dataGridView1.Rows[i].Cells["MaPhieuDat"].Value.ToString());

                        //Update DoanhThuChuyenBay
                        DataTable updateDoanhThuChuyenBay = BLL.BLL_BaoCaoDoanhThuChuyenBay.SelectAllDoanhThuChuyenBay(dataGridView1.Rows[i].Cells["MaChuyenBay"].Value.ToString());

                        foreach (DataRow temp in updateDoanhThuChuyenBay.Rows)
                        {
                            BLL.BLL_BaoCaoDoanhThuChuyenBay.UpdateBaoCaoDoanhThuChuyenBay(int.Parse(temp.ItemArray[1].ToString()), int.Parse(temp.ItemArray[2].ToString()), dataGridView1.Rows[i].Cells["MaChuyenBay"].Value.ToString(), Convert.ToInt32(temp.ItemArray[3].ToString()), Convert.ToInt32(temp.ItemArray[4].ToString()), 0.0f);
                        }

                        LoadDataGridView();
                    }
                }
                BLL.BLL_LogNguoiDung.InsertLogNguoiDung(frmMain.TenDangNhap, DateTime.Now, "Hủy vé ");

            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
    }
}
