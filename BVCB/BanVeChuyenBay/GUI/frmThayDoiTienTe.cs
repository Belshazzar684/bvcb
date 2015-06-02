using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Xml;

namespace BanVeChuyenBay.GUI
{
    public partial class frmThayDoiTienTe : Form
    {
        #region Tham số
        List<String> listCurrency;
        double rate;
        #endregion

        public frmThayDoiTienTe()
        {
            InitializeComponent();
        }

        private void frmThayDoiTienTe_Load(object sender, EventArgs e)
        {
            listCurrency = initListCurrency();
            foreach (String currency in listCurrency)
            {
                cbCurrency.Items.Add(currency);
            }
            cbCurrency.SelectedIndex = 0;
        }

        //chức năng: Khởi tạo danh sách các loại tiền tệ hỗ trợ
        //mô tả:
        public List<String> initListCurrency()
        {
            List<String>  list = new List<string>();
            list.Add("VND - Việt Nam đồng");
            list.Add("USD - Dollar Mỹ");
            list.Add("EUR - Euro");
            list.Add("RUB - Rub Nga");
            list.Add("JPY - Yên Nhật");
            list.Add("CNY - Nhân dân tệ");

            return list;
        }

        //chức năng: Lấy tỉ giá trực tiếp từ webservicex.net
        //mô tả: Trả về tỉ giá so với VND, nếu có lỗi trả về -1
        public double GetRate(string fromCurrency)
        {
            try
            {
                String url = "http://www.webservicex.net/CurrencyConvertor.asmx/ConversionRate?FromCurrency=" + fromCurrency + "&ToCurrency=VND";
                WebRequest webrequest = WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)webrequest.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(responseFromServer);
                string value = doc.InnerText;
                reader.Close();
                dataStream.Close();
                response.Close();
                txtRate.Text = value;
                return double.Parse(value);
            }
            catch(Exception e)
            {
                MessageBox.Show("Error", e.Message);
                return -1;
            }
        }

        //sự kiện index của combobox cbCurrecy
        //chức năng: Lấy lại tỉ giá
        //mô tả:
        private void cbCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            rate = GetRate(cbCurrency.Text.Substring(0, 3));
            if (rate == -1)
            {
                cbCurrency.SelectedIndex = 0;
                return;
            }
            txtRate.Text = rate.ToString();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //sự kiện click của btnDoi
        //chức năng: Luu lại sự thay đổi
        //mô tả:
        private void btDoi_Click(object sender, EventArgs e)
        {
            frmMain.TienTe = cbCurrency.Text.Substring(0,3);
            frmMain.TiGia = rate;
            MessageBox.Show("Thay đổi thành công", "Thông báo");
        }
    }
}
