using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Iterfaces.IManageApiRepository
{
    public interface IUserManageApi
    {
        bool CheckUserManage(string UserName, string PassWord); 

    }
}
