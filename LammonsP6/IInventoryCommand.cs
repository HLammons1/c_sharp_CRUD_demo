//Hayden Lammons HLammons1@cnm.edu
//LammonsP6, implement command design pattern

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.tutorialspoint.com/design_pattern/command_pattern.htm

namespace LammonsP6
{
    public interface IInventoryCommand
    {
        void Do();
        void Undo();
    }
}
