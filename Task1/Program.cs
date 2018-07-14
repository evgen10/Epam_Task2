using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2Library;


namespace Task1
{
    class Program
    {

        static string enteredString = "";


        static void Main(string[] args)
        {
            do
            {

                try
                {

                    EnterString();

                    StringSeparator stringSeparator = new StringSeparator();

                    Console.WriteLine(@"The first symbol of your string is ""{0}"".  ", stringSeparator.GetFirstSymbol(enteredString));


                }
                catch (ArgumentNullException e)
                {
                    PrintErrorMessage(e.Message);
                }


            } while (Exit());

        }
        

        static void PrintErrorMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static void EnterString()
        {

            Console.WriteLine("\nEnter a string!");
            enteredString = Console.ReadLine();

        }

        static bool Exit()
        {
            Console.WriteLine(@"Press any key to continue. Press ""ESC"" to exit." + "\n");

            if (Console.ReadKey(true).Key == ConsoleKey.Escape)
            {
                return false;
            }

            return true;

        }
    }
}
