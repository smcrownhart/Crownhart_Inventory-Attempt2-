using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crownhart_InventoryAttempt
{
    internal class Shippable
    {
        private string _name;
        private IShippable _shipCost;
        
        
        public Shippable(string Name, IShippable ShipCost)
        {
            _name = Name;
            _shipCost = ShipCost;
           

        }

        public decimal ChangeItem(IShippable NewCost)
        { 
            _shipCost = NewCost;
            return _shipCost.ShipCost;
        }


        public string PrintName()
        {
            return _name;
        }

        internal decimal Add(decimal shipCost)
        {
            
            return _shipCost.Cost(shipCost);
        }
    }
}
