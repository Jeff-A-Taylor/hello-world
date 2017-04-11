using ERMABusinessLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationInterface
{
    public class UnitService
    {
        public IDictionary<int, string> GetNaturalGasAsDictionary()
        {
            ERMABusinessLibrary.Persistence.UnitRepository persistence = new ERMABusinessLibrary.Persistence.UnitRepository();
            return persistence.GetNaturalGasAsDictionary();
        }

        public IDictionary<int, string> UnitsAsDictionary()
        {
            ERMABusinessLibrary.Persistence.UnitRepository persistence = new ERMABusinessLibrary.Persistence.UnitRepository();
            return persistence.UnitsAsDictionary();
        }

        public List<tblUnitsMaster> GetNaturalGasUnitsList()
        {
            ERMABusinessLibrary.Persistence.UnitRepository persistence = new ERMABusinessLibrary.Persistence.UnitRepository();
            return persistence.GetNaturalGasUnitsList();
        }

        public int GetUnitID(string description)
        {
            ERMABusinessLibrary.Persistence.UnitRepository persistence = new ERMABusinessLibrary.Persistence.UnitRepository();
            return persistence.GetUnitID(description);
        }

        public string GetUnitDescription(int unitID)
        {
            ERMABusinessLibrary.Persistence.UnitRepository persistence = new ERMABusinessLibrary.Persistence.UnitRepository();
            return persistence.GetUnitDescription(unitID);
        }

        public int? GetCompanyNominationUnit(int companyID)
        {
            ERMABusinessLibrary.Persistence.UnitRepository persistence = new ERMABusinessLibrary.Persistence.UnitRepository();
            return persistence.GetCompanyNominationUnit(companyID);
        }

        // this method accepts an account's LocationID and returns the
        // corresponding utility company's default unit for nominations.
        // (Or zero if no default unit exists).
        public int? GetCompanyNominationUnitForLocation(int locationID)
        {
            ERMABusinessLibrary.Persistence.UnitRepository persistence = new ERMABusinessLibrary.Persistence.UnitRepository();
            return persistence.GetCompanyNominationUnitForLocation(locationID);
        }

        public void SaveCompanyNominationUnit(int companyID, int? unitID)
        {
            ERMABusinessLibrary.Persistence.UnitRepository persistence = new ERMABusinessLibrary.Persistence.UnitRepository();
            persistence.SaveCompanyNominationUnit(companyID, unitID);
        }

        // This method converts the given quantity specified in fromUnitID to the new
        // toUnitID.
        public double? convert(int? fromUnitID, int? toUnitID, double? quantity)
        {
            ERMABusinessLibrary.Persistence.UnitRepository persistence = new ERMABusinessLibrary.Persistence.UnitRepository();
            return persistence.convert(fromUnitID, toUnitID, quantity);
        }
    }
}
