using cs37_Exam_RestaurantOrderingSystem.CSV_Directory.Functions_Directory;
using System;

namespace cs37_Exam_RestaurantOrderingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cs37_Exam_RestaurantOrderingSystem");
            #region Asignment
            // RESTORANO SISTEMA:
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
            //
            // (3) Iš užsakymo sudaromi 2 čekiai:
            //    (3.1) Vienas restoranui kitas klientui;
            //      (?) Pagalvokite kuom skirtųsi informacija patiekiama restoranui
            //          ir klientui, kuri informacija persidengia?
            //
            // (4) Abu čekiai turi būti galimi išsiųsti email'u (panaudoti interface).
            //
            // (5) Priklausomai nuo kliento norų, jam čekis gali būti nespausdinamas,
            //     bet čekis restoranui spausdinamas visada ir
            //     taip pat čekio skirto restoranui informacija įrašoma į failą.
            //
            // (!) UŽDUOTIES ATLIKIMUI SKIRIAMOS 2 SAVAITĖS (KOVO 17)!
            #endregion

            RootFunction.RunProgram();

        }
    }
}
