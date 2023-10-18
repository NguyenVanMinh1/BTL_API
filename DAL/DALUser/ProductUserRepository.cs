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
    public class ProductUserRepository : IProductRepository
    {
        private IDatabaseHelper _databaseHelper;
        public ProductUserRepository (IDatabaseHelper databaseHelper)
        {
            _databaseHelper = databaseHelper;
        }

        public List<ProductModel> FilterProductByPriceAscending()
        {
            var ProcName = "FilterSANPHAMByPriceDescending";
            var Ok = _databaseHelper.ExecuteSProcedureReturnDataTable(ProcName);
            var result = Ok.ConvertTo<ProductModel>().ToList();
            return result;
        }

        public List<ProductModel> FilterProductByPriceDescending()
        {
            var ProcName = "FilterSANPHAMByPriceAscending";
            var Ok = _databaseHelper.ExecuteSProcedureReturnDataTable(ProcName);
            var result = Ok.ConvertTo<ProductModel>().ToList();
            return result;
        }

        public List<ProductModel> GetAllProduct()
        {
            var ProcName = "GETALLSANPHAM";
            var Ok = _databaseHelper.ExecuteSProcedureReturnDataTable(ProcName);
            var result = Ok.ConvertTo<ProductModel>().ToList();
            return result;
        }
        public List<ProductModel> GetBestSellingProducts()
        {
            var ProcName = "GetBestSellingSANPHAMs";
            var Ok = _databaseHelper.ExecuteSProcedureReturnDataTable(ProcName);
            var result = Ok.ConvertTo<ProductModel>().ToList();
            return result;


        }

        public List<BinhLuanModel> GetBinhLuanByProduct(int ProductID)
        {
            var ProcName = "GETBINHLUANBYPRODUCTID";
            var Ok = _databaseHelper.ExecuteSProcedureReturnDataTable(ProcName, "@ProductID", ProductID);
            var result = Ok.ConvertTo<BinhLuanModel>().ToList();
            return result;
        }

        public List<ProductModel> GetLatestProducts()
        {
            var ProcName = "GetLatestSANPHAM";
            var Ok = _databaseHelper.ExecuteSProcedureReturnDataTable(ProcName);
            var result = Ok.ConvertTo<ProductModel>().ToList();
            return result;
        }

        public ProductModel GetProductByid(int ProductID)
        {
            var ProcName = "GetSanPhamByID";
            var Ok = _databaseHelper.ExecuteSProcedureReturnDataTable(ProcName, "@SanPhamID", ProductID);
            var result = Ok.ConvertTo<ProductModel>().FirstOrDefault();
            return result;
        }

        public List<ProductModel> GetProductNews()
        {
            var ProcName = "GetNewestSANPHAM";
            var Ok = _databaseHelper.ExecuteSProcedureReturnDataTable(ProcName);
            var result = Ok.ConvertTo<ProductModel>().ToList();
            return result;
        }

        public List<ProductModel> GetProductSale()
        {
            var ProcName = "GetSANPHAMSale";
            var Ok = _databaseHelper.ExecuteSProcedureReturnDataTable(ProcName);
            var result = Ok.ConvertTo<ProductModel>().ToList();
            return result;
        }

        public List<ProductModel> GetProductViewCount()
        {
            var ProcName = "VIEWCOUNT";
            var Ok = _databaseHelper.ExecuteSProcedureReturnDataTable(ProcName);
            var result = Ok.ConvertTo<ProductModel>().ToList();
            return result;
        }

        public List<ProductModel> PaingProduct(int PageSize, int PageNumer)
        {
            string spName = "GetSANPHAMsByPage";
            var dt = _databaseHelper.ExecuteSProcedureReturnDataTable(spName, "@PageSize", PageSize, "@PageNumber", PageNumer);
            var listSanPham = dt.ConvertTo<ProductModel>().ToList();
            return listSanPham;
        }

        public List<ProductModel> SearchProduct(string ProductName)
        {
            var ProcName = "SearchSANPHAMByName";
            var OK = _databaseHelper.ExecuteSProcedureReturnDataTable(ProcName, "@SANPHAMName", ProductName);
            var result =OK.ConvertTo<ProductModel>().ToList();
            return result;
        }

        public List<ProductModel> SearchProductByPriceASC(int CategoryID)
        {
            var ProcName = "SearchSANPHAMByPriceASC";
            var Ok = _databaseHelper.ExecuteSProcedureReturnDataTable(ProcName, "@CategoryID", CategoryID);
            var result = Ok.ConvertTo<ProductModel>().ToList();
            return result;
        }

        public List<ProductModel> SearchProductByPriceDesc(int CategoryID)
        {
            var ProcName = "SearchSANPHAMByPriceDesc";
            var Ok = _databaseHelper.ExecuteSProcedureReturnDataTable(ProcName, "@CategoryID", CategoryID);
            var result = Ok.ConvertTo<ProductModel>().ToList();
            return result;
        }

        public List<ProductModel> SearchProductByPriceRange(int min, int max)
        {
            var ProcName = "SearchSANPHAMByPriceRange";
            var OK = _databaseHelper.ExecuteSProcedureReturnDataTable(ProcName, "@MinPrice", min, "@MaxPrice", max);
            var result = OK.ConvertTo<ProductModel>().ToList();
            return result;
        }

        public List<ProductModel> SearchProductByPriceRangeCategory(int CategoryID, int PriceMin, int PriceMax)
        {
            var ProcName = "SearchSANPHAMByPriceRangeLOAI";
            var Ok = _databaseHelper.ExecuteSProcedureReturnDataTable(ProcName, "@LOAIID", CategoryID, "@MinPrice", PriceMin, "@MaxPrice", PriceMax);
            var result = Ok.ConvertTo<ProductModel>().ToList();
            return result;
        }
    }
}
