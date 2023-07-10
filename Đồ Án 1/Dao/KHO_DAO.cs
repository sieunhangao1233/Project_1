using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Đồ_Án_1.Data;
namespace Đồ_Án_1.Dao
{
    public class KHO_DAO
    {
        Entities1 kho = new Entities1();
        public List<KHO> GetKHOs(string ID)
        {
            return kho.KHOes.Where(s => s.KhoID == ID).ToList();
        }
        public void Add(KHO k)
        {
            kho.KHOes.Add(k);
        }
        public void Update(KHO k)
        {
            KHO ud = kho.KHOes.Find(k.KhoID);
            ud.TenKho = k.TenKho;
            ud.NhanVienID_QL = k.NhanVienID_QL;
            ud.Trangthai = k.Trangthai;
        }
        public void Delete(string k)
        {
            KHO de = kho.KHOes.First<KHO>();
            kho.KHOes.Remove(de);
        }
        public void SaveChanges()
        {
            kho.SaveChanges();
        }
    }
}
