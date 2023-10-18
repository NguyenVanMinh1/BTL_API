using Model.PublicModel;

namespace BLL.Iterfaces
{
    public interface IProductManageBus
    {
       bool AddProduct (ProductModel model);
        bool UpdateProduct (ProductModel model);
        bool DeleteProduct (int ProductID);
        List<ProductModel> GetAllProduct();
        ProductModel GetProductById(int ProductID);
        List<ProductModel> SearchProductByName(string Name);


    }
}
