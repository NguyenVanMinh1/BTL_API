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
    public class BrandBus : IBrandBus
    {
        private IBrandRepository _productRepository;
        public BrandBus(IBrandRepository productRepository)
        {
            _productRepository = productRepository;
        }
    
        public List<BrandModel> GetAllBrand()
        {
          return  _productRepository.GetAllBrand();
        }
    }
}
