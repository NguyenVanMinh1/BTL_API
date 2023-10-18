using BLL.Iterfaces;
using DAL.Iterfaces;
using Model.PublicModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BusUser
{
    public class ProductBus : IProductBus
    {
        private IProductRepository _productRepository;
        public ProductBus (IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public List<ProductModel> FilterProductByPriceAscending()
        {
            return _productRepository.FilterProductByPriceAscending();
        }

        public List<ProductModel> FilterProductByPriceDescending()
        {
            return _productRepository.FilterProductByPriceDescending();
        }

        public List<ProductModel> GetAllProduct()
        {
          return    _productRepository.GetAllProduct();
        }

        public List<ProductModel> GetBestSellingProducts()
        {
            return _productRepository.GetBestSellingProducts();
        }

        public List<BinhLuanModel> GetBinhLuanByProduct(int ProductID)
        {
            return _productRepository.GetBinhLuanByProduct(ProductID);

        }

        public List<ProductModel> GetLatestProducts()
        {
          return _productRepository.GetLatestProducts();
        }

        public ProductModel GetProductByid(int ProductID)
        {
            return _productRepository.GetProductByid(ProductID);
        }

        public List<ProductModel> GetProductNews()
        {
            return _productRepository.GetProductNews();
        }

        public List<ProductModel> GetProductSale()
        {
            return _productRepository.GetProductSale();
        }

        public List<ProductModel> GetProductViewCount()
        {
            return _productRepository.GetProductViewCount();
        }

        public List<ProductModel> PaingProduct(int PageSize, int PageNumber)
        {
            return _productRepository.PaingProduct(PageSize, PageNumber);
        }

        public List<ProductModel> SearchProduct(string ProductName)
        {
            return _productRepository.SearchProduct(ProductName);
        }

        public List<ProductModel> SearchProductByPriceASC(int CategoryID)
        {
            return _productRepository.SearchProductByPriceASC(CategoryID);
        }

        public List<ProductModel> SearchProductByPriceDesc(int CategoryID)
        {
            return _productRepository.SearchProductByPriceDesc(CategoryID);
        }

        public List<ProductModel> SearchProductByPriceRange(int min, int max)
        {
           return _productRepository.SearchProductByPriceRange(min , max);
        }

        public List<ProductModel> SearchProductByPriceRangeCategory(int CategoryID, int PriceMin, int PriceMax)
        {
            return _productRepository.SearchProductByPriceRangeCategory(CategoryID, PriceMin, PriceMax);
        }
    }
}
