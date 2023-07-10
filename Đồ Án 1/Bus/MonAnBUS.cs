using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Đồ_Án_1.Dao;
using Đồ_Án_1.Data;
namespace Đồ_Án_1.Bus
{
    public class MonAnBUS
    {
        MonAnDAO monand = new MonAnDAO();
        List<MONAN> monan;
        public List<MONAN> GetList()
        {
            return monand.getall();
        }
        public void Add(MONAN m)
        {
            monand.Add(m);
            monand.SaveChanges();
        }
        public void Delete(MONAN m)
        {
            monand.Delete(m.monanID);
            monand.SaveChanges();
        }
        public void Update(MONAN m)
        {
            monand.Update(m);
            monand.SaveChanges();

        }
    }

}
