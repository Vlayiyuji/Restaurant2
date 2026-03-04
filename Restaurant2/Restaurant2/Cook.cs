//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Restaurant2
{
    internal class Cook
    {
        private EggOrder eggOrder;
        private ChickenOrder chickenOrder;
        Employee employee = new Employee();
        public Order SubmitRequest(MenuItem menuItem, int quantity) //принимаем заказ 
        {
            Order currentOrder;
            if (menuItem == MenuItem.Chicken)
            {
                currentOrder = new ChickenOrder(quantity);
            }
            else if (menuItem == MenuItem.Egg)
            {
                currentOrder = new EggOrder(quantity);
            }
            else
            {
                throw new ArgumentException("Это не курица или яйцо");
            }
            return currentOrder;
        }
        public void PrepareFood(Order order) //готовим еду 
        {
            if (order is ChickenOrder)
            {
                order.Cook();
            }
            if (order is EggOrder)
            {
                order.Cook();
            }
        }
    }
}