using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs37_Exam_RestaurantOrderingSystem.Functions_Directory.GeneralFunctions_Directory
{
    internal class ValidationHelper
    {
        public static decimal InputValidationDecimal()
        {
            string input = Console.ReadLine();
            decimal inputValue;
            bool success = decimal.TryParse(input, out inputValue) && inputValue > 0;
            while (!success)
            {
                Console.WriteLine("(!) Netinkama įvestis");
                Console.Write(" -> Bandykite dar kartą:");
                input = Console.ReadLine();
                success = decimal.TryParse(input, out inputValue) && inputValue > 0;
            }
            Console.Clear();
            return inputValue;
        }
        public static int InputValidation(int selectorSize)
        {
            string input = Console.ReadLine();
            int inputValue;
            bool success = int.TryParse(input, out inputValue) && inputValue > 0 && inputValue <= selectorSize;
            while (!success)
            {
                Console.WriteLine("(!) Netinkama įvestis");
                Console.Write(" -> Bandykite dar kartą:");
                input = Console.ReadLine();
                success = int.TryParse(input, out inputValue) && inputValue > 0 && inputValue <= selectorSize;
            }
            Console.Clear();
            return inputValue;
        }
    }
}
