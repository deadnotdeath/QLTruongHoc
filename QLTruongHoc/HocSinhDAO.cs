using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTruongHoc
{
    internal class HocSinhDAO : DBConnect
    {
        public HocSinhDAO()
        { 
            conn = new SqlConnection(Properties.Settings.Default.connStr);
            tableName = "HocSinh";
        }

        public void Them(ConNguoi hs)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("INSERT INTO HocSinh(Id, Ten, Diachi, Gioitinh, Cmnd, Ngaysinh, Sodienthoai, Email) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')",hs.ID, hs.HoVaTen, hs.DiaChi, hs.GioiTinh, hs.CMND, hs.NgaySinh, hs.SoDienThoai, hs.Email);
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

        public void Xoa(ConNguoi hs)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("DELETE FROM HocSinh WHERE Id = '{0}'", hs.ID);
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
        public void Sua(ConNguoi hs)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("UPDATE HocSinh SET Ten = '{0}', Diachi = '{1}', Gioitinh = '{2}', Cmnd = '{3}', Ngaysinh ='{4}', Sodienthoai = '{5}', Email = '{6}' WHERE Id = '{7}'", hs.HoVaTen, hs.DiaChi, hs.GioiTinh, hs.CMND, hs.NgaySinh, hs.SoDienThoai, hs.Email, hs.ID);
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
