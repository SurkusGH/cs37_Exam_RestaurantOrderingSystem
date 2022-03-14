using cs37_Exam_RestaurantOrderingSystem.DataType;
using cs37_Exam_RestaurantOrderingSystem.Functions.GeneralFunctions;
using cs37_Exam_RestaurantOrderingSystem.Functions.CashRegister.ChequeSystem;
using System;

namespace cs37_Exam_RestaurantOrderingSystem.Functions.GUI
{
    public class ConsoleStringInterpolation
    {
        #region GUI_Menu
        public static void GUI_Menu_TableSelector()
        {
            Console.Clear();
            Console.WriteLine($"\n Staliukų pasirinkimas: " +
                              $"\n  1> 2-vietis staliukas;    " +
                              $"\n  2> 4-vietis staliukas;    " +
                              $"\n  3> 8-vietis staliukas.    " +
                              $"\n  4> Atlaisvinti staliuką." +
                              $"\n\n  0> Uždaryti kasą.\n");
        }

        public static void GUI_Menu_FoodSelector_TableForTwo()
        {
            Console.Clear();
            Console.WriteLine($"\n  * Staliukų pasirinkimas: [->1]" +
                              $"\n  1> 2-vietis staliukas     -->  1> Maistas" +
                              $"\n                            -->  2> Gėrimai" +
                              $"\n                            " +
                              $"\n                            " +
                              $"\n  0> Grįžti <--");
        }
        public static void GUI_Menu_FoodSelector_TableForFour()
        {
            Console.Clear();
            Console.WriteLine($"\n  *  Staliukų pasirinkimas: [->2]" +
                              $"\n                                 " +
                              $"\n  2> 4-vietis staliukas     -->  1> Maistas" +
                              $"\n                            -->  2> Gėrimai" +
                              $"\n                            " +
                              $"\n  0> Grįžti <--");
        }
        public static void GUI_Menu_FoodSelector_TableForEight()
        {
            Console.Clear();
            Console.WriteLine($"\n  *  Staliukų pasirinkimas: [->3] " +
                              $"\n                            " +
                              $"\n                            " +
                              $"\n  3> 2-vietis staliukas     -->  1> Maistas" +
                              $"\n                            -->  2> Gėrimai" +
                              $"\n  0> Grįžti <--");
        }
        #endregion

        #region GUI_MenuItemPrinting

        /// <summary>
        /// This method uses string interpolation to generate FOOD selection menu list
        /// Also GUI elements for moving to DRINKS menu list & closing order 
        /// </summary>
        public static void GUI_Food_SubMenu()
        {
            int indexer = 1;
            Console.Clear();
            Console.WriteLine($"\n Maisto MENIU:");
            RootFunction.foods.ForEach(f => Console.WriteLine($"  {indexer++}> -> " +
                                                              $"{BarcodeIdentifier.Identifier(f.ID)}, " +
                                                              $"{f.Price}, Eur " +
                                                              $"paruošiamas per {f.TimeToPrepare}, " +
                                                              $"patiekalas: {Food_DataType.IsVeganPrintingHelper(f.IsVegan)}"));
                                            Console.WriteLine($"\n  6> -> Pereiti į gėrymų meniu <-");
                                            Console.WriteLine($"\n  0> Baigti užsakymą");
        }

        /// <summary>
        /// This method uses string interpolation to generate DRINKS selection menu list
        /// Also GUI elements for moving to FOOD menu list & closing order 
        /// </summary>
        public static void GUI_Drinks_SubMenu()
        {
            int indexer = 1;
            Console.Clear();
            Console.WriteLine($"\n Gėrymų MENIU:");
            RootFunction.drinks.ForEach(d => Console.WriteLine($"  {indexer++}> -> " +
                                                               $"{BarcodeIdentifier.Identifier(d.ID)}, " +
                                                               $"{d.Price}, Eur " +
                                                               $"paruošiamas per {d.TimeToPrepare}, " +
                                                               $"patiekalas yra: {Drinks_DataType.NoSugarPrintingHelper(d.NoSuggar)}"));
                                             Console.WriteLine($"\n  6> -> Pereiti į maisto meniu <-");
                                             Console.WriteLine($"\n  0> Baigti užsakymą");
        }

        #endregion

        #region GUI_TableGraphicRepresentation

        /// <summary>
        /// This method generates current table layout: able requisites, availability, and orders assigned to it
        /// </summary>
        public static void GUI_Menu_TablesGraphicRepresentation()
        {
            RootFunction.tables.ForEach(t => Console.WriteLine($"Staliukas #{t.TableID} " +
                                                   $"({t.PeaopleCanBeSeated} kėdės), " +
                                                   $"yra užimtas: {Table_DataType.AvalabilityPrintingHelper(t.TableTaken)}, " +
                                                   $"\nUžsakymai: " +
                                                   $"{Table_DataType.ListPrintingHelper(t.Orders)} " +
                                                   $"\nSUMA: {t.OrderSum} Eur \n\n"));
        }

        /// <summary>
        /// This method prints preview of check tha is to be sent to consumer
        /// </summary>
        public static void PrintCheckPreview()
        {
            Console.WriteLine($"\nČekio preview:");
            ChequeGenerator.externalCheque.ForEach(item => Console.WriteLine(item));
            Console.WriteLine($"Viso: {ChequeGenerator.Sum} Eur\n\n");
        }
        #endregion
    }
}
