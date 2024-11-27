using Microsoft.Data.SqlClient;
namespace V48ADOnetAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataBaseConnection SakilaConnection = new DataBaseConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Sakila;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            Menu.PrintIntro();
            while (true)
            {
                int UserChoice = Menu.MainMenu();
                MenuChoice menuChoice = (MenuChoice)UserChoice;
                switch (menuChoice)
                {
                    case MenuChoice.SearchByActor:
                        SqlCommand sqlCMD = QueryManager.SearchByActor(SakilaConnection.Connection);
                        QueryManager.PrintResult(SakilaConnection.Connection, sqlCMD);
                        Menu.GoBackToMenu();
                        break;
                    case MenuChoice.ExitProgram:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Input...");
                        Menu.GoBackToMenu();
                        break;
                }

            }



        }
    }


}
