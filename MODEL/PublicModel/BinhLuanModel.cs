using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.PublicModel
{
    public class BinhLuanModel
    {
       public int  BinhLuanID { get; set; }
        public int CUSTOMERID { get; set; }
        public string BinhLuan { get; set; }
        public string Image { get; set; }
        public int DanhGia { get; set; }
        public int SANPHAMID { get; set; }

       }
}
