using BLL.Iterfaces;
using DAL.Iterfaces;
using DAL.Iterfaces.IManageApiRepository;
using Model.PublicModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BusUser
{
    public class ProductAdminBus : IProductManageBus
    {
        private IProductManageApi _productRepository;
        public ProductAdminBus(IProductManageApi productRepository)
        {
            _productRepository = productRepository;
        }
        public bool AddProduct(ProductModel model)
        {
            return _productRepository.AddSanPham(model);
        }

        public bool DeleteProduct(int ProductID)
        {
            return _productRepository.DeleteSanpham(ProductID);
        }

        public List<ProductModel> GetAllProduct()
        {
            return _productRepository.GetAllProduct();
        }

        public ProductModel GetProductById(int ProductID)
        {
            return _productRepository.GetProductById(ProductID);
        }

        public List<ProductModel> SearchProductByName(string Name)
        {
            return _productRepository.SearchProductByName(Name);
        }

        public bool UpdateProduct(ProductModel model)
        {
            return _productRepository.UpdateSanPham(model);
        }
    }
}
