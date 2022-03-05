using cs37_Exam_RestaurantOrderingSystem.CSV_Directory.Functions_Directory.GUI_Directory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs37_Exam_RestaurantOrderingSystem.CSV_Directory.Functions_Directory
{
    public class RootFunction
    {
        public static void RunProgram()
        {
            ConsoleStringInterpolation.GUI_Menu(); // <-- Tik spausdina
            FunctionCalls.MenuChoice(); // <-- Tik prašo input'o
        }
    }
}
