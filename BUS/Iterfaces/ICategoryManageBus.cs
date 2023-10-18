
using Model.PublicModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Iterfaces
{
    public interface ICategoryManageBus
    {
        List<CategoryModel> GetAllCategory();
        bool AddSanPham(CategoryModel model);
        bool UpdateSanPham(CategoryModel model);
        bool DeleteSanpham(int ProductID);
    }
}
