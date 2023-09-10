//Hayden Lammons HLammons1@cnm.edu
//LammonsP6, implement command design pattern

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LammonsP6
{
    public class InventoryItem
    {
        public string Name { get; private set; }
        public InventoryItem(string _name) { Name = _name; }

        public override string ToString()
        {
            return Name;
        }
    }
}
