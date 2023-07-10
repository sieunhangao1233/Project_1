using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Đồ_Án_1.Data;
namespace Đồ_Án_1.Dao
{
    public class HOADON_DAO
    {
        Entities1 hoadon = new Entities1();
        public List<HOADON> getall()
        {
            return hoadon.HOADONs.ToList();
        }
        public void Them(HOADON l)
        {
            hoadon.HOADONs.Add(l);
            hoadon.SaveChanges();
        }
        public void Sua(HOADON l)
        {
            HOADON g = hoadon.HOADONs.Find(l.HoaDonID);
            if (g != null)
            {
                g.HoaDonID = l.HoaDonID;
                g.NhanVienID = l.NhanVienID;
                g.BanID = l.BanID;
                g.TrangThai = l.TrangThai;
                g.Giamgia = l.Giamgia;
                g.Tongtien = l.Tongtien;
                g.NgayTao = l.NgayTao;
            }
            hoadon.SaveChanges();
        }

    }
}