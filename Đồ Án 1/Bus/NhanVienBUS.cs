using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Đồ_Án_1.Dao;
using Đồ_Án_1.Data;
namespace Đồ_Án_1.Bus
{
    public class NhanVienBUS
    {
        NhanVienDAO nvd = new NhanVienDAO();
        List<NHANVIEN> nhanvien;
        public List<NHANVIEN> GetList()
        {
            return nvd.getall();
        }
        public void Add(NHANVIEN n)
        {
            nvd.Add(n);
            nvd.SaveChanges();
        }
        public void Detele(string l)
        {
            nvd.Detele(l);
            nvd.SaveChanges();
        }
        public void Update(NHANVIEN n)
        {
            nvd.Updete(n);
            nvd.SaveChanges();
        }
    }
}
