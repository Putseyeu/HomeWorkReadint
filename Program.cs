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
            ChecksNumbers(ref number);
            Console.WriteLine($"Число {number} верное.");
        }

        static void ChecksNumbers(ref int number)
        {
            bool done = false;
            while ( done != true)
            {
                Console.WriteLine($"Для завершения программы. Введите  число от {int.MinValue}  до {int.MaxValue}");
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int result) == true)
                {
                    number = result;
                    done = true;
                }                
            }
        }
    }
}
