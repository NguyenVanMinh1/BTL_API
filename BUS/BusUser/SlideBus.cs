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
    public class SlideBus: ISlideBus
    {
        private ISlideRepository _productRepository;
        public SlideBus(ISlideRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public List<SlideModel> GetAllSlide()
        {
            return _productRepository.GetAllSlide();
        }
    }
}
