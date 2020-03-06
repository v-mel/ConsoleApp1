using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    class Program
    {
        static void ShowMenu(string[] inputArray, string userMessage)
        {
            Console.WriteLine(userMessage);
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.WriteLine(i + 1 + ": " + inputArray[i]);
            };
        }

        static void Main(string[] args)
        {
            //defining menu, user choices, counters
            string[] pizzalist = { "margarita", "cesario", "bavarian" };
            string[] extras = { "cheese", "cream sauce", "mushrooms", "chicken" };
            string[] extrasfinalchoice = new string[4];
            int extrasInput;
            int choice;
            int choicecounter = 0;
            string pizzamessage = "select your pizza:";
            string extrasmessage = "select your extras (optional up to 4 ingredients). press '0' to skip this step:";



            // get user choice on pizza
            ShowMenu(pizzalist, pizzamessage);
            choice = int.Parse(Console.ReadLine()) - 1;
            Console.Clear();

            // get user choice on extras:
            do
            {
                Console.Clear();
                ShowMenu(extras, extrasmessage);
                extrasInput = int.Parse(Console.ReadLine()) - 1;
                if (extrasInput < 0)
                {
                    break;
                }
                else
                {
                    extrasfinalchoice[choicecounter] = extras[extrasInput];
                    choicecounter += 1;
                }
            }
            while (choicecounter < extrasfinalchoice.Length);

            Pizza userSelectedPizza = new Pizza(pizzalist[choice], extrasfinalchoice);

            // show confirmation of user choice
            userSelectedPizza.ShowPizzaWithExtras();

            Console.ReadKey();
        }
    }
}
