using cs37_Exam_RestaurantOrderingSystem.CSV_Directory.Functions_Directory.GUI_Directory;
using cs37_Exam_RestaurantOrderingSystem.DataType_Directory;
using cs37_Exam_RestaurantOrderingSystem.Functions_Directory.GeneralFunctions.ChequeSystem;
using cs37_Exam_RestaurantOrderingSystem.Functions_Directory.GeneralFunctions_Directory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs37_Exam_RestaurantOrderingSystem.CSV_Directory.Functions_Directory
{
    public class FunctionCalls
    {
        public static int tableIndex = 0;
        public static void MenuChoice()
        {
            switch (ValidationHelper.InputValidation(3))
            {
                case 1:
                    ConsoleStringInterpolation.GUI_Menu_FoodSelector_TableForTwo();
                    FunctionCalls.tableIndex = 0;
                    SubMenuChoice();
                    break;
                case 2:
                    ConsoleStringInterpolation.GUI_Menu_FoodSelector_TableForFour();
                    FunctionCalls.tableIndex = 3;
                    SubMenuChoice();
                    break;
                case 3:
                    ConsoleStringInterpolation.GUI_Menu_FoodSelector_TableForEight();
                    FunctionCalls.tableIndex = 5;
                    SubMenuChoice();
                    break;
                case 0:
                    ConsoleStringInterpolation.GUI_Menu_TableSelector();
                    MenuChoice();
                    break;
            }
        }
        public static void SubMenuChoice()
        {
            switch (ValidationHelper.InputValidation(2))
            {
                case 1:
                    ConsoleStringInterpolation.GUI_Food_SubMenu();
                    SubMenuFoodChoice();
                    break;
                case 2:
                    ConsoleStringInterpolation.GUI_Drinks_SubMenu();
                    SubMenuDrinksChoice();
                    break;
                case 0:
                    ConsoleStringInterpolation.GUI_Menu_TableSelector();
                    MenuChoice();
                    break;
                    
            }
        }

        public static void SubMenuFoodChoice()
        {
            ConsoleStringInterpolation.PrintExternalCheque();
            ConsoleStringInterpolation.GUI_Menu_TablesGraphicRepresentation();
            switch (ValidationHelper.InputValidationListGeneric(RootFunction.foods))
            {
                case 1:
                    ExternalCheque.ExternalChequeConstructor(RootFunction.foods, tableIndex, 0);
                    ConsoleStringInterpolation.GUI_Food_SubMenu();
                    SubMenuFoodChoice();
                    break;
                case 2:
                    ExternalCheque.ExternalChequeConstructor(RootFunction.foods, tableIndex, 1);
                    ConsoleStringInterpolation.GUI_Food_SubMenu();
                    SubMenuFoodChoice();
                    break;
                case 3:
                    ExternalCheque.ExternalChequeConstructor(RootFunction.foods, tableIndex, 2);
                    ConsoleStringInterpolation.GUI_Food_SubMenu();
                    SubMenuFoodChoice();
                    break;
                case 4:
                    ExternalCheque.ExternalChequeConstructor(RootFunction.foods, tableIndex, 3);
                    ConsoleStringInterpolation.GUI_Food_SubMenu();
                    SubMenuFoodChoice();
                    break;
                case 5:
                    ExternalCheque.ExternalChequeConstructor(RootFunction.foods, tableIndex, 4);
                    ConsoleStringInterpolation.GUI_Food_SubMenu();
                    SubMenuFoodChoice();
                    break;
                case 0:
                    ConsoleStringInterpolation.GUI_Menu_TableSelector();
                    MenuChoice();
                    break;
            }
        }
        public static void SubMenuDrinksChoice()
        {
            ConsoleStringInterpolation.PrintExternalCheque();
            ConsoleStringInterpolation.GUI_Menu_TablesGraphicRepresentation();
            switch (ValidationHelper.InputValidationListGeneric(RootFunction.drinks))
            {
                case 1:
                    ExternalCheque.ExternalChequeConstructor(RootFunction.drinks, tableIndex, 0);
                    ConsoleStringInterpolation.GUI_Drinks_SubMenu();
                    SubMenuDrinksChoice();
                    break;
                case 2:
                    ExternalCheque.ExternalChequeConstructor(RootFunction.drinks, tableIndex, 1);
                    ConsoleStringInterpolation.GUI_Drinks_SubMenu();
                    SubMenuDrinksChoice();
                    break;
                case 3:
                    ExternalCheque.ExternalChequeConstructor(RootFunction.drinks, tableIndex, 2);
                    ConsoleStringInterpolation.GUI_Drinks_SubMenu();
                    SubMenuDrinksChoice();
                    break;
                case 4:
                    ExternalCheque.ExternalChequeConstructor(RootFunction.drinks, tableIndex, 3);
                    ConsoleStringInterpolation.GUI_Drinks_SubMenu();
                    SubMenuDrinksChoice();
                    break;
                case 5:
                    ExternalCheque.ExternalChequeConstructor(RootFunction.drinks, tableIndex, 4);
                    ConsoleStringInterpolation.GUI_Drinks_SubMenu();
                    SubMenuDrinksChoice();
                    break;
                case 0:
                    ConsoleStringInterpolation.GUI_Menu_TableSelector();
                    MenuChoice();
                    break;
            }
        }
    }
}
