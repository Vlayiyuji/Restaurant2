using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant2
{
    internal class Order
    {
        protected int? _quantity;
        public Order(int? quantity) {
            _quantity = quantity;
        }
        public int? GetQuantity() => _quantity;
        public virtual void Cook() { }
    }
}