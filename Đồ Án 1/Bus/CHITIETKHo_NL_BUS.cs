using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Đồ_Án_1.Data;
using Đồ_Án_1.Dao;
namespace Đồ_Án_1.Bus
{
    public class CHITIETKHo_NL_BUS
    {
        Kho_NguyenLieu_DAO khonl = new Kho_NguyenLieu_DAO();
        List<KHO_NL> kho_nl;
        public List<KHO_NL>GetKHO_NLs(string id)
        {
            kho_nl = khonl.GetKHO_NLs(id);
            return kho_nl;
        }
        public void Add(KHO_NL k)
        {
            khonl.Add(k);
            khonl.SaveChanges();
        }
        public void Delete(KHO_NL kl)
        {
            khonl.Delete(kl.KhoID);
            khonl.SaveChanges();
        }
        public void Updete(KHO_NL k)
        {
            khonl.Update(k);
            khonl.SaveChanges();
        }
    }
}
