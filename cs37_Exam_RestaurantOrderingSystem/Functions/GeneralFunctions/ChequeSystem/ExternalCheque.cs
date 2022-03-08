using cs37_Exam_RestaurantOrderingSystem.CSV_DB.Functions_Directory;
using cs37_Exam_RestaurantOrderingSystem.Functions.GeneralFunctions.ChequeSystem;
using cs37_Exam_RestaurantOrderingSystem.Functions.GeneralFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cs37_Exam_RestaurantOrderingSystem.Functions.GeneralFunctions_Directory;

namespace cs37_Exam_RestaurantOrderingSystem.Functions.GeneralFunctions.ChequeSystem
{
    public class ExternalCheque
    {
        #region Globals
        public static List<string> externalCheque = new List<string>();
        public static string Cheque;
        public static decimal Sum = 0;
        #endregion 


        public static void ExternalChequeConstructor_AddFood(int tableIndex, int index)
        {
            //RootFunction.tables.IndexOf(TableAllocation.AutomaticTableSelector(index));
            string tempString = $"{ BarcodeIdentifier.Identifier(RootFunction.foods[index].ID)} @ " +
                                $"{ RootFunction.foods[index].Price } Eur";

            externalCheque.Add(tempString);

            RootFunction.tables[RootFunction.tables.IndexOf(TableAllocation.AutomaticTableSelector(tableIndex))].Orders.Add(tempString);
            RootFunction.tables[RootFunction.tables.IndexOf(TableAllocation.AutomaticTableSelector(tableIndex))].OrderSum += RootFunction.foods[index].Price;

            Sum = RootFunction.tables[RootFunction.tables.IndexOf(TableAllocation.AutomaticTableSelector(tableIndex))].OrderSum;

        }
        public static void ExternalChequeConstructor_AddDrinks(int tableIndex, int index)
        {
            string tempString = $"{ BarcodeIdentifier.Identifier(RootFunction.drinks[index].ID)} @ " +
                                $"{ RootFunction.drinks[index].Price } Eur";

            externalCheque.Add(tempString);
            
            RootFunction.tables[RootFunction.tables.IndexOf(TableAllocation.AutomaticTableSelector(tableIndex))].Orders.Add(tempString);
            RootFunction.tables[RootFunction.tables.IndexOf(TableAllocation.AutomaticTableSelector(tableIndex))].OrderSum += RootFunction.drinks[index].Price;

            Sum = RootFunction.tables[RootFunction.tables.IndexOf(TableAllocation.AutomaticTableSelector(tableIndex))].OrderSum;
        }
        public static void ExternalChequeConstructor_Reset()
        {
            externalCheque.Clear();
            Cheque = "";
            Sum = 0;
        }
        public static void ChequeConstructorAndSender()
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

            ChequeDelivery.SendCheque();
        }
    }
}
