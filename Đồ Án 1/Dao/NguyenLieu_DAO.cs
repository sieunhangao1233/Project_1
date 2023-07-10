using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Đồ_Án_1.Data;
namespace Đồ_Án_1.Dao
{
    public class NguyenLieu_DAO
    {
        Entities1 nguyenL = new Entities1();
        public List<NGUYENLIEU> GetNGUYENLIEUs(string nl)
        {
            return nguyenL.NGUYENLIEUx.Where(s => s.nguyenieuID == nl).ToList();
        }
        public void Add(NGUYENLIEU n)
        {
            nguyenL.NGUYENLIEUx.Add(n);
        }
        public void Update(NGUYENLIEU n)
        {
            NGUYENLIEU nl = nguyenL.NGUYENLIEUx.Find(n.nguyenieuID);
            nl.tenNL = n.tenNL;
            nl.DonGia = n.DonGia;
            nl.LoaiNL = n.LoaiNL;
        }
        public void Delete(string n)
        {
            NGUYENLIEU nl = nguyenL.NGUYENLIEUx.First<NGUYENLIEU>();
            nguyenL.NGUYENLIEUx.Remove(nl);
        }
        public void SaveChanges()
        {
            nguyenL.SaveChanges();
        }
    }
}
