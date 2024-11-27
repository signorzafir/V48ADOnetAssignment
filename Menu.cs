using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V48ADOnetAssignment
{
    enum MenuChoice
    {
        SearchByActor = 1,
        ExitProgram = 2
    }
    internal class Menu
    {
        internal static void PrintIntro()
        {
            Console.WriteLine("Movies Search Engine");
        }
        internal static int MainMenu()
        {
            Console.WriteLine("Select search option\n" +
                "1- Search By Actor's Name\n" +
                "2- Close Program");
            Console.Write("Your input: ");
            int input = Utility.GetIntInput();
            return input;
        }
        internal static string GetActorFirstName()
        {
            Console.Write("Please Enter Actors First Name : ");
            string input = Utility.GetStringInput();
            return input;
        }
        internal static string GetActorLastName()
        {
            Console.Write("Please Enter Actors Last Name : ");
            string input = Utility.GetStringInput();
            return input;
        }
        internal static void GoBackToMenu()
        {
            Console.Write("Press Enter to go back to Menu. ");
            Console.ReadKey();
            Console.Clear();
        }
    }


}
