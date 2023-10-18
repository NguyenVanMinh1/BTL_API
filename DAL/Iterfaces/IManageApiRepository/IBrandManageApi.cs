using Model.PublicModel;
using Model.PublicModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Iterfaces.IManageApiRepository
{
    public interface IBrandManageApi
    {
        List<BrandModel> GetAllBrand();
    }
}
