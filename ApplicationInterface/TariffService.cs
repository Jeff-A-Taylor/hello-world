using ERMABusinessLibrary.Persistence;
using System.Collections.Generic;

namespace RateEngineBusiness.Persistence
{
    public class TariffService
    {
        public int Add(int id, int companyId, string commodity, string rate, string tariff)
        {
            TariffPersistence persistence = new TariffPersistence();
            return persistence.Add(id, companyId, commodity, rate, tariff);
        }

        public int Add(tbl_Tariff tariff)
        {
            TariffPersistence persistence = new TariffPersistence();
            return persistence.Add(tariff);
        }

        public void Remove(int tariffId)
        {
            TariffPersistence persistence = new TariffPersistence();
            persistence.Remove(tariffId);
        }

        public tbl_Tariff Find(int tariffId)
        {
            TariffPersistence persistence = new TariffPersistence();
            return persistence.Find(tariffId);
        }

        public ICollection<tbl_Tariff> GetList(int companyId)
        {
            TariffPersistence persistence = new TariffPersistence();
            return persistence.GetList(companyId);
        }

        public List<tbl_Tariff> GetListWithEmpty(int companyId)
        {
            TariffPersistence persistence = new TariffPersistence();
            return persistence.GetListWithEmpty(companyId);
        }
    }
}
