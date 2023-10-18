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
    public class CategoryBus : ICategoryBus
    {
        public ICategoryRepository _categoryRepository;
        public CategoryBus (ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public List<CategoryModel> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public List<ProductModel> GetProductByCategory(int CategoryID)
        {
            return _categoryRepository.GetProductByCategory(CategoryID);
        }
    }
}
