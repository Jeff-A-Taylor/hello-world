using ERMABusinessLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationInterface
{
    public class NaturalGasBudgetService
    {
        public int Add(int locationID, string budgetName)
        {
            ERMABusinessLibrary.Persistence.NaturalGasBudgetRepository persistence = new ERMABusinessLibrary.Persistence.NaturalGasBudgetRepository();
            return persistence.Add(locationID, budgetName);
        }

        public void AddCostBudgetItems(int budgetID, List<CostBudgetItem> budgetItems)
        {
            ERMABusinessLibrary.Persistence.NaturalGasBudgetRepository persistence = new ERMABusinessLibrary.Persistence.NaturalGasBudgetRepository();
            persistence.AddCostBudgetItems(budgetID, budgetItems);
        }

        public List<CostBudget> GetList(int locationID)
        {
            ERMABusinessLibrary.Persistence.NaturalGasBudgetRepository persistence = new ERMABusinessLibrary.Persistence.NaturalGasBudgetRepository();
            return persistence.GetList(locationID);
        }

        public List<CostBudgetItem> GetCostBudgetItemsList(int budgetID)
        {
            ERMABusinessLibrary.Persistence.NaturalGasBudgetRepository persistence = new ERMABusinessLibrary.Persistence.NaturalGasBudgetRepository();
            return persistence.GetCostBudgetItemsList(budgetID);
        }

        public List<View_NaturalGasBudget> GetBudgetSummariesList(string searchString, string sortExpression)
        {
            ERMABusinessLibrary.Persistence.NaturalGasBudgetRepository persistence = new ERMABusinessLibrary.Persistence.NaturalGasBudgetRepository();
            return persistence.GetBudgetSummariesList(searchString, sortExpression);
        }

        public CostBudgetItem GetCostBudgetItem(int BudgetItemID)
        {
            ERMABusinessLibrary.Persistence.NaturalGasBudgetRepository persistence = new ERMABusinessLibrary.Persistence.NaturalGasBudgetRepository();
            return persistence.GetCostBudgetItem(BudgetItemID);
        }

        public void DeleteAllBudgetItemsForCostBudget(int BudgetID)
        {
            ERMABusinessLibrary.Persistence.NaturalGasBudgetRepository persistence = new ERMABusinessLibrary.Persistence.NaturalGasBudgetRepository();
            persistence.DeleteAllBudgetItemsForCostBudget(BudgetID);
        }

        public void DeleteCostBudgetItem(int ID)
        {
            ERMABusinessLibrary.Persistence.NaturalGasBudgetRepository persistence = new ERMABusinessLibrary.Persistence.NaturalGasBudgetRepository();
            persistence.DeleteCostBudgetItem(ID);
        }

        public int InsertCostBudgetItem(int BudgetID, double Qty, DateTime Date)
        {
            ERMABusinessLibrary.Persistence.NaturalGasBudgetRepository persistence = new ERMABusinessLibrary.Persistence.NaturalGasBudgetRepository();
            return persistence.InsertCostBudgetItem(BudgetID, Qty, Date);
        }

        public void UpdateCostBudgetItem(int ID, double Qty, DateTime Date)
        {
            ERMABusinessLibrary.Persistence.NaturalGasBudgetRepository persistence = new ERMABusinessLibrary.Persistence.NaturalGasBudgetRepository();
            persistence.UpdateCostBudgetItem(ID, Qty, Date);
        }

        public void DeleteCostBudget(int budgetID)
        {
            ERMABusinessLibrary.Persistence.NaturalGasBudgetRepository persistence = new ERMABusinessLibrary.Persistence.NaturalGasBudgetRepository();
            persistence.DeleteCostBudget(budgetID);
        }

        public CostBudget GetCostBudget(int budgetID)
        {
            ERMABusinessLibrary.Persistence.NaturalGasBudgetRepository persistence = new ERMABusinessLibrary.Persistence.NaturalGasBudgetRepository();
            return persistence.GetCostBudget(budgetID);
        }
    }
}
