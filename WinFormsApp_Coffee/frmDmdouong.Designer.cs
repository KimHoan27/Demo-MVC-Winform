
namespace WinFormsApp_Coffee
{
    partial class frmDmdouong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDmdouong));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.btnXoadm = new System.Windows.Forms.Button();
            this.btnSuadm = new System.Windows.Forms.Button();
            this.btnThemdm = new System.Windows.Forms.Button();
            this.dgvDmdouong = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMadanhmuc = new System.Windows.Forms.TextBox();
            this.txtTendanhmuc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDmdouong)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLammoi);
            this.panel1.Controls.Add(this.btnXoadm);
            this.panel1.Controls.Add(this.btnSuadm);
            this.panel1.Controls.Add(this.btnThemdm);
            this.panel1.Location = new System.Drawing.Point(7, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 88);
            this.panel1.TabIndex = 0;
            // 
            // btnLammoi
            // 
            this.btnLammoi.Location = new System.Drawing.Point(496, 5);
            this.btnLammoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(154, 79);
            this.btnLammoi.TabIndex = 3;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnXoadm
            // 
            this.btnXoadm.Location = new System.Drawing.Point(332, 5);
            this.btnXoadm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoadm.Name = "btnXoadm";
            this.btnXoadm.Size = new System.Drawing.Size(156, 79);
            this.btnXoadm.TabIndex = 2;
            this.btnXoadm.Text = "Xóa danh mục";
            this.btnXoadm.UseVisualStyleBackColor = true;
            this.btnXoadm.Click += new System.EventHandler(this.btnXoadm_Click);
            // 
            // btnSuadm
            // 
            this.btnSuadm.Location = new System.Drawing.Point(169, 5);
            this.btnSuadm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSuadm.Name = "btnSuadm";
            this.btnSuadm.Size = new System.Drawing.Size(156, 79);
            this.btnSuadm.TabIndex = 1;
            this.btnSuadm.Text = "Sửa danh mục";
            this.btnSuadm.UseVisualStyleBackColor = true;
            this.btnSuadm.Click += new System.EventHandler(this.btnSuadm_Click);
            // 
            // btnThemdm
            // 
            this.btnThemdm.Location = new System.Drawing.Point(5, 5);
            this.btnThemdm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemdm.Name = "btnThemdm";
            this.btnThemdm.Size = new System.Drawing.Size(156, 79);
            this.btnThemdm.TabIndex = 0;
            this.btnThemdm.Text = "Thêm danh mục";
            this.btnThemdm.UseVisualStyleBackColor = true;
            this.btnThemdm.Click += new System.EventHandler(this.btnThemdm_Click);
            // 
            // dgvDmdouong
            // 
            this.dgvDmdouong.AllowUserToAddRows = false;
            this.dgvDmdouong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDmdouong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDmdouong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvDmdouong.Location = new System.Drawing.Point(7, 31);
            this.dgvDmdouong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDmdouong.Name = "dgvDmdouong";
            this.dgvDmdouong.RowHeadersWidth = 51;
            this.dgvDmdouong.RowTemplate.Height = 29;
            this.dgvDmdouong.Size = new System.Drawing.Size(663, 349);
            this.dgvDmdouong.TabIndex = 0;
            this.dgvDmdouong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDmdouong_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaDanhMuc";
            this.Column1.HeaderText = "Mã danh mục";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "TenDanhMuc";
            this.Column2.HeaderText = "Tên danh mục";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtMadanhmuc);
            this.panel3.Controls.Add(this.txtTendanhmuc);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(7, 31);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(422, 349);
            this.panel3.TabIndex = 2;
            // 
            // txtMadanhmuc
            // 
            this.txtMadanhmuc.Enabled = false;
            this.txtMadanhmuc.Location = new System.Drawing.Point(139, 6);
            this.txtMadanhmuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMadanhmuc.Name = "txtMadanhmuc";
            this.txtMadanhmuc.Size = new System.Drawing.Size(279, 31);
            this.txtMadanhmuc.TabIndex = 4;
            // 
            // txtTendanhmuc
            // 
            this.txtTendanhmuc.Location = new System.Drawing.Point(139, 72);
            this.txtTendanhmuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTendanhmuc.Name = "txtTendanhmuc";
            this.txtTendanhmuc.Size = new System.Drawing.Size(279, 31);
            this.txtTendanhmuc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên danh mục:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã danh mục:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 150);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDmdouong);
            this.groupBox2.Location = new System.Drawing.Point(12, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(677, 387);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách danh mục";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Location = new System.Drawing.Point(699, 155);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(436, 387);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin danh mục";
            // 
            // frmDmdouong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 554);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmDmdouong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý danh mục đồ uống";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDmdouong)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoadm;
        private System.Windows.Forms.Button btnSuadm;
        private System.Windows.Forms.Button btnThemdm;
        private System.Windows.Forms.DataGridView dgvDmdouong;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTendanhmuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMadanhmuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}