
namespace WinFormsApp_Coffee
{
    partial class frmQuanlyban
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanlyban));
            this.btnKhoaban = new System.Windows.Forms.Button();
            this.btnXoaban = new System.Windows.Forms.Button();
            this.btnSuaban = new System.Windows.Forms.Button();
            this.btnThemban = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.dgvQuanlyban = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.dateBD = new System.Windows.Forms.DateTimePicker();
            this.txtSoghe = new System.Windows.Forms.TextBox();
            this.txtTenban = new System.Windows.Forms.TextBox();
            this.txtMaban = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanlyban)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKhoaban
            // 
            this.btnKhoaban.Location = new System.Drawing.Point(495, 2);
            this.btnKhoaban.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnKhoaban.Name = "btnKhoaban";
            this.btnKhoaban.Size = new System.Drawing.Size(156, 78);
            this.btnKhoaban.TabIndex = 3;
            this.btnKhoaban.Text = "Khóa bàn";
            this.btnKhoaban.UseVisualStyleBackColor = true;
            this.btnKhoaban.Click += new System.EventHandler(this.btnKhoaban_Click);
            // 
            // btnXoaban
            // 
            this.btnXoaban.Location = new System.Drawing.Point(331, 2);
            this.btnXoaban.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnXoaban.Name = "btnXoaban";
            this.btnXoaban.Size = new System.Drawing.Size(156, 78);
            this.btnXoaban.TabIndex = 2;
            this.btnXoaban.Text = "Xóa bàn";
            this.btnXoaban.UseVisualStyleBackColor = true;
            this.btnXoaban.Click += new System.EventHandler(this.btnXoaban_Click);
            // 
            // btnSuaban
            // 
            this.btnSuaban.Location = new System.Drawing.Point(167, 2);
            this.btnSuaban.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSuaban.Name = "btnSuaban";
            this.btnSuaban.Size = new System.Drawing.Size(156, 78);
            this.btnSuaban.TabIndex = 1;
            this.btnSuaban.Text = "Sửa bàn";
            this.btnSuaban.UseVisualStyleBackColor = true;
            this.btnSuaban.Click += new System.EventHandler(this.btnSuaban_Click);
            // 
            // btnThemban
            // 
            this.btnThemban.Location = new System.Drawing.Point(6, 2);
            this.btnThemban.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnThemban.Name = "btnThemban";
            this.btnThemban.Size = new System.Drawing.Size(156, 78);
            this.btnThemban.TabIndex = 0;
            this.btnThemban.Text = "Thêm bàn";
            this.btnThemban.UseVisualStyleBackColor = true;
            this.btnThemban.Click += new System.EventHandler(this.btnThemban_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLammoi);
            this.panel1.Controls.Add(this.btnKhoaban);
            this.panel1.Controls.Add(this.btnXoaban);
            this.panel1.Controls.Add(this.btnSuaban);
            this.panel1.Controls.Add(this.btnThemban);
            this.panel1.Location = new System.Drawing.Point(7, 29);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 83);
            this.panel1.TabIndex = 2;
            // 
            // btnLammoi
            // 
            this.btnLammoi.Location = new System.Drawing.Point(660, 2);
            this.btnLammoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(144, 78);
            this.btnLammoi.TabIndex = 4;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // dgvQuanlyban
            // 
            this.dgvQuanlyban.AllowUserToAddRows = false;
            this.dgvQuanlyban.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuanlyban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanlyban.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4});
            this.dgvQuanlyban.Location = new System.Drawing.Point(4, 29);
            this.dgvQuanlyban.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dgvQuanlyban.Name = "dgvQuanlyban";
            this.dgvQuanlyban.ReadOnly = true;
            this.dgvQuanlyban.RowHeadersWidth = 62;
            this.dgvQuanlyban.RowTemplate.Height = 33;
            this.dgvQuanlyban.Size = new System.Drawing.Size(966, 492);
            this.dgvQuanlyban.TabIndex = 0;
            this.dgvQuanlyban.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanlyban_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaBan";
            this.Column1.HeaderText = "Mã bàn";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenBan";
            this.Column2.HeaderText = "Tên bàn";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SoGhe";
            this.Column3.HeaderText = "Số ghế";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TrangThai";
            this.Column5.HeaderText = "Trạng thái bàn";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NgayBatDauSD";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.Column4.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column4.HeaderText = "Ngày bắt đầu sử dụng";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbTrangThai);
            this.panel3.Controls.Add(this.dateBD);
            this.panel3.Controls.Add(this.txtSoghe);
            this.panel3.Controls.Add(this.txtTenban);
            this.panel3.Controls.Add(this.txtMaban);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(10, 29);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(399, 492);
            this.panel3.TabIndex = 4;
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Items.AddRange(new object[] {
            "Trống",
            "Có người",
            "Đã khóa"});
            this.cbTrangThai.Location = new System.Drawing.Point(141, 272);
            this.cbTrangThai.Margin = new System.Windows.Forms.Padding(2);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(253, 33);
            this.cbTrangThai.TabIndex = 17;
            // 
            // dateBD
            // 
            this.dateBD.CustomFormat = "dd/MM/yyyy";
            this.dateBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBD.Location = new System.Drawing.Point(141, 208);
            this.dateBD.Margin = new System.Windows.Forms.Padding(2);
            this.dateBD.Name = "dateBD";
            this.dateBD.Size = new System.Drawing.Size(253, 31);
            this.dateBD.TabIndex = 16;
            this.dateBD.Value = new System.DateTime(2021, 9, 23, 0, 0, 0, 0);
            // 
            // txtSoghe
            // 
            this.txtSoghe.Location = new System.Drawing.Point(141, 138);
            this.txtSoghe.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtSoghe.Name = "txtSoghe";
            this.txtSoghe.Size = new System.Drawing.Size(253, 31);
            this.txtSoghe.TabIndex = 13;
            // 
            // txtTenban
            // 
            this.txtTenban.Location = new System.Drawing.Point(141, 78);
            this.txtTenban.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtTenban.Name = "txtTenban";
            this.txtTenban.Size = new System.Drawing.Size(253, 31);
            this.txtTenban.TabIndex = 12;
            // 
            // txtMaban
            // 
            this.txtMaban.Enabled = false;
            this.txtMaban.Location = new System.Drawing.Point(141, 15);
            this.txtMaban.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtMaban.Name = "txtMaban";
            this.txtMaban.Size = new System.Drawing.Size(253, 31);
            this.txtMaban.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 272);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Trạng thái bàn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã bàn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày sử dụng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số ghế:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên bàn:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(11, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(974, 124);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvQuanlyban);
            this.groupBox2.Location = new System.Drawing.Point(11, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(974, 529);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách bàn";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Location = new System.Drawing.Point(991, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(423, 529);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin bàn";
            // 
            // frmQuanlyban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 670);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.MaximizeBox = false;
            this.Name = "frmQuanlyban";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bàn";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanlyban)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKhoaban;
        private System.Windows.Forms.Button btnXoaban;
        private System.Windows.Forms.Button btnSuaban;
        private System.Windows.Forms.Button btnThemban;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvQuanlyban;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoghe;
        private System.Windows.Forms.TextBox txtTenban;
        private System.Windows.Forms.TextBox txtMaban;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateBD;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}