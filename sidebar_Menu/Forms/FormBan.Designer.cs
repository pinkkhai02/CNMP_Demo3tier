
namespace sidebar_Menu.Forms
{
    partial class FormBan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBan));
            this.dgvTTBan = new System.Windows.Forms.DataGridView();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cbbLocTheoTrangThai = new System.Windows.Forms.ComboBox();
            this.txtSoBan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTrangThai = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaBan = new Guna.UI2.WinForms.Guna2Button();
            this.btnSuaBan = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemBan = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTBan)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTTBan
            // 
            this.dgvTTBan.AllowUserToAddRows = false;
            this.dgvTTBan.AllowUserToDeleteRows = false;
            this.dgvTTBan.AllowUserToResizeColumns = false;
            this.dgvTTBan.AllowUserToResizeRows = false;
            this.dgvTTBan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTTBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTTBan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTTBan.BackgroundColor = System.Drawing.Color.White;
            this.dgvTTBan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTTBan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTTBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.tenban,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(158)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTTBan.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTTBan.EnableHeadersVisualStyles = false;
            this.dgvTTBan.GridColor = System.Drawing.Color.Black;
            this.dgvTTBan.Location = new System.Drawing.Point(21, 228);
            this.dgvTTBan.Name = "dgvTTBan";
            this.dgvTTBan.RowHeadersVisible = false;
            this.dgvTTBan.RowHeadersWidth = 51;
            this.dgvTTBan.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvTTBan.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvTTBan.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTTBan.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTTBan.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2);
            this.dgvTTBan.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(148)))), ((int)(((byte)(242)))));
            this.dgvTTBan.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTTBan.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTTBan.RowTemplate.Height = 24;
            this.dgvTTBan.RowTemplate.ReadOnly = true;
            this.dgvTTBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTTBan.Size = new System.Drawing.Size(999, 346);
            this.dgvTTBan.TabIndex = 54;
            this.dgvTTBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTTBan_CellClick);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox1.Controls.Add(this.cbbLocTheoTrangThai);
            this.guna2GroupBox1.Controls.Add(this.txtSoBan);
            this.guna2GroupBox1.Controls.Add(this.txtTrangThai);
            this.guna2GroupBox1.Controls.Add(this.btnTimKiem);
            this.guna2GroupBox1.Controls.Add(this.btnXoaBan);
            this.guna2GroupBox1.Controls.Add(this.btnSuaBan);
            this.guna2GroupBox1.Controls.Add(this.btnThemBan);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(133)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(21, 34);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(999, 172);
            this.guna2GroupBox1.TabIndex = 55;
            this.guna2GroupBox1.Text = "Thông Tin Bàn";
            // 
            // cbbLocTheoTrangThai
            // 
            this.cbbLocTheoTrangThai.FormattingEnabled = true;
            this.cbbLocTheoTrangThai.ItemHeight = 23;
            this.cbbLocTheoTrangThai.Items.AddRange(new object[] {
            "Trống",
            "Có Khách",
            "Tất Cả"});
            this.cbbLocTheoTrangThai.Location = new System.Drawing.Point(667, 118);
            this.cbbLocTheoTrangThai.Name = "cbbLocTheoTrangThai";
            this.cbbLocTheoTrangThai.Size = new System.Drawing.Size(184, 31);
            this.cbbLocTheoTrangThai.TabIndex = 26;
            // 
            // txtSoBan
            // 
            this.txtSoBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoBan.DefaultText = "";
            this.txtSoBan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoBan.DisabledState.Parent = this.txtSoBan;
            this.txtSoBan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoBan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoBan.FocusedState.Parent = this.txtSoBan;
            this.txtSoBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoBan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoBan.HoverState.Parent = this.txtSoBan;
            this.txtSoBan.Location = new System.Drawing.Point(120, 58);
            this.txtSoBan.Name = "txtSoBan";
            this.txtSoBan.PasswordChar = '\0';
            this.txtSoBan.PlaceholderText = "";
            this.txtSoBan.ReadOnly = true;
            this.txtSoBan.SelectedText = "";
            this.txtSoBan.ShadowDecoration.Parent = this.txtSoBan;
            this.txtSoBan.Size = new System.Drawing.Size(200, 30);
            this.txtSoBan.TabIndex = 25;
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.FormattingEnabled = true;
            this.txtTrangThai.ItemHeight = 23;
            this.txtTrangThai.Items.AddRange(new object[] {
            "Trống",
            "Có Khách"});
            this.txtTrangThai.Location = new System.Drawing.Point(480, 58);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(195, 31);
            this.txtTrangThai.TabIndex = 24;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Animated = true;
            this.btnTimKiem.CheckedState.Parent = this.btnTimKiem;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.CustomImages.Parent = this.btnTimKiem;
            this.btnTimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimKiem.DisabledState.Parent = this.btnTimKiem;
            this.btnTimKiem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.HoverState.Parent = this.btnTimKiem;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTimKiem.Location = new System.Drawing.Point(857, 109);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.ShadowDecoration.Parent = this.btnTimKiem;
            this.btnTimKiem.Size = new System.Drawing.Size(139, 45);
            this.btnTimKiem.TabIndex = 19;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoaBan
            // 
            this.btnXoaBan.CheckedState.Parent = this.btnXoaBan;
            this.btnXoaBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaBan.CustomImages.Parent = this.btnXoaBan;
            this.btnXoaBan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaBan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaBan.DisabledState.Parent = this.btnXoaBan;
            this.btnXoaBan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.btnXoaBan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaBan.ForeColor = System.Drawing.Color.White;
            this.btnXoaBan.HoverState.Parent = this.btnXoaBan;
            this.btnXoaBan.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaBan.Image")));
            this.btnXoaBan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnXoaBan.Location = new System.Drawing.Point(273, 109);
            this.btnXoaBan.Name = "btnXoaBan";
            this.btnXoaBan.ShadowDecoration.Parent = this.btnXoaBan;
            this.btnXoaBan.Size = new System.Drawing.Size(122, 45);
            this.btnXoaBan.TabIndex = 17;
            this.btnXoaBan.Text = "Xoá";
            this.btnXoaBan.Click += new System.EventHandler(this.btnXoaBan_Click);
            // 
            // btnSuaBan
            // 
            this.btnSuaBan.CheckedState.Parent = this.btnSuaBan;
            this.btnSuaBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaBan.CustomImages.Parent = this.btnSuaBan;
            this.btnSuaBan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaBan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuaBan.DisabledState.Parent = this.btnSuaBan;
            this.btnSuaBan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.btnSuaBan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaBan.ForeColor = System.Drawing.Color.White;
            this.btnSuaBan.HoverState.Parent = this.btnSuaBan;
            this.btnSuaBan.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaBan.Image")));
            this.btnSuaBan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSuaBan.Location = new System.Drawing.Point(145, 109);
            this.btnSuaBan.Name = "btnSuaBan";
            this.btnSuaBan.ShadowDecoration.Parent = this.btnSuaBan;
            this.btnSuaBan.Size = new System.Drawing.Size(122, 45);
            this.btnSuaBan.TabIndex = 16;
            this.btnSuaBan.Text = "Sửa";
            this.btnSuaBan.Click += new System.EventHandler(this.btnSuaBan_Click);
            // 
            // btnThemBan
            // 
            this.btnThemBan.CheckedState.Parent = this.btnThemBan;
            this.btnThemBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemBan.CustomImages.Parent = this.btnThemBan;
            this.btnThemBan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemBan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemBan.DisabledState.Parent = this.btnThemBan;
            this.btnThemBan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.btnThemBan.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnThemBan.ForeColor = System.Drawing.Color.White;
            this.btnThemBan.HoverState.Parent = this.btnThemBan;
            this.btnThemBan.Image = ((System.Drawing.Image)(resources.GetObject("btnThemBan.Image")));
            this.btnThemBan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThemBan.Location = new System.Drawing.Point(17, 109);
            this.btnThemBan.Name = "btnThemBan";
            this.btnThemBan.ShadowDecoration.Parent = this.btnThemBan;
            this.btnThemBan.Size = new System.Drawing.Size(122, 45);
            this.btnThemBan.TabIndex = 15;
            this.btnThemBan.Text = "Thêm";
            this.btnThemBan.Click += new System.EventHandler(this.btnThemBan_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(376, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 36);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hoạt Động";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số Bàn";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Số Bàn";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // tenban
            // 
            this.tenban.HeaderText = "Tên Bàn";
            this.tenban.MinimumWidth = 6;
            this.tenban.Name = "tenban";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Trạng Thái";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // FormBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 603);
            this.Controls.Add(this.dgvTTBan);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBan";
            this.Text = "Quản Lý Bàn";
            this.Load += new System.EventHandler(this.FormBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTBan)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTTBan;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.ComboBox txtTrangThai;
        private Guna.UI2.WinForms.Guna2Button btnXoaBan;
        private Guna.UI2.WinForms.Guna2Button btnSuaBan;
        private Guna.UI2.WinForms.Guna2Button btnThemBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtSoBan;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private System.Windows.Forms.ComboBox cbbLocTheoTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenban;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}