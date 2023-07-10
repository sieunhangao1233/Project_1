using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Đồ_Án_1.Data;
namespace Đồ_Án_1.Dao
{
    public class HDN_HDX
    {
        Entities1 hdn_hdx = new Entities1();
        public void Add_HDN(HoaDonNhap n)
        {
            hdn_hdx.HoaDonNhaps.Add(n);
        }
        public void Delete_HDN(string n)
        {
            HoaDonNhap hdn = hdn_hdx.HoaDonNhaps.Find(n);
            hdn_hdx.HoaDonNhaps.Remove(hdn);
        }
        public void Update_HDN(HoaDonNhap n)
        {
            HoaDonNhap hdn = hdn_hdx.HoaDonNhaps.Find(n.HoaDonNhapID);
            hdn.Ngaynhap = n.Ngaynhap;
            hdn.Ngaynhan = n.Ngaynhan;
            hdn.NhanVienID = n.NhanVienID;
            hdn.KhoID = n.KhoID;
            hdn.Trangthai = n.Trangthai;
            hdn.Tongtien = n.Tongtien;
        }
        public void Add_HDX(HoaDonXuat n)
        {
            hdn_hdx.HoaDonXuats.Add(n);
        }
        public void Delete_HDX(string x)
        {
            HoaDonXuat hdn = hdn_hdx.HoaDonXuats.Find(x);
            hdn_hdx.HoaDonXuats.Remove(hdn);
        }
        public void Update_HDX(HoaDonXuat n)
        {
            HoaDonXuat hdn = hdn_hdx.HoaDonXuats.Find(n.HoaDonXuatID);
            hdn.Ngayxuat = n.Ngayxuat;
            hdn.Ngaynhan = n.Ngaynhan;
            hdn.NhanVien_Xuat = n.NhanVien_Xuat;
            hdn.NhanVien_Nhan = n.NhanVien_Nhan;
            hdn.KhoID = n.KhoID;
        }
        public void SaveChanger()
        {
            hdn_hdx.SaveChanges();
        }
    }
}
