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
            dataGridView1.Rows.Clear();

            DataTable dt = BLL.BLL_DiaDiem.SelectAllDiaDiem();
            foreach (DataRow row in dt.Rows)
            {
                dataGridView1.Rows.Add(row.ItemArray[(int)Support.BLL.Support.IDDiaDiem.QuocGia], row.ItemArray[(int)Support.BLL.Support.IDDiaDiem.ThanhPho], row.ItemArray[(int)Support.BLL.Support.IDDiaDiem.MaDiaDiem]);
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            BLL.BLL_DiaDiem.InsertDiaDiem(txtQuocGia.Text, txtThanhPho.Text);
            LoadDanhSachDiaDiem();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                BLL.BLL_DiaDiem.DeleteDiaDiem(dataGridView1.SelectedRows[0].Cells["MaDiaDiem"].Value.ToString());
                LoadDanhSachDiaDiem();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                BLL.BLL_DiaDiem.UpdateDiaDiem(dataGridView1.SelectedRows[0].Cells["MaDiaDiem"].Value.ToString(), txtQuocGia.Text, txtThanhPho.Text);
                LoadDanhSachDiaDiem();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để sửa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtQuocGia.Text = dataGridView1.SelectedRows[0].Cells["QuocGia"].Value.ToString();
                txtThanhPho.Text = dataGridView1.SelectedRows[0].Cells["ThanhPho"].Value.ToString();
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }
    }
}
