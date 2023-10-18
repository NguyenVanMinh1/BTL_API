using BLL.Iterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TONGXUANTU.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductBus _ProductBus;
        public ProductController (IProductBus productBus)
        {
            _ProductBus = productBus;
        }
        [Route("GetAllProduct")]
        [HttpGet]
        public IActionResult GetAllProduct()
        {
          var result = _ProductBus.GetAllProduct();
            return Ok(result);
        }
        [Route("Locgiatiengiamdan")]
        [HttpGet]
        public IActionResult Locgiatiengiamdan()
        {
            var result = _ProductBus.FilterProductByPriceDescending();
            return Ok(result);
        }
        [Route("Locgiatientangdan")]
        [HttpGet]
        public IActionResult Locgiatientangdan()
        {
            var result = _ProductBus.FilterProductByPriceAscending();
            return Ok(result);
        }
        [Route("TimKiemSanPham/{ProductName}")]
        [HttpGet]
        public IActionResult TimKiemSanPham(string ProductName)
        {
            var result = _ProductBus.SearchProduct(ProductName);
            return Ok(result);
        }
        [Route("TimKiemTheoKhoangGia/{Min}AndMax/{Max}")]
        [HttpGet]

        public IActionResult TimKiemTheoKhoangGia(int Min , int Max)
        {
            var result = _ProductBus.SearchProductByPriceRange(Min, Max);
            return Ok(result);
        }
        [Route("SanPhamMoiVe")]
        [HttpGet]
        public IActionResult SanPhamMoiVe()
        {
            return Ok(_ProductBus.GetProductNews());
        }
        [Route("SanPhamGiamGia")]
        [HttpGet]
        public IActionResult SanPhamGiamGia()
        {
            return Ok(_ProductBus.GetProductSale());
        }
        [HttpGet]
        [Route("SanPhamPhanTrang/{number}PageSize/{size}")]
        public IActionResult SanPhamPhanTrang(int size ,int number)
        {
            return Ok(_ProductBus.PaingProduct(size, number));
        }
        [HttpGet]
        [Route("SanPhamBanChay")]
        public IActionResult SanPhamBanChay()
        {
            return Ok(_ProductBus.GetBestSellingProducts());
        }
        //[HttpGet]
        //[Route("GetLatestProducts")]
        //public IActionResult GetLatestProducts()
        //{
        //    return Ok(_ProductBus.GetLatestProducts());
        //}
        [HttpGet]
        [Route("TimKiemSanPhamTheoKhoangGiaLoai/{id}Min/{min}Max/{max}")]
        public IActionResult TimKiemSanPhamTheoKhoangGiaLoai(int id , int min , int max)
        {
            return Ok(_ProductBus.SearchProductByPriceRangeCategory(id, min, max));
        }
        [HttpGet]
        [Route("TimKiemSanPhamGiaTuCaoXuongThap/{id}")]
        public IActionResult TimKiemSanPhamGiaTuCaoXuongThap(int id)
        {
            return Ok(_ProductBus.SearchProductByPriceDesc(id));
        }
        [HttpGet]
        [Route("TimKiemSanPhamTuThapLenCao/{id}")]
        public IActionResult TimKiemSanPhamTuThapLenCao(int id)
        {
            return Ok(_ProductBus.SearchProductByPriceASC(id));
        }
        [HttpGet]
        [Route("GetSanPhamByID/{id}")]
        public IActionResult GetSanPhamByID(int id)
        {
            return Ok(_ProductBus.GetProductByid(id));
        }
        [HttpGet]
        [Route("GetBinhLuanByProduct/{id}")]
        public IActionResult GetBinhLuanByProduct(int id)
        {
            return Ok(_ProductBus.GetBinhLuanByProduct(id));
        }
        [HttpGet]
        [Route("GetProductByViewCount")]
        public IActionResult GetProductByViewCount()
        {
            return Ok(_ProductBus.GetProductViewCount());
        }    
    }
}
