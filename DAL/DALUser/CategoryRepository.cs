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
    public class CategoryRepository: ICategoryRepository
    {
        private IDatabaseHelper _databaseHelper;
        public CategoryRepository(IDatabaseHelper databaseHelper)
        {
            _databaseHelper = databaseHelper;
        }

        public List<CategoryModel> GetAll()
        {
            string ProcName = "GetAllLOAI"; 
            var Ok = _databaseHelper.ExecuteSProcedureReturnDataTable(ProcName);
            var result = Ok.ConvertTo<CategoryModel>().ToList();
            return result;
        }

        public List<ProductModel> GetProductByCategory(int CategoryID)
        {
            string ProcName = "GetAllSANPHAMByLOAI";
            var Ok = _databaseHelper.ExecuteSProcedureReturnDataTable(ProcName, "@LOAIID", CategoryID);
            var result = Ok.ConvertTo<ProductModel>().ToList();
            return result;
          

        }
    }
}
