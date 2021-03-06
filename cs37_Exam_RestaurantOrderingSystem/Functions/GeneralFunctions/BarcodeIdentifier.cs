namespace cs37_Exam_RestaurantOrderingSystem.Functions.GeneralFunctions
{
    public class BarcodeIdentifier
    {
        /// <summary>
        /// This method identyfies items by their 4-digit pseudo-barcode
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static string Identifier(int ID)
        {
            return ID switch
            {
                1001 => "Mėsainis",
                1002 => "Kievo kotletas",
                1003 => "Pica",
                1004 => "Vegan item #1",
                1005 => "Vegan item #2",

                2001 => "Vanduo",
                2002 => "Arbata",
                2003 => "Kava",
                2004 => "Kokteilis",
                2005 => "Cola",
                _ => "404 - (!) Prekė nerasta."
            };
        }
    }
}
