using sidebar_Menu.DAO;
using sidebar_Menu.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu = sidebar_Menu.DTO.Menu;
using System.Globalization;

namespace sidebar_Menu.Forms
{

    
    public partial class FormBanHang : Form
    {
        DataTable dt = new DataTable();
        public FormBanHang()
        {
            InitializeComponent();
            
        }
        

        void LoadNhomMonAn()
        {
            List<NhomMon> dsnhommon = NhomMonDAO.Instance.LayDanhSachNhomMon();
            cbGroup.DataSource = dsnhommon;
            cbGroup.DisplayMember = "tennhom";
            cbGroup.ValueMember = "manhom";
        }

        void LoadMonAnTuIDNhomMonAn(string manhom)
        {
            List<MonAn> dsmonan = MonAnDAO.Instance.LayDanhSachMonAnTuMaNhom(manhom);
            cbFood.DataSource = dsmonan;
            cbFood.DisplayMember = "tenmon";
            cbFood.ValueMember = "mamon";
        }

        void LoadBan()
        {
            fpnlTable.Controls.Clear();
            List<Ban> dsban =  BanDAO.Instance.LoadDanhSachBan();

            foreach (Ban item in dsban)
            {
                Button btn = new Button() { Width = BanDAO.ChieuRongBan , Height = BanDAO.ChieuDaiBan };
                btn.Text = item.Tenban + Environment.NewLine + item.Trangthai;
                btn.Click += btn_Click ;
                btn.Tag = item;

                switch(item.Trangthai)
                {
                    case "":
                        btn.BackColor = Color.FromArgb(255, 174, 0);
                        break;
                    default:
                        btn.BackColor = Color.Red;
                        break;

                }    

                fpnlTable.Controls.Add(btn);
            }
        }

        void ShowHoaDon(int id)
        {
            dgvFood.Rows.Clear();
            List<Menu> cthoadon = MenuDAO.Instance.LayDanhSachMenuTuIDBan(id);
            int i = 0;
            decimal tongtien = 0;
            
            foreach (Menu item in cthoadon)
            {
                dgvFood.Rows.Add();
                dgvFood.Rows[i].Cells[0].Value = item.Tenmon;
                dgvFood.Rows[i].Cells[1].Value = item.Dvt;
                dgvFood.Rows[i].Cells[2].Value = item.Soluong;
                dgvFood.Rows[i].Cells[3].Value = item.Giatien;
                dgvFood.Rows[i].Cells[4].Value = item.Tongtien;
                tongtien += item.Tongtien;
                i++;
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            if(cthoadon.Count != 0)
                LuuTongTienVaThanhTien.tongtien = tongtien;

            lblInfoTable.Text = "Bàn: " + LoadTenBan(id);
            lblTimeIn.Text = "Giờ khách vào: " + LoadGioVao(id);
            lbPriceSum.Text = "Tổng tiền: " + tongtien.ToString("c", culture) ;
            
        }

        

        private void btn_Click(object sender, EventArgs e)
        {
            int idban = ((sender as Button).Tag as Ban).Id;
            dgvFood.Tag = (sender as Button).Tag;
            ShowHoaDon(idban);
        }


        private void cbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            string manhom ;

            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            NhomMon selected = cb.SelectedItem as NhomMon;

            manhom = selected.Manhom;

            LoadMonAnTuIDNhomMonAn(manhom);

        }

        private void cbFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dvt;

            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            MonAn selected = cb.SelectedItem as MonAn;

            dvt = selected.Dvt;

            lblUnit.Text = "ĐVT: " + dvt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            

            Ban ban = dgvFood.Tag as Ban;

            if(ban == null )
            {
                MessageBox.Show("Bạn chưa chọn bàn. Vui lòng chọn lại!");
                return;
            }
            else
            { 

                string sohd = HoaDonDAO.Instance.LayIDHoaDonUncheckTuIDBan(ban.Id);

                string mamon = (cbFood.SelectedItem as MonAn).Mamon;

                decimal giatien = (cbFood.SelectedItem as MonAn).Giatien;

                int soluong = (int)numQuantity.Value;

                decimal thanhtien = giatien * soluong;

                string username = Const.username;

                string manv;
                string tennv;

                string query = "Select IDNhanVien from taikhoan where name = '" + username + "'";

                DataTable data = new DataTable();

                data = DataProvider.Instance.ExecuteQuery(query);

                manv = data.Rows[0].Field<string>(0);

                query = "Select tennv from nhanvien where manv = '" + manv + "'";

                data = DataProvider.Instance.ExecuteQuery(query);

                tennv = data.Rows[0].Field<string>(0);


                string text;

                if (sohd == null)
                {
                    HoaDonDAO.Instance.ThemHoaDon(ban.Id, manv);

                    int i = HoaDonDAO.Instance.LaySoLuongHoaDon();
                    if (i >= 100)
                    {
                        text = "HD" + i;
                    }
                    else
                    {
                        if (i >= 10)
                            text = "HD0" + i;

                        else
                            text = "HD00" + i;
                    }

                    ChiTietHoaDonDAO.Instance.ThemChiTietHoaDon(text, mamon, soluong, giatien , thanhtien);
                }

                else
                {
                    ChiTietHoaDonDAO.Instance.ThemChiTietHoaDon(sohd, mamon, soluong, giatien, thanhtien);


                }
                
                ShowHoaDon(ban.Id);
                LoadBan();
            }

            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Ban ban = dgvFood.Tag as Ban;

            string sohd = HoaDonDAO.Instance.LayIDHoaDonUncheckTuIDBan(ban.Id);

            if(sohd != null)
            {
                if (MessageBox.Show("Bạn có chắc thanh toán hóa đơn cho bàn " + ban.Tenban , "Thông Báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    HoaDonDAO.Instance.GioRa(sohd);
                    FormReportHoaDon rp = new FormReportHoaDon(sohd);
                    rp.ShowDialog();
                    ShowHoaDon(ban.Id);
                    LoadBan();
                }
            }    
        }

        private void FormBanHang_Load(object sender, EventArgs e)
        {
            LoadBan();
            LoadNhomMonAn();
        }

        string LoadTenBan(int id)
        {
            string trangthai = "Có Người";

            string query = "Select tenban from ban where id =" + id + " and trangthai = N'"+ trangthai +"' ";

            DataTable data = new DataTable();

            data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                return data.Rows[0].Field<string>(0);
            }
            else
                return "";
        }

        string LoadGioVao(int soban)
        {
            string query = "Select giovao from hoadon where soban =" + soban +" and trangthai = 0";

            DateTimePicker giovao = new DateTimePicker();

            DataTable data = new DataTable();

            data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
            {
                giovao.Value = data.Rows[0].Field<DateTime>(0);
                return giovao.Value.ToString("MM/dd/yyyy HH:mm:ss");
            }
            else
                return "";
        }
    }
}
