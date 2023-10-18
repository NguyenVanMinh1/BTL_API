using DAL.Helper;
using DAL.Iterfaces.IManageApiRepository;
using Model.PublicModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DAL.DALManage
{
    public class ProductManageDAL : IProductManageApi
    {
        private IDatabaseHelper _databaseHelper;
        public ProductManageDAL(IDatabaseHelper databaseHelper)
        {
            _databaseHelper = databaseHelper;
        }
        public bool AddSanPham(ProductModel model)
        {
            var requestJson = model != null ? MessageConvert.SerializeObject(model) : null;
            try
            {
                string msgError = "";
                var result = _databaseHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_SANPHAM_create",
                "@RequestBody", requestJson
                );
                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteSanpham(int ProductID)
        {
            try
            {
                string msgError = "";
                var result = _databaseHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_SANPHAM_delete",
                    "@SANPHAMID", ProductID
                );
                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;
            }
          
            catch (Exception ex)
            {
                // Handle other exceptions
                return false;
            }

        }

        public List<ProductModel> GetAllProduct()
        {
            var ProcName = "GETALLSANPHAM";
            var OK = _databaseHelper.ExecuteSProcedureReturnDataTable(ProcName);
            var result = OK.ConvertTo<ProductModel>().ToList();
            return result;
        }

        public ProductModel GetProductById(int ProductID)
        {
            var ProcName = "GetSANPHAMByid";
            var Ok = _databaseHelper.ExecuteSProcedureReturnDataTable(ProcName, "@SANPHAMID", ProductID);
            var result = Ok.ConvertTo<ProductModel>().FirstOrDefault();
            return result;
        }

        public List<ProductModel> SearchProductByName(string Name)
        {
            var ProcName = "SearchSANPHAMByName";
            var Ok = _databaseHelper.ExecuteSProcedureReturnDataTable(ProcName, "@SANPHAMName", Name);
            var result= Ok.ConvertTo<ProductModel>().ToList();
            return result;
        }

        public bool UpdateSanPham(ProductModel model)
        {
            var requestJson = model != null ? MessageConvert.SerializeObject(model) : null;
            try
            {
                string msgError = "";
                var result = _databaseHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "sp_SANPHAM_update",
                "@request", requestJson
                );
                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
