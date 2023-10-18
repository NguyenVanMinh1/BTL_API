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
    public class BrandManageBus : IBrandManageBus
    {

        public IBrandManageApi _categoryRepository;
        public BrandManageBus(IBrandManageApi categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public List<BrandModel> GetAllBrand()
        {
          return _categoryRepository.GetAllBrand();
        }
    }
}
