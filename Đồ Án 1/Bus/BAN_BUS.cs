using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Đồ_Án_1.Data;
using Đồ_Án_1.Dao;
namespace Đồ_Án_1.Bus
{
    public class BAN_BUS
    {
        BAN_DAO ban_dao = new BAN_DAO();
        public List<BAN> GetList()
        {
            return ban_dao.getall();
        }
        public void Add(BAN b)
        {
            ban_dao.Add(b);
            ban_dao.SaveChanges();
        }
        public void Delete(string b)
        {
            ban_dao.Delete(b);
            ban_dao.SaveChanges();
        }
        public void Update(BAN b)
        {
            ban_dao.Update(b);
            ban_dao.SaveChanges();

        }
    }
}
