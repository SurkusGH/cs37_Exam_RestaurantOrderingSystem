using cs37_Exam_RestaurantOrderingSystem.Functions.GUI;
using cs37_Exam_RestaurantOrderingSystem.DataType;
using cs37_Exam_RestaurantOrderingSystem.Functions.GeneralFunctions;
using System.Collections.Generic;

namespace cs37_Exam_RestaurantOrderingSystem.Functions
{
    public class RootFunction
    {
        #region GLOBALS
        public static List<Table_DataType> tables = FileHandler.ReadTableData();
        public static List<Food_DataType> foods = FileHandler.ReadFoodData();
        public static List<Drinks_DataType> drinks = FileHandler.ReadDrinksData();
        #endregion

        /// <summary>
        /// This method initiates program
        /// </summary>
        public static void RunProgram()
        {
            FileHandler.CashRegistryStartUpTime();
            ConsoleStringInterpolation.GUI_Menu_TableSelector();
            ConsoleStringInterpolation.GUI_Menu_TablesGraphicRepresentation();
            FunctionCalls.MenuChoice();
        }
        #region CombinedRepetetiveFunctions()

        public static void MainMenu()
        {
            ConsoleStringInterpolation.GUI_Menu_TableSelector();
            ConsoleStringInterpolation.GUI_Menu_TablesGraphicRepresentation();
            FunctionCalls.MenuChoice();
        }
        #endregion
    }
}
