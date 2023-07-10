using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Đồ_Án_1.Data;
namespace Đồ_Án_1.Dao
{
    public class UserDao
    {
        Entities1 dk = new Entities1();
        public List<DANGNHAP>GetDANGNHAPs(string taikhoan)
        {
            return dk.DANGNHAPs.Where(u => u.TaiKhoan == taikhoan).ToList();
        }
        public void Add(DANGNHAP dn)
        {
            dk.DANGNHAPs.Add(dn);
            dk.SaveChanges();
        }
    }
}
