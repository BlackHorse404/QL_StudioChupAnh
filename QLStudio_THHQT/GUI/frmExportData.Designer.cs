
namespace QLStudio_THHQT.GUI
{
    partial class frmExportData
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_NhapData = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Table = new System.Windows.Forms.ComboBox();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 100);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(819, 100);
            this.label2.TabIndex = 0;
            this.label2.Text = "NHẬP, XUẤT DỮ LIỆU";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.btn_NhapData);
            this.panel2.Controls.Add(this.btn_export);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 327);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(819, 100);
            this.panel2.TabIndex = 1;
            // 
            // btn_NhapData
            // 
            this.btn_NhapData.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_NhapData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_NhapData.Location = new System.Drawing.Point(496, 24);
            this.btn_NhapData.Name = "btn_NhapData";
            this.btn_NhapData.Size = new System.Drawing.Size(234, 64);
            this.btn_NhapData.TabIndex = 1;
            this.btn_NhapData.Text = "NHẬP DỮ LIỆU";
            this.btn_NhapData.UseVisualStyleBackColor = false;
            this.btn_NhapData.Click += new System.EventHandler(this.btn_NhapData_Click);
            // 
            // btn_export
            // 
            this.btn_export.BackColor = System.Drawing.SystemColors.Info;
            this.btn_export.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_export.Location = new System.Drawing.Point(85, 24);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(234, 64);
            this.btn_export.TabIndex = 0;
            this.btn_export.Text = "XUẤT DỮ LIỆU";
            this.btn_export.UseVisualStyleBackColor = false;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cb_Table);
            this.panel3.Controls.Add(this.txt_path);
            this.panel3.Controls.Add(this.btn_browse);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(819, 227);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(169, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Đối Tượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(174, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // cb_Table
            // 
            this.cb_Table.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cb_Table.FormattingEnabled = true;
            this.cb_Table.Location = new System.Drawing.Point(300, 116);
            this.cb_Table.Name = "cb_Table";
            this.cb_Table.Size = new System.Drawing.Size(296, 33);
            this.cb_Table.TabIndex = 2;
            // 
            // txt_path
            // 
            this.txt_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txt_path.Location = new System.Drawing.Point(174, 27);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(422, 32);
            this.txt_path.TabIndex = 1;
            // 
            // btn_browse
            // 
            this.btn_browse.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_browse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_browse.Location = new System.Drawing.Point(617, 24);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(100, 38);
            this.btn_browse.TabIndex = 0;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = false;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // frmExportData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 427);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmExportData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmExportData";
            this.Load += new System.EventHandler(this.frmExportData_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_NhapData;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.ComboBox cb_Table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}