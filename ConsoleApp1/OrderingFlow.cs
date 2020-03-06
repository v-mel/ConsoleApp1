using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class OrderingFlow
    {
        Menu productsMenu = new Menu();
        string SelectPizza()
        {

            productsMenu.ShowPizzaMenu();
            int userChoice = int.Parse(Console.ReadLine()) - 1;
            Console.Clear();

            return MenuProducts.pizzaArray[userChoice];
        }
        string[] SelectExtras()
        {
            string[] chosenExtras = new string[4];
            int choiceCounter = 0;
            do
            {
                Console.Clear();
                productsMenu.ShowPizzaExtrasMenu();
                int extrasInput = int.Parse(Console.ReadLine()) - 1;
                if (extrasInput < 0)
                {
                    break;
                }
                else
                {
                    chosenExtras[choiceCounter] = MenuProducts.pizzaExtras[extrasInput];
                    choiceCounter += 1;
                }
            }
            while (choiceCounter < chosenExtras.Length);

            return chosenExtras;
        }

        public Pizza OrderPIzza()
        {
            Pizza selectedPizza = new Pizza("");
            productsMenu.ShowOrderMenu();
            string input = Console.ReadLine();
            if (input.ToLower() == "yes")
            {
                selectedPizza.pizzaName = SelectPizza();
                selectedPizza.extrasNames = SelectExtras();
            }
            return selectedPizza;
        }
    }
}
