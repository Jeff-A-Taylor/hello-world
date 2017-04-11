using ERMABusinessLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationInterface
{
    public class ConversionFactorService
    {
        //public List<CompanyConversionFactor> GetList(bool getRetainageFactors, bool getConversionFactors)
        //{
        //    using (var dataContext = this.GetDataSource())
        //    {
        //        List<CompanyConversionFactor> conversionFactors = (from data in dataContext.CompanyConversionFactors
        //                                                           where data.IsConversionFactor == getConversionFactors && data.IsRetainageFactor == getRetainageFactors
        //                                                           orderby data.EffectiveDate descending
        //                                                           select data).ToList();
        //        var companyConversionFactors = from data in conversionFactors
        //                                       where data.TariffId == null
        //                                       select data;
        //        foreach (var factor in companyConversionFactors)
        //        {
        //            factor.TariffId = 0;
        //        }
        //        return conversionFactors.OrderBy(f => f.EffectiveDate).ToList();
        //    }
        //}

        public List<CompanyConversionFactor> GetList(int companyId, bool getRetainageFactors, bool getConversionFactors)
        {
            ERMABusinessLibrary.Persistence.ConversionFactorRepository persistence = new ERMABusinessLibrary.Persistence.ConversionFactorRepository();
            return persistence.GetList(companyId, getRetainageFactors, getConversionFactors);
        }

        public IList<CompanyConversionFactor> GetList(int companyId, bool getRetainageFactors, bool getConversionFactors, DateTime effectiveDate)
        {
            ERMABusinessLibrary.Persistence.ConversionFactorRepository persistence = new ERMABusinessLibrary.Persistence.ConversionFactorRepository();
            return persistence.GetList(companyId, getRetainageFactors, getConversionFactors, effectiveDate);
        }

        //public List<CompanyConversionFactor> GetList(bool getRetainageFactors, bool getConversionFactors, DateTime effectiveDate)
        //{
        //    using (var dataContext = this.GetDataSource())
        //    {
        //        List<CompanyConversionFactor> conversionFactors = (from data in dataContext.CompanyConversionFactors
        //                                                           where data.IsConversionFactor == getConversionFactors && data.IsRetainageFactor == getRetainageFactors &&
        //                                                            data.EffectiveDate <= effectiveDate
        //                                                           orderby data.EffectiveDate ascending
        //                                                           select data).ToList();
        //        var companyConversionFactors = from data in conversionFactors
        //                                       where data.TariffId == null
        //                                       select data;
        //        foreach (var factor in companyConversionFactors)
        //        {
        //            factor.TariffId = 0;
        //        }
        //        return conversionFactors.OrderBy(f => f.EffectiveDate).ToList();
        //    }
        //}

        //public CompanyConversionFactor Get(int companyId, bool isRetainageFactor, bool isConversionFactor, DateTime effectiveDate)
        //{
        //    using (var dataContext = this.GetDataSource())
        //    {
        //        var conversionFactors = from data in dataContext.CompanyConversionFactors
        //                                where data.CompanyId == companyId && data.EffectiveDate <= effectiveDate
        //                                orderby data.EffectiveDate descending
        //                                select data;
        //        var companyConversionFactors = from data in conversionFactors
        //                                       where data.TariffId == null
        //                                       select data;
        //        foreach (var factor in companyConversionFactors)
        //        {
        //            factor.TariffId = 0;
        //        }
        //        return conversionFactors.FirstOrDefault();
        //    }
        //}

        //public CompanyConversionFactor Get(bool isRetainageFactor, bool isConversionFactor, DateTime effectiveDate)
        //{
        //    using (var dataContext = this.GetDataSource())
        //    {
        //        var conversionFactors = from data in dataContext.CompanyConversionFactors
        //                                where data.EffectiveDate <= effectiveDate
        //                                orderby data.EffectiveDate descending
        //                                select data;
        //        var companyConversionFactors = from data in conversionFactors
        //                                       where data.TariffId == null
        //                                       select data;
        //        foreach (var factor in companyConversionFactors)
        //        {
        //            factor.TariffId = 0;
        //        }
        //        return conversionFactors.FirstOrDefault();
        //    }
        //}

        public void Delete(int Id)
        {
            ERMABusinessLibrary.Persistence.ConversionFactorRepository persistence = new ERMABusinessLibrary.Persistence.ConversionFactorRepository();
            persistence.Delete(Id);
        }

        public void Update(int Id, int tariffId, double quantity, DateTime effectiveDate, bool isRetainageFactor, bool isConversionFactor)
        {
            ERMABusinessLibrary.Persistence.ConversionFactorRepository persistence = new ERMABusinessLibrary.Persistence.ConversionFactorRepository();
            persistence.Update(Id, tariffId, quantity, effectiveDate, isRetainageFactor, isConversionFactor);
        }

        public int Insert(int companyId, int tariffId, double quantity, DateTime effectiveDate, bool isRetainageFactor, bool isConversionFactor)
        {
            ERMABusinessLibrary.Persistence.ConversionFactorRepository persistence = new ERMABusinessLibrary.Persistence.ConversionFactorRepository();
            return persistence.Insert(companyId, tariffId, quantity, effectiveDate, isRetainageFactor, isConversionFactor);
        }
    }
}
