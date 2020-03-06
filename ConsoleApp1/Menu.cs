using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Menu
    {
        static string pizzaMessage = "select your pizza:";
        static string extrasMessage = "select your extras (optional up to 4 ingredients). press '0' to skip this step:";
        static string orderMessage = "Make your pizza order. For continue enter 'yes' :";

        void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
        
        void ShowMenu(string[] inputArray, string userMessage)
        {
            Console.WriteLine(userMessage);
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.WriteLine(i + 1 + ": " + inputArray[i]);
            };

        }

        public void ShowPizzaMenu()
        {
            Console.Clear();
            ShowMenu(MenuProducts.pizzaArray, pizzaMessage );
        }

        public void ShowPizzaExtrasMenu()
        {
            Console.Clear();
            ShowMenu(MenuProducts.pizzaExtras, extrasMessage);
        }

        public void ShowOrderMenu()
        {
            Console.Clear();
            ShowMessage(orderMessage);
        }
    }
}
