using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTruongHoc
{
    internal class ConNguoi
    {
        public string iD = "DEFAULT";
        public string hoVaTen = "DEFAULT";
        public string diaChi = "DEFAULT";
        public string gioiTinh = "DEFAULT";
        public string cmnd = "DEFAULT";
        public DateTime ngaySinh;
        public string soDienThoai = "DEFAULT";
        public string email = "DEFAULT";
        public ConNguoi()
        {

        }
        public string ID
        {
            get { return iD; }
            set { iD = value; }
        }
        public string HoVaTen
        {
            get { return hoVaTen; }
            set { hoVaTen = value; }
        }

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        public string CMND
        {
            get { return cmnd; }
            set { cmnd = value; }
        }

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        public string SoDienThoai
        {
            get { return soDienThoai; }
            set { soDienThoai = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
