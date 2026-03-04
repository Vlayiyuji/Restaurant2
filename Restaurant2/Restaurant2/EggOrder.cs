using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant2
{
    internal class EggOrder : Order
    {
        private int _eggQuality;
        Random rnd = new Random();
        public EggOrder(int? quantity) : base(quantity)
        {
            if (!quantity.HasValue || quantity < 0)
            {
                throw new ArgumentException("число яиц должно быть положительным числом");
            }
            _eggQuality = rnd.Next(0,101); 
        }

        public int GetQuality()
        {
            return _eggQuality;
        }
        public void Crack()
        {
        }

        public void DiscardShell() { }
        public override void Cook()
        {
            for (int i = 0; i < GetQuantity(); i++)
            {
                Crack();
                DiscardShell();
            }
        }
    }
}