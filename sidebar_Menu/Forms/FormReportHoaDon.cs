using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sidebar_Menu.DAO;

namespace sidebar_Menu.Forms
{
    public partial class FormReportHoaDon : Form
    {
        public string invoice_ID;
        public FormReportHoaDon(string sohd)
        {
            InitializeComponent();
            invoice_ID = sohd;
        }

        private void FormReportHoaDon_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-C45AB4E\SQLEXPRESS;Initial Catalog=Max_QueryQLMICAYCAY;Persist Security Info=True;User ID=sa; Password=123");
            cnn.Open();
            //string sql = "select * from View_Bill_MiCay where sohd = '" + invoice_ID + "'";
            SqlDataAdapter da = new SqlDataAdapter("select * from View_Bill_MiCay where sohd = '" + invoice_ID + "'", cnn);
            //DataTable dt = new DataTable();
            //dt = DataProvider.Instance.ExecuteQuery(sql);
            DataSetQLMiCay ds = new DataSetQLMiCay();
            //ds.Tables.Add(dt, "DataBillQLMiCay");
            da.Fill(ds, "DataBillQLMiCay");
            ReportDataSource datasource = new ReportDataSource("DataQLMiCay", ds.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();
            cnn.Close();
            this.reportViewer1.RefreshReport();
        }
    }
}
