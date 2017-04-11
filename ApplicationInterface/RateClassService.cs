using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ERMABusinessLibrary.TariffRateClasses;
using ERMABusinessLibrary.Persistence;

namespace ApplicationInterface
{

    //[Serializable]
    //public partial class TariffRateClassSerializable
    //{
    //    public int AccountTariffId { get; set; }
    //    public int AccountId { get; set; }
    //    public int LocationId { get; set; }
    //    public int TariffId { get; set; }
    //    public DateTime? EffectiveDate { get; set; }
    //    public DateTime? ExpirationDate { get; set; }
    //    public string RateClassDescription { get; set; }
    //    public string RateClassTitle { get; set; }
    //}

    public class RateClassService
    {
        public tbl_Tariff GetTariff(int tariffID)
        {
            ERMABusinessLibrary.Persistence.RateClassRepository persistence = new ERMABusinessLibrary.Persistence.RateClassRepository();
            return persistence.GetTariff(tariffID);
        }

        public List<TariffRateClass> GetList(int locationId)
        {
            ERMABusinessLibrary.Persistence.RateClassRepository persistence = new ERMABusinessLibrary.Persistence.RateClassRepository();
            return persistence.GetList(locationId);
        }

        public List<TariffRateClassSerializable> GetAllTariffRates(int accountID)
        {
            ERMABusinessLibrary.Persistence.RateClassRepository persistence = new ERMABusinessLibrary.Persistence.RateClassRepository();
            return persistence.GetAllTariffRates(accountID);
        }

        public void DeleteAccountTariff(int AccountTariffId)
        {
            ERMABusinessLibrary.Persistence.RateClassRepository persistence = new ERMABusinessLibrary.Persistence.RateClassRepository();
            persistence.DeleteAccountTariff(AccountTariffId);
        }

        public List<tbl_Tariff> GetTariffList(int utilityCompanyId, bool insertUknownTariff)
        {
            ERMABusinessLibrary.Persistence.RateClassRepository persistence = new ERMABusinessLibrary.Persistence.RateClassRepository();
            return persistence.GetTariffList(utilityCompanyId, insertUknownTariff);
        }

        public void DeleteAccountTariffs(int accountId)
        {
            ERMABusinessLibrary.Persistence.RateClassRepository persistence = new ERMABusinessLibrary.Persistence.RateClassRepository();
            persistence.DeleteAccountTariffs(accountId);
        }

        public void UpdateRateClasses(List<TariffRateClassSerializable> tariffRates, int accountId)
        {
            ERMABusinessLibrary.Persistence.RateClassRepository persistence = new ERMABusinessLibrary.Persistence.RateClassRepository();
            persistence.UpdateRateClasses(tariffRates, accountId);
        }
    }
}
