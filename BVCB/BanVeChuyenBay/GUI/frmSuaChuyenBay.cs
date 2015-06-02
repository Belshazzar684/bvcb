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
    public partial class frmSuaChuyenBay : Form
    {

        DataTable DSSanBay, DSSanBayDen, DSSanBayDi, DSTuyenBay, DSThamSo, DSLichChuyenBay, DSCT_Ghe, DSCT_LichChuyenBay;
        int MaxSBTrungGian, MaxTGDung, MinTGDung, MinTGBay;
        public frmSuaChuyenBay()
        {
            InitializeComponent();
            DSTuyenBay = BLL.BLL_TuyenBay.SelectAllTuyenBay();
            DSThamSo = BLL.BLL_LichChuyenBay.SelectAllThamSo();
            MaxSBTrungGian = Convert.ToInt32(DSThamSo.Rows[0].ItemArray[(int)Support.BLL.Support.IDThamSo.MaxSoSanBayTG]);
            MaxTGDung = Convert.ToInt16(DSThamSo.Rows[0].ItemArray[(int)Support.BLL.Support.IDThamSo.MaxTGDung]);
            MinTGDung = Convert.ToInt16(DSThamSo.Rows[0].ItemArray[(int)Support.BLL.Support.IDThamSo.MinTGDung]);
            MinTGBay = Convert.ToInt16(DSThamSo.Rows[0].ItemArray[(int)Support.BLL.Support.IDThamSo.MinTGBay]);
        }

        private void loadSoHangVe()
        {
            DataTable dt = BLL.BLL_HangVe.SelectAllHangVe();
            DataRow row;

            int MaxRowHangVe = dt.Rows.Count;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                row = dt.Rows[i];
                if (dataGridView2.Rows.Count >= MaxRowHangVe)
                {
                    dataGridView2.AllowUserToAddRows = false;
                }

                dataGridView2.Rows.Add(row.ItemArray[0], row.ItemArray[1], "");
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbMaChuyenBay_MouseClick(object sender, MouseEventArgs e)
        {
            cbMaChuyenBay.Items.Clear();

            DSLichChuyenBay = BLL.BLL_LichChuyenBay.SelectAllLichChuyenBay();

            foreach (DataRow row in DSLichChuyenBay.Rows)
            {
                cbMaChuyenBay.Items.Add(row.ItemArray[(int)Support.BLL.Support.IDLichChuyenBay.MaChuyenBay]);
            }
        }

        private void cbMaSanBayDi_MouseClick(object sender, MouseEventArgs e)
        {
            cbSanBayDi.Items.Clear();
            if (cbSanBayDen.Text.Equals(""))
            {

                if (DSSanBayDi == null)
                    DSSanBayDi = BLL.BLL_TuyenBay.SelectAtColumnsTuyenBay("MaSanBayDi");
                

                foreach (DataRow row in DSSanBayDi.Rows)
                {
                    cbSanBayDi.Items.Add(row.ItemArray[(int)Support.BLL.Support.IDSanBay.TenSanBay]);
                }
            }
            else
            {
           
                if(DSTuyenBay == null)
                    DSTuyenBay = BLL.BLL_TuyenBay.SelectAllTuyenBay();

                if(DSSanBay == null)
                    DSSanBay = BLL.BLL_SanBay.SelectAllSanBay();

                
                DataRow[] rows = DSSanBay.Select("TenSanBay='" + cbSanBayDen.Text + "'");
                String MaSanBayDen = rows[0].ItemArray[(int)Support.BLL.Support.IDSanBay.MaSanBay].ToString();
                rows = DSTuyenBay.Select("MaSanBayDen='" + MaSanBayDen + "'");
                for(int i = 0; i < rows.Count(); i++)
                {
                    DataRow[] temp = DSSanBay.Select("MaSanBay='" + rows[i].ItemArray[(int)Support.BLL.Support.IDTuyenBay.MaSanBayDi] + "'");

                    cbSanBayDi.Items.Add(temp[0].ItemArray[(int)Support.BLL.Support.IDSanBay.TenSanBay]);
                }
            }
        }

        private void cbMaSanBayDen_MouseClick(object sender, MouseEventArgs e)
        {
            cbSanBayDen.Items.Clear();
            if (cbSanBayDi.Text.Equals(""))
            {
                if (DSSanBayDen == null)
                    DSSanBayDen = BLL.BLL_TuyenBay.SelectAtColumnsTuyenBay("MaSanBayDen");

                foreach (DataRow row in DSSanBayDen.Rows)
                {
                    cbSanBayDen.Items.Add(row.ItemArray[(int)Support.BLL.Support.IDSanBay.TenSanBay]);
                }
            }
            else
            {
                if (DSTuyenBay == null)
                    DSTuyenBay = BLL.BLL_TuyenBay.SelectAllTuyenBay();

                if (DSSanBay == null)
                    DSSanBay = BLL.BLL_SanBay.SelectAllSanBay();


                DataRow[] rows = DSSanBay.Select("TenSanBay='" + cbSanBayDi.Text + "'");
                String MaSanBayDi = rows[0].ItemArray[(int)Support.BLL.Support.IDSanBay.MaSanBay].ToString();
                rows = DSTuyenBay.Select("MaSanBayDi='" + MaSanBayDi + "'");
                for (int i = 0; i < rows.Count(); i++)
                {
                    DataRow[] temp = DSSanBay.Select("MaSanBay='" + rows[i].ItemArray[(int)Support.BLL.Support.IDTuyenBay.MaSanBayDen] + "'");

                    cbSanBayDen.Items.Add(temp[0].ItemArray[(int)Support.BLL.Support.IDSanBay.TenSanBay]);
                }
            }
        }

        void UpdateDanhSachSanBayTrungGian()
        {
            // dam bao danh sach san bay trung gian khong bi trung voi san bay den, san bay di
            try
            {
                SanBayTrungGian.Selected = false;
                SanBayTrungGian.Items.Clear();

                if (DSSanBay == null)
                    DSSanBay = BLL.BLL_SanBay.SelectAllSanBay();
                foreach (DataRow row in DSSanBay.Rows)
                {
                    if (!row.ItemArray[1].Equals(cbSanBayDi.SelectedItem) && !row.ItemArray[1].Equals(cbSanBayDen.SelectedItem))
                    {
                        SanBayTrungGian.Items.Add(row.ItemArray[(int)Support.BLL.Support.IDSanBay.TenSanBay]);
                    }
                }
            }
            catch
            {
            }

        }

        private void cbMaChuyenBay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if( !cbMaChuyenBay.Text.Equals(""))
            {
                DataRow []rows = DSLichChuyenBay.Select("MaChuyenBay='" + cbMaChuyenBay.Text + "'");

                String MaTuyenBay = rows[0].ItemArray[(int)Support.BLL.Support.IDLichChuyenBay.MaTuyenBay].ToString();
                dtpNgayGio.Value = (DateTime)rows[0].ItemArray[(int)Support.BLL.Support.IDLichChuyenBay.KhoiHanh];
                txtThoiGianBay.Text = rows[0].ItemArray[(int)Support.BLL.Support.IDLichChuyenBay.ThoiGianBay].ToString();
                txtGiaVe.Text = rows[0].ItemArray[(int)Support.BLL.Support.IDLichChuyenBay.GiaVe].ToString();

                DSSanBay = BLL.BLL_SanBay.SelectAllSanBay();
                DSTuyenBay = BLL.BLL_TuyenBay.SelectAllTuyenBay();
                rows = DSTuyenBay.Select("MaTuyenBay='" + MaTuyenBay + "'");

                String MaSanBayDi, MaSanBayDen;
                MaSanBayDi = rows[0].ItemArray[(int)Support.BLL.Support.IDTuyenBay.MaSanBayDi].ToString();
                MaSanBayDen = rows[0].ItemArray[(int)Support.BLL.Support.IDTuyenBay.MaSanBayDen].ToString();

                // dien ten san bay vao combobox san bay den, san bay di
                cbSanBayDen.Items.Clear();
                rows = DSSanBay.Select("MaSanBay='" + MaSanBayDen + "'");
                cbSanBayDen.Items.Add(rows[0].ItemArray[(int)Support.BLL.Support.IDSanBay.TenSanBay].ToString());
                cbSanBayDen.SelectedIndex = 0;

                cbSanBayDi.Items.Clear();
                rows = DSSanBay.Select("MaSanBay='" + MaSanBayDi + "'");
                cbSanBayDi.Items.Add(rows[0].ItemArray[(int)Support.BLL.Support.IDSanBay.TenSanBay].ToString());
                cbSanBayDi.SelectedIndex = 0;


                DSCT_Ghe = BLL.BLL_CT_Ghe.SelectAtCT_Ghe(cbMaChuyenBay.Text);
                DataTable dt = BLL.BLL_HangVe.SelectAllHangVe();
                dataGridView2.Rows.Clear();
                foreach(DataRow row in DSCT_Ghe.Rows)
                {
                    if (dataGridView2.Rows.Count >= DSCT_Ghe.Rows.Count)
                    {
                        dataGridView2.AllowUserToAddRows = false;
                    }
                    DataRow[] tenhangve = dt.Select("MaHangVe='" + row.ItemArray[(int)Support.BLL.Support.IDCTGhe.MaHangVe] + "'");
                    dataGridView2.Rows.Add(row.ItemArray[(int)Support.BLL.Support.IDCTGhe.MaHangVe], tenhangve[0].ItemArray[(int)Support.BLL.Support.IDHangVe.TenHangVe], row.ItemArray[(int)Support.BLL.Support.IDCTGhe.SoGhe]);
                }

                
                DSCT_LichChuyenBay = BLL.BLL_CT_LichChuyenBay.SelectAtCT_LichChuyenBay(cbMaChuyenBay.Text);
                
                dataGridView1.Rows.Clear();
                int temp = 0;
                foreach (DataRow row in DSCT_LichChuyenBay.Rows)
                {
                    rows = DSSanBay.Select("MaSanBay='" + row.ItemArray[(int)Support.BLL.Support.IDCTLichChuyenBay.MaSanBayTrungGian] + "'");

                    DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)dataGridView1.Rows[temp].Cells[0];
                    cell.Items.Add(rows[0].ItemArray[(int)Support.BLL.Support.IDSanBay.TenSanBay]);
                    cell.Value = rows[0].ItemArray[(int)Support.BLL.Support.IDSanBay.TenSanBay];
                    

                    dataGridView1.Rows[temp].Cells[1].Value = row.ItemArray[3];
                    dataGridView1.Rows[temp].Cells[2].Value = row.ItemArray[4];

                    temp++;
                }
            }
        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (dataGridView1.Rows.Count > MaxSBTrungGian)
                dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DSSanBay = BLL.BLL_SanBay.SelectAllSanBay();
                DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)dataGridView1.Rows[e.RowIndex].Cells[0];
                cell.Items.Clear();
                cell.Value = null;

                foreach (DataRow row in DSSanBay.Rows)
                {
                    cell.Items.Add(row.ItemArray[(int)Support.BLL.Support.IDSanBay.TenSanBay]);
                }
            }
        }


        class LichChuyenBay
        {
            public string MaChuyenBay;
            public string MaTuyenBay;
            public DateTime KhoiHanh;
            public int ThoiGianBay;
            public int DonGia;


            public LichChuyenBay(string maChuyenBay, string maTuyenBay, DateTime khoiHanh, int donGia, int thoiGianBay)
            {
                this.MaChuyenBay = maChuyenBay;
                this.KhoiHanh = khoiHanh;
                this.ThoiGianBay = thoiGianBay;
                this.DonGia = donGia;
                this.MaTuyenBay = maTuyenBay;
            }
        }

        class CT_LichChuyenBay
        {
            public string MaChuyenBay;
            public string MaSanBayTrungGian;
            public string GhiChu;
            public int ThoiGianDung;

            public CT_LichChuyenBay(string maChuyenBay, string maSanBayTrungGian, int thoiGianDung, string ghiChu)
            {
                MaChuyenBay = maChuyenBay;
                MaSanBayTrungGian = maSanBayTrungGian;
                ThoiGianDung = thoiGianDung;
                GhiChu = ghiChu;
            }
        }

        class CT_Ghe
        {
            public string MaChuyenBay;
            public string MaHangVe;
            public int SoGhe;
            public int SoGheDat;
            public int SoGheTrong;

            public CT_Ghe(string maChuyenBay, string maHangVe, int soGhe, int soGheDat, int soGheTrong)
            {
                MaChuyenBay = maChuyenBay;
                MaHangVe = maHangVe;
                SoGhe = soGhe;
                SoGheDat = soGheDat;
                SoGheTrong = soGheTrong;
            }
        }

        private LichChuyenBay solveDataInputLichChuyenBay()
        {
            //////////////
            string MaSanBayDi = "";
            DataRow[] rows = DSSanBay.Select("TenSanBay='" + cbSanBayDi.Text + "'");

            for (int i = 0; i < rows.Length; i++)
            {
                MaSanBayDi = rows[i].ItemArray[(int)Support.BLL.Support.IDSanBay.MaSanBay].ToString();
            }

            ///////////////
            string MaSanBayDen = "";
            rows = DSSanBay.Select("TenSanBay='" + cbSanBayDen.Text + "'");

            for (int i = 0; i < rows.Length; i++)
            {
                MaSanBayDen = rows[i].ItemArray[(int)Support.BLL.Support.IDSanBay.MaSanBay].ToString();
            }


            string MaTuyenBay = "";
            rows = DSTuyenBay.Select("MaSanBayDi='" + MaSanBayDi + "' AND MaSanBayDen='" + MaSanBayDen + "'");
            for (int i = 0; i < rows.Length; i++)
            {
                MaTuyenBay = rows[i].ItemArray[(int)Support.BLL.Support.IDTuyenBay.MaTuyenBay].ToString();
            }

            LichChuyenBay lcb = new LichChuyenBay(cbMaChuyenBay.Text, MaTuyenBay, dtpNgayGio.Value, (int)Convert.ToDecimal(txtGiaVe.Text.ToString()), Convert.ToInt32(txtThoiGianBay.Text.ToString()));

            return lcb;
        }

        private List<CT_LichChuyenBay> solveDataInputCT_LichChuyenBay()
        {
            List<CT_LichChuyenBay> list = new List<CT_LichChuyenBay>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if ((row.Cells[0].Value == null || row.Cells[0].Value == "") && (row.Cells[1].Value == null || row.Cells[1].Value == ""))
                    break;


                string MaSanBayTrungGian = "";
                DataRow[] rows = DSSanBay.Select("TenSanBay='" + row.Cells[0].Value + "'");

                for (int i = 0; i < rows.Length; i++)
                {
                    MaSanBayTrungGian = rows[i].ItemArray[(int)Support.BLL.Support.IDSanBay.MaSanBay].ToString();
                }

                if (row.Cells[2].Value != null)
                    list.Add(new CT_LichChuyenBay(cbMaChuyenBay.Text, MaSanBayTrungGian, Convert.ToInt32(row.Cells[1].Value.ToString()), row.Cells[2].Value.ToString()));
                else
                    list.Add(new CT_LichChuyenBay(cbMaChuyenBay.Text, MaSanBayTrungGian, Convert.ToInt32(row.Cells[1].Value.ToString()), ""));
            }

            return list;
        }

        private List<CT_Ghe> solveDataInputCT_Ghe()
        {
            List<CT_Ghe> list = new List<CT_Ghe>();

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                list.Add(new CT_Ghe(cbMaChuyenBay.Text, row.Cells[0].Value.ToString(), Convert.ToInt32(row.Cells[2].Value.ToString()), 0, Convert.ToInt32(row.Cells[2].Value.ToString())));
            }

            return list;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            int n;

            try
            {
                // kiem tra thoi gian bay
                n = Convert.ToInt16(txtThoiGianBay.Text.ToString());
            }catch
            {
                MessageBox.Show("Vui lòng nhập đúng kiểu dữ liệu", "Lỗi");
                return;
            }


            try
            {
                if (n < MinTGBay)
                {
                    MessageBox.Show("Thời gian bay tối thiểu là " + MinTGBay);
                    return;
                }


                // kiem tra so luong ghe
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.Cells[2].Value == null)
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ và đúng thông tin", "Error");
                        return;
                    }

                    try
                    {
                        n = Convert.ToInt16(row.Cells[2].Value.ToString());
                    }
                    catch
                    {
                        MessageBox.Show("Vui lòng nhập đúng kiểu dữ liệu", "Lỗi");
                        return;
                    }

                    if (n < 0)
                    {
                        MessageBox.Show("Vui lòng nhập đúng số ghế");
                        return;
                    }
                }


                // kiem tra thong tin san bay trung gian
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value == null && row.Cells[1].Value == null)
                        break;
                    else if (row.Cells[0].Value == null || row.Cells[1].Value == null)
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ và đúng thông tin", "Error");
                        return;
                    }

                    try
                    {
                        n = Convert.ToInt16(row.Cells[1].Value.ToString());
                    }
                    catch
                    {
                        MessageBox.Show("Vui lòng nhập đúng kiểu dữ liệu", "Lỗi");
                        return;
                    }

                    if (n < MinTGDung || n > MaxTGDung)
                    {
                        MessageBox.Show("Thời gian dừng nằm trong khoảng " + MinTGDung + " và " + MaxTGDung);
                        return;
                    }
                }

                try 
                {
                    if (Convert.ToDecimal(txtGiaVe.Text.ToString()) < 0)
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ và đúng thông tin", "Error");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Vui lòng nhập đúng kiểu dữ liệu", "Lỗi");
                    return;
                }
                

                if (cbMaChuyenBay.Text.Equals(""))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ và đúng thông tin", "Error");
                    return;
                }

                if (cbSanBayDen.Text.Equals(""))
                {
                    MessageBox.Show("Vui lòng chọn sân bay đến", "Error");
                    return;
                }


                if (cbSanBayDi.Text.Equals(""))
                {
                    MessageBox.Show("Vui lòng chọn sân bay đi", "Error");
                    return;
                }


                LichChuyenBay lcb = solveDataInputLichChuyenBay();
                List<CT_LichChuyenBay> ct_lcb = solveDataInputCT_LichChuyenBay();
                List<CT_Ghe> ct_ghe = solveDataInputCT_Ghe();


                BLL.BLL_LichChuyenBay.UpdateLichChuyenBay(lcb.MaChuyenBay, lcb.MaTuyenBay, lcb.KhoiHanh, lcb.ThoiGianBay, lcb.DonGia);
                BLL.BLL_CT_LichChuyenBay.DeleteCT_LichChuyenBay(lcb.MaChuyenBay);

                for (int i = 0; i < ct_lcb.Count; i++)
                {
                    BLL.BLL_CT_LichChuyenBay.InsertCT_LichChuyenBay(ct_lcb[i].MaChuyenBay, ct_lcb[i].MaSanBayTrungGian, ct_lcb[i].ThoiGianDung, ct_lcb[i].GhiChu);
                }

                for (int i = 0; i < ct_ghe.Count; i++)
                {
                    BLL.BLL_CT_Ghe.UpdateCT_Ghe(ct_ghe[i].MaChuyenBay, ct_ghe[i].MaHangVe, ct_ghe[i].SoGhe, ct_ghe[i].SoGheDat, ct_ghe[i].SoGheTrong);
                }


                int thang, nam;
                thang = dtpNgayGio.Value.Month;
                nam = dtpNgayGio.Value.Year;
                BLL.BLL_BaoCaoDoanhThuChuyenBay.UpdateBaoCaoDoanhThuChuyenBay(thang, nam, lcb.MaChuyenBay, 0, 0, 0.0f);

                MessageBox.Show("Nhập thông tin thành công.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
