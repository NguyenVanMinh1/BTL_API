using DAL.Helper;
using DAL.Iterfaces.IManageApiRepository;
using Model.PublicModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALManage
{
    public class BrandManageDAL : IBrandManageApi
    {

        private IDatabaseHelper _databaseHelper;
        public BrandManageDAL(IDatabaseHelper databaseHelper)
        {
            _databaseHelper = databaseHelper;
        }
        public List<BrandModel> GetAllBrand()
        {
            var ProcName = "GetAllNHANHIEU";
            var OK = _databaseHelper.ExecuteSProcedureReturnDataTable(ProcName);
            var result = OK.ConvertTo<BrandModel>().ToList();
            return result;
        }
    }
}
