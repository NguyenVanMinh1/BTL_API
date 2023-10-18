using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Iterfaces
{
    public interface ICheckUserManageBus
    {
        bool CheckUser(string UserName, string PassWord);

    }
}
