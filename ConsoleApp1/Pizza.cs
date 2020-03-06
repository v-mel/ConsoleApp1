using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Pizza
    {
        public string pizzaName;
        public string[] extrasNames = new string[5];

        public Pizza()
        {
            this.pizzaName = "Margarita";
        }

        public Pizza(string pizzaName)
        {
            this.pizzaName = pizzaName;
        }

        public Pizza(string pizzaName, string[] extrasNames)
        {
            this.pizzaName = pizzaName;
            for (int i = 0; i < extrasNames.Length; i++)
            {
                this.extrasNames[i] = extrasNames[i];
            }
        }

        public void ShowPizzaName()
        {
            Console.Clear();
            Console.WriteLine("Your PIzza: \n " + this.pizzaName);
            Console.ReadLine();
        }

        public void ShowPizzaWithExtras()
        {
            Console.Clear();
            Console.WriteLine("Your pizza:\n" + pizzaName + " with additional: ");
            if (extrasNames[0] == null)
            {
                Console.WriteLine("no extras were selected");
            }
            else
            {
                for (int i = 0; i < extrasNames.Length; i++)
                {
                    if (extrasNames[i] == null)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine(extrasNames[i]);
                    }

                }
                Console.ReadLine();


            }
        }

        //public int[] SelectPizzaExtras(string[] extrasNames)
        //{
        //    int[] extrasSelection = new int[5];
        //    //todo

        //    return extrasSelection;
        //}
    }
}
