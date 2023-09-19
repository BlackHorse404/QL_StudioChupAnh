
namespace QLStudio_THHQT.GUI
{
    partial class SaoLuu_PhucHoi
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
            this.btn_SaoLuu = new System.Windows.Forms.Button();
            this.btn_PhucHoiCSDL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_SaoLuu
            // 
            this.btn_SaoLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btn_SaoLuu.Location = new System.Drawing.Point(149, 39);
            this.btn_SaoLuu.Name = "btn_SaoLuu";
            this.btn_SaoLuu.Size = new System.Drawing.Size(159, 73);
            this.btn_SaoLuu.TabIndex = 0;
            this.btn_SaoLuu.Text = "Sao Lưu";
            this.btn_SaoLuu.UseVisualStyleBackColor = true;
            this.btn_SaoLuu.Click += new System.EventHandler(this.btn_SaoLuu_Click);
            // 
            // btn_PhucHoiCSDL
            // 
            this.btn_PhucHoiCSDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btn_PhucHoiCSDL.Location = new System.Drawing.Point(149, 165);
            this.btn_PhucHoiCSDL.Name = "btn_PhucHoiCSDL";
            this.btn_PhucHoiCSDL.Size = new System.Drawing.Size(159, 73);
            this.btn_PhucHoiCSDL.TabIndex = 1;
            this.btn_PhucHoiCSDL.Text = "Phục Hồi";
            this.btn_PhucHoiCSDL.UseVisualStyleBackColor = true;
            this.btn_PhucHoiCSDL.Click += new System.EventHandler(this.btn_PhucHoiCSDL_Click);
            // 
            // SaoLuu_PhucHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 304);
            this.Controls.Add(this.btn_PhucHoiCSDL);
            this.Controls.Add(this.btn_SaoLuu);
            this.Name = "SaoLuu_PhucHoi";
            this.Text = "SaoLuu_PhucHoi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_SaoLuu;
        private System.Windows.Forms.Button btn_PhucHoiCSDL;
    }
}