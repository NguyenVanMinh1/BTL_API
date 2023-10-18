using Model.PublicModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Iterfaces.IManageApiRepository
{
    public interface ICategoryManageApi
    {
        List<CategoryModel> GetAllCategory();
        bool AddCategory(CategoryModel model);
        bool UpdateCategory(CategoryModel model);
        bool DeleteCategory(int CategoryID);
    }
}
