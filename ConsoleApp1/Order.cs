using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Order
    {
        public Pizza[] pizzasArray = new Pizza[5];

        public Order()
        {
        }

        public Order(Pizza[] pizzas)
        {
            for (int i = 0; i < pizzas.Length; i++)
            {
                this.pizzasArray[i] = pizzas[i];
            }
        }

        public void ShowOrder()
        {
            Console.Clear();
            Console.WriteLine("Your Pizzas order:");
            for (int i = 0; i < pizzasArray.Length; i++)
            {
                Console.WriteLine(pizzasArray[i].pizzaName + ";");
            }
        }
        public void ShowFullOrder()
        {
            Console.Clear();
            Console.WriteLine("Your Full order with supplements");
            for (int i = 0; i < pizzasArray.Length; i++)
            {
                if (pizzasArray[i] != null)
                {
                    Console.WriteLine(pizzasArray[i].pizzaName + " with supplements:");
                }
                else
                {
                    break;
                }
                if (pizzasArray[i].extrasNames[0] == null)
                {
                    Console.WriteLine("no extras were selected");
                }
                else
                {
                    for (int j = 0; j < pizzasArray[i].extrasNames.Length; j++)
                    {
                        if (pizzasArray[i].extrasNames[j] == null)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine(pizzasArray[i].extrasNames[j]);
                        }

                    }
                }
            }


        }
    }
}

