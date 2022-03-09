﻿using cs37_Exam_RestaurantOrderingSystem.CSV_DB.Functions.GUI;
using cs37_Exam_RestaurantOrderingSystem.DataType;
using cs37_Exam_RestaurantOrderingSystem.Functions.GeneralFunctions;
using cs37_Exam_RestaurantOrderingSystem.Functions.GeneralFunctions.ChequeSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cs37_Exam_RestaurantOrderingSystem.Functions.CashRegister.ChequeSystem;
using cs37_Exam_RestaurantOrderingSystem.CSV_DB.Functions;

namespace cs37_Exam_RestaurantOrderingSystem.Functions
{
    public class FunctionCalls
    {
        public static int tableIndex = 0;
        public static void MenuChoice()
        {

            switch (ValidationHelper.InputValidation(4))
            {
                case 1:
                    ConsoleStringInterpolation.GUI_Menu_FoodSelector_TableForTwo();
                    tableIndex = 2;
                    TableAllocation.TableIndexer();
                    TableAllocation.TableAvailabilityCheck(tableIndex);
                    SubMenuChoice();
                    break;
                case 2:
                    ConsoleStringInterpolation.GUI_Menu_FoodSelector_TableForFour();
                    tableIndex = 4;
                    TableAllocation.TableIndexer();
                    TableAllocation.TableAvailabilityCheck(tableIndex);
                    SubMenuChoice();
                    break;
                case 3:
                    ConsoleStringInterpolation.GUI_Menu_FoodSelector_TableForEight();
                    tableIndex = 8;
                    TableAllocation.TableIndexer();
                    TableAllocation.TableAvailabilityCheck(tableIndex);
                    SubMenuChoice();
                    break;
                case 4:
                    ConsoleStringInterpolation.GUI_Menu_TableSelector();
                    TableAllocation.PrintTableAvailability();
                    SubMenuChoice();
                    break;
                case 0:
                    ConsoleStringInterpolation.GUI_Menu_TableSelector();
                    ChequeAutoDelivery_Shop.SendCheque();
                    Environment.Exit(0);
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
                    SubMenuDrinksChoice();
                    ConsoleStringInterpolation.GUI_Drinks_SubMenu();
                    break;
                case 0:
                    ConsoleStringInterpolation.GUI_Menu_TableSelector();
                    TableAllocation.SetTableAsTaken();
                    ChequeDelivery.SendCheque();
                    ChequeGenerator.ChequeConstructor_Reset();
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
                    SubMenuDrinksChoice();
                    break;
                case 0:
                    ConsoleStringInterpolation.GUI_Menu_TableSelector();
                    TableAllocation.SetTableAsTaken();
                    ChequeDelivery.SendCheque();
                    ChequeGenerator.ChequeConstructor_Reset();
                    MenuChoice();
                    break;
            }
        }
    }
}