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
using BanVeChuyenBay.BLL;

namespace BanVeChuyenBay.GUI
{
    public partial class frmLichChuyenBay : Form
    {
        public class Data
        {
            public string Name { get; set; }
            public string ID { get; set; }
        }

        int MaxRowHangVe;
        int MaxSBTrungGian;
        int MinTGDung, MaxTGDung, MinTGBay;
        DataTable DSSanBay, DSSanBayDen, DSSanBayDi, DSTuyenBay, DSThamSo;
        enum IDTuyenBay
        {
            MaTuyenBay = 0,
            MaSanBayDi = 1,
            MaSanBayDen = 2
        }

        enum IDThamSo
        {
            MaxSoSanBayTG = 0,
            MaxTGDung = 1,
            MinTGDung = 2,
            MinTGBay = 3,
            TGDatVe = 5,
            TGHuyVe = 6
        }

        enum IDSanBay
        {
            MaSanBay = 0,
            TenSanBay = 1
        }

        public frmLichChuyenBay()
        {
            InitializeComponent();
            loadSoHangVe();
            LoadHangHangKhong();

            DSThamSo = BLL_LichChuyenBay.SelectAllThamSo();
            DataRow row = DSThamSo.Rows[0];

            MaxSBTrungGian = Convert.ToInt16(row.ItemArray[(int)IDThamSo.MaxSoSanBayTG]);
            MaxTGDung = Convert.ToInt16(row.ItemArray[(int)IDThamSo.MaxTGDung]);
            MinTGDung = Convert.ToInt16(row.ItemArray[(int)IDThamSo.MinTGDung]);
            MinTGBay = Convert.ToInt16(row.ItemArray[(int)IDThamSo.MinTGBay]);

            DSTuyenBay = BLL.BLL_TuyenBay.SelectAllTuyenBay();

            dataGridView2.Rows[0].Cells[0].Value = "";
            dataGridView2.Rows[0].Cells[1].Value = "";

            txtMaChuyenBay.Text = "cb" + (BLL_BoDem.SelectBoDem("LICHCHUYENBAY") + 1);
        }

        private void loadSoHangVe()
        {
            DataTable dt = BLL.BLL_HangVe.SelectAllHangVe();
            DataRow row;

            MaxRowHangVe = dt.Rows.Count;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                row = dt.Rows[i];
                if (dataGridView1.Rows.Count >= MaxRowHangVe)
                {
                    dataGridView1.AllowUserToAddRows = false;
                }
                dataGridView1.Rows.Add(row.ItemArray[0], row.ItemArray[1], "");
            }
        }

       

