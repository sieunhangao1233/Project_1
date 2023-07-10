using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Đồ_Án_1.Data;

namespace Đồ_Án_1.Dao
{
    public class MonAnDAO
    {
        Entities1 monan = new Entities1();
        public List<MONAN> getall()
        {
            return monan.MONANs.ToList();
        }
        public void Add(MONAN m)
        {
            monan.MONANs.Add(m);
        }
        public void Update(MONAN m)
        {
            MONAN ud = monan.MONANs.Find(m.monanID);
            ud.monanID = m.monanID;
            ud.TenMon = m.TenMon;
            ud.LoaiMon = m.LoaiMon;
            ud.TrangThai = m.TrangThai;
            ud.NhanVienID = m.NhanVienID;
            ud.Ngaytao = m.Ngaytao;
            ud.DonGia = m.DonGia;
        }
        public void SaveChanges()
        {
            monan.SaveChanges();
        }
        public void Delete(string m)
        {
            MONAN de = monan.MONANs.First<MONAN>();
            monan.MONANs.Remove(de);
        }

    }
}
