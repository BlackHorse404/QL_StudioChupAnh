
namespace QLStudio_THHQT.GUI
{
    partial class frmRegister
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_retypePassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkBox_ChangePassFirstLogin = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd_NhanVien = new System.Windows.Forms.RadioButton();
            this.rd_KeToan = new System.Windows.Forms.RadioButton();
            this.rd_QuanTri = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 72);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(795, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "TẠO TÀI KHOẢN NHÂN VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 494);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 77);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Create, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_cancel, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(795, 77);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_Create
            // 
            this.btn_Create.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_Create.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btn_Create.Location = new System.Drawing.Point(74, 3);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(280, 71);
            this.btn_Create.TabIndex = 0;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = false;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cancel.Location = new System.Drawing.Point(440, 3);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(280, 71);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(795, 422);
            this.panel3.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(795, 422);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.txt_username, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.txt_password, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.txt_retypePassword, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.chkBox_ChangePassFirstLogin, 0, 7);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(23, 23);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 8;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(371, 376);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // txt_username
            // 
            this.txt_username.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_username.Location = new System.Drawing.Point(3, 55);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(338, 30);
            this.txt_username.TabIndex = 1;
            this.txt_username.Leave += new System.EventHandler(this.txt_username_Leave);
            // 
            // txt_password
            // 
            this.txt_password.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_password.Location = new System.Drawing.Point(3, 149);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(338, 30);
            this.txt_password.TabIndex = 3;
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.Leave += new System.EventHandler(this.txt_password_Leave);
            // 
            // txt_retypePassword
            // 
            this.txt_retypePassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_retypePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_retypePassword.Location = new System.Drawing.Point(3, 243);
            this.txt_retypePassword.Name = "txt_retypePassword";
            this.txt_retypePassword.Size = new System.Drawing.Size(338, 30);
            this.txt_retypePassword.TabIndex = 5;
            this.txt_retypePassword.UseSystemPasswordChar = true;
            this.txt_retypePassword.Leave += new System.EventHandler(this.txt_retypePassword_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(3, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(365, 47);
            this.label5.TabIndex = 7;
            this.label5.Text = "More";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(3, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(365, 47);
            this.label4.TabIndex = 4;
            this.label4.Text = "Retype Password";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(3, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(365, 47);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 47);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // chkBox_ChangePassFirstLogin
            // 
            this.chkBox_ChangePassFirstLogin.AutoSize = true;
            this.chkBox_ChangePassFirstLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkBox_ChangePassFirstLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkBox_ChangePassFirstLogin.Location = new System.Drawing.Point(3, 332);
            this.chkBox_ChangePassFirstLogin.Name = "chkBox_ChangePassFirstLogin";
            this.chkBox_ChangePassFirstLogin.Size = new System.Drawing.Size(365, 41);
            this.chkBox_ChangePassFirstLogin.TabIndex = 6;
            this.chkBox_ChangePassFirstLogin.Text = "Đổi Mật Khẩu Lần Đầu Đăng Nhập ";
            this.chkBox_ChangePassFirstLogin.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd_NhanVien);
            this.groupBox1.Controls.Add(this.rd_KeToan);
            this.groupBox1.Controls.Add(this.rd_QuanTri);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(400, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 376);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phân Quyền Cho Tài Khoản";
            // 
            // rd_NhanVien
            // 
            this.rd_NhanVien.AutoSize = true;
            this.rd_NhanVien.Checked = true;
            this.rd_NhanVien.Location = new System.Drawing.Point(70, 244);
            this.rd_NhanVien.Name = "rd_NhanVien";
            this.rd_NhanVien.Size = new System.Drawing.Size(230, 29);
            this.rd_NhanVien.TabIndex = 2;
            this.rd_NhanVien.TabStop = true;
            this.rd_NhanVien.Text = "Quyền Hạn Nhân Viên";
            this.rd_NhanVien.UseVisualStyleBackColor = true;
            // 
            // rd_KeToan
            // 
            this.rd_KeToan.AutoSize = true;
            this.rd_KeToan.Location = new System.Drawing.Point(70, 167);
            this.rd_KeToan.Name = "rd_KeToan";
            this.rd_KeToan.Size = new System.Drawing.Size(214, 29);
            this.rd_KeToan.TabIndex = 1;
            this.rd_KeToan.TabStop = true;
            this.rd_KeToan.Text = "Quyền Hạn Kế Toán";
            this.rd_KeToan.UseVisualStyleBackColor = true;
            // 
            // rd_QuanTri
            // 
            this.rd_QuanTri.AutoSize = true;
            this.rd_QuanTri.Location = new System.Drawing.Point(70, 94);
            this.rd_QuanTri.Name = "rd_QuanTri";
            this.rd_QuanTri.Size = new System.Drawing.Size(215, 29);
            this.rd_QuanTri.TabIndex = 0;
            this.rd_QuanTri.TabStop = true;
            this.rd_QuanTri.Text = "Quyền Hạn Quản Trị";
            this.rd_QuanTri.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(795, 571);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo Tài Khoản";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_retypePassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkBox_ChangePassFirstLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rd_NhanVien;
        private System.Windows.Forms.RadioButton rd_KeToan;
        private System.Windows.Forms.RadioButton rd_QuanTri;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}