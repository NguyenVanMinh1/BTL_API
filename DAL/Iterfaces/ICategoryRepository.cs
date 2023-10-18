using Model.PublicModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Iterfaces
{
    public interface ICategoryRepository
    {
        List<CategoryModel> GetAll();
        List<ProductModel> GetProductByCategory(int CategoryID);
        
        
    }
}
