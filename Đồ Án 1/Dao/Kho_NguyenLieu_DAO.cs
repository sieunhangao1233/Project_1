using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Đồ_Án_1.Data;
namespace Đồ_Án_1.Dao
{
    public class Kho_NguyenLieu_DAO
    {
        Entities1 k = new Entities1();
        public List<KHO_NL>GetKHO_NLs(string id)
        {
            return k.KHO_NL.Where(s => s.KhoID == id).ToList();
        }
        public void Add(KHO_NL kl)
        {
            k.KHO_NL.Add(kl);
        }
        public void Update(KHO_NL kl)
        {
            KHO_NL up = k.KHO_NL.Find(kl.KhoID);
            up.nguyenlieuID = kl.nguyenlieuID;
            up.SoLuong = kl.SoLuong;
            up.GhiChu = kl.GhiChu;
        }
        public void Delete(string kl)
        {
            KHO_NL de = k.KHO_NL.First<KHO_NL>();
            k.KHO_NL.Remove(de);
        }
        public void SaveChanges()
        {
            k.SaveChanges();
        }
    }
}
