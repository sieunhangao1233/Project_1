using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Đồ_Án_1.Data;
using Đồ_Án_1.Dao;
namespace Đồ_Án_1.Bus
{   
    public class CHITIETHOADON_BUS
    {
        ChiTietHoaDon_DAO dal = new ChiTietHoaDon_DAO();
        public List<CHITIET_HOADON> GetList()
        {
            return dal.getall();
        }
        public void Them(CHITIET_HOADON l)
        {
            dal.Them(l);
        }
        public void Sua(CHITIET_HOADON l)
        {
            dal.Sua(l);
        }
        public void Xoa(string ma)
        {
            dal.Xoa(ma);
        }
    }
}
