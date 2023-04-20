namespace Lan
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
            this.txtManv = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSapxep = new System.Windows.Forms.Button();
            this.btnHienthi = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lương";
            // 
            // txtManv
            // 
            this.txtManv.Location = new System.Drawing.Point(260, 37);
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(100, 22);
            this.txtManv.TabIndex = 3;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(260, 89);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(100, 22);
            this.txtHoten.TabIndex = 4;
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(260, 154);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(100, 22);
            this.txtLuong.TabIndex = 5;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(595, 31);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 41);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(595, 88);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 36);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(595, 144);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 36);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSapxep
            // 
            this.btnSapxep.Location = new System.Drawing.Point(784, 37);
            this.btnSapxep.Name = "btnSapxep";
            this.btnSapxep.Size = new System.Drawing.Size(75, 35);
            this.btnSapxep.TabIndex = 9;
            this.btnSapxep.Text = "Sắp xếp";
            this.btnSapxep.UseVisualStyleBackColor = true;
            this.btnSapxep.Click += new System.EventHandler(this.btnSapxep_Click);
            // 
            // btnHienthi
            // 
            this.btnHienthi.Location = new System.Drawing.Point(784, 108);
            this.btnHienthi.Name = "btnHienthi";
            this.btnHienthi.Size = new System.Drawing.Size(75, 63);
            this.btnHienthi.TabIndex = 10;
            this.btnHienthi.Text = "Hiển thị";
            this.btnHienthi.UseVisualStyleBackColor = true;
            this.btnHienthi.Click += new System.EventHandler(this.btnHienthi_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(63, 255);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(743, 204);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 521);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnHienthi);
            this.Controls.Add(this.btnSapxep);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.txtManv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtManv;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSapxep;
        private System.Windows.Forms.Button btnHienthi;
        private System.Windows.Forms.ListView listView1;
    }
}

