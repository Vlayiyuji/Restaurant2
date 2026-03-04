using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant2
{
    internal class ChickenOrder : Order
    {
        public ChickenOrder(int? quantity) : base(quantity)
        { 
            if (!quantity.HasValue || quantity < 0)
            {
                throw new ArgumentOutOfRangeException("Число куриц должно быть положительным числом");
            }
        }
        public void CutUp()
        {

        }
        public override void Cook()
        {
            for (int i = 0; i < GetQuantity(); i++)
            {
                CutUp();
            }
        }
    }
}