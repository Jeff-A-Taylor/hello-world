using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationInterface
{
    public class CostBudgetService
    {
        public void UpdateCostBudgetLocation(int newLocationId, int oldLocationId)
        {
            ERMABusinessLibrary.Persistence.CostBudgetRepository persistence = new ERMABusinessLibrary.Persistence.CostBudgetRepository();
            persistence.UpdateCostBudgetLocation(newLocationId, oldLocationId);
        }
    }
}
