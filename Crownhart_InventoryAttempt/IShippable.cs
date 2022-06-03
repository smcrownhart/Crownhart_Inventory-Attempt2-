using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crownhart_InventoryAttempt
{
    internal interface IShippable
    {
        decimal ShipCost { get; set; }
        string Product { get; set; }

        decimal Cost(decimal cost);

        
        string Name();

       
    }
}
