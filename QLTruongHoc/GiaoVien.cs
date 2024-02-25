using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTruongHoc
{
    internal class GiaoVien: ConNguoi
    {
        public GiaoVien(string iD, string hoVaTen, string diaChi, string gioiTinh, string cmnd, DateTime ngaySinh, string soDienThoai, string email) : base()
        {
            this.iD = iD;
            this.hoVaTen = hoVaTen;
            this.diaChi = diaChi;
            this.gioiTinh = gioiTinh;
            this.cmnd = cmnd;
            this.ngaySinh = ngaySinh;
            this.soDienThoai = soDienThoai;
            this.email = email;
        }
    }
}
