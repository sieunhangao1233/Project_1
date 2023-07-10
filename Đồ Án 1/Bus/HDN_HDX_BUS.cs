using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Đồ_Án_1.Data;
using Đồ_Án_1.Dao;
namespace Đồ_Án_1.Bus
{
    public class HDN_HDX_BUS
    {
        HDN_HDX hdn_hdx = new HDN_HDX();
        public void Add_N(HoaDonNhap n)
        {
            hdn_hdx.Add_HDN(n);
            hdn_hdx.SaveChanger();
        }
        public void Update_N(HoaDonNhap n)
        {
            hdn_hdx.Update_HDN(n);
            hdn_hdx.SaveChanger();
        }
        public void Delete_N(string n)
        {
            hdn_hdx.Delete_HDN(n);
            hdn_hdx.SaveChanger();
        }
        public void Add_X(HoaDonXuat n)
        {
            hdn_hdx.Add_HDX(n);
            hdn_hdx.SaveChanger();
        }
        public void Update_X(HoaDonXuat n)
        {
            hdn_hdx.Update_HDX(n);
            hdn_hdx.SaveChanger();
        }
        public void Delete_X(string x)
        {
            hdn_hdx.Delete_HDX(x);
            hdn_hdx.SaveChanger();
        }
    }
}
