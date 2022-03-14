using cs37_Exam_RestaurantOrderingSystem.Functions.GeneralFunctions.ChequeSystem;
using cs37_Exam_RestaurantOrderingSystem.Functions.GeneralFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using cs37_Exam_RestaurantOrderingSystem.Functions.GUI;

namespace cs37_Exam_RestaurantOrderingSystem.Functions.CashRegister.ChequeSystem
{
    public class ChequeGenerator
    {

        #region GLOBALS
        public static List<string> externalCheque = new List<string>();
        public static string Cheque;
        public static string InternalCheque;
        public static decimal Sum = 0;
        public static decimal Turnover = 0;
        #endregion 

        /// <summary>
        /// This method adds indicated food to selected table
        /// Additionally: calculates order Sum and generates string for cheque to be sent
        /// </summary>
        /// <param Indicates to which table food is assigned="tableIndex"></param>
        /// <param Indicates which food is assigned="index"></param>
        public static void ChequeConstructor_AddFood(int tableIndex, int index)
        {
            string tempString = $"{ BarcodeIdentifier.Identifier(RootFunction.foods[index].ID)} @ " +
                                $"{ RootFunction.foods[index].Price } Eur";

            externalCheque.Add(tempString);

            RootFunction.tables[RootFunction.tables.IndexOf(TableAllocation.AutomaticTableSelector(tableIndex))].Orders.Add(tempString);
            RootFunction.tables[RootFunction.tables.IndexOf(TableAllocation.AutomaticTableSelector(tableIndex))].OrderSum += RootFunction.foods[index].Price;
            RootFunction.foods[index].ItemsSold++;


            Sum = RootFunction.tables[RootFunction.tables.IndexOf(TableAllocation.AutomaticTableSelector(tableIndex))].OrderSum;

        }
        /// <summary>
        /// This method adds indicated drink to selected table
        /// Additionally: calculates order Sum and generates string for cheque to be sent
        /// </summary>
        /// <param Indicates to which table drink is assigned="tableIndex"></param>
        /// <param Indicates which drink is assigned="index"></param>
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

        /// <summary>
        /// This method calculates total money spent over an instance of program
        /// Writes cheque data to txt file
        /// Additionally: resets Global variable values, for re-using
        /// </summary>
        public static void ChequeConstructor_RecordAndReset()
        {
            Turnover += Sum;
            FileHandler.WriteChequeToHistory(Cheque);
            externalCheque.Clear();
            Cheque = "";
            Sum = 0;
        }

        /// <summary>
        /// This method constructs Cheque (consumer) from data accumulated by methods above
        /// </summary>
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
            Cheque += "\n";
        }

        /// <summary>
        /// This method constructs Cheque (shop) from data accumulated by methods above
        /// </summary>
        public static void ChequeConstructor_Shop()
        {
            InternalCheque += $"\nParduotos prekės:";
            var sortedFoodList = RootFunction.foods.Where(f => f.ItemsSold > 0);
            foreach (var item in sortedFoodList) { InternalCheque += $"\nitem {item.ID} - sold: {item.ItemsSold}"; }
            var sortedDrinksList = RootFunction.drinks.Where(d => d.ItemsSold > 0);
            foreach (var item in sortedDrinksList){ InternalCheque += $"\nitem {item.ID} - sold: {item.ItemsSold}"; }
            InternalCheque += $"\nApyvarta: {Turnover} Eur";

            FileHandler.WriteSummaryToHistory(InternalCheque);
        }

        /// <summary>
        /// This is binary method, that inquires if check is to be sent to consumer
        /// Additionally it is one of the main intersections of the code that is generally executed
        /// </summary>
        public static void IsCheckSentToUser()
        {
            Console.WriteLine("\n(?) Ar klientas nori čekio (Y/N)?");
            switch (ValidationHelper.LetterInputValidation())
            {
                case "y":
                    ChequeConstructor_Client();
                    ChequeDelivery.SendCheque();
                    Console.WriteLine("\n\n(!) Čekis -> IŠSIŲSTAS");
                    ChequeConstructor_RecordAndReset();
                    Thread.Sleep(2000);

                    RootFunction.MainMenu();
                    break;

                case "n":
                    Console.WriteLine("\n\n(!) Čekis -> NEIŠSIŲSTAS");
                    ChequeConstructor_Client();
                    ChequeConstructor_RecordAndReset();
                    Thread.Sleep(2000);

                    RootFunction.MainMenu();
                    break;
            }

        }
    }
}
