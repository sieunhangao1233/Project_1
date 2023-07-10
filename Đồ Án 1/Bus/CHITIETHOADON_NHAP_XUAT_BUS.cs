using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Đồ_Án_1.Dao;
using Đồ_Án_1.Data;
namespace Đồ_Án_1.Bus
{
    public class CHITIETHOADON_NHAP_XUAT_BUS
    {
        CHITIETHOADON_NHAP_XUAT_DAO ctd = new CHITIETHOADON_NHAP_XUAT_DAO();
        public List<CHITIET_HDN> GetList()
        {
            return ctd.getall1();
        }
        public List<CHITIET_HDX> GetList1()
        {
            return ctd.getall();
        }

        public void Add_ctN(CHITIET_HDN n)
        {
            ctd.Add_ctN(n);
        }
        public void Add_ctX(CHITIET_HDX x)
        {
            ctd.Add_ctX(x);
        }
        public void Delete_ctN(string n)
        {
            ctd.Delete_ctN(n);
        }
        public void Delete_ctX(string x)
        {
            ctd.Delete_ctX(x);
        }
        public void Update_ctN(CHITIET_HDN n)
        {
            ctd.Update_ctN(n);
        }
        public void Update_ctX(CHITIET_HDX x)
        {
            ctd.Update_ctX(x);
        }
    }
}
