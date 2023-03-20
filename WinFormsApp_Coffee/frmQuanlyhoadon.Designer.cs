
namespace WinFormsApp_Coffee
{
    partial class frmQuanlyhoadon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanlyhoadon));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKhoahd = new System.Windows.Forms.Button();
            this.btnXoahd = new System.Windows.Forms.Button();
            this.btnSuahd = new System.Windows.Forms.Button();
            this.btnThemhd = new System.Windows.Forms.Button();
            this.btnXemhd = new System.Windows.Forms.Button();
            this.dgvQlhoadon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cbtrangthai = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbtenban = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtNgaylap = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbtennv = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMahd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQlhoadon)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnKhoahd);
            this.panel1.Controls.Add(this.btnXoahd);
            this.panel1.Controls.Add(this.btnSuahd);
            this.panel1.Controls.Add(this.btnThemhd);
            this.panel1.Controls.Add(this.btnXemhd);
            this.panel1.Location = new System.Drawing.Point(7, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 89);
            this.panel1.TabIndex = 4;
            // 
            // btnKhoahd
            // 
            this.btnKhoahd.Location = new System.Drawing.Point(660, 6);
            this.btnKhoahd.Margin = new System.Windows.Forms.Padding(4);
            this.btnKhoahd.Name = "btnKhoahd";
            this.btnKhoahd.Size = new System.Drawing.Size(156, 79);
            this.btnKhoahd.TabIndex = 4;
            this.btnKhoahd.Text = "Khóa hóa đơn";
            this.btnKhoahd.UseVisualStyleBackColor = true;
            this.btnKhoahd.Click += new System.EventHandler(this.btnKhoahd_Click);
            // 
            // btnXoahd
            // 
            this.btnXoahd.Location = new System.Drawing.Point(496, 5);
            this.btnXoahd.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoahd.Name = "btnXoahd";
            this.btnXoahd.Size = new System.Drawing.Size(156, 79);
            this.btnXoahd.TabIndex = 3;
            this.btnXoahd.Text = "Xóa hóa đơn";
            this.btnXoahd.UseVisualStyleBackColor = true;
            this.btnXoahd.Click += new System.EventHandler(this.btnXoahd_Click);
            // 
            // btnSuahd
            // 
            this.btnSuahd.Location = new System.Drawing.Point(331, 4);
            this.btnSuahd.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuahd.Name = "btnSuahd";
            this.btnSuahd.Size = new System.Drawing.Size(156, 79);
            this.btnSuahd.TabIndex = 2;
            this.btnSuahd.Text = "Sửa hóa đơn";
            this.btnSuahd.UseVisualStyleBackColor = true;
            this.btnSuahd.Click += new System.EventHandler(this.btnSuahd_Click);
            // 
            // btnThemhd
            // 
            this.btnThemhd.Location = new System.Drawing.Point(169, 5);
            this.btnThemhd.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemhd.Name = "btnThemhd";
            this.btnThemhd.Size = new System.Drawing.Size(156, 79);
            this.btnThemhd.TabIndex = 1;
            this.btnThemhd.Text = "Thêm hóa đơn";
            this.btnThemhd.UseVisualStyleBackColor = true;
            this.btnThemhd.Click += new System.EventHandler(this.btnThemhd_Click);
            // 
            // btnXemhd
            // 
            this.btnXemhd.Location = new System.Drawing.Point(6, 4);
            this.btnXemhd.Margin = new System.Windows.Forms.Padding(4);
            this.btnXemhd.Name = "btnXemhd";
            this.btnXemhd.Size = new System.Drawing.Size(156, 79);
            this.btnXemhd.TabIndex = 0;
            this.btnXemhd.Text = "Xem hóa đơn";
            this.btnXemhd.UseVisualStyleBackColor = true;
            this.btnXemhd.Click += new System.EventHandler(this.btnXemhd_Click);
            // 
            // dgvQlhoadon
            // 
            this.dgvQlhoadon.AllowUserToAddRows = false;
            this.dgvQlhoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQlhoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQlhoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvQlhoadon.Location = new System.Drawing.Point(7, 29);
            this.dgvQlhoadon.Margin = new System.Windows.Forms.Padding(2);
            this.dgvQlhoadon.Name = "dgvQlhoadon";
            this.dgvQlhoadon.RowHeadersWidth = 62;
            this.dgvQlhoadon.RowTemplate.Height = 25;
            this.dgvQlhoadon.Size = new System.Drawing.Size(894, 421);
            this.dgvQlhoadon.TabIndex = 0;
            this.dgvQlhoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQlhoadon_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaHD";
            this.Column1.HeaderText = "Mã HĐ";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Tentk";
            this.Column2.HeaderText = "Tên nhân viên";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Ngaylap";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column3.HeaderText = "Ngày lập";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Tenban";
            this.Column4.HeaderText = "Tên bàn";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Trangthaihoadon";
            this.Column5.HeaderText = "Trạng thái";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(7, 29);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(388, 421);
            this.panel2.TabIndex = 13;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.cbtrangthai);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(6, 299);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(374, 64);
            this.panel7.TabIndex = 7;
            // 
            // cbtrangthai
            // 
            this.cbtrangthai.FormattingEnabled = true;
            this.cbtrangthai.Items.AddRange(new object[] {
            "Chưa thanh toán",
            "Đã thanh toán",
            "Đã khóa"});
            this.cbtrangthai.Location = new System.Drawing.Point(142, 20);
            this.cbtrangthai.Name = "cbtrangthai";
            this.cbtrangthai.Size = new System.Drawing.Size(226, 33);
            this.cbtrangthai.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Trạng thái:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cbtenban);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(6, 225);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(374, 64);
            this.panel6.TabIndex = 6;
            // 
            // cbtenban
            // 
            this.cbtenban.FormattingEnabled = true;
            this.cbtenban.Location = new System.Drawing.Point(142, 20);
            this.cbtenban.Name = "cbtenban";
            this.cbtenban.Size = new System.Drawing.Size(226, 33);
            this.cbtenban.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên bàn:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dtNgaylap);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(6, 151);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(374, 64);
            this.panel5.TabIndex = 5;
            // 
            // dtNgaylap
            // 
            this.dtNgaylap.CustomFormat = "dd/MM/yyyy";
            this.dtNgaylap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgaylap.Location = new System.Drawing.Point(142, 20);
            this.dtNgaylap.Name = "dtNgaylap";
            this.dtNgaylap.Size = new System.Drawing.Size(226, 31);
            this.dtNgaylap.TabIndex = 1;
            this.dtNgaylap.Value = new System.DateTime(2021, 10, 9, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày lập:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbtennv);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(4, 79);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(376, 64);
            this.panel4.TabIndex = 4;
            // 
            // cbtennv
            // 
            this.cbtennv.FormattingEnabled = true;
            this.cbtennv.Location = new System.Drawing.Point(144, 20);
            this.cbtennv.Name = "cbtennv";
            this.cbtennv.Size = new System.Drawing.Size(226, 33);
            this.cbtennv.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên nhân viên:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtMahd);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(6, 5);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(374, 64);
            this.panel3.TabIndex = 3;
            // 
            // txtMahd
            // 
            this.txtMahd.Enabled = false;
            this.txtMahd.Location = new System.Drawing.Point(142, 15);
            this.txtMahd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMahd.Name = "txtMahd";
            this.txtMahd.Size = new System.Drawing.Size(226, 31);
            this.txtMahd.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã hóa đơn:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvQlhoadon);
            this.groupBox1.Location = new System.Drawing.Point(12, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(906, 459);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hóa đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(12, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(906, 130);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Location = new System.Drawing.Point(924, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(402, 459);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin hóa đơn";
            // 
            // frmQuanlyhoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 614);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmQuanlyhoadon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý hóa đơn";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQlhoadon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKhoahd;
        private System.Windows.Forms.Button btnXoahd;
        private System.Windows.Forms.Button btnSuahd;
        private System.Windows.Forms.Button btnThemhd;
        private System.Windows.Forms.Button btnXemhd;
        private System.Windows.Forms.DataGridView dgvQlhoadon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtMahd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbtrangthai;
        private System.Windows.Forms.ComboBox cbtenban;
        private System.Windows.Forms.DateTimePicker dtNgaylap;
        private System.Windows.Forms.ComboBox cbtennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}