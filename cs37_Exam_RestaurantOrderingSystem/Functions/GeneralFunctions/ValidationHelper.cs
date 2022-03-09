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
            bool success = int.TryParse(input, out inputValue) && inputValue >=0 && inputValue <= menuSelectionSize;
            while (!success)
            {
                Console.WriteLine("(!) Netinkama įvestis");
                Console.Write(" -> Bandykite dar kartą:");
                input = Console.ReadLine();
                success = int.TryParse(input, out inputValue) && inputValue >= 0 && inputValue <= menuSelectionSize;
            }
            Console.Clear();
            return inputValue;
        }
        public static string LetterInputValidation()
        {
            string input = Console.ReadLine();
            bool success = input.ToLower() == "y" || "n" == input.ToLower();
            while (!success)
            {
                Console.WriteLine("(!) Netinkama įvestis");
                Console.Write(" -> Y/N:");
                input = Console.ReadLine();
                success = input.ToLower() == "y" || "n" == input.ToLower();
            }
            Console.Clear();
            return input;
        }

        public static int InputValidationListGeneric<T>(List<T> ListIndexNumber)
        {
            string input = Console.ReadLine();
            int inputValue;
            bool success = int.TryParse(input, out inputValue) && inputValue >= 0 && inputValue <= ListIndexNumber.Count;
            while (!success)
            {
                Console.WriteLine("(!) Netinkama įvestis");
                Console.Write(" -> Bandykite dar kartą:");
                input = Console.ReadLine();
                success = int.TryParse(input, out inputValue) && inputValue >=0 && inputValue <= ListIndexNumber.Count;
            }
            Console.Clear();
            return inputValue;
        }
    }
}
