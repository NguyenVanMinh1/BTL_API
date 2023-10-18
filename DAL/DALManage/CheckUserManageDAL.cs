using DAL.Helper;
using DAL.Iterfaces.IManageApiRepository;
using Model.PublicModel;
using MODEL.PublicModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALManage
{
    public class CheckUserManageDAL : IUserManageApi
    {
        private IDatabaseHelper _databaseHelper;
        public CheckUserManageDAL(IDatabaseHelper databaseHelper)
        {
            _databaseHelper = databaseHelper;
        }
        public bool CheckUserManage(string UserName, string PassWord)
        {
            var ProcName = "CheckUser";
            var Ok = _databaseHelper.ExecuteSProcedureReturnDataTable(ProcName, "@UserName", UserName, "@PassWord", PassWord);
            var result = Ok.ConvertTo<UserModel>().FirstOrDefault();
            if (result == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
