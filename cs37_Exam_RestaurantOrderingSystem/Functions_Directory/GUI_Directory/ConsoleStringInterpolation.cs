﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs37_Exam_RestaurantOrderingSystem.CSV_Directory.Functions_Directory.GUI_Directory
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
        public static void GUI_Menu_TableChoice()
        {
            Console.WriteLine($"\n Staliukų pasirinkimas: " +
                              $"\n (1) 2-vietis staliukas;    " +
                              $"\n (2) 4-vietis staliukas;    " +
                              $"\n (3) 8-vietis staliukas.🍔    " +
                              $"\n                            ");
        }
        public static void GUI_Menu_FoodChoice_TableForTwo()
        {
            Console.WriteLine($"\n (*) Staliukų pasirinkimas: [->1]" +
                              $"\n (1) 2-vietis staliukas     --> (1) Maistas" +
                              $"\n                            --> (2) Gėrimai" +
                              $"\n                            " +
                              $"\n                            ");
        }
        public static void GUI_Menu_FoodChoice_TableForFour()
        {
            Console.WriteLine($"\n (*) Staliukų pasirinkimas: [->2]" +
                              $"\n                                 " +
                              $"\n (2) 4-vietis staliukas     --> (1) Maistas" +
                              $"\n                            --> (2) Gėrimai" +
                              $"\n                            ");
        }
        public static void GUI_Menu_FoodChoice_TableForEight()
        {
            Console.WriteLine($"\n (*) Staliukų pasirinkimas: [->3] " +
                              $"\n                            " +
                              $"\n                            " +
                              $"\n (3) 2-vietis staliukas     --> (1) Maistas" +
                              $"\n                            --> (2) Gėrimai");
        }

        public static void GUI_Menu_TablesGraphicRepresentation()
        {
            //Console.WriteLine($"{List<Table_DataType>}");
        }

    }
}
