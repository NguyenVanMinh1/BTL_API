using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.PublicModel
{
    public class ProductModel
    {
        public int SANPHAMID { get; set; }
        public string PRODUCNAME { get; set; }
        public int LOAIID { get; set; }
        public int PRICE { get; set; }
        public string IMAGESANPHAM { get; set; }
        public string TENCHATLIEU { get; set; }
        public DateTime CREATEDATE { get; set; }
        public int NHANHIEUID { get; set; }
        public int SOLUONG { get; set; }
        public string GhiChu { get; set; }
        public string LOAINAME { get; set; }
        public string NHANHIEUNAME { get; set; }
        public int ViewCount { get; set; }


    }
    public class BinhLuanModel
    {
        public int BinhLuanID { get; set; }
        public int CUSTOMERID { get; set; }
        public string BinhLuan { get; set; }
        public string Image { get; set; }
        public int DanhGia { get; set; }
        public int SANPHAMID { get; set; }

    }

}
