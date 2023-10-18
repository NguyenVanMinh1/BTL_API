using DAL.Helper;
using DAL.Iterfaces;
using Model.PublicModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALUser
{
    public class BrandUserRepository : IBrandRepository
    {
        private IDatabaseHelper _databaseHelper;
        public BrandUserRepository(IDatabaseHelper databaseHelper)
        {
            _databaseHelper = databaseHelper;
        }
        public List<BrandModel> GetAllBrand()
        {
            string ProcName = "GetAllNHANHIEU";
            var Ok = _databaseHelper.ExecuteSProcedureReturnDataTable(ProcName);
            var result = Ok.ConvertTo<BrandModel>().ToList();
            return result;
        }
    }
}
