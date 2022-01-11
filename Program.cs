using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkReadint
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;            
            Console.WriteLine("Число " + GetNumber(number) + " верное.");
        }

        static int GetNumber(int number)
        {
            bool numberFound = false;
            while (numberFound == false)
            {
                Console.WriteLine($"Для завершения программы. Введите  число от {int.MinValue}  до {int.MaxValue}");
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out int result) == true)
                {
                    number = Convert.ToInt32(userInput);
                    numberFound = true;
                }
            }
            return number;
        }
    }
}
