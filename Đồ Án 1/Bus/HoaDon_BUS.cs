using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Đồ_Án_1.Dao;
using Đồ_Án_1.Data;
namespace Đồ_Án_1.Bus
{
    public class HoaDon_BUS
    {
        HOADON_DAO dal = new HOADON_DAO();
        List<HOADON> l;
        public List<HOADON> GetList()
        {
            return dal.getall();
        }

        public void Them(HOADON l)
        {
            dal.Them(l);
        }
        public void Sua(HOADON l)
        {
            dal.Sua(l);
        }
    }
}
