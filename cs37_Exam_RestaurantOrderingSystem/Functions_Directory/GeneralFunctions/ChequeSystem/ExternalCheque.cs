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
        public static void ExternalChequeConstructor<T>(List<T> list, int tableIndex, int index)
        {
            string tempString = $"{ BarcodeIdentifier.Identifier(RootFunction.foods[index].ID)} @ " +
                                $"{ RootFunction.foods[index].Price } Eur";
            externalCheque.Add(tempString);
            RootFunction.tables[tableIndex].Orders.Add(tempString);
            RootFunction.tables[tableIndex].OrderSum += RootFunction.drinks[index].Price;
        }
    }
}
