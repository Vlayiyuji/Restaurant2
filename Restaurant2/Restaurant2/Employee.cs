using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant2
{
    //выполняет функции официанта
    internal class Employee
    {
        public ChickenOrder chickenOrder;
        public Cook cook;
        public EggOrder eggOrder;
        public MenuItem[][] orders = new MenuItem[0][];
        public int orderNumber = 0;
        private int totalQuantityChicken;
        private int totalQuantityEgg;

        public MenuItem[] ReceiveRequest(int quantityChicken, int quantityEgg, MenuItem drink) //Получение запроса от одного клиента
        {
            Array.Resize(ref orders, orders.Length+1);
            int totalSize = quantityChicken + quantityEgg + 1;

            MenuItem[] currentOrder = new MenuItem[totalSize];
            int i;
            
            //сначала заполняем массив(заказ) курицами
            for ( i = 0; i < quantityChicken; i++)
            {              
                currentOrder[i] = MenuItem.Chicken;  
                
            }

            //потом яйцами 
            for (; i < currentOrder.Length-1; i++)
            {
                currentOrder[i] = MenuItem.Egg;     
            }
            orderNumber++;
            try
            {
                if (orderNumber <= 8)
                {
                    currentOrder[currentOrder.Length - 1] = drink; //в конце массива добавляем напиток который выбрали с помощтю Enum
                    orders[orders.Length - 1] = currentOrder;
                    totalQuantityChicken += quantityChicken;
                    totalQuantityEgg += quantityEgg;
                    return currentOrder; //метод возвращает полученный запрос ввиде массива 
                }
                else
                {
                    throw new IndexOutOfRangeException("Вы уже совершили восеь заказов");
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
        
        public void SendAllRequest(int totalQuantityChicken, int totalQuantityEgg, MenuItem menuItem) //отправляем все заказы повару
        {
            int totalChickens = totalQuantityChicken;
            int totalEggs = totalQuantityEgg;   
            chickenOrder = (cook.SubmitRequest(MenuItem.Chicken, totalChickens) as ChickenOrder)!;
            cook.PrepareFood(chickenOrder);
            eggOrder = (cook.SubmitRequest(MenuItem.Egg, totalEggs) as EggOrder)!;
            cook.PrepareFood(eggOrder);
        }
        public string[] ServeFood() //доставляем еду клиенту richtextbox
        {
            string[] totalOrder = new string[orders.Length];
            for (int i = 0; i < orders.Length; i++)
            {
                MenuItem[] order = orders[orders.Length];

                int chickenCount = 0;
                int eggCount = 0;

                for (int j = 0; j <= order.Length - 2; j++)
                {
                    if (order[j] == MenuItem.Chicken)
                        chickenCount++;
                    else if (order[j] == MenuItem.Egg)
                        eggCount++;
                    else throw new ArgumentOutOfRangeException();
                }

                MenuItem drink = order[order.Length - 1];

                string customerOrder = $"Customer:{i} is served {chickenCount} chicken, {eggCount} egg, {drink} \n";
                totalOrder[i] += customerOrder;
            }
            return totalOrder;
        }
     }
  }