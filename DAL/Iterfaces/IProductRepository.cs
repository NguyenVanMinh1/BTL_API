using Model.PublicModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Iterfaces
{
    public interface IProductRepository
    {
        List<ProductModel> GetAllProduct();
        List<ProductModel> SearchProduct(string ProductName);
        List<ProductModel> SearchProductByPriceRange(int min , int max);
        List<ProductModel> FilterProductByPriceDescending();
        List<ProductModel> FilterProductByPriceAscending();
        List<ProductModel> GetProductNews();
        List<ProductModel> GetProductSale();
        List<ProductModel> PaingProduct(int PageSize  , int PageNumber);
        List<ProductModel> GetBestSellingProducts();
        List<ProductModel> GetLatestProducts();
        List<ProductModel> SearchProductByPriceRangeCategory(int CategoryID, int PriceMin, int PriceMax);

        List<ProductModel> SearchProductByPriceDesc(int CategoryID);
        List<ProductModel> SearchProductByPriceASC(int CategoryID);
     
        ProductModel GetProductByid(int ProductID);
        List<BinhLuanModel> GetBinhLuanByProduct(int ProductID);
        List<ProductModel> GetProductViewCount();


    }
}
