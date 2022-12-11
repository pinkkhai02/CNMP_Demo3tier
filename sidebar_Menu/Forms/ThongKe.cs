using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using sidebar_Menu.DAO;

namespace sidebar_Menu.Forms
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
            date_day.Format = DateTimePickerFormat.Custom;
            date_day.CustomFormat = "dd-MM-yyyy";
            date_month.Format = DateTimePickerFormat.Custom;
            date_month.CustomFormat = "dd-MM-yyyy";
            date_year.Format = DateTimePickerFormat.Custom;
            date_year.CustomFormat = "dd-MM-yyyy";
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            rdbTatCa.Checked = true;
        }

        private void rdbTatCa_CheckedChanged(object sender, EventArgs e)
        {
            date_day.Enabled = false;
            date_month.Enabled = false;
            date_year.Enabled = false;
            string sqlcheck = "Select * from hoadon where trangthai = 1 ";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(sqlcheck);

            dgvThongTinHD.Rows.Clear();
            chartThongKe.Series["Tổng Tiền"].Points.Clear();
            int i = 0;
            decimal tongtien = 0;
            foreach (DataRow dr in data.Rows)
            {
                dgvThongTinHD.Rows.Add();
                dgvThongTinHD.Rows[i].Cells[0].Value = (i + 1).ToString();
                dgvThongTinHD.Rows[i].Cells[1].Value = dr.Field<string>(0);
                dgvThongTinHD.Rows[i].Cells[2].Value = dr.Field<string>(3);
                dgvThongTinHD.Rows[i].Cells[3].Value = dr.Field<DateTime>(1);
                dgvThongTinHD.Rows[i].Cells[4].Value = dr.Field<DateTime>(2);
                dgvThongTinHD.Rows[i].Cells[5].Value = dr.Field<int>(4);
                dgvThongTinHD.Rows[i].Cells[6].Value = dr.Field<decimal>(5);

                chartThongKe.Series["Tổng Tiền"].Points.Add((double)dr.Field<decimal>(5));
                chartThongKe.Series["Tổng Tiền"].Points[i].AxisLabel = dr.Field<string>(0);
                chartThongKe.Series["Tổng Tiền"].Points[i].LegendText = dr.Field<string>(0);
                chartThongKe.Series["Tổng Tiền"].Points[i].Label = dr.Field<decimal>(5).ToString();

                tongtien += dr.Field<decimal>(5);
                i++;
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            lblTongTien.Text = "Tổng Tiền: " + tongtien.ToString("c", culture);
        }

        private void rdbNgay_CheckedChanged(object sender, EventArgs e)
        {
            date_day.Enabled = true;
            date_month.Enabled = false;
            date_year.Enabled = false;
            date_day.Value = DateTime.Now;
        }

        private void date_day_ValueChanged(object sender, EventArgs e)
        {
            int ngay = date_day.Value.Day;
            int thang = date_day.Value.Month;
            int nam = date_day.Value.Year;
            string sqlcheck = "Select * from hoadon Where day(giora) = " + ngay + " AND month(giora) = " + thang + "" +
                "AND year(giora) = " + nam + " AND trangthai = 1";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(sqlcheck);

            dgvThongTinHD.Rows.Clear();
            chartThongKe.Series["Tổng Tiền"].Points.Clear();
            int i = 0;
            decimal tongtien = 0;
            foreach (DataRow dr in data.Rows)
            {
                dgvThongTinHD.Rows.Add();
                dgvThongTinHD.Rows[i].Cells[0].Value = (i + 1).ToString();
                dgvThongTinHD.Rows[i].Cells[1].Value = dr.Field<string>(0);
                dgvThongTinHD.Rows[i].Cells[2].Value = dr.Field<string>(3);
                dgvThongTinHD.Rows[i].Cells[3].Value = dr.Field<DateTime>(1);
                dgvThongTinHD.Rows[i].Cells[4].Value = dr.Field<DateTime>(2);
                dgvThongTinHD.Rows[i].Cells[5].Value = dr.Field<int>(4);
                dgvThongTinHD.Rows[i].Cells[6].Value = dr.Field<decimal>(5);

                chartThongKe.Series["Tổng Tiền"].Points.Add((double)dr.Field<decimal>(5));
                chartThongKe.Series["Tổng Tiền"].Points[i].AxisLabel = dr.Field<string>(0);
                chartThongKe.Series["Tổng Tiền"].Points[i].LegendText = dr.Field<string>(0);
                chartThongKe.Series["Tổng Tiền"].Points[i].Label = dr.Field<decimal>(5).ToString();

                tongtien += dr.Field<decimal>(5);
                i++;
            }
            chartThongKe.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            CultureInfo culture = new CultureInfo("vi-VN");
            lblTongTien.Text = "Tổng Tiền: " + tongtien.ToString("c", culture);
        }

        private void rdbThang_CheckedChanged(object sender, EventArgs e)
        {
            date_day.Enabled = false;
            date_month.Enabled = true;
            date_year.Enabled = false;
            date_month.Value = DateTime.Now;
        }

        private void date_month_ValueChanged(object sender, EventArgs e)
        {
            int thang = date_month.Value.Month;
            int nam = date_month.Value.Year;
            string sqlcheck = "Select * from hoadon Where month(giora) = " + thang + "" +
                "AND year(giora) = " + nam + " AND trangthai = 1";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(sqlcheck);

            dgvThongTinHD.Rows.Clear();
            chartThongKe.Series["Tổng Tiền"].Points.Clear();
            int i = 0;
            decimal tongtien = 0;
            foreach (DataRow dr in data.Rows)
            {
                dgvThongTinHD.Rows.Add();
                dgvThongTinHD.Rows[i].Cells[0].Value = (i + 1).ToString();
                dgvThongTinHD.Rows[i].Cells[1].Value = dr.Field<string>(0);
                dgvThongTinHD.Rows[i].Cells[2].Value = dr.Field<string>(3);
                dgvThongTinHD.Rows[i].Cells[3].Value = dr.Field<DateTime>(1);
                dgvThongTinHD.Rows[i].Cells[4].Value = dr.Field<DateTime>(2);
                dgvThongTinHD.Rows[i].Cells[5].Value = dr.Field<int>(4);
                dgvThongTinHD.Rows[i].Cells[6].Value = dr.Field<decimal>(5);

                chartThongKe.Series["Tổng Tiền"].Points.Add((double)dr.Field<decimal>(5));
                chartThongKe.Series["Tổng Tiền"].Points[i].AxisLabel = dr.Field<string>(0);
                chartThongKe.Series["Tổng Tiền"].Points[i].LegendText = dr.Field<string>(0);
                chartThongKe.Series["Tổng Tiền"].Points[i].Label = dr.Field<decimal>(5).ToString();

                tongtien += dr.Field<decimal>(5);
                i++;
            }
            chartThongKe.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            CultureInfo culture = new CultureInfo("vi-VN");
            lblTongTien.Text = "Tổng Tiền: " + tongtien.ToString("c", culture);
        }

        private void rdbNam_CheckedChanged(object sender, EventArgs e)
        {
            date_day.Enabled = false;
            date_month.Enabled = false;
            date_year.Enabled = true;
            date_year.Value = DateTime.Now;
        }

        private void date_year_ValueChanged(object sender, EventArgs e)
        {
            int nam = date_year.Value.Year;
            string sqlcheck = "Select * from hoadon Where year(giora) = " + nam + " AND trangthai = 1";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(sqlcheck);

            dgvThongTinHD.Rows.Clear();
            chartThongKe.Series["Tổng Tiền"].Points.Clear();
            int i = 0;
            decimal tongtien = 0;
            foreach (DataRow dr in data.Rows)
            {
                dgvThongTinHD.Rows.Add();
                dgvThongTinHD.Rows[i].Cells[0].Value = (i + 1).ToString();
                dgvThongTinHD.Rows[i].Cells[1].Value = dr.Field<string>(0);
                dgvThongTinHD.Rows[i].Cells[2].Value = dr.Field<string>(3);
                dgvThongTinHD.Rows[i].Cells[3].Value = dr.Field<DateTime>(1);
                dgvThongTinHD.Rows[i].Cells[4].Value = dr.Field<DateTime>(2);
                dgvThongTinHD.Rows[i].Cells[5].Value = dr.Field<int>(4);
                dgvThongTinHD.Rows[i].Cells[6].Value = dr.Field<decimal>(5);

                chartThongKe.Series["Tổng Tiền"].Points.Add((double)dr.Field<decimal>(5));
                chartThongKe.Series["Tổng Tiền"].Points[i].AxisLabel = dr.Field<string>(0);
                chartThongKe.Series["Tổng Tiền"].Points[i].LegendText = dr.Field<string>(0);
                chartThongKe.Series["Tổng Tiền"].Points[i].Label = dr.Field<decimal>(5).ToString();

                tongtien += dr.Field<decimal>(5);
                i++;
            }
            chartThongKe.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            CultureInfo culture = new CultureInfo("vi-VN");
            lblTongTien.Text = "Tổng Tiền: " + tongtien.ToString("c", culture);
        }

        
    }
}
