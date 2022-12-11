using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using sidebar_Menu.DAO;

namespace sidebar_Menu.Forms
{
    public partial class FormNhomThucPham : Form
    {
        public FormNhomThucPham()
        {
            InitializeComponent();
        }

        private void MaIDTuTangNhomMon()
        {
            string sql = "select manhom from nhommon";
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
                    string text = "GR00";
                    text = text + i;
                    if (text == dr.Field<String>(0))
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
                    string text = "GR0";
                    text = text + i;
                    if (text == dr.Field<String>(0))
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
                    txtMaNM.Text = "GR00" + i;
                }
                else
                {
                    txtMaNM.Text = "GR0" + i;
                }
            }

        }

        private void LoadDataNhomMon()
        {
            dgvNhomMon.Rows.Clear();
            string sql = "select * from nhommon";
            
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery(sql);
            int i = 0;
            foreach (DataRow dr in dt.Rows)
            {
                dgvNhomMon.Rows.Add();
                dgvNhomMon.Rows[i].Cells[0].Value = (i + 1).ToString();
                dgvNhomMon.Rows[i].Cells[1].Value = dr.Field<string>(0);
                dgvNhomMon.Rows[i].Cells[2].Value = dr.Field<string>(1);

                i++;
            }
        }
        private void ResetNhomMon()
        {
            MaIDTuTangNhomMon();
            txtTenNhom.Text = "";
        }

        private void btnAddd_Click(object sender, EventArgs e)
        {
            string MaNhomMon = txtMaNM.Text;
            string TenNhomMon = txtTenNhom.Text;
            string sql = @"INSERT INTO [dbo].[nhommon] ([manhom], [tennhom]) VALUES ('" + MaNhomMon + "', N'" + TenNhomMon + "')";
            int i = 0;
            i = DataProvider.Instance.ExecuteNonQuery(sql);
            MessageBox.Show("Thêm Thành Công", "Thông báo");
            LoadDataNhomMon();
            ResetNhomMon();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string MaNhomMon = txtMaNM.Text;
            string TenNhomMon = txtTenNhom.Text;
            string sql = @"update nhommon set tennhom = N'" + TenNhomMon + "' where manhom = '" + MaNhomMon + "' ";
            int i = 0;
            i = DataProvider.Instance.ExecuteNonQuery(sql);
            MessageBox.Show("Cập Nhật Thành Công", "Thông báo");
            LoadDataNhomMon();
            ResetNhomMon();
        }

        private void btnXoaa_Click(object sender, EventArgs e)
        {

            int rowindex = dgvNhomMon.CurrentCell.RowIndex;
            string MaNhomMon = dgvNhomMon.Rows[rowindex].Cells[1].Value.ToString();
            string sqlDelete = @"Delete nhommon Where manhom = '" + MaNhomMon + "'";
            int i = 0;
            i = DataProvider.Instance.ExecuteNonQuery(sqlDelete);
            MessageBox.Show("Xóa thành công!");
            LoadDataNhomMon();
            ResetNhomMon();
        }

        private void dgcTTNMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvNhomMon.Rows[e.RowIndex];

                txtMaNM.Text = row.Cells[1].Value.ToString();
                txtTenNhom.Text = row.Cells[2].Value.ToString();
            }
        }

        private void TTNhomMon_Load(object sender, EventArgs e)
        {
            LoadDataNhomMon();
            MaIDTuTangNhomMon();
            LoadtxtTimKiem();
        }
        private void LoadtxtTimKiem()
        {
            AutoCompleteStringCollection timkiem = new AutoCompleteStringCollection();

            string sql = "Select tennhom From nhommon ";
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow dr in dt.Rows)
            {
                timkiem.Add(dr.Field<string>(0));
            }
            
            txtTimKiem.AutoCompleteCustomSource = timkiem;
            txtTimKiem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTimKiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên sách cần tìm !");
            }
            else
            {
                dgvNhomMon.Rows.Clear();
                string sql = "Select * From nhommon Where tennhom like N'" + txtTimKiem.Text + "%'";
                DataTable dt = new DataTable();
                dt = DataProvider.Instance.ExecuteQuery(sql);
                dgvNhomMon.Rows.Add();
                dgvNhomMon.Rows[0].Cells[0].Value = 1.ToString();
                dgvNhomMon.Rows[0].Cells[1].Value = dt.Rows[0].Field<string>(0);
                dgvNhomMon.Rows[0].Cells[2].Value = dt.Rows[0].Field<string>(1);

            }
        }
    }
}
