using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Đồ_Án_1.Data;
namespace Đồ_Án_1.Dao
{
    public class BAN_DAO
    {
        Entities1 ban = new Entities1();
        public List<BAN> getall()
        {
            return ban.BANs.ToList();
        }
        public void Add(BAN b)
        {
            ban.BANs.Add(b);
        }
        public void SaveChanges()
        {
            ban.SaveChanges();
        }
        public void Update(BAN b)
        {
            BAN g = ban.BANs.Find(b.BanID);
            if (g != null)
            {
                g.LoaiBan = b.LoaiBan;
                g.Tinhtrang = b.Tinhtrang;
                g.SoLuong = b.SoLuong;
            }
        }
        public void Delete(string b)
        {
            BAN bn = ban.BANs.Find(b);
            ban.BANs.Remove(bn);
        }
    }

}
