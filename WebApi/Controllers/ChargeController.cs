using ApplicationInterface;
using ERMABusinessLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class ChargeController : ApiController
    {
        public ICollection<CompanyRateCharge> GetList(int tariffId, DateTime effectiveDate)
        {
            ChargeService service = new ChargeService();
            return service.GetList(tariffId, effectiveDate);
        }

        public ICollection<CompanyRateCharge> GetList(int tariffId, int year, int month)
        {
            ChargeService service = new ChargeService();
            return service.GetList(tariffId, year, month);
        }

        public ICollection<CompanyRateCharge> GetList(int tariffId, int year)
        {
            ChargeService service = new ChargeService();
            return service.GetList(tariffId, year);
        }

        public ICollection<CompanyRateCharge> GetList(int tariffId, ChargeType chargeType, int year)
        {
            ChargeService service = new ChargeService();
            return service.GetList(tariffId, chargeType, year);
        }

        public ICollection<CompanyRateCharge> GetList(int tariffId)
        {
            ChargeService service = new ChargeService();
            return service.GetList(tariffId);
        }

        public void Remove(int id)
        {
            ChargeService service = new ChargeService();
            service.Remove(id);
        }

        public CompanyRateCharge Find(int id)
        {
            ChargeService service = new ChargeService();
            return service.Find(id);
        }

        public int AddStepCharge(int id, int tariffId, string description, double rate, double minimumVolume, double maximumVolume, DateTime effectiveDate, DateTime expirationDate, bool isActive, int seasonMonthStart, int seasonMonthEnd)
        {
            ChargeService service = new ChargeService();
            return service.AddStepCharge(id, tariffId, description, rate, minimumVolume, maximumVolume, effectiveDate, expirationDate, isActive, seasonMonthStart, seasonMonthEnd);
        }

        public int AddUsageCharge(int id, int tariffId, string description, double rate, DateTime effectiveDate, DateTime expirationDate, bool isActive, bool addToStepCharge)
        {
            ChargeService service = new ChargeService();
            return service.AddUsageCharge(id, tariffId, description, rate, effectiveDate, expirationDate, isActive, addToStepCharge);
        }

        public int AddAccountCharge(int id, int tariffId, string description, double rate, DateTime effectiveDate, DateTime expirationDate, bool isActive)
        {
            ChargeService service = new ChargeService();
            return service.AddAccountCharge(id, tariffId, description, rate, effectiveDate, expirationDate, isActive);
        }

        public int Add(int id, int tariffId, string description, ChargeType type, double rate, double minimumVolume, double maximumVolume,
           DateTime effectiveDate, DateTime expirationDate, bool isActive, int adjustmentStartYear, int seasonMonthStart, int seasonMonthEnd)
        {
            ChargeService service = new ChargeService();
            return service.Add(id, tariffId, description, type, rate, minimumVolume, maximumVolume,
           effectiveDate, expirationDate, isActive, adjustmentStartYear, seasonMonthStart, seasonMonthEnd);
        }

        public int Add(CompanyRateCharge dataNew)
        {
            ChargeService service = new ChargeService();
            return service.Add(dataNew);
        }
    }
}
