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
    public partial class frmThayDoiQD1 : Form
    {
        public frmThayDoiQD1()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtTGBayToiThieu.Text) < 0 || Convert.ToInt32(txtSoSBTGToiDa.Text) < 0
                    || Convert.ToInt32(txtTGDToiThieu.Text) < 0 || Convert.ToInt32(txtTGDToiDa.Text) < 0)
                {
                    MessageBox.Show("Số không được âm", "Lỗi");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng kiểu dữ liệu", "Lỗi");
                return;
            }

            int tgbaytoithieu = Convert.ToInt32(txtTGBayToiThieu.Text);
            int sosbtgtoida = Convert.ToInt32(txtSoSBTGToiDa.Text);
            int tgdungtoithieu = Convert.ToInt32(txtTGDToiThieu.Text);
            int tgdungtoida = Convert.ToInt32(txtTGDToiDa.Text);

            BLL.BLL_ThamSo.UpdateThamSo(tgbaytoithieu, sosbtgtoida, tgdungtoithieu, tgdungtoida);
            MessageBox.Show("Nhập thành công", "Thông báo");
            BLL.BLL_LogNguoiDung.InsertLogNguoiDung(frmMain.TenDangNhap, DateTime.Now, "Thay đổi quy định về một chuyến bay");
        }
    }
}
