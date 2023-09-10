//Hayden Lammons HLammons1@cnm.edu
//LammonsP6, implement command design pattern

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LammonsP6
{
    public class AddMultipleCommand : IInventoryCommand
    {
        private int number = 0;
        InventoryItem Item { get; set; }
        List<InventoryItem> TargetList { get; set; }

        public AddMultipleCommand(InventoryItem item, List<InventoryItem> targetList)
        {
            Item = item;
            TargetList = targetList;
        }

        public void Do()
        {
            number = new Random().Next(1, 7); TargetList.Add(Item);
            for (int i = 0; i < number;i++)
            {
                TargetList.Add(Item);
            }
        }

        public void Undo()
        {
            TargetList.RemoveAll(n => n.ToString().Equals(Item.ToString()));
        }
    }
}
