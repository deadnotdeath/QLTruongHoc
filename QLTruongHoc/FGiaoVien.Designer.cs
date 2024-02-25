namespace QLTruongHoc
{
    partial class FGiaoVien
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

        private void InitializeComponent()
        {
            ucThongTin = new UCThongTin();
            SuspendLayout();
            // 
            // ucThongTin
            // 
            ucThongTin.AllowDrop = true;
            ucThongTin.Location = new Point(0, 0);
            ucThongTin.Margin = new Padding(3, 2, 3, 2);
            ucThongTin.Name = "ucThongTin";
            ucThongTin.Size = new Size(824, 458);
            ucThongTin.TabIndex = 0;
            // 
            // FGiaoVien
            // 
            ClientSize = new Size(823, 458);
            Controls.Add(ucThongTin);
            Name = "FGiaoVien";
            Text = "Giáo Viên";
            Load += UcThongTin_Load;
            ResumeLayout(false);
        }

        private UCThongTin ucThongTin;
    }
}
