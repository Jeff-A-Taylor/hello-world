using ERMABusinessLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationInterface
{
    public class TariffLossFactorService
    {
        public int Add(int id, int tariffId, double quantity, DateTime effectiveDate)
        {
            ERMABusinessLibrary.Persistence.TariffLossFactorRepository persistence = new ERMABusinessLibrary.Persistence.TariffLossFactorRepository();
            return persistence.Add(id, tariffId, quantity, effectiveDate);
        }

        public IList<TariffLossFactor> GetList(int tariffId)
        {
            ERMABusinessLibrary.Persistence.TariffLossFactorRepository persistence = new ERMABusinessLibrary.Persistence.TariffLossFactorRepository();
            return persistence.GetList(tariffId);
        }

        public IList<TariffLossFactor> GetListByCompany(int companyId)
        {
            ERMABusinessLibrary.Persistence.TariffLossFactorRepository persistence = new ERMABusinessLibrary.Persistence.TariffLossFactorRepository();
            return persistence.GetListByCompany(companyId);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="id"></param>
        public void Remove(int id)
        {
            ERMABusinessLibrary.Persistence.TariffLossFactorRepository persistence = new ERMABusinessLibrary.Persistence.TariffLossFactorRepository();
            persistence.Remove(id);
        }

        public TariffLossFactor GetMostRecentTariffLossFactor(int tariffId, DateTime termEnd)
        {
            ERMABusinessLibrary.Persistence.TariffLossFactorRepository persistence = new ERMABusinessLibrary.Persistence.TariffLossFactorRepository();
            return persistence.GetMostRecentTariffLossFactor(tariffId, termEnd);
        }
    }
}
