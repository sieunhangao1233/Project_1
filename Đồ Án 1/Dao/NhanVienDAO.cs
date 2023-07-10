using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Đồ_Án_1.Data;
namespace Đồ_Án_1.Dao
{
    public class NhanVienDAO
    {
        Entities1 nv = new Entities1();
        public List<NHANVIEN> getall()
        {
            return nv.NHANVIENs.ToList();
        }
        public void Add(NHANVIEN n)
        {
            nv.NHANVIENs.Add(n);
        }
        public void Updete(NHANVIEN n)
        {
            NHANVIEN ud = nv.NHANVIENs.Find(n.NhanVienID);
            ud.Hoten = n.Hoten;
            ud.Gioitinh = n.Gioitinh;
            ud.Chucvu = n.Chucvu;
            ud.Quequan = n.Quequan;
            ud.Sdt = n.Sdt;
            ud.CCCD = n.CCCD;
            ud.NgayLam = n.NgayLam;
        }
        public void SaveChanges()
        {
            nv.SaveChanges();
        }
        public void Detele(string l)
        {
            NHANVIEN de = nv.NHANVIENs.Find(l);
            nv.NHANVIENs.Remove(de);
        }

    }
}
