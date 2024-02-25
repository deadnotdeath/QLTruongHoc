using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTruongHoc
{
    internal class GiaoVienDAO : DBConnect
    {
        public GiaoVienDAO() 
        {
            conn = new SqlConnection(Properties.Settings.Default.gvStr);
            tableName = "GiaoVien";
        }

        public void Them(ConNguoi gv)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("INSERT INTO GiaoVien(Idgv, Tengv, Diachigv, Gioitinhgv, Cmndgv, Ngaysinhgv, Sodienthoaigv, Emailgv) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", gv.ID, gv.HoVaTen, gv.DiaChi, gv.GioiTinh, gv.CMND, gv.NgaySinh, gv.SoDienThoai, gv.Email);
                base.ThucThi(sqlStr);
                MessageBox.Show("them thanh cong");
                Load_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show("them that bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }


        public void Xoa(ConNguoi gv)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("DELETE FROM GiaoVien WHERE Idgv = '{0}'", gv.ID);
                base.ThucThi(sqlStr);
                MessageBox.Show("xoa thanh cong");
                Load_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show("xoa that bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
        public void Sua(ConNguoi gv)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("UPDATE GiaoVien SET Tengv = '{0}', Diachigv = '{1}', Gioitinhgv = '{2}', Cmndgv = '{3}', Ngaysinhgv ='{4}', Sodienthoaigv = '{5}', Emailgv = '{6}' WHERE Idgv = '{7}'", gv.HoVaTen, gv.DiaChi, gv.GioiTinh, gv.CMND, gv.NgaySinh, gv.SoDienThoai, gv.Email, gv.ID);
                base.ThucThi(sqlStr);
                MessageBox.Show("sua thanh cong");
                Load_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show("sua that bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
