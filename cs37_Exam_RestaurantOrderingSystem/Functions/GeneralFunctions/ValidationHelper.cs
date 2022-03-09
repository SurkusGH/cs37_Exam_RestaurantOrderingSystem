using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs37_Exam_RestaurantOrderingSystem.Functions.GeneralFunctions
{
    public class ValidationHelper
    {
        public static int InputValidation(int menuSelectionSize)
        {
            string input = Console.ReadLine();
            int inputValue;
            bool success = int.TryParse(input, out inputValue) && inputValue > -1 && inputValue <= menuSelectionSize;
            while (!success)
            {
                Console.WriteLine("(!) Netinkama įvestis");
                Console.Write(" -> Bandykite dar kartą:");
                input = Console.ReadLine();
                success = int.TryParse(input, out inputValue) && inputValue > -1 && inputValue <= menuSelectionSize;
            }
            Console.Clear();
            return inputValue;
        }

        public static int InputValidationListGeneric<T>(List<T> ListIndexNumber)
        {
            string input = Console.ReadLine();
            int inputValue;
            bool success = int.TryParse(input, out inputValue) && inputValue > -1 && inputValue <= ListIndexNumber.Count+1;
            while (!success)
            {
                Console.WriteLine("(!) Netinkama įvestis");
                Console.Write(" -> Bandykite dar kartą:");
                input = Console.ReadLine();
                success = int.TryParse(input, out inputValue) && inputValue > -1 && inputValue <= ListIndexNumber.Count+1;
            }
            Console.Clear();
            return inputValue;
        }
    }
}
