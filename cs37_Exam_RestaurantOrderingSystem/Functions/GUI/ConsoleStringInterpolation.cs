using cs37_Exam_RestaurantOrderingSystem.DataType;
using cs37_Exam_RestaurantOrderingSystem.Functions.GeneralFunctions.ChequeSystem;
using cs37_Exam_RestaurantOrderingSystem.Functions.GeneralFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cs37_Exam_RestaurantOrderingSystem.Functions.CashRegister.ChequeSystem;

namespace cs37_Exam_RestaurantOrderingSystem.Functions.GUI
{
    public class ConsoleStringInterpolation
    {
        // (1) Padavėja turi galėti užregistruoti žmogaus užsakymą:
        //    (1.1) Prekės pavadinimas + kaina eurais;
        //    (1.2) Kuriant užsakymą pirmas pasirinkimas yra staliukas, prie kurio sėdi žmonės;
        //    (1.2) Pasirinkus staliuką sistemoje jis pažymimas kaip užimtas
        //          taip pat turi būti galimybė pažymėti jog staliukas atsilaisvino;
        //    (1.3) Sąraše užimti staliukai turi būti pažymėti kaip užimti;
        //    (1.4) Prekės ir gėrimai imami iš dviejų skirtingų failų pvz food.txt / csv drinks.txt / csv.
        //
        // (2) Užsakyme yra staliuko informacija:
        //    (2.1) Staliuko numeris, kiek sėdimų vietų;
        //    (2.2) Užsakyti patiekalai/ gėrimai ir bendra mokama suma;
        //    (2.3) Užsakymo data ir laikas.
        #region GUI_Menu
        public static void GUI_Menu_TableSelector()
        {
            Console.Clear();
            Console.WriteLine($"\n Staliukų pasirinkimas: " +
                              $"\n (1) 2-vietis staliukas;    " +
                              $"\n (2) 4-vietis staliukas;    " +
                              $"\n (3) 8-vietis staliukas.    " +
                              $"\n (4) Atlaisvinti staliuką." +
                              $"\n\n (0) Uždaryti kasą.\n");
        }

        public static void GUI_Menu_FoodSelector_TableForTwo()
        {
            Console.Clear();
            Console.WriteLine($"\n (*) Staliukų pasirinkimas: [->1]" +
                              $"\n (1) 2-vietis staliukas     --> (1) Maistas" +
                              $"\n                            --> (2) Gėrimai" +
                              $"\n                            " +
                              $"\n                            " +
                              $"\n (0) Grįžti <--");
        }
        public static void GUI_Menu_FoodSelector_TableForFour()
        {
            Console.Clear();
            Console.WriteLine($"\n (*) Staliukų pasirinkimas: [->2]" +
                              $"\n                                 " +
                              $"\n (2) 4-vietis staliukas     --> (1) Maistas" +
                              $"\n                            --> (2) Gėrimai" +
                              $"\n                            " +
                              $"\n (0) Grįžti <--");
        }
        public static void GUI_Menu_FoodSelector_TableForEight()
        {
            Console.Clear();
            Console.WriteLine($"\n (*) Staliukų pasirinkimas: [->3] " +
                              $"\n                            " +
                              $"\n                            " +
                              $"\n (3) 2-vietis staliukas     --> (1) Maistas" +
                              $"\n                            --> (2) Gėrimai" +
                              $"\n (0) Grįžti <--");
        }
        #endregion

        #region GUI_MenuItemPrinting

        public static void GUI_Food_SubMenu()
        {
            int indexer = 1;
            Console.Clear();
            Console.WriteLine($"\n Maisto MENIU:");
            RootFunction.foods.ForEach(f => Console.WriteLine($" ({indexer++}) -> " +
                                                              $"{BarcodeIdentifier.Identifier(f.ID)}, " +
                                                              $"{f.Price}, Eur " +
                                                              $"paruošiamas per {f.TimeToPrepare}, " +
                                                              $"patiekalas: {Food_DataType.IsVeganPrintingHelper(f.IsVegan)}"));
                                            Console.WriteLine($"\n (6) -> Pereiti į gėrymų meniu <-");
                                            Console.WriteLine($"\n (0) Baigti užsakymą");
        }
        public static void GUI_Drinks_SubMenu()
        {
            int indexer = 1;
            Console.Clear();
            Console.WriteLine($"\n Gėrymų MENIU:");
            RootFunction.drinks.ForEach(d => Console.WriteLine($" ({indexer++}) -> " +
                                                               $"{BarcodeIdentifier.Identifier(d.ID)}, " +
                                                               $"{d.Price}, Eur " +
                                                               $"paruošiamas per {d.TimeToPrepare}, " +
                                                               $"patiekalas yra: {Drinks_DataType.NoSugarPrintingHelper(d.NoSuggar)}"));
                                             Console.WriteLine($"\n (6) -> Pereiti į maisto meniu <-");
                                             Console.WriteLine($"\n (0) Baigti užsakymą");
        }   

        #endregion
        public static void GUI_Menu_TablesGraphicRepresentation()
        {
            RootFunction.tables.ForEach(t => Console.WriteLine($"Staliukas #{t.TableID} " +
                                                   $"({t.PeaopleCanBeSeated} kėdės), " +
                                                   $"yra užimtas: {Table_DataType.AvalabilityPrintingHelper(t.TableTaken)}, " +
                                                   $"\nUžsakymai: " +
                                                   $"{Table_DataType.ListPrintingHelper(t.Orders)} " +
                                                   $"\nSUMA: {t.OrderSum} Eur \n\n"));
        }
        public static void PrintCheckPreview()
        {
            Console.WriteLine($"\nČekio preview:");
            ChequeGenerator.externalCheque.ForEach(item => Console.WriteLine(item));
            Console.WriteLine($"Viso: {ChequeGenerator.Sum} Eur\n\n");
        }
    }
}
