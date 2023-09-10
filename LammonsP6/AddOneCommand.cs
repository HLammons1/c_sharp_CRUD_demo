//Hayden Lammons HLammons1@cnm.edu
//LammonsP6, implement command design pattern

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LammonsP6
{
    public class AddOneCommand : IInventoryCommand
    {
        InventoryItem Item { get; set; }
        List<InventoryItem> TargetList { get; set; }

        public AddOneCommand(InventoryItem item, List<InventoryItem> targetList)
        {
            Item = item;
            TargetList = targetList;
        }

        public void Do()
        {
            TargetList.Add(Item);
        }

        public void Undo()
        {
            TargetList.Remove(Item);
        }
    }
}
