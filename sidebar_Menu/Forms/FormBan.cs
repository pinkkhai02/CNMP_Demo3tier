using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sidebar_Menu.DAO;
using System.Data.SqlClient;

namespace sidebar_Menu.Forms
{
    public partial class FormBan : Form
    {
        public FormBan()
        {
            InitializeComponent();
        }
        //SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-C45AB4E\SQLEXPRESS;Initial Catalog=Max_QueryQLMICAYCAY;Persist Security Info=True;User ID=sa; Password = 123");

        private void FormBan_Load(object sender, EventArgs e)
        {
            LoadDataBan();
            //MaIDTuTang();
        }
        private void MaIDTuTang()
        {
            string sql = "select soban from ban";
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery(sql);

            int i = 1;
            int dem = 0;
            int j = 0;
            foreach (DataRow dr in dt.Rows)
            {
                j++;
                if (j < 10)
                {
                    int text = 0;
                    text = i;
                    if (text == dr.Field<int>(0))
                    {
                        dem++;
                        i++;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    int text = 0;
                    text = i;
                    if (text == dr.Field<int>(0))
                    {
                        dem++;
                        i++;
                    }
                    else
                    {
                        break;
                    }
                }

            }
            if (dem <= dt.Rows.Count)
            {
                if (i < 10)
                {
                    txtSoBan.Text = "" + i;
                }
                else
                {
                    txtSoBan.Text = "" + i;
                }
            }

        }
        private void LoadDataBan()
        {
            dgvTTBan.Rows.Clear();
            string sql = "select [id], [tenban] , [trangthai] from ban";
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery(sql);
            int i = 0;
            foreach (DataRow dr in dt.Rows)
            {
                dgvTTBan.Rows.Add();
                dgvTTBan.Rows[i].Cells[0].Value = dr.Field<int>(0);
                dgvTTBan.Rows[i].Cells[1].Value = dr.Field<string>(1);
                dgvTTBan.Rows[i].Cells[2].Value = dr.Field<string>(2);

                i++;
            }
        }

        private void dgvTTBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvTTBan.Rows[e.RowIndex];

                txtSoBan.Text = row.Cells[0].Value.ToString();
                txtTrangThai.Text = row.Cells[1].Value.ToString();


            }
        }

        private void btnThemBan_Click(object sender, EventArgs e)
        {
            string soban = txtSoBan.Text;
            string trangthai = txtTrangThai.Text;
            string sql = @"INSERT [dbo].[ban] ([soban], [trangthai]) VALUES ('" + soban + "', N'" + trangthai + "')";
            int i = 0;
            i = DataProvider.Instance.ExecuteNonQuery(sql);
            MessageBox.Show("Thêm Thành Công", "Thông báo");
            LoadDataBan();
            Reset();
        }

        private void btnSuaBan_Click(object sender, EventArgs e)
        {
            string soban = txtSoBan.Text;
            string trangthai = txtTrangThai.Text;
            string sql = @"update [dbo].[ban] set  [trangthai] = N'" + trangthai + "' where [soban] = '" + soban + "'";
            int i = 0;
            i = DataProvider.Instance.ExecuteNonQuery(sql);
            MessageBox.Show("Cập Nhật Thành Công", "Thông báo");
            LoadDataBan();
            Reset();
        }

        private void btnXoaBan_Click(object sender, EventArgs e)
        {
            

            int rowindex = dgvTTBan.CurrentCell.RowIndex;
            string MaBan = dgvTTBan.Rows[rowindex].Cells[0].Value.ToString();
            string sqlDelete = @"Delete ban Where soban = '" + MaBan + "'";
            int i = 0;
            i = DataProvider.Instance.ExecuteNonQuery(sqlDelete);
            MessageBox.Show("Xóa thành công!", "Thông Báo");
            LoadDataBan();
            Reset();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tt = cbbLocTheoTrangThai.Text;
            if (tt == "Tất Cả")
            {
                dgvTTBan.Rows.Clear();
                string sql = "select * from ban ";
                
                DataTable dt = new DataTable();
                dt = DataProvider.Instance.ExecuteQuery(sql);
                int i = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    dgvTTBan.Rows.Add();
                    dgvTTBan.Rows[i].Cells[0].Value = dr.Field<int>(0);
                    dgvTTBan.Rows[i].Cells[1].Value = dr.Field<string>(1);

                    i++;
                }
            }
            else
            {

                dgvTTBan.Rows.Clear();
                string sql = "select * from ban where trangthai = N'" + tt + "'";
                DataTable dt = new DataTable();
                dt = DataProvider.Instance.ExecuteQuery(sql);
                int i = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    dgvTTBan.Rows.Add();
                    dgvTTBan.Rows[i].Cells[0].Value = dr.Field<int>(0);
                    dgvTTBan.Rows[i].Cells[1].Value = dr.Field<string>(1);

                    i++;
                }
            }

        }
        private void Reset()
        {
            //MaIDTuTang();
            txtTrangThai.Text = "";
        }
    }
}
