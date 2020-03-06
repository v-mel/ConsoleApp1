using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Order
    {
        public Pizza[] pizzasArray;

        public Order()
        {
        }

        public Order(Pizza[] pizzas)
        {
            for (int i = 0; i < pizzas.Length; i++)
            {
                pizzasArray[i] = pizzas[i];
            }
        }

        public void ShowOrder()
        {
            Console.WriteLine("Your Pizzas:");
            for (int i = 0; i < pizzasArray.Length; i++)
            {
                Console.WriteLine(pizzasArray[i].pizzaName + ";");
            }
        }
        public void ShowFullOrder()
        {
            Console.WriteLine("Your Pizzas with supplements");
            for (int i = 0; i < pizzasArray.Length; i++)
            {
                Console.WriteLine(pizzasArray[i].pizzaName + " with supplements:");
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
                    Console.ReadLine();

                }
            }


        }
    }
}

