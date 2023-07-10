using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Đồ_Án_1.Data;
namespace Đồ_Án_1.Dao
{
    public class CHITIETHOADON_NHAP_XUAT_DAO
    {
        Entities1 nx = new Entities1();
        public List<CHITIET_HDX> getall()
        {
            return nx.CHITIET_HDX.ToList();
        }
        public List<CHITIET_HDN> getall1()
        {
            return nx.CHITIET_HDN.ToList();
        }
        public void Add_ctN(CHITIET_HDN n)
        {
            nx.CHITIET_HDN.Add(n);
            nx.SaveChanges();
        }
        public void Add_ctX(CHITIET_HDX x)
        {
            nx.CHITIET_HDX.Add(x);
            nx.SaveChanges();
        }
        public void Update_ctN(CHITIET_HDN n)
        {
            CHITIET_HDN ctn = nx.CHITIET_HDN.Find(n.HoaDonNhapID);
            ctn.nguyenlieuID = n.nguyenlieuID;
            ctn.Soluong = n.Soluong;
            ctn.DonGia = n.DonGia;
            nx.SaveChanges();
        }
        public void Update_ctX(CHITIET_HDX x)
        {
            CHITIET_HDX ctx = nx.CHITIET_HDX.Find(x.HoaDonXuatID);
            ctx.nguyenlieuID = x.nguyenlieuID;
            ctx.SoLuong = x.SoLuong;
            ctx.Dongia = x.Dongia;
            nx.SaveChanges();
        }
        public void Delete_ctN(string n)
        {
            CHITIET_HDN ctn = nx.CHITIET_HDN.Find(n);
            nx.CHITIET_HDN.Remove(ctn);
            nx.SaveChanges();
        }
        public void Delete_ctX(string x)
        {
            CHITIET_HDX ctn = nx.CHITIET_HDX.Find(x);
            nx.CHITIET_HDX.Remove(ctn);
        }
    }
}
