
namespace sidebar_Menu.Forms
{
    partial class FormNhomThucPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhomThucPham));
            this.dgvNhomMon = new System.Windows.Forms.DataGridView();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.txtMaNM = new System.Windows.Forms.TextBox();
            this.txtTenNhom = new System.Windows.Forms.TextBox();
            this.btnXoaa = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddd = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhomMon)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNhomMon
            // 
            this.dgvNhomMon.AllowUserToAddRows = false;
            this.dgvNhomMon.AllowUserToDeleteRows = false;
            this.dgvNhomMon.AllowUserToResizeColumns = false;
            this.dgvNhomMon.AllowUserToResizeRows = false;
            this.dgvNhomMon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhomMon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhomMon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNhomMon.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhomMon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhomMon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNhomMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhomMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(158)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhomMon.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNhomMon.EnableHeadersVisualStyles = false;
            this.dgvNhomMon.GridColor = System.Drawing.Color.Black;
            this.dgvNhomMon.Location = new System.Drawing.Point(42, 252);
            this.dgvNhomMon.Name = "dgvNhomMon";
            this.dgvNhomMon.RowHeadersVisible = false;
            this.dgvNhomMon.RowHeadersWidth = 51;
            this.dgvNhomMon.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvNhomMon.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvNhomMon.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNhomMon.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvNhomMon.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2);
            this.dgvNhomMon.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(148)))), ((int)(((byte)(242)))));
            this.dgvNhomMon.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvNhomMon.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhomMon.RowTemplate.Height = 24;
            this.dgvNhomMon.RowTemplate.ReadOnly = true;
            this.dgvNhomMon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhomMon.Size = new System.Drawing.Size(957, 320);
            this.dgvNhomMon.TabIndex = 53;
            this.dgvNhomMon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgcTTNMon_CellClick);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GroupBox1.Controls.Add(this.txtTimKiem);
            this.guna2GroupBox1.Controls.Add(this.btnTimKiem);
            this.guna2GroupBox1.Controls.Add(this.txtMaNM);
            this.guna2GroupBox1.Controls.Add(this.txtTenNhom);
            this.guna2GroupBox1.Controls.Add(this.btnXoaa);
            this.guna2GroupBox1.Controls.Add(this.btnUpdate);
            this.guna2GroupBox1.Controls.Add(this.btnAddd);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(133)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(42, 56);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(957, 165);
            this.guna2GroupBox1.TabIndex = 54;
            this.guna2GroupBox1.Text = "Thông Tin Nhóm Thực Phẩm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.CheckedState.Parent = this.btnTimKiem;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.CustomImages.Parent = this.btnTimKiem;
            this.btnTimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimKiem.DisabledState.Parent = this.btnTimKiem;
            this.btnTimKiem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.HoverState.Parent = this.btnTimKiem;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTimKiem.Location = new System.Drawing.Point(787, 109);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.ShadowDecoration.Parent = this.btnTimKiem;
            this.btnTimKiem.Size = new System.Drawing.Size(152, 45);
            this.btnTimKiem.TabIndex = 24;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtMaNM
            // 
            this.txtMaNM.Location = new System.Drawing.Point(214, 55);
            this.txtMaNM.Name = "txtMaNM";
            this.txtMaNM.ReadOnly = true;
            this.txtMaNM.Size = new System.Drawing.Size(192, 30);
            this.txtMaNM.TabIndex = 22;
            // 
            // txtTenNhom
            // 
            this.txtTenNhom.Location = new System.Drawing.Point(643, 59);
            this.txtTenNhom.Name = "txtTenNhom";
            this.txtTenNhom.Size = new System.Drawing.Size(192, 30);
            this.txtTenNhom.TabIndex = 21;
            // 
            // btnXoaa
            // 
            this.btnXoaa.CheckedState.Parent = this.btnXoaa;
            this.btnXoaa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaa.CustomImages.Parent = this.btnXoaa;
            this.btnXoaa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaa.DisabledState.Parent = this.btnXoaa;
            this.btnXoaa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.btnXoaa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaa.ForeColor = System.Drawing.Color.White;
            this.btnXoaa.HoverState.Parent = this.btnXoaa;
            this.btnXoaa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaa.Image")));
            this.btnXoaa.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnXoaa.Location = new System.Drawing.Point(273, 109);
            this.btnXoaa.Name = "btnXoaa";
            this.btnXoaa.ShadowDecoration.Parent = this.btnXoaa;
            this.btnXoaa.Size = new System.Drawing.Size(122, 45);
            this.btnXoaa.TabIndex = 17;
            this.btnXoaa.Text = "Xoá";
            this.btnXoaa.Click += new System.EventHandler(this.btnXoaa_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.DisabledState.Parent = this.btnUpdate;
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdate.Location = new System.Drawing.Point(145, 109);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(122, 45);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddd
            // 
            this.btnAddd.CheckedState.Parent = this.btnAddd;
            this.btnAddd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddd.CustomImages.Parent = this.btnAddd;
            this.btnAddd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddd.DisabledState.Parent = this.btnAddd;
            this.btnAddd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.btnAddd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddd.ForeColor = System.Drawing.Color.White;
            this.btnAddd.HoverState.Parent = this.btnAddd;
            this.btnAddd.Image = ((System.Drawing.Image)(resources.GetObject("btnAddd.Image")));
            this.btnAddd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddd.Location = new System.Drawing.Point(17, 109);
            this.btnAddd.Name = "btnAddd";
            this.btnAddd.ShadowDecoration.Parent = this.btnAddd;
            this.btnAddd.Size = new System.Drawing.Size(122, 45);
            this.btnAddd.TabIndex = 15;
            this.btnAddd.Text = "Thêm";
            this.btnAddd.Click += new System.EventHandler(this.btnAddd_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(443, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 36);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên Nhóm Thực Phẩm";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã Nhóm Thực Phẩm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.Parent = this.txtTimKiem;
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.FocusedState.Parent = this.txtTimKiem;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.HoverState.Parent = this.txtTimKiem;
            this.txtTimKiem.Location = new System.Drawing.Point(559, 109);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderText = "Tìm Kiếm Nhóm Thực Phẩm";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.ShadowDecoration.Parent = this.txtTimKiem;
            this.txtTimKiem.Size = new System.Drawing.Size(222, 45);
            this.txtTimKiem.TabIndex = 25;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 40.10695F;
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 129.9465F;
            this.Column2.HeaderText = "Mã Nhóm Thực Phẩm";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 129.9465F;
            this.Column3.HeaderText = "Tên Nhóm Thực Phẩm";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // FormNhomThucPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 603);
            this.Controls.Add(this.dgvNhomMon);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNhomThucPham";
            this.Text = "Quản Lý Nhóm Thực Phẩm";
            this.Load += new System.EventHandler(this.TTNhomMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhomMon)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNhomMon;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.TextBox txtTenNhom;
        private Guna.UI2.WinForms.Guna2Button btnXoaa;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnAddd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNM;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
    }
}