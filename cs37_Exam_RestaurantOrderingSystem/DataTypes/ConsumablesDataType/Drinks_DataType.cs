namespace cs37_Exam_RestaurantOrderingSystem.DataType
{
    public  class Drinks_DataType : Item_DataType
    {
        public bool NoSuggar { get; set; }
        
        public Drinks_DataType(int id = 0, decimal price = 0, int timeToPrepare = 0, bool noSuggar = false, int itemsSold = 0)
        {
            ID = id;
            Price = price;
            TimeToPrepare = timeToPrepare;
            NoSuggar = noSuggar;
            ItemsSold = itemsSold;
        }
        #region DataPrintingHelper
        public static string NoSugarPrintingHelper(bool check)
        {
            if (check) { return "su cukrumi"; }
            else { return "be cukraus"; }
        }
        #endregion
    }
}
