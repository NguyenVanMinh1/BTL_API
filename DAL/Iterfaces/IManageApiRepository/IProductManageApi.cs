using Model.PublicModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Iterfaces.IManageApiRepository
{
    public interface IProductManageApi
    {
        bool AddSanPham(ProductModel model);
        bool UpdateSanPham(ProductModel model);
        bool DeleteSanpham(int ProductID);
        List<ProductModel> GetAllProduct();
        ProductModel GetProductById(int ProductID);
        List<ProductModel> SearchProductByName(string Name);



    }
}
