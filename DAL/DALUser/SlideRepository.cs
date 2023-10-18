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
    public class SlideRepository : ISlideRepository
    {
        private IDatabaseHelper _databaseHelper;
        public SlideRepository(IDatabaseHelper databaseHelper)
        {
            _databaseHelper = databaseHelper;
        }
        public List<SlideModel> GetAllSlide()
        {

            string ProcName = "GetSlide";
            var Ok = _databaseHelper.ExecuteSProcedureReturnDataTable(ProcName);
            var result = Ok.ConvertTo<SlideModel>().ToList();
            return result;
        }
    }
}
