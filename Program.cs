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
            string userInput = "";
            Console.WriteLine($"Для завершения программы. Введите  число от {int.MinValue}  до {int.MaxValue}");

            while (true)
            {
                userInput = Console.ReadLine();
                if (int.TryParse(userInput, out int result) == true)
                {
                    Console.WriteLine($" Число  {userInput} введено верно.");
                    break;
                }
                Console.WriteLine($"Повторите попытку. Допустимые числа от {int.MinValue}  до {int.MaxValue}");
            }            
        }
    }
}
