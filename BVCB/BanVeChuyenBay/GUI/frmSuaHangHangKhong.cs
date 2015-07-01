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
    public partial class frmSuaHangHangKhong : Form
    {
        public class Data
        {
            public string Name { get; set; }
            public string ID { get; set; }
        }

        public frmSuaHangHangKhong()
        {
            InitializeComponent();
        }

        private void frmSuaHangHangKhong_Load(object sender, EventArgs e)
        {
            LoadHangHangKhong();
        }

        //Load combobox Hang Hang Khong
        private void LoadHangHangKhong()
        {
            BindingList<Data> _comboItems = new BindingList<Data>();
            foreach (DataRow hhk in BLL.BLL_HangHangKhong.SelectAllHangHangKhong().Rows)
            {
                _comboItems.Add(new Data { Name = hhk["MaHang"].ToString(), ID = hhk["TenHang"].ToString() });
            }
            cbMaHang.DisplayMember = "Name";
            cbMaHang.ValueMember = "ID";
            cbMaHang.DataSource = _comboItems;
            if (cbMaHang.Items.Count > 0)
                cbMaHang.SelectedIndex = 0;
        }

        private void cbMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenHang.Text = cbMaHang.SelectedValue.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            BLL.BLL_HangHangKhong.UpdateHangHangKhong(cbMaHang.Text, txtTenHang.Text);
            MessageBox.Show("Sửa thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BLL.BLL_LogNguoiDung.InsertLogNguoiDung(frmMain.TenDangNhap, DateTime.Now, "Sửa hãng hàng không " + cbMaHang.Text);
        }
    }
}
