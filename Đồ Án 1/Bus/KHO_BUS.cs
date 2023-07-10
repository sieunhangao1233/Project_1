using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Đồ_Án_1.Data;
using Đồ_Án_1.Dao;
namespace Đồ_Án_1.Bus
{
    public class KHO_BUS
    {
        KHO_DAO kho = new KHO_DAO();
        List<KHO> Kho;
        public List<KHO>GetKHOs(string kID)
        {
            Kho = kho.GetKHOs(kID);
            return Kho;
        }
        public void Add(KHO k)
        {
            kho.Add(k);
            kho.SaveChanges();
        }
        public void Delete(KHO k)
        {
            kho.Delete(k.KhoID);
            kho.SaveChanges();
        }
        public void Update(KHO k)
        {
            kho.Update(k);
            kho.SaveChanges();
        }
    }
}
