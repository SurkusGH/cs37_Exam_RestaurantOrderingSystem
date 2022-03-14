using cs37_Exam_RestaurantOrderingSystem.Functions.GUI;
using cs37_Exam_RestaurantOrderingSystem.Functions.GeneralFunctions;
using System;
using cs37_Exam_RestaurantOrderingSystem.Functions.CashRegister.ChequeSystem;

namespace cs37_Exam_RestaurantOrderingSystem.Functions
{
    public class FunctionCalls
    {
        #region GLOBALS
        public static int tableIndex = 0;
        #endregion

        public static void MenuChoice()
        {

            switch (ValidationHelper.InputValidation(4))
            {
                case 1:
                    ConsoleStringInterpolation.GUI_Menu_FoodSelector_TableForTwo();
                    ConsoleStringInterpolation.GUI_Menu_TablesGraphicRepresentation();
                    tableIndex = 2;
                    TableAllocation.TableIndexer();
                    TableAllocation.TableAvailabilityCheck(tableIndex);
                    SubMenuChoice();
                    break;
                case 2:
                    ConsoleStringInterpolation.GUI_Menu_FoodSelector_TableForFour();
                    ConsoleStringInterpolation.GUI_Menu_TablesGraphicRepresentation();
                    tableIndex = 4;
                    TableAllocation.TableIndexer();
                    TableAllocation.TableAvailabilityCheck(tableIndex);
                    SubMenuChoice();
                    break;
                case 3:
                    ConsoleStringInterpolation.GUI_Menu_FoodSelector_TableForEight();
                    ConsoleStringInterpolation.GUI_Menu_TablesGraphicRepresentation();
                    tableIndex = 8;
                    TableAllocation.TableIndexer();
                    TableAllocation.TableAvailabilityCheck(tableIndex);
                    SubMenuChoice();
                    break;
                case 4:
                    ConsoleStringInterpolation.GUI_Menu_TableSelector();
                    ConsoleStringInterpolation.GUI_Menu_TablesGraphicRepresentation();
                    TableAllocation.TableAvailabilityChange();
                    SubMenuChoice();
                    break;
                case 0:
                    ConsoleStringInterpolation.GUI_Menu_TableSelector();
                    ChequeAutoDelivery_Shop.SendCheque();
                    Environment.Exit(0);
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
            ConsoleStringInterpolation.PrintCheckPreview();
            ConsoleStringInterpolation.GUI_Menu_TablesGraphicRepresentation();
            switch (ValidationHelper.InputValidation(6))
            {
                case 1:
                    ChequeGenerator.ChequeConstructor_AddFood(tableIndex, 0);
                    ConsoleStringInterpolation.GUI_Food_SubMenu();
                    SubMenuFoodChoice();
                    break;
                case 2:
                    ChequeGenerator.ChequeConstructor_AddFood(tableIndex, 1);
                    ConsoleStringInterpolation.GUI_Food_SubMenu();
                    SubMenuFoodChoice();
                    break;
                case 3:
                    ChequeGenerator.ChequeConstructor_AddFood(tableIndex, 2);
                    ConsoleStringInterpolation.GUI_Food_SubMenu();
                    SubMenuFoodChoice();
                    break;
                case 4:
                    ChequeGenerator.ChequeConstructor_AddFood(tableIndex, 3);
                    ConsoleStringInterpolation.GUI_Food_SubMenu();
                    SubMenuFoodChoice();
                    break;
                case 5:
                    ChequeGenerator.ChequeConstructor_AddFood(tableIndex, 4);
                    ConsoleStringInterpolation.GUI_Food_SubMenu();
                    SubMenuFoodChoice();
                    break;
                case 6:
                    ConsoleStringInterpolation.GUI_Drinks_SubMenu();
                    SubMenuDrinksChoice();
                    
                    break;
                case 0:
                    ConsoleStringInterpolation.GUI_Menu_TableSelector();
                    TableAllocation.SetTableAsTaken();
                    ChequeGenerator.IsCheckSentToUser();
                    ChequeGenerator.ChequeConstructor_RecordAndReset();
                    MenuChoice();
                    break;
            }
        }
        public static void SubMenuDrinksChoice()
        {
            ConsoleStringInterpolation.PrintCheckPreview();
            ConsoleStringInterpolation.GUI_Menu_TablesGraphicRepresentation();
            switch (ValidationHelper.InputValidation(6))
            {
                case 1:
                    ChequeGenerator.ChequeConstructor_AddDrinks(tableIndex, 0);
                    ConsoleStringInterpolation.GUI_Drinks_SubMenu();
                    SubMenuDrinksChoice();
                    break;
                case 2:
                    ChequeGenerator.ChequeConstructor_AddDrinks(tableIndex, 1);
                    ConsoleStringInterpolation.GUI_Drinks_SubMenu();
                    SubMenuDrinksChoice();
                    break;
                case 3:
                    ChequeGenerator.ChequeConstructor_AddDrinks(tableIndex, 2);
                    ConsoleStringInterpolation.GUI_Drinks_SubMenu();
                    SubMenuDrinksChoice();
                    break;
                case 4:
                    ChequeGenerator.ChequeConstructor_AddDrinks(tableIndex, 3);
                    ConsoleStringInterpolation.GUI_Drinks_SubMenu();
                    SubMenuDrinksChoice();
                    break;
                case 5:
                    ChequeGenerator.ChequeConstructor_AddDrinks(tableIndex, 4);
                    ConsoleStringInterpolation.GUI_Drinks_SubMenu();
                    SubMenuDrinksChoice();
                    break;
                case 6:
                    ConsoleStringInterpolation.GUI_Food_SubMenu();
                    SubMenuFoodChoice();
                    break;
                case 0:
                    ConsoleStringInterpolation.GUI_Menu_TableSelector();
                    TableAllocation.SetTableAsTaken();
                    ChequeGenerator.IsCheckSentToUser();
                    ChequeGenerator.ChequeConstructor_RecordAndReset();
                    MenuChoice();
                    break;
            }
        }
    }
}
