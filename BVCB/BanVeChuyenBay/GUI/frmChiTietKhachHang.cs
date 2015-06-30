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
    public partial class frmChiTietKhachHang : Form
    {
        string MaKhachHang = null;
        public class Data
        {
            public string Name { get; set; }
            public string ID { get; set; }
        }

        //Load khach hang
        public void LoadKhachHang()
        {
            BindingList<Data> _comboItems = new BindingList<Data>();
            BindingList<Data> _comboItems2 = new BindingList<Data>();
            foreach (DataRow kh in BLL.BLL_NhanVien.SelectALLKhachHang().Rows)
            {
                _comboItems.Add(new Data { Name = kh["TenNhanVien"].ToString(), ID = kh["MaNhanVien"].ToString() });
                _comboItems2.Add(new Data { Name = kh["MaNhanVien"].ToString(), ID = kh["TenNhanVien"].ToString() });
            }
            cbKhachHang.DisplayMember = "Name";
            cbKhachHang.ValueMember = "ID";
            cbKhachHang.DataSource = _comboItems;
            if (cbKhachHang.Items.Count > 0)
                cbKhachHang.SelectedIndex = 0;

            cbMaKhachHang.DisplayMember = "Name";
            cbMaKhachHang.ValueMember = "ID";
            cbMaKhachHang.DataSource = _comboItems2;
            if (cbMaKhachHang.Items.Count > 0)
                cbMaKhachHang.SelectedIndex = 0;
        }

        public frmChiTietKhachHang()
        {
            InitializeComponent();
        }

        public frmChiTietKhachHang(string _MaKhachHang)
        {
            InitializeComponent();
            MaKhachHang = _MaKhachHang;
        }

        private void cbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.BLL_KhachHang.Select_ChiTietKhachHangAll(cbKhachHang.SelectedValue.ToString());
            cbMaKhachHang.SelectedValue = cbKhachHang.Text;
        }

        private void frmChiTietKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
            if (MaKhachHang != null)
            {
                cbKhachHang.SelectedValue = MaKhachHang;
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbMaKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbKhachHang.SelectedValue = cbMaKhachHang.Text;
        }
    }
}