        private void btThoat_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.TabControl TAB = frmMain.m_Tab;
            TAB.Tabs.Remove(TAB.SelectedTab);
            Close();
        }

        private void dataGridView2_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (dataGridView2.Rows.Count > MaxSBTrungGian)
                dataGridView2.AllowUserToAddRows = false;
            {
                dataGridView2.Rows[dataGridView2.RowCount - 1].Cells[0].Value = "";
                dataGridView2.Rows[dataGridView2.RowCount - 1].Cells[1].Value = "";
            }
        }

        private void cbSanBayDi_MouseClick(object sender, MouseEventArgs e)
        {

            cbSanBayDi.Items.Clear();
            if (cbSanBayDen.Text.Equals(""))
            {
                DSSanBayDi = BLL.BLL_TuyenBay.SelectAtColumnsTuyenBay("MaSanBayDi");


                foreach (DataRow row in DSSanBayDi.Rows)
                {
                    cbSanBayDi.Items.Add(row.ItemArray[(int)Support.BLL.Support.IDSanBay.TenSanBay]);
                }
            }
            else
            {
                
                DSTuyenBay = BLL.BLL_TuyenBay.SelectAllTuyenBay();

                DSSanBay = BLL.BLL_SanBay.SelectAllSanBay();


                DataRow[] rows = DSSanBay.Select("TenSanBay='" + cbSanBayDen.Text + "'");
                String MaSanBayDen = rows[0].ItemArray[(int)Support.BLL.Support.IDSanBay.MaSanBay].ToString();
                rows = DSTuyenBay.Select("MaSanBayDen='" + MaSanBayDen + "'");
                for (int i = 0; i < rows.Count(); i++)
                {
                    DataRow[] temp = DSSanBay.Select("MaSanBay='" + rows[i].ItemArray[(int)Support.BLL.Support.IDTuyenBay.MaSanBayDi] + "'");

                    cbSanBayDi.Items.Add(temp[0].ItemArray[(int)Support.BLL.Support.IDSanBay.TenSanBay]);
                }
            }
        }

        private void cbSanBayDen_MouseClick(object sender, MouseEventArgs e)
        {
            cbSanBayDen.Items.Clear();
            if (cbSanBayDi.Text.Equals(""))
            {
                
                DSSanBayDen = BLL.BLL_TuyenBay.SelectAtColumnsTuyenBay("MaSanBayDen");

                foreach (DataRow row in DSSanBayDen.Rows)
                {
                    cbSanBayDen.Items.Add(row.ItemArray[(int)Support.BLL.Support.IDSanBay.TenSanBay]);
                }
            }
            else
            {
                DSTuyenBay = BLL.BLL_TuyenBay.SelectAllTuyenBay();

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

        // update combox SanBayTrungGian



        private LichChuyenBay solveDataInputLichChuyenBay()
        {
            //////////////
            string MaSanBayDi = "";
            DataRow[] rows = DSSanBay.Select("TenSanBay='" + cbSanBayDi.Text + "'");

            for (int i = 0; i < rows.Length; i++)
            {
                MaSanBayDi = rows[i].ItemArray[(int)IDSanBay.MaSanBay].ToString();
            }

            ///////////////
            string MaSanBayDen = "";
            rows = DSSanBay.Select("TenSanBay='" + cbSanBayDen.Text + "'");

            for (int i = 0; i < rows.Length; i++)
            {
                MaSanBayDen = rows[i].ItemArray[(int)IDSanBay.MaSanBay].ToString();
            }


            string MaTuyenBay = "";
            rows = DSTuyenBay.Select("MaSanBayDi='" + MaSanBayDi + "' AND MaSanBayDen='" + MaSanBayDen + "'");
            for (int i = 0; i < rows.Length; i++)
            {
                MaTuyenBay = rows[i].ItemArray[(int)IDTuyenBay.MaTuyenBay].ToString();
            }

            LichChuyenBay lcb = new LichChuyenBay(txtMaChuyenBay.Text, MaTuyenBay, dtpNgayGio.Value, Convert.ToInt32(txtGiaVe.Text.ToString()), Convert.ToInt32(txtThoiGianBay.Text.ToString()));

            return lcb;
        }

        private List<CT_LichChuyenBay> solveDataInputCT_LichChuyenBay()
        {
            List<CT_LichChuyenBay> list = new List<CT_LichChuyenBay>();

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                //Fix bug so 1.2.2 - Nhat - kiểm tra hết tất cả các row của dataGridView2
                if (!((row.Cells[0].Value == null || row.Cells[0].Value == "") && (row.Cells[1].Value == null || row.Cells[1].Value == "")))
                {
                    string MaSanBayTrungGian = "";
                    DataRow[] rows = DSSanBay.Select("TenSanBay='" + row.Cells[0].Value + "'");

                    for (int i = 0; i < rows.Length; i++)
                    {
                        MaSanBayTrungGian = rows[i].ItemArray[(int)IDSanBay.MaSanBay].ToString();
                    }

                    if (row.Cells[2].Value != null)
                        list.Add(new CT_LichChuyenBay(txtMaChuyenBay.Text, MaSanBayTrungGian, Convert.ToInt32(row.Cells[1].Value.ToString()), row.Cells[2].Value.ToString()));
                    else
                        list.Add(new CT_LichChuyenBay(txtMaChuyenBay.Text, MaSanBayTrungGian, Convert.ToInt32(row.Cells[1].Value.ToString()), ""));
                }
            }

            return list;
        }

        private List<CT_Ghe> solveDataInputCT_Ghe()
        {
            List<CT_Ghe> list = new List<CT_Ghe>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                list.Add(new CT_Ghe(txtMaChuyenBay.Text, row.Cells[0].Value.ToString(), Convert.ToInt32(row.Cells[2].Value.ToString()), 0, Convert.ToInt32(row.Cells[2].Value.ToString())));
            }

            return list;
        }

        private void buttonX3_Click(object sender, EventArgs e)
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
                foreach (DataGridViewRow row in dataGridView1.Rows)
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
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if ((row.Cells[0].Value == null || row.Cells[0].Value.Equals("")) && (row.Cells[1].Value == null || row.Cells[1].Value.Equals("")))
                        break;
                    else if ((row.Cells[0].Value == null || row.Cells[0].Value.Equals("")) || (row.Cells[1].Value == null || row.Cells[1].Value.Equals("")))
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
                        MessageBox.Show("Thời gian dừng nằm trong khoảng " + MinTGDung + " va " + MaxTGDung);
                        return;
                    }
                }


                if (Convert.ToInt32(txtGiaVe.Text.ToString()) < 0)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ và đúng thông tin", "Error");
                    return;
                }

                if (txtMaChuyenBay.Text.Equals(""))
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


                /// nhap du lieu vao bll
                BLL_LichChuyenBay.InsertLichChuyenBay(lcb.MaChuyenBay, lcb.MaTuyenBay, lcb.KhoiHanh, lcb.ThoiGianBay, lcb.DonGia, cbHangHangKhong.SelectedValue.ToString());

                for (int i = 0; i < ct_lcb.Count; i++)
                {
                    BLL.BLL_CT_LichChuyenBay.InsertCT_LichChuyenBay(ct_lcb[i].MaChuyenBay, ct_lcb[i].MaSanBayTrungGian, ct_lcb[i].ThoiGianDung, ct_lcb[i].GhiChu);
                }

                for (int i = 0; i < ct_ghe.Count; i++)
                {
                    BLL.BLL_CT_Ghe.InsertCT_Ghe(ct_ghe[i].MaChuyenBay, ct_ghe[i].MaHangVe, ct_ghe[i].SoGhe, ct_ghe[i].SoGheDat, ct_ghe[i].SoGheTrong);
                }

                // insert BAOCAODOANHTHUCHUYENBAY
                int thang, nam;
                thang = dtpNgayGio.Value.Month;
                nam = dtpNgayGio.Value.Year;

                BLL_BaoCaoDoanhThuChuyenBay.InsertBaoCaoDoanhThuChuyenBay(thang, nam, lcb.MaChuyenBay, 0, 0, 0.0f);

                MessageBox.Show("Nhập thông tin thành công.");

                buttonX4_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
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

        private void buttonX4_Click(object sender, EventArgs e)
        {
            txtMaChuyenBay.Text = "cb" + (BLL_BoDem.SelectBoDem("LICHCHUYENBAY") + 1);
            txtGiaVe.Text = "";
            txtThoiGianBay.Text = "";

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[2].Value = null;
            }

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                row.Cells[0].Selected = false;
                row.Cells[0].Value = null;
                row.Cells[1].Value = null;
                row.Cells[2].Value = null;
            }
            LoadHangHangKhong();
        }

        private void btnSanBayDi_Click(object sender, EventArgs e)
        {
            frmThemSanBay form = new frmThemSanBay();
            form.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Nhat - fix bug 1.2.3 - Kiểm tra rowIndex khác -1
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                DSSanBay = BLL.BLL_SanBay.SelectAllSanBay();
                DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)dataGridView2.Rows[e.RowIndex].Cells[0];
                cell.Items.Clear();
                cell.Value = "";
                foreach (DataRow row in DSSanBay.Rows)
                {
                    cell.Items.Add(row.ItemArray[(int)Support.BLL.Support.IDSanBay.TenSanBay]);
                }
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            frmThemTuyenBay form = new frmThemTuyenBay();
            form.Show();
        }


        //sự kiện CellValueChanged của datagridview2
        //chức năng: Kiem tra khong cho chọn sân bay trùng
        //mô tả:
        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1 && e.ColumnIndex ==0)
            {
                //combobox column ở vị trí cell 0
                DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)dataGridView2.Rows[e.RowIndex].Cells[0];
                if (cell.Value != null)
                {
                    if (!String.IsNullOrEmpty(cell.Value.ToString()))
                    {
                        for (int i = 0; i < dataGridView2.Rows.Count; i++)
                        {
                            if (i != e.RowIndex)
                            {
                                if (!String.IsNullOrEmpty(dataGridView2.Rows[i].Cells[0].Value.ToString()))
                                {
                                    if (cell.Value.ToString() == dataGridView2.Rows[i].Cells[0].Value.ToString())
                                    {
                                        MessageBox.Show("Sân bay trung gian không được trùng", "Error");
                                        cell.Value = null;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        //Event để fire event sang cellValueChanged ngay khi sau chọn chứ ko phải khi rời khỏi cell đó
        private void dataGridView2_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (this.dataGridView2.IsCurrentCellDirty)
            {
                // This fires the cell value changed handler below
                dataGridView2.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        //Load combobox Hang Hang Khong
        private void LoadHangHangKhong()
        {
            BindingList<Data> _comboItems = new BindingList<Data>();
            foreach (DataRow hhk in BLL.BLL_HangHangKhong.SelectAllHangHangKhong().Rows)
            {
                _comboItems.Add(new Data { Name = hhk["TenHang"].ToString(), ID = hhk["MaHang"].ToString() });
            }
            cbHangHangKhong.DisplayMember = "Name";
            cbHangHangKhong.ValueMember = "ID";
            cbHangHangKhong.DataSource = _comboItems;
            if (cbHangHangKhong.Items.Count > 0)
                cbHangHangKhong.SelectedIndex = 0;
        }

        private void btnHangHangKhong_Click(object sender, EventArgs e)
        {
            frmThemHangHangKhong form = new frmThemHangHangKhong();
            form.ShowDialog();
        }
    }
}