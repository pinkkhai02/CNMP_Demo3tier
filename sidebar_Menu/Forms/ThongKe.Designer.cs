
namespace sidebar_Menu.Forms
{
    partial class ThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giovao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mahd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvThongTinHD = new Guna.UI2.WinForms.Guna2DataGridView();
            this.soban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbTatCa = new Guna.UI2.WinForms.Guna2RadioButton();
            this.date_year = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.date_month = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.date_day = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.rdbNam = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdbThang = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdbNgay = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.chartThongKe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinHD)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // tongtien
            // 
            this.tongtien.HeaderText = "Tổng Tiền";
            this.tongtien.MinimumWidth = 6;
            this.tongtien.Name = "tongtien";
            // 
            // giora
            // 
            this.giora.HeaderText = "Giờ Ra";
            this.giora.MinimumWidth = 6;
            this.giora.Name = "giora";
            // 
            // giovao
            // 
            this.giovao.HeaderText = "Giờ Vào";
            this.giovao.MinimumWidth = 6;
            this.giovao.Name = "giovao";
            // 
            // manv
            // 
            this.manv.HeaderText = "Mã Nhân Viên";
            this.manv.MinimumWidth = 6;
            this.manv.Name = "manv";
            // 
            // mahd
            // 
            this.mahd.HeaderText = "Mã Hóa Đơn";
            this.mahd.MinimumWidth = 6;
            this.mahd.Name = "mahd";
            // 
            // stt
            // 
            this.stt.FillWeight = 58F;
            this.stt.HeaderText = "STT";
            this.stt.MinimumWidth = 6;
            this.stt.Name = "stt";
            // 
            // dgvThongTinHD
            // 
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            this.dgvThongTinHD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvThongTinHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTinHD.BackgroundColor = System.Drawing.Color.White;
            this.dgvThongTinHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThongTinHD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvThongTinHD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongTinHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvThongTinHD.ColumnHeadersHeight = 77;
            this.dgvThongTinHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.mahd,
            this.manv,
            this.giovao,
            this.giora,
            this.soban,
            this.tongtien});
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThongTinHD.DefaultCellStyle = dataGridViewCellStyle24;
            this.dgvThongTinHD.EnableHeadersVisualStyles = false;
            this.dgvThongTinHD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThongTinHD.Location = new System.Drawing.Point(626, 139);
            this.dgvThongTinHD.Name = "dgvThongTinHD";
            this.dgvThongTinHD.RowHeadersVisible = false;
            this.dgvThongTinHD.RowHeadersWidth = 51;
            this.dgvThongTinHD.RowTemplate.Height = 24;
            this.dgvThongTinHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongTinHD.Size = new System.Drawing.Size(411, 359);
            this.dgvThongTinHD.TabIndex = 55;
            this.dgvThongTinHD.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongTinHD.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvThongTinHD.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvThongTinHD.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvThongTinHD.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvThongTinHD.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongTinHD.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThongTinHD.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvThongTinHD.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvThongTinHD.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvThongTinHD.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvThongTinHD.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvThongTinHD.ThemeStyle.HeaderStyle.Height = 77;
            this.dgvThongTinHD.ThemeStyle.ReadOnly = false;
            this.dgvThongTinHD.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvThongTinHD.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvThongTinHD.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvThongTinHD.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvThongTinHD.ThemeStyle.RowsStyle.Height = 24;
            this.dgvThongTinHD.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvThongTinHD.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // soban
            // 
            this.soban.HeaderText = "Số Bàn";
            this.soban.MinimumWidth = 6;
            this.soban.Name = "soban";
            // 
            // lblTongTien
            // 
            this.lblTongTien.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTongTien.Font = new System.Drawing.Font("UTM American Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(625, 501);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(412, 101);
            this.lblTongTien.TabIndex = 54;
            this.lblTongTien.Text = "Tổng Tiền : ";
            this.lblTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbTatCa);
            this.groupBox2.Controls.Add(this.date_year);
            this.groupBox2.Controls.Add(this.date_month);
            this.groupBox2.Controls.Add(this.date_day);
            this.groupBox2.Controls.Add(this.rdbNam);
            this.groupBox2.Controls.Add(this.rdbThang);
            this.groupBox2.Controls.Add(this.rdbNgay);
            this.groupBox2.Location = new System.Drawing.Point(12, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1025, 80);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bộ Lọc";
            // 
            // rdbTatCa
            // 
            this.rdbTatCa.AutoSize = true;
            this.rdbTatCa.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbTatCa.CheckedState.BorderThickness = 0;
            this.rdbTatCa.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbTatCa.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbTatCa.CheckedState.InnerOffset = -4;
            this.rdbTatCa.Location = new System.Drawing.Point(38, 40);
            this.rdbTatCa.Name = "rdbTatCa";
            this.rdbTatCa.Size = new System.Drawing.Size(71, 21);
            this.rdbTatCa.TabIndex = 9;
            this.rdbTatCa.Text = "Tất Cả";
            this.rdbTatCa.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbTatCa.UncheckedState.BorderThickness = 2;
            this.rdbTatCa.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbTatCa.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbTatCa.CheckedChanged += new System.EventHandler(this.rdbTatCa_CheckedChanged);
            // 
            // date_year
            // 
            this.date_year.BorderRadius = 10;
            this.date_year.Checked = true;
            this.date_year.CheckedState.Parent = this.date_year;
            this.date_year.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date_year.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_year.HoverState.Parent = this.date_year;
            this.date_year.Location = new System.Drawing.Point(875, 26);
            this.date_year.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_year.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_year.Name = "date_year";
            this.date_year.ShadowDecoration.Parent = this.date_year;
            this.date_year.Size = new System.Drawing.Size(143, 36);
            this.date_year.TabIndex = 8;
            this.date_year.Value = new System.DateTime(2021, 12, 17, 22, 35, 14, 925);
            this.date_year.ValueChanged += new System.EventHandler(this.date_year_ValueChanged);
            // 
            // date_month
            // 
            this.date_month.BorderRadius = 10;
            this.date_month.Checked = true;
            this.date_month.CheckedState.Parent = this.date_month;
            this.date_month.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date_month.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_month.HoverState.Parent = this.date_month;
            this.date_month.Location = new System.Drawing.Point(592, 26);
            this.date_month.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_month.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_month.Name = "date_month";
            this.date_month.ShadowDecoration.Parent = this.date_month;
            this.date_month.Size = new System.Drawing.Size(143, 36);
            this.date_month.TabIndex = 8;
            this.date_month.Value = new System.DateTime(2021, 12, 17, 22, 35, 14, 925);
            this.date_month.ValueChanged += new System.EventHandler(this.date_month_ValueChanged);
            // 
            // date_day
            // 
            this.date_day.BorderRadius = 10;
            this.date_day.Checked = true;
            this.date_day.CheckedState.Parent = this.date_day;
            this.date_day.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date_day.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_day.HoverState.Parent = this.date_day;
            this.date_day.Location = new System.Drawing.Point(291, 26);
            this.date_day.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_day.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_day.Name = "date_day";
            this.date_day.ShadowDecoration.Parent = this.date_day;
            this.date_day.Size = new System.Drawing.Size(143, 36);
            this.date_day.TabIndex = 7;
            this.date_day.Value = new System.DateTime(2021, 12, 17, 22, 35, 14, 925);
            this.date_day.ValueChanged += new System.EventHandler(this.date_day_ValueChanged);
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbNam.CheckedState.BorderThickness = 0;
            this.rdbNam.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbNam.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbNam.CheckedState.InnerOffset = -4;
            this.rdbNam.Location = new System.Drawing.Point(762, 38);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(95, 21);
            this.rdbNam.TabIndex = 3;
            this.rdbNam.Text = "Theo Năm";
            this.rdbNam.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbNam.UncheckedState.BorderThickness = 2;
            this.rdbNam.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbNam.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbNam.CheckedChanged += new System.EventHandler(this.rdbNam_CheckedChanged);
            // 
            // rdbThang
            // 
            this.rdbThang.AutoSize = true;
            this.rdbThang.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbThang.CheckedState.BorderThickness = 0;
            this.rdbThang.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbThang.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbThang.CheckedState.InnerOffset = -4;
            this.rdbThang.Location = new System.Drawing.Point(468, 38);
            this.rdbThang.Name = "rdbThang";
            this.rdbThang.Size = new System.Drawing.Size(107, 21);
            this.rdbThang.TabIndex = 2;
            this.rdbThang.Text = "Theo Tháng";
            this.rdbThang.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbThang.UncheckedState.BorderThickness = 2;
            this.rdbThang.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbThang.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbThang.CheckedChanged += new System.EventHandler(this.rdbThang_CheckedChanged);
            // 
            // rdbNgay
            // 
            this.rdbNgay.AutoSize = true;
            this.rdbNgay.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbNgay.CheckedState.BorderThickness = 0;
            this.rdbNgay.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbNgay.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbNgay.CheckedState.InnerOffset = -4;
            this.rdbNgay.Location = new System.Drawing.Point(166, 38);
            this.rdbNgay.Name = "rdbNgay";
            this.rdbNgay.Size = new System.Drawing.Size(99, 21);
            this.rdbNgay.TabIndex = 1;
            this.rdbNgay.Text = "Theo Ngày";
            this.rdbNgay.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbNgay.UncheckedState.BorderThickness = 2;
            this.rdbNgay.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbNgay.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbNgay.CheckedChanged += new System.EventHandler(this.rdbNgay_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Brewers KT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 41);
            this.label1.TabIndex = 52;
            this.label1.Text = "DOANH THU ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartThongKe
            // 
            chartArea8.Name = "ChartArea1";
            this.chartThongKe.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chartThongKe.Legends.Add(legend8);
            this.chartThongKe.Location = new System.Drawing.Point(13, 137);
            this.chartThongKe.Name = "chartThongKe";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Tổng Tiền";
            this.chartThongKe.Series.Add(series8);
            this.chartThongKe.Size = new System.Drawing.Size(607, 464);
            this.chartThongKe.TabIndex = 56;
            this.chartThongKe.Text = "chart1";
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 613);
            this.Controls.Add(this.chartThongKe);
            this.Controls.Add(this.dgvThongTinHD);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Name = "ThongKe";
            this.Text = "Thông Kê";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinHD)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn giora;
        private System.Windows.Forms.DataGridViewTextBoxColumn giovao;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahd;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private Guna.UI2.WinForms.Guna2DataGridView dgvThongTinHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn soban;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2RadioButton rdbTatCa;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_year;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_month;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_day;
        private Guna.UI2.WinForms.Guna2RadioButton rdbNam;
        private Guna.UI2.WinForms.Guna2RadioButton rdbThang;
        private Guna.UI2.WinForms.Guna2RadioButton rdbNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThongKe;
    }
}