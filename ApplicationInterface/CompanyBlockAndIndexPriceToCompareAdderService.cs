using ERMABusinessLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationInterface
{
    public class CompanyBlockAndIndexPriceToCompareAdderService
    {
        public List<CompanyBlockAndIndexPriceToCompareAdder> GetList(int companyId)
        {
            ERMABusinessLibrary.Persistence.CompanyBlockAndIndexPriceToCompareAdderRepository persistence = 
                new ERMABusinessLibrary.Persistence.CompanyBlockAndIndexPriceToCompareAdderRepository();
            return persistence.GetList(companyId);
        }


        public void Delete(int Id)
        {
            ERMABusinessLibrary.Persistence.CompanyBlockAndIndexPriceToCompareAdderRepository persistence =
                new ERMABusinessLibrary.Persistence.CompanyBlockAndIndexPriceToCompareAdderRepository();
            persistence.Delete(Id);
        }

        public void Update(int Id, double quantity, DateTime effectiveDate)
        {
            ERMABusinessLibrary.Persistence.CompanyBlockAndIndexPriceToCompareAdderRepository persistence =
                new ERMABusinessLibrary.Persistence.CompanyBlockAndIndexPriceToCompareAdderRepository();
            persistence.Update(Id, quantity, effectiveDate);
        }

        public int Insert(int companyId, double quantity, DateTime effectiveDate)
        {
            ERMABusinessLibrary.Persistence.CompanyBlockAndIndexPriceToCompareAdderRepository persistence =
                new ERMABusinessLibrary.Persistence.CompanyBlockAndIndexPriceToCompareAdderRepository();
            return persistence.Insert(companyId, quantity, effectiveDate);

        }
    }
}
