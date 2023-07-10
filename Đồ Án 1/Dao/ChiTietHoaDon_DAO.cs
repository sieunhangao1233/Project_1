using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Đồ_Án_1.Data;
namespace Đồ_Án_1.Dao
{
    public class ChiTietHoaDon_DAO
    {
        Entities1 databa = new Entities1();
        public List<CHITIET_HOADON> getall()
        {
            return databa.CHITIET_HOADON.ToList();
        }
        public void Them(CHITIET_HOADON l)
        {

            databa.CHITIET_HOADON.Add(l);
            databa.SaveChanges();
        }
        public void Sua(CHITIET_HOADON l)
        {
            CHITIET_HOADON g = databa.CHITIET_HOADON.Find(l.HoaDonID);
            if (g != null)
            {
                g.HoaDonID = l.HoaDonID;
                g.monanID = l.monanID;
                g.Dongia = l.Dongia;


            }
            databa.SaveChanges();
        }
        public void Xoa(string ma)
        {

            CHITIET_HOADON g = databa.CHITIET_HOADON.Find(ma);
            databa.CHITIET_HOADON.Remove(g);
            databa.SaveChanges();
        }
        public List<CHITIET_HOADON> Timkiem(string ma)
        {

            return databa.CHITIET_HOADON.Where(hd => hd.HoaDonID.Contains(ma)).ToList();

        }
    }
}
