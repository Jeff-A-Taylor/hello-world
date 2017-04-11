using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERMABusinessLibrary.Persistence;

namespace ApplicationInterface
{
    public class CompanyServiceTypesService
    {
        public IDictionary<int, string> GetList()
        {
            ERMABusinessLibrary.Persistence.CompanyServiceTypesRepository persistence = new CompanyServiceTypesRepository();
            return persistence.GetList();
        }

        public IDictionary<int, string> GetListByCompany(int companyId)
        {
            ERMABusinessLibrary.Persistence.CompanyServiceTypesRepository persistence = new CompanyServiceTypesRepository();
            return persistence.GetListByCompany(companyId);
        }
    }
}
