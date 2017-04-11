using ApplicationInterface;
using ERMABusinessLibrary.Persistence;
using ERMABusinessLibrary.TariffRateClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class RateClassController : ApiController
    {
        public tbl_Tariff GetTariff(int tariffID)
        {
            RateClassService service = new RateClassService();
            return service.GetTariff(tariffID);
        }

        public List<TariffRateClass> GetList(int locationId)
        {
            RateClassService service = new RateClassService();
            return service.GetList(locationId);
        }

        public List<TariffRateClassSerializable> GetAllTariffRates(int accountID)
        {
            RateClassService service = new RateClassService();
            return service.GetAllTariffRates(accountID);
        }

        public void DeleteAccountTariff(int AccountTariffId)
        {
            RateClassService service = new RateClassService();
            service.DeleteAccountTariff(AccountTariffId);
        }

        public List<tbl_Tariff> GetTariffList(int utilityCompanyId, bool insertUknownTariff)
        {
            RateClassService service = new RateClassService();
            return service.GetTariffList(utilityCompanyId, insertUknownTariff);
        }

        public void DeleteAccountTariffs(int accountId)
        {
            RateClassService service = new RateClassService();
            service.DeleteAccountTariffs(accountId);
        }

        public void UpdateRateClasses(List<TariffRateClassSerializable> tariffRates, int accountId)
        {
            RateClassService service = new RateClassService();
            service.UpdateRateClasses(tariffRates, accountId);
        }
    }
}
