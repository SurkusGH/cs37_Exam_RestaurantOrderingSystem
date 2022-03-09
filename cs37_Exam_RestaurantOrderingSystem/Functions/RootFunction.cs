using cs37_Exam_RestaurantOrderingSystem.CSV_DB.Functions.GUI;
using cs37_Exam_RestaurantOrderingSystem.DataType;
using cs37_Exam_RestaurantOrderingSystem.Functions;
using cs37_Exam_RestaurantOrderingSystem.Functions.GeneralFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs37_Exam_RestaurantOrderingSystem.CSV_DB.Functions
{
    public class RootFunction
    {
        public static List<Table_DataType> tables = FileHandler.ReadTableData();
        public static List<Food_DataType> foods = FileHandler.ReadFoodData();
        public static List<Drinks_DataType> drinks = FileHandler.ReadDrinksData();
        public static void RunProgram()
        {

            ConsoleStringInterpolation.GUI_Menu_TableSelector(); // <-- Tik spausdina
            ConsoleStringInterpolation.GUI_Menu_TablesGraphicRepresentation(); // <-- Tik spausdina kaip atrodo staliukai
            FunctionCalls.MenuChoice(); // <-- Tik prašo input'o
            
        }
    }
}
