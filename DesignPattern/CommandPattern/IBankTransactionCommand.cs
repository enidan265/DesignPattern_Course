using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    //Command Interface
    public interface IBankTransactionCommand
    {
        void Execute();
        void Undo();
    }
}
