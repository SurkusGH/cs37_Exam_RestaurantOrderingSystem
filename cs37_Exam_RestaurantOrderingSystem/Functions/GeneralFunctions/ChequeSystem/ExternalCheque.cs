using cs37_Exam_RestaurantOrderingSystem.CSV_Directory.Functions_Directory;
using cs37_Exam_RestaurantOrderingSystem.Functions_Directory.GeneralFunctions_Directory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs37_Exam_RestaurantOrderingSystem.Functions_Directory.GeneralFunctions.ChequeSystem
{
    public class ExternalCheque
    {
        public static List<string> externalCheque = new List<string>();
        public static void ExternalChequeConstructor_AddFood(int tableIndex, int index)
        {
            //RootFunction.tables.IndexOf(TableAllocation.AutomaticTableSelector(index));
            string tempString = $"{ BarcodeIdentifier.Identifier(RootFunction.foods[index].ID)} @ " +
                                $"{ RootFunction.foods[index].Price } Eur";
            externalCheque.Add(tempString);
            RootFunction.tables[RootFunction.tables.IndexOf(TableAllocation.AutomaticTableSelector(tableIndex))].Orders.Add(tempString);
            RootFunction.tables[RootFunction.tables.IndexOf(TableAllocation.AutomaticTableSelector(tableIndex))].OrderSum += RootFunction.foods[index].Price;
        }
        public static void ExternalChequeConstructor_AddDrinks(int tableIndex, int index)
        {
            string tempString = $"{ BarcodeIdentifier.Identifier(RootFunction.drinks[index].ID)} @ " +
                                $"{ RootFunction.drinks[index].Price } Eur";
            externalCheque.Add(tempString);
            RootFunction.tables[RootFunction.tables.IndexOf(TableAllocation.AutomaticTableSelector(tableIndex))].Orders.Add(tempString);
            RootFunction.tables[RootFunction.tables.IndexOf(TableAllocation.AutomaticTableSelector(tableIndex))].OrderSum += RootFunction.drinks[index].Price;
        }
        public static void ExternalChequeConstructor_Reset()
        {
            externalCheque.Clear();
        }
    }
}
