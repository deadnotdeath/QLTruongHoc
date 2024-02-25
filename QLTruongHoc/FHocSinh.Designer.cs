namespace QLTruongHoc
{
    partial class FHocSinh
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            ucThongTin.Location = new Point(0, -1);
            ucThongTin.Margin = new Padding(3, 2, 3, 2);
            ucThongTin.Name = "ucThongTin";
            ucThongTin.Size = new Size(825, 440);
            ucThongTin.TabIndex = 0;
            ucThongTin.Load += ucThongTin_Load;
            // 
            // FHocSinh
            // 
            ClientSize = new Size(821, 446);
            Controls.Add(ucThongTin);
            Name = "FHocSinh";
            ResumeLayout(false);
        }

        private UCThongTin ucThongTin;
    }
}
