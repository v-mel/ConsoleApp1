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

        static void ShowConfirmation(int selectedPizza, int[] selectedExtras, string[] allPizzas, string[] allExtras)
        {
           
        }

        static void main(string[] args)
        {
            //defining menu, user choices, counters
            string[] pizzalist = { "margarita", "cesario", "bavarian" };
            string[] extras = { "cheese", "cream sauce", "mushrooms", "chicken" };
            int[] extrasfinalchoice = new int[4];
            int choice;
            int extraschoice = -1;
            int choicecounter = 0;
            string pizzamessage = "select your pizza:";
            string extrasmessage = "select your extras (optional up to 4 ingredients). press '0' to skip this step:";


            // get user choice on pizza
            ShowMenu(pizzalist, pizzamessage);
            choice = int.Parse(Console.ReadLine()) - 1;
            Console.Clear();

            // get user choice on extras:
            while (extraschoice != 0 && choicecounter < extrasfinalchoice.Length)
            {
                Console.Clear();
                ShowMenu(extras, extrasmessage);

                extraschoice = int.Parse(Console.ReadLine()); ///remove extras choisej
                extrasfinalchoice[choicecounter] = extraschoice;
                choicecounter += 1;
            };


            // show confirmation of user choice
            ShowConfirmation(choice, extrasfinalchoice, pizzalist, extras);

            Console.ReadKey();
        }
    }
}
