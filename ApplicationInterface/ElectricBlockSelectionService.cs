using ERMABusinessLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationInterface
{
    public class ElectricBlockSelectionService
    {
        public List<ElectricBlockSelection> GetList(int LocationID)
        {
            ElectricBlockSelectionService service = new ElectricBlockSelectionService();
            return service.GetList(LocationID);
        }

        public List<View_ElectricBlockSelection> GetViewList(int LocationID)
        {
            ElectricBlockSelectionService service = new ElectricBlockSelectionService();
            return service.GetViewList(LocationID);
        }

        //public void Add(List<ElectricBlockSelection> blockSelections)
        //{
        //    using (var dataContext = this.GetDataSource())
        //    {
        //        dataContext.ElectricBlockSelections.InsertAllOnSubmit(blockSelections);
        //        dataContext.SubmitChanges();
        //    }
        //}

        public void AddBlockSelection(ElectricBlockSelection newBlock)
        {
            ElectricBlockSelectionService service = new ElectricBlockSelectionService();
            service.AddBlockSelection(newBlock);
        }

        //public int AddBlockSelection(int blockGroupId,DateTime monthBeginning, double quantity, bool isOnPeak, double totalKwh, double aboveBlockKwh, double belowBlockKwh)
        //{
        //    using (var dataContext = this.GetDataSource())
        //    {
        //        ElectricBlockSelection blockSelection = new ElectricBlockSelection();
        //        var existingBlock = from data in dataContext.ElectricBlockSelections
        //                            where data.ElectricBlockGroupId == blockGroupId && data.MonthBeginning.Equals(monthBeginning) && data.IsOnPeakBlock == isOnPeak
        //                            select data;

        //        if (existingBlock.Count() > 0)
        //        {
        //            blockSelection = existingBlock.First();
        //            blockSelection.Quantity = quantity;
        //            blockSelection.TotalKwh = totalKwh;
        //            blockSelection.KwhAboveBlock = aboveBlockKwh;
        //            blockSelection.KwhBelowBlock = belowBlockKwh;
        //            blockSelection.Updated = DateTime.Now;
        //        }
        //        else
        //        {
        //            blockSelection.ElectricBlockGroupId = blockGroupId;
        //            blockSelection.Quantity = quantity;
        //            blockSelection.TotalKwh = totalKwh;
        //            blockSelection.KwhAboveBlock = aboveBlockKwh;
        //            blockSelection.KwhBelowBlock = belowBlockKwh;
        //            blockSelection.IsOnPeakBlock = isOnPeak;
        //            blockSelection.Created = DateTime.Now;
        //            blockSelection.Updated = DateTime.Now;
        //            blockSelection.MonthBeginning = monthBeginning;
        //            dataContext.ElectricBlockSelections.InsertOnSubmit(blockSelection);
        //        }

        //        dataContext.SubmitChanges();

        //        return blockSelection.Id;
        //    }
        //}

        public int AddBlockGroup(int locationId, string description, bool isLockedByProcurementEvent)
        {
            ElectricBlockSelectionService service = new ElectricBlockSelectionService();
            return service.AddBlockGroup(locationId, description, isLockedByProcurementEvent);
        }

        /// <summary>
        /// Object datasource want the extra parameter for some reason. No idea why S. Ketcham 28-sep-2012.
        /// </summary>
        /// <param name="blockId"></param>
        /// <param name="id"></param>
        public void DeleteBlockSelection(int blockId /* dummy*/, int id)
        {
            ElectricBlockSelectionService service = new ElectricBlockSelectionService();
            service.DeleteBlockSelection(blockId /* dummy*/, id);
        }

        public void DeleteBlockSelection(int id)
        {
            ElectricBlockSelectionService service = new ElectricBlockSelectionService();
            service.DeleteBlockSelection(id);
        }

        public void DeleteLocationBlockSelections(int locationId)
        {
            ElectricBlockSelectionService service = new ElectricBlockSelectionService();
            service.DeleteLocationBlockSelections(locationId);
        }

        public ElectricBlockSelection GetMostRecentBlockSelection(int locationId, int month, int year, bool isOnPeak)
        {
            ElectricBlockSelectionService service = new ElectricBlockSelectionService();
            return service.GetMostRecentBlockSelection(locationId, month, year, isOnPeak);
        }

        public int GetBlockGroupId(int locationId)
        {
            ElectricBlockSelectionService service = new ElectricBlockSelectionService();
            return service.GetBlockGroupId(locationId);
        }
    }
}
