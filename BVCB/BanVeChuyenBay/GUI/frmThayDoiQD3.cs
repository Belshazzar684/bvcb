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
    public partial class frmThayDoiQD3 : Form
    {
        public frmThayDoiQD3()
        {
            InitializeComponent();
            cbHuyDatCho.Items.Add("True");
            cbHuyDatCho.Items.Add("False");

            cbHuyDatCho.SelectedIndex = 0;
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
                if(Convert.ToInt32(txtTGDatVe.Text) < 0)
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

            BLL.BLL_ThamSo.UpdateThamSo(Convert.ToBoolean(cbHuyDatCho.Text), Convert.ToInt32(txtTGDatVe.Text));
            MessageBox.Show("Nhập thành công", "Thông báo");
        }
    }
}
