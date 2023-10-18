using BLL.Iterfaces;
using DAL.Iterfaces.IManageApiRepository;
using Model.PublicModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BusUser
{
    public class CategoryManageBus: ICategoryManageBus
    {
        public ICategoryManageApi _categoryRepository;
        public CategoryManageBus(ICategoryManageApi categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public bool AddSanPham(CategoryModel model)
        {
            return _categoryRepository.AddCategory(model);
        }

        public bool DeleteSanpham(int ProductID)
        {
            return _categoryRepository.DeleteCategory(ProductID);
        }

        public List<CategoryModel> GetAllCategory()
        {
            return _categoryRepository.GetAllCategory();
        }

        public bool UpdateSanPham(CategoryModel model)
        {
            return _categoryRepository.UpdateCategory(model);
        }
    }
}
