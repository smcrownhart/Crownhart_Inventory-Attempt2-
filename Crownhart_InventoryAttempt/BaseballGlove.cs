using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crownhart_InventoryAttempt
{
    class BaseballGlove : IShippable
    {
        private decimal _shipCost;
        private string _product;
        private int _quantity;

        public BaseballGlove(string Product, double ShipCost)
        {
            _product = Product;
            _shipCost = (decimal)ShipCost;

        }


        public decimal ShipCost
        {
            get { return _shipCost; }
            set { _shipCost = value; }
        }

        public string Product
        {
            get { return _product; }
            set { _product = value; }
        }

        public decimal Cost(decimal cost)
        {
            return _shipCost;
        }

        public int NumItems(int Quantity)
        {
            _quantity += Quantity;
            return Quantity;
        }
        public string Name()
        {
            return _product;
        }
    }
}

