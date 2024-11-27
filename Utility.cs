using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V48ADOnetAssignment
{
    internal class Utility
    {
        public static int GetIntInput()
        {
            while (true)
            {
                string? input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input) && int.TryParse(input, out int result))
                {
                    return result;
                }
                Console.WriteLine("Invalid input... please Enter only whole Numbers.");
            }
        }
        public static string GetStringInput()
        {
            while (true)
            {
                string? input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    return input;
                }
                Console.WriteLine("Invalid input...");
            }
        }
    }


}
