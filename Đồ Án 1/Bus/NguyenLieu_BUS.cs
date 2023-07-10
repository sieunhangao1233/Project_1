using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Đồ_Án_1.Dao;
using Đồ_Án_1.Data;
namespace Đồ_Án_1.Bus
{
    public class NguyenLieu_BUS
    {
        NguyenLieu_DAO nld = new NguyenLieu_DAO();
        List<NGUYENLIEU> nguyenlieu;
        public List<NGUYENLIEU> GetNGUYENLIEUs(string nl)
        {
            nguyenlieu = nld.GetNGUYENLIEUs(nl);
            return nguyenlieu;
        }
        public void Add(NGUYENLIEU n)
        {
            nld.Add(n);
            nld.SaveChanges();
        }
        public void Update(NGUYENLIEU n)
        {
            nld.Update(n);
            nld.SaveChanges();
        }
        public void Delete(NGUYENLIEU n)
        {
            nld.Delete(n.nguyenieuID);
            nld.SaveChanges();
        }
    }
}
