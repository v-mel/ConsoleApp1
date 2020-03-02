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
            this.pizzaName = "margarita";
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

        public void ShowPizzaName(string pizzaName)
        {
            Console.Clear();
            Console.WriteLine("Your PIzza: \n " + pizzaName);
            Console.ReadLine();
        }

        public void ShowPizzaWithExtras (string pizzaName, int[] extrasSelection, string[] extrasNames)
        {
            Console.Clear();
            Console.WriteLine("Your pizza:\n" + pizzaName + " with additional: ");
            for (int i = 0; i < extrasSelection.Length; i++)
            {
                if (extrasSelection[i] == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(extrasNames[extrasSelection[i] - 1]);
                }

            }
            Console.ReadLine();


        }

        public int[] SelectPizzaExtras (string[] extrasNames)
        {
            int[] extrasSelection = new int[5];


            return extrasSelection;
        }
    }
}
