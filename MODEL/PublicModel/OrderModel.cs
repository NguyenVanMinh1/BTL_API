using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.PublicModel
{
    public class OrderModel
    {
        public KhachHangModel khach { get; set; }
        public List<ChiTietDonHangModel> listchitiet { get; set; }
    }
    public class KhachHangModel
    {
        public int? CUSTOMERID { get; set; }
        public string CUSTOMERNAME { get; set; }
        public string CUSTOMERPHONE { get; set; }
        public string CUSTOMERADDRESS { get; set; }
        public string CUSTOMEREMAIL { get; set; }
        public int ORDERSTATUSID { get; set; }

    }
    public class ChiTietDonHangModel
    {
        public int? SANPHAMID { get; set; }
     
        public int QUANTITY { get; set; }
        public int PRICE { get; set; }
       

    }
}
