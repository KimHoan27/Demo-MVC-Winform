
namespace WinFormsApp_Coffee
{
    partial class frmQuanlykhuyenmai
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanlykhuyenmai));
            this.cbbTrangthai = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateNgaykt = new System.Windows.Forms.DateTimePicker();
            this.dateNgaybd = new System.Windows.Forms.DateTimePicker();
            this.txtMadot = new System.Windows.Forms.TextBox();
            this.txtTendot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvQuanlykhuyenmai = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnXemdotkm = new System.Windows.Forms.Button();
            this.btnXoadotkhuyenmai = new System.Windows.Forms.Button();
            this.btnSuathongtin = new System.Windows.Forms.Button();
            this.btnThemdotkhuyenmai = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanlykhuyenmai)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbTrangthai
            // 
            this.cbbTrangthai.FormattingEnabled = true;
            this.cbbTrangthai.Items.AddRange(new object[] {
            "Chưa áp dụng",
            "Đang diễn ra"});
            this.cbbTrangthai.Location = new System.Drawing.Point(144, 275);
            this.cbbTrangthai.Margin = new System.Windows.Forms.Padding(2);
            this.cbbTrangthai.Name = "cbbTrangthai";
            this.cbbTrangthai.Size = new System.Drawing.Size(249, 33);
            this.cbbTrangthai.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 279);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Trạng thái";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 214);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày kết thúc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày bắt đầu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên đợt:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dateNgaykt);
            this.panel3.Controls.Add(this.dateNgaybd);
            this.panel3.Controls.Add(this.cbbTrangthai);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtMadot);
            this.panel3.Controls.Add(this.txtTendot);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(7, 29);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(429, 411);
            this.panel3.TabIndex = 10;
            // 
            // dateNgaykt
            // 
            this.dateNgaykt.CustomFormat = "dd/MM/yyyy";
            this.dateNgaykt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgaykt.Location = new System.Drawing.Point(145, 208);
            this.dateNgaykt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateNgaykt.Name = "dateNgaykt";
            this.dateNgaykt.Size = new System.Drawing.Size(252, 31);
            this.dateNgaykt.TabIndex = 18;
            // 
            // dateNgaybd
            // 
            this.dateNgaybd.CustomFormat = "dd/MM/yyyy";
            this.dateNgaybd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgaybd.Location = new System.Drawing.Point(144, 145);
            this.dateNgaybd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateNgaybd.Name = "dateNgaybd";
            this.dateNgaybd.Size = new System.Drawing.Size(252, 31);
            this.dateNgaybd.TabIndex = 17;
            // 
            // txtMadot
            // 
            this.txtMadot.Enabled = false;
            this.txtMadot.Location = new System.Drawing.Point(144, 15);
            this.txtMadot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMadot.Name = "txtMadot";
            this.txtMadot.Size = new System.Drawing.Size(249, 31);
            this.txtMadot.TabIndex = 4;
            // 
            // txtTendot
            // 
            this.txtTendot.Location = new System.Drawing.Point(144, 78);
            this.txtTendot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTendot.Name = "txtTendot";
            this.txtTendot.Size = new System.Drawing.Size(249, 31);
            this.txtTendot.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đợt:";
            // 
            // dgvQuanlykhuyenmai
            // 
            this.dgvQuanlykhuyenmai.AllowUserToAddRows = false;
            this.dgvQuanlykhuyenmai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuanlykhuyenmai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanlykhuyenmai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvQuanlykhuyenmai.Location = new System.Drawing.Point(7, 29);
            this.dgvQuanlykhuyenmai.Margin = new System.Windows.Forms.Padding(2);
            this.dgvQuanlykhuyenmai.Name = "dgvQuanlykhuyenmai";
            this.dgvQuanlykhuyenmai.RowHeadersWidth = 62;
            this.dgvQuanlykhuyenmai.RowTemplate.Height = 33;
            this.dgvQuanlykhuyenmai.Size = new System.Drawing.Size(865, 413);
            this.dgvQuanlykhuyenmai.TabIndex = 0;
            this.dgvQuanlykhuyenmai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanlykhuyenmai_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaDot";
            this.Column1.HeaderText = "Mã đợt km";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenDot";
            this.Column2.HeaderText = "Tên đợt km";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NgayBatDau";
            dataGridViewCellStyle5.Format = "dd/MM/yyyy";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column3.HeaderText = "Ngày bắt đầu";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NgayKetThuc";
            dataGridViewCellStyle6.Format = "dd/MM/yyyy";
            this.Column4.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column4.HeaderText = "Ngày kết thúc";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TrangThai";
            this.Column5.HeaderText = "Trạng thái";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLammoi);
            this.panel1.Controls.Add(this.btnXemdotkm);
            this.panel1.Controls.Add(this.btnXoadotkhuyenmai);
            this.panel1.Controls.Add(this.btnSuathongtin);
            this.panel1.Controls.Add(this.btnThemdotkhuyenmai);
            this.panel1.Location = new System.Drawing.Point(7, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 88);
            this.panel1.TabIndex = 8;
            // 
            // btnLammoi
            // 
            this.btnLammoi.Location = new System.Drawing.Point(660, 4);
            this.btnLammoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(148, 79);
            this.btnLammoi.TabIndex = 4;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnXemdotkm
            // 
            this.btnXemdotkm.Location = new System.Drawing.Point(5, 4);
            this.btnXemdotkm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXemdotkm.Name = "btnXemdotkm";
            this.btnXemdotkm.Size = new System.Drawing.Size(156, 79);
            this.btnXemdotkm.TabIndex = 3;
            this.btnXemdotkm.Text = "Xem đợt khuyến mãi";
            this.btnXemdotkm.UseVisualStyleBackColor = true;
            this.btnXemdotkm.Click += new System.EventHandler(this.btnXemdotkm_Click);
            // 
            // btnXoadotkhuyenmai
            // 
            this.btnXoadotkhuyenmai.Location = new System.Drawing.Point(496, 4);
            this.btnXoadotkhuyenmai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoadotkhuyenmai.Name = "btnXoadotkhuyenmai";
            this.btnXoadotkhuyenmai.Size = new System.Drawing.Size(156, 79);
            this.btnXoadotkhuyenmai.TabIndex = 2;
            this.btnXoadotkhuyenmai.Text = "Xóa đợt khuyến mãi";
            this.btnXoadotkhuyenmai.UseVisualStyleBackColor = true;
            this.btnXoadotkhuyenmai.Click += new System.EventHandler(this.btnXoadotkhuyenmai_Click);
            // 
            // btnSuathongtin
            // 
            this.btnSuathongtin.Location = new System.Drawing.Point(332, 4);
            this.btnSuathongtin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSuathongtin.Name = "btnSuathongtin";
            this.btnSuathongtin.Size = new System.Drawing.Size(156, 79);
            this.btnSuathongtin.TabIndex = 1;
            this.btnSuathongtin.Text = "Sửa đợt khuyến mãi";
            this.btnSuathongtin.UseVisualStyleBackColor = true;
            this.btnSuathongtin.Click += new System.EventHandler(this.btnSuathongtin_Click);
            // 
            // btnThemdotkhuyenmai
            // 
            this.btnThemdotkhuyenmai.Location = new System.Drawing.Point(169, 4);
            this.btnThemdotkhuyenmai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemdotkhuyenmai.Name = "btnThemdotkhuyenmai";
            this.btnThemdotkhuyenmai.Size = new System.Drawing.Size(156, 79);
            this.btnThemdotkhuyenmai.TabIndex = 0;
            this.btnThemdotkhuyenmai.Text = "Thêm đợt khuyến mãi";
            this.btnThemdotkhuyenmai.UseVisualStyleBackColor = true;
            this.btnThemdotkhuyenmai.Click += new System.EventHandler(this.btnThemdotkhuyenmai_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(880, 132);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvQuanlykhuyenmai);
            this.groupBox2.Location = new System.Drawing.Point(10, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(880, 447);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách đợt KM";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Location = new System.Drawing.Point(893, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(448, 447);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin đợt";
            // 
            // frmQuanlykhuyenmai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 612);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmQuanlykhuyenmai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khuyến mãi";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanlykhuyenmai)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbTrangthai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtMadot;
        private System.Windows.Forms.TextBox txtTendot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvQuanlykhuyenmai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoadotkhuyenmai;
        private System.Windows.Forms.Button btnSuathongtin;
        private System.Windows.Forms.Button btnThemdotkhuyenmai;
        private System.Windows.Forms.Button btnXemdotkm;
        private System.Windows.Forms.DateTimePicker dateNgaykt;
        private System.Windows.Forms.DateTimePicker dateNgaybd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}