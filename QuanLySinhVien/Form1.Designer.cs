namespace QuanLySinhVien
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbMaSV = new System.Windows.Forms.TextBox();
            this.txbTenSV = new System.Windows.Forms.TextBox();
            this.txbLop = new System.Windows.Forms.TextBox();
            this.txbDiem = new System.Windows.Forms.TextBox();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.dtgvSinhVien = new System.Windows.Forms.DataGridView();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddSinhVien = new System.Windows.Forms.Button();
            this.btnEditSinhVien = new System.Windows.Forms.Button();
            this.btnDeleteSinhVien = new System.Windows.Forms.Button();
            this.btnSortSinhVien = new System.Windows.Forms.Button();
            this.txbFindSinhVien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sinh viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lớp:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Điểm:";
            // 
            // txbMaSV
            // 
            this.txbMaSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbMaSV.Location = new System.Drawing.Point(167, 16);
            this.txbMaSV.Multiline = true;
            this.txbMaSV.Name = "txbMaSV";
            this.txbMaSV.Size = new System.Drawing.Size(214, 29);
            this.txbMaSV.TabIndex = 5;
            // 
            // txbTenSV
            // 
            this.txbTenSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbTenSV.Location = new System.Drawing.Point(167, 53);
            this.txbTenSV.Multiline = true;
            this.txbTenSV.Name = "txbTenSV";
            this.txbTenSV.Size = new System.Drawing.Size(214, 29);
            this.txbTenSV.TabIndex = 6;
            // 
            // txbLop
            // 
            this.txbLop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbLop.Location = new System.Drawing.Point(167, 94);
            this.txbLop.Multiline = true;
            this.txbLop.Name = "txbLop";
            this.txbLop.Size = new System.Drawing.Size(214, 29);
            this.txbLop.TabIndex = 7;
            // 
            // txbDiem
            // 
            this.txbDiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDiem.Location = new System.Drawing.Point(167, 229);
            this.txbDiem.Multiline = true;
            this.txbDiem.Name = "txbDiem";
            this.txbDiem.Size = new System.Drawing.Size(214, 29);
            this.txbDiem.TabIndex = 9;
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDiaChi.Location = new System.Drawing.Point(167, 142);
            this.txbDiaChi.Multiline = true;
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(486, 68);
            this.txbDiaChi.TabIndex = 10;
            // 
            // dtgvSinhVien
            // 
            this.dtgvSinhVien.AllowUserToResizeColumns = false;
            this.dtgvSinhVien.AllowUserToResizeRows = false;
            this.dtgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvSinhVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dtgvSinhVien.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.TenSV,
            this.Lop,
            this.DiaChi,
            this.Diem});
            this.dtgvSinhVien.Location = new System.Drawing.Point(12, 349);
            this.dtgvSinhVien.Name = "dtgvSinhVien";
            this.dtgvSinhVien.RowHeadersWidth = 51;
            this.dtgvSinhVien.RowTemplate.Height = 24;
            this.dtgvSinhVien.Size = new System.Drawing.Size(776, 213);
            this.dtgvSinhVien.TabIndex = 0;
            this.dtgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSinhVien_CellClick);
            // 
            // MaSV
            // 
            this.MaSV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.HeaderText = "Mã sinh viên";
            this.MaSV.MinimumWidth = 6;
            this.MaSV.Name = "MaSV";
            // 
            // TenSV
            // 
            this.TenSV.DataPropertyName = "TenSV";
            this.TenSV.HeaderText = "Tên sinh viên";
            this.TenSV.MinimumWidth = 6;
            this.TenSV.Name = "TenSV";
            // 
            // Lop
            // 
            this.Lop.DataPropertyName = "Lop";
            this.Lop.HeaderText = "Lớp";
            this.Lop.MinimumWidth = 6;
            this.Lop.Name = "Lop";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            // 
            // Diem
            // 
            this.Diem.DataPropertyName = "Diem";
            this.Diem.HeaderText = "Điểm";
            this.Diem.MinimumWidth = 6;
            this.Diem.Name = "Diem";
            // 
            // btnAddSinhVien
            // 
            this.btnAddSinhVien.Location = new System.Drawing.Point(167, 286);
            this.btnAddSinhVien.Name = "btnAddSinhVien";
            this.btnAddSinhVien.Size = new System.Drawing.Size(117, 34);
            this.btnAddSinhVien.TabIndex = 11;
            this.btnAddSinhVien.Text = "Thêm";
            this.btnAddSinhVien.UseVisualStyleBackColor = true;
            this.btnAddSinhVien.Click += new System.EventHandler(this.btnAddSinhVien_Click);
            // 
            // btnEditSinhVien
            // 
            this.btnEditSinhVien.Location = new System.Drawing.Point(314, 286);
            this.btnEditSinhVien.Name = "btnEditSinhVien";
            this.btnEditSinhVien.Size = new System.Drawing.Size(117, 34);
            this.btnEditSinhVien.TabIndex = 12;
            this.btnEditSinhVien.Text = "Sửa";
            this.btnEditSinhVien.UseVisualStyleBackColor = true;
            this.btnEditSinhVien.Click += new System.EventHandler(this.btnEditSinhVien_Click);
            // 
            // btnDeleteSinhVien
            // 
            this.btnDeleteSinhVien.Location = new System.Drawing.Point(463, 286);
            this.btnDeleteSinhVien.Name = "btnDeleteSinhVien";
            this.btnDeleteSinhVien.Size = new System.Drawing.Size(117, 34);
            this.btnDeleteSinhVien.TabIndex = 13;
            this.btnDeleteSinhVien.Text = "Xóa";
            this.btnDeleteSinhVien.UseVisualStyleBackColor = true;
            this.btnDeleteSinhVien.Click += new System.EventHandler(this.btnDeleteSinhVien_Click);
            // 
            // btnSortSinhVien
            // 
            this.btnSortSinhVien.Location = new System.Drawing.Point(615, 286);
            this.btnSortSinhVien.Name = "btnSortSinhVien";
            this.btnSortSinhVien.Size = new System.Drawing.Size(117, 34);
            this.btnSortSinhVien.TabIndex = 14;
            this.btnSortSinhVien.Text = "Sắp xếp";
            this.btnSortSinhVien.UseVisualStyleBackColor = true;
            // 
            // txbFindSinhVien
            // 
            this.txbFindSinhVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbFindSinhVien.Location = new System.Drawing.Point(550, 229);
            this.txbFindSinhVien.Multiline = true;
            this.txbFindSinhVien.Name = "txbFindSinhVien";
            this.txbFindSinhVien.Size = new System.Drawing.Size(214, 29);
            this.txbFindSinhVien.TabIndex = 16;
            this.txbFindSinhVien.TextChanged += new System.EventHandler(this.txbFindSinhVien_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(460, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tìm kiếm:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 565);
            this.Controls.Add(this.txbFindSinhVien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSortSinhVien);
            this.Controls.Add(this.btnDeleteSinhVien);
            this.Controls.Add(this.btnEditSinhVien);
            this.Controls.Add(this.btnAddSinhVien);
            this.Controls.Add(this.dtgvSinhVien);
            this.Controls.Add(this.txbDiaChi);
            this.Controls.Add(this.txbDiem);
            this.Controls.Add(this.txbLop);
            this.Controls.Add(this.txbTenSV);
            this.Controls.Add(this.txbMaSV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbMaSV;
        private System.Windows.Forms.TextBox txbTenSV;
        private System.Windows.Forms.TextBox txbLop;
        private System.Windows.Forms.TextBox txbDiem;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.DataGridView dtgvSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem;
        private System.Windows.Forms.Button btnAddSinhVien;
        private System.Windows.Forms.Button btnEditSinhVien;
        private System.Windows.Forms.Button btnDeleteSinhVien;
        private System.Windows.Forms.Button btnSortSinhVien;
        private System.Windows.Forms.TextBox txbFindSinhVien;
        private System.Windows.Forms.Label label6;
    }
}

