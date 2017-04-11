using ERMABusinessLibrary.Persistence;
using System;
using System.Collections.Generic;

namespace ApplicationInterface
{
    /// <summary>
    /// Currently this is persistence to a denormaized database table.
    /// It will need corrected later when the business layer settles out for gas and electric.
    /// Only gas is known at this time.
    /// </summary>
    public class ChargeService
    {
        public ICollection<CompanyRateCharge> GetList(int tariffId, DateTime effectiveDate)
        {
            ERMABusinessLibrary.Persistence.ChargeRepository persistence = new ERMABusinessLibrary.Persistence.ChargeRepository();
            return persistence.GetList(tariffId, effectiveDate);
        }

        public ICollection<CompanyRateCharge> GetList(int tariffId, int year, int month)
        {
            ERMABusinessLibrary.Persistence.ChargeRepository persistence = new ERMABusinessLibrary.Persistence.ChargeRepository();
            return persistence.GetList(tariffId, year, month);
        }

        public ICollection<CompanyRateCharge> GetList(int tariffId, int year)
        {
            ERMABusinessLibrary.Persistence.ChargeRepository persistence = new ERMABusinessLibrary.Persistence.ChargeRepository();
            return persistence.GetList(tariffId, year);
        }

        public ICollection<CompanyRateCharge> GetList(int tariffId, ChargeType chargeType, int year)
        {
            ERMABusinessLibrary.Persistence.ChargeRepository persistence = new ERMABusinessLibrary.Persistence.ChargeRepository();
            return persistence.GetList(tariffId, chargeType, year);
        }

        public ICollection<CompanyRateCharge> GetList(int tariffId)
        {
            ERMABusinessLibrary.Persistence.ChargeRepository persistence = new ERMABusinessLibrary.Persistence.ChargeRepository();
            return persistence.GetList(tariffId);
        }

        public void Remove(int id)
        {
            ERMABusinessLibrary.Persistence.ChargeRepository persistence = new ERMABusinessLibrary.Persistence.ChargeRepository();
            persistence.Remove(id);
        }

        public CompanyRateCharge Find(int id)
        {
            ERMABusinessLibrary.Persistence.ChargeRepository persistence = new ERMABusinessLibrary.Persistence.ChargeRepository();
            return persistence.Find(id);
        }

        public int AddStepCharge(int id, int tariffId, string description, double rate, double minimumVolume, double maximumVolume, DateTime effectiveDate, DateTime expirationDate, bool isActive, int seasonMonthStart, int seasonMonthEnd)
        {
            ERMABusinessLibrary.Persistence.ChargeRepository persistence = new ERMABusinessLibrary.Persistence.ChargeRepository();
            return persistence.AddStepCharge(id, tariffId, description, rate, minimumVolume, maximumVolume, effectiveDate, expirationDate, isActive, seasonMonthStart, seasonMonthEnd);
        }

        public int AddUsageCharge(int id, int tariffId, string description, double rate, DateTime effectiveDate, DateTime expirationDate, bool isActive, bool addToStepCharge)
        {
            ERMABusinessLibrary.Persistence.ChargeRepository persistence = new ERMABusinessLibrary.Persistence.ChargeRepository();
            return persistence.AddUsageCharge(id, tariffId, description, rate, effectiveDate, expirationDate, isActive, addToStepCharge);
        }

        public int AddAccountCharge(int id, int tariffId, string description, double rate, DateTime effectiveDate, DateTime expirationDate, bool isActive)
        {
            ERMABusinessLibrary.Persistence.ChargeRepository persistence = new ERMABusinessLibrary.Persistence.ChargeRepository();
            return persistence.AddAccountCharge(id, tariffId, description, rate, effectiveDate, expirationDate, isActive);
        }

        public int Add(int id, int tariffId, string description, ChargeType type, double rate, double minimumVolume, double maximumVolume,
           DateTime effectiveDate, DateTime expirationDate, bool isActive, int adjustmentStartYear, int seasonMonthStart, int seasonMonthEnd)
        {
            ERMABusinessLibrary.Persistence.ChargeRepository persistence = new ERMABusinessLibrary.Persistence.ChargeRepository();
            return persistence.Add(id, tariffId, description, type, rate, minimumVolume, maximumVolume,
           effectiveDate, expirationDate, isActive, adjustmentStartYear, seasonMonthStart, seasonMonthEnd);
        }

        public int Add(CompanyRateCharge dataNew)
        {
            ERMABusinessLibrary.Persistence.ChargeRepository persistence = new ERMABusinessLibrary.Persistence.ChargeRepository();
            return persistence.Add(dataNew);
        }

    }
}
