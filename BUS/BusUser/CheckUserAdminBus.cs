using BLL.Iterfaces;
using DAL.Iterfaces.IManageApiRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BusUser
{
    public class CheckUserAdminBus : ICheckUserManageBus
    {
        private IUserManageApi _productRepository;
        public CheckUserAdminBus(IUserManageApi productRepository)
        {
            _productRepository = productRepository;
        }
        public bool CheckUser(string UserName, string PassWord)
        {
            return _productRepository.CheckUserManage(UserName, PassWord);
        }
    }
}
