
namespace WinFormsApp_Coffee
{
    partial class frmGiaapdung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiaapdung));
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnXemdotgia = new System.Windows.Forms.Button();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnSuadotgia = new System.Windows.Forms.Button();
            this.btnThemdotgia = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbtrangthai = new System.Windows.Forms.ComboBox();
            this.dateBD = new System.Windows.Forms.DateTimePicker();
            this.txtMadotgia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvGiaapdung = new System.Windows.Forms.DataGridView();
            this.MaDotgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaapdung)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnXemdotgia);
            this.panel4.Controls.Add(this.btnLammoi);
            this.panel4.Controls.Add(this.btnSuadotgia);
            this.panel4.Controls.Add(this.btnThemdotgia);
            this.panel4.Location = new System.Drawing.Point(7, 31);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(659, 76);
            this.panel4.TabIndex = 2;
            // 
            // btnXemdotgia
            // 
            this.btnXemdotgia.Location = new System.Drawing.Point(5, 4);
            this.btnXemdotgia.Margin = new System.Windows.Forms.Padding(4);
            this.btnXemdotgia.Name = "btnXemdotgia";
            this.btnXemdotgia.Size = new System.Drawing.Size(156, 68);
            this.btnXemdotgia.TabIndex = 3;
            this.btnXemdotgia.Text = "Xem đợt giá";
            this.btnXemdotgia.UseVisualStyleBackColor = true;
            this.btnXemdotgia.Click += new System.EventHandler(this.btnXemdotgia_Click);
            // 
            // btnLammoi
            // 
            this.btnLammoi.Location = new System.Drawing.Point(496, 5);
            this.btnLammoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(156, 68);
            this.btnLammoi.TabIndex = 2;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnSuadotgia
            // 
            this.btnSuadotgia.Location = new System.Drawing.Point(332, 5);
            this.btnSuadotgia.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuadotgia.Name = "btnSuadotgia";
            this.btnSuadotgia.Size = new System.Drawing.Size(156, 68);
            this.btnSuadotgia.TabIndex = 1;
            this.btnSuadotgia.Text = "Sửa đợt giá";
            this.btnSuadotgia.UseVisualStyleBackColor = true;
            this.btnSuadotgia.Click += new System.EventHandler(this.btnSuadotgia_Click);
            // 
            // btnThemdotgia
            // 
            this.btnThemdotgia.Location = new System.Drawing.Point(169, 5);
            this.btnThemdotgia.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemdotgia.Name = "btnThemdotgia";
            this.btnThemdotgia.Size = new System.Drawing.Size(156, 68);
            this.btnThemdotgia.TabIndex = 0;
            this.btnThemdotgia.Text = "Thêm đợt giá";
            this.btnThemdotgia.UseVisualStyleBackColor = true;
            this.btnThemdotgia.Click += new System.EventHandler(this.btnThemdotgia_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbtrangthai);
            this.panel3.Controls.Add(this.dateBD);
            this.panel3.Controls.Add(this.txtMadotgia);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(7, 31);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(388, 430);
            this.panel3.TabIndex = 1;
            // 
            // cbtrangthai
            // 
            this.cbtrangthai.FormattingEnabled = true;
            this.cbtrangthai.Items.AddRange(new object[] {
            "Chưa áp dụng",
            "Đã áp dụng"});
            this.cbtrangthai.Location = new System.Drawing.Point(140, 151);
            this.cbtrangthai.Margin = new System.Windows.Forms.Padding(4);
            this.cbtrangthai.Name = "cbtrangthai";
            this.cbtrangthai.Size = new System.Drawing.Size(240, 33);
            this.cbtrangthai.TabIndex = 7;
            // 
            // dateBD
            // 
            this.dateBD.CustomFormat = "dd/MM/yyyy";
            this.dateBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBD.Location = new System.Drawing.Point(140, 82);
            this.dateBD.Margin = new System.Windows.Forms.Padding(4);
            this.dateBD.Name = "dateBD";
            this.dateBD.Size = new System.Drawing.Size(240, 31);
            this.dateBD.TabIndex = 6;
            this.dateBD.Value = new System.DateTime(2021, 10, 10, 0, 0, 0, 0);
            // 
            // txtMadotgia
            // 
            this.txtMadotgia.Enabled = false;
            this.txtMadotgia.Location = new System.Drawing.Point(140, 14);
            this.txtMadotgia.Margin = new System.Windows.Forms.Padding(4);
            this.txtMadotgia.Name = "txtMadotgia";
            this.txtMadotgia.Size = new System.Drawing.Size(240, 31);
            this.txtMadotgia.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Trạng thái:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày bắt đầu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đợt giá:";
            // 
            // dgvGiaapdung
            // 
            this.dgvGiaapdung.AllowUserToAddRows = false;
            this.dgvGiaapdung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGiaapdung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaapdung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDotgia,
            this.Column3,
            this.Column4});
            this.dgvGiaapdung.Location = new System.Drawing.Point(7, 31);
            this.dgvGiaapdung.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGiaapdung.Name = "dgvGiaapdung";
            this.dgvGiaapdung.RowHeadersWidth = 51;
            this.dgvGiaapdung.RowTemplate.Height = 29;
            this.dgvGiaapdung.Size = new System.Drawing.Size(681, 430);
            this.dgvGiaapdung.TabIndex = 0;
            this.dgvGiaapdung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiaapdung_CellClick);
            // 
            // MaDotgia
            // 
            this.MaDotgia.DataPropertyName = "MaDotgia";
            this.MaDotgia.HeaderText = "Mã";
            this.MaDotgia.MinimumWidth = 6;
            this.MaDotgia.Name = "MaDotgia";
            this.MaDotgia.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NgayBatDauAD";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column3.HeaderText = "Ngày Bắt Đầu";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "TrangThai";
            this.Column4.HeaderText = "Trạng Thái";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Location = new System.Drawing.Point(12, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 121);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvGiaapdung);
            this.groupBox2.Location = new System.Drawing.Point(12, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(702, 470);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách đợt giá";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Location = new System.Drawing.Point(720, 126);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 470);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin đợt";
            // 
            // frmGiaapdung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 602);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmGiaapdung";
            this.Text = "Giá áp dụng";
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaapdung)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSuadotgia;
        private System.Windows.Forms.Button btnThemdotgia;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtMadotgia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvGiaapdung;
        private System.Windows.Forms.ComboBox cbtrangthai;
        private System.Windows.Forms.DateTimePicker dateBD;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDotgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnXemdotgia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}