using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTruongHoc
{
    public partial class UCThongTin : UserControl
    {
        public UCThongTin()
        {
            InitializeComponent();
        }

        internal DBConnect Connect
        {
            get => connect;
            set
            {
                connect = value;
                conn = connect.conn;

                LoadConnect();
            }
        }

        public void Load_Data()
        {
            gvThongTin.DataSource = connect.Load_Data(); /// gvHsinh = name cua data gridview
        }

        private void LoadConnect()
        {
            try
            {
                conn.Open();
                Load_Data();
            } catch (Exception exc)
            {
                MessageBox.Show("UcLoad error :" + exc.Message);
            }
        }

        ConNguoi GetFormValue() => new ConNguoi()
        {
            hoVaTen = txtHoVaTen.Text,
            diaChi = txtDiaChi.Text,
            cmnd = txtCMND.Text,
            ngaySinh = dtpNgaySinh.Value
        };

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (connect is GiaoVienDAO gv)
            {
                gv.Them(GetFormValue());
            } else
            {
                if (connect is HocSinhDAO hs)
                {
                    hs.Them(GetFormValue());
                }
            }

            Load_Data();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (connect is GiaoVienDAO gv)
            {
                gv.Xoa(GetFormValue());
            } else
            {
                if (connect is HocSinhDAO hs)
                {
                    hs.Xoa(GetFormValue());
                }
            }

            Load_Data();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (connect is GiaoVienDAO gv)
            {
                gv.Sua(GetFormValue());
            } else
            {
                if (connect is HocSinhDAO hs)
                {
                    hs.Sua(GetFormValue());
                }
            }

            Load_Data();
        }

        SqlConnection conn;
        private DBConnect connect;
    }
}
