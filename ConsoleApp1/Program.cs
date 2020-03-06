using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza;
            Order pizzasOrder = new Order();
            int ordersCounter = 0;

            OrderingFlow onePizzaOrder = new OrderingFlow();


            do
            {
                pizza = onePizzaOrder.OrderPIzza();
                if (pizza.pizzaName != "")
                {
                    pizzasOrder.pizzasArray[ordersCounter] = pizza;
                    ordersCounter++;
                }
                else { break; }

            } while (pizza.pizzaName != "" && ordersCounter < pizzasOrder.pizzasArray.Length);

            if (pizzasOrder.pizzasArray[0] != null)
            {
                pizzasOrder.ShowFullOrder();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Order was not Done");
            }
            Console.ReadLine();
        }
    }
}
