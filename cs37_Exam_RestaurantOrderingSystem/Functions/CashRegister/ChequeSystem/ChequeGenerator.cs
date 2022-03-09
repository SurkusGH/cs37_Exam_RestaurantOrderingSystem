using cs37_Exam_RestaurantOrderingSystem.CSV_DB.Functions;
using cs37_Exam_RestaurantOrderingSystem.Functions.GeneralFunctions.ChequeSystem;
using cs37_Exam_RestaurantOrderingSystem.Functions.GeneralFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs37_Exam_RestaurantOrderingSystem.Functions.CashRegister.ChequeSystem
{
    public class ChequeGenerator
    {
        #region Globals
        public static List<string> externalCheque = new List<string>();
        public static string Cheque;
        public static string InternalCheque;
        public static decimal Sum = 0;
        public static decimal Turnover = 0;
        #endregion 

        public static void ChequeConstructor_AddFood(int tableIndex, int index)
        {
            //RootFunction.tables.IndexOf(TableAllocation.AutomaticTableSelector(index));
            string tempString = $"{ BarcodeIdentifier.Identifier(RootFunction.foods[index].ID)} @ " +
                                $"{ RootFunction.foods[index].Price } Eur";

            externalCheque.Add(tempString);

            RootFunction.tables[RootFunction.tables.IndexOf(TableAllocation.AutomaticTableSelector(tableIndex))].Orders.Add(tempString);
            RootFunction.tables[RootFunction.tables.IndexOf(TableAllocation.AutomaticTableSelector(tableIndex))].OrderSum += RootFunction.foods[index].Price;
            RootFunction.foods[index].ItemsSold++;


            Sum = RootFunction.tables[RootFunction.tables.IndexOf(TableAllocation.AutomaticTableSelector(tableIndex))].OrderSum;

        }
        public static void ChequeConstructor_AddDrinks(int tableIndex, int index)
        {
            string tempString = $"{ BarcodeIdentifier.Identifier(RootFunction.drinks[index].ID)} @ " +
                                $"{ RootFunction.drinks[index].Price } Eur";

            externalCheque.Add(tempString);
            
            RootFunction.tables[RootFunction.tables.IndexOf(TableAllocation.AutomaticTableSelector(tableIndex))].Orders.Add(tempString);
            RootFunction.tables[RootFunction.tables.IndexOf(TableAllocation.AutomaticTableSelector(tableIndex))].OrderSum += RootFunction.drinks[index].Price;
            RootFunction.drinks[index].ItemsSold++;

            Sum = RootFunction.tables[RootFunction.tables.IndexOf(TableAllocation.AutomaticTableSelector(tableIndex))].OrderSum;
        }
        public static void ChequeConstructor_Reset()
        {
            Turnover += Sum;
            externalCheque.Clear();
            Cheque = "";
            Sum = 0;
        }
        public static void ChequeConstructor_Client()
        {
            int index = 1;
            foreach (var item in externalCheque)
            {
                Cheque += $"\n Prekė #{index++}: {item}";
            }
            Cheque += "";
            Cheque += $"\nMokėtina suma: {Sum} Eur";
            Cheque += "";
            Cheque += $"\nČekio data: {DateTime.Today.Year}-{DateTime.Today.Month}-{DateTime.Today.Day}, " +
                                                             $"{DateTime.Now.Hour}:{DateTime.Now.Minute} ";
            Cheque += "";
        }
        public static void ChequeConstructor_Shop()
        {
            InternalCheque += $"Parduotos prekės:";
            var sortedFoodList = RootFunction.foods.Where(f => f.ItemsSold > 0);
            foreach (var item in sortedFoodList) { InternalCheque += $"\nitem {item.ID} - sold: {item.ItemsSold}"; }
            var sortedDrinksList = RootFunction.drinks.Where(d => d.ItemsSold > 0);
            foreach (var item in sortedDrinksList){ InternalCheque += $"\nitem {item.ID} - sold: {item.ItemsSold}"; }
            InternalCheque += $"\nApyvarta: {Turnover} Eur";
        }
    }
}
