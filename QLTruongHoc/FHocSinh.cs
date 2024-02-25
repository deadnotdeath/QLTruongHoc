using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLTruongHoc
{
    public partial class FHocSinh : Form
    {
        public FHocSinh()
        {
            InitializeComponent();
        }
      
        private void ucThongTin_Load(object sender, EventArgs e)
        {
            ucThongTin.Connect = new HocSinhDAO();
        }
    }
}
