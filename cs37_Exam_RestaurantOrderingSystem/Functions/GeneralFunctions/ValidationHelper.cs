using System;
using System.Collections.Generic;

namespace cs37_Exam_RestaurantOrderingSystem.Functions.GeneralFunctions
{
    public class ValidationHelper
    {
        /// <summary>
        /// This filter is limited by user (hardcoded)
        /// </summary>
        /// <param name="validatorSize"></param>
        /// <returns></returns>
        public static int InputValidation(int validatorSize)
        {
            string input = Console.ReadLine();
            int inputValue;
            bool success = int.TryParse(input, out inputValue) && inputValue >=0 && inputValue <= validatorSize;
            while (!success)
            {
                Console.WriteLine("(!) Netinkama įvestis");
                Console.Write(" -> Bandykite dar kartą:");
                input = Console.ReadLine();
                success = int.TryParse(input, out inputValue) && inputValue >= 0 && inputValue <= validatorSize;
            }
            Console.Clear();
            return inputValue;
        }
        /// <summary>
        /// This filter limits input to two letters: eiter 'y', or 'n'
        /// Also filters out capitalisation
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// This filter limits input by the size of the (generic) list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="List"></param>
        /// <returns></returns>
        public static int InputValidationListGeneric<T>(List<T> List)
        {
            string input = Console.ReadLine();
            int inputValue;
            bool success = int.TryParse(input, out inputValue) && inputValue > 0 && inputValue <= List.Count;
            while (!success)
            {
                Console.WriteLine("(!) Netinkama įvestis");
                Console.Write(" -> Bandykite dar kartą:");
                input = Console.ReadLine();
                success = int.TryParse(input, out inputValue) && inputValue > 0 && inputValue <= List.Count;
            }
            Console.Clear();
            return inputValue;
        }
    }
}
