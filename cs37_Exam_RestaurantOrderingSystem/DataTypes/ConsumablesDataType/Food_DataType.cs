namespace cs37_Exam_RestaurantOrderingSystem.DataType
{
    public class Food_DataType : Item_DataType
    {
        public bool IsVegan { get; set; }

        public Food_DataType(int id = 0, decimal price = 0, int timeToPrepare = 0, bool isVegan = false, int itemsSold = 0) 
        {
            ID = id;
            Price = price;
            TimeToPrepare = timeToPrepare;
            IsVegan = isVegan;
            ItemsSold = itemsSold;
        }
        #region DataPrintingHelper
        public static string IsVeganPrintingHelper(bool check)
        {
            if (check) { return "veganiškas"; }
            else { return "ne veganiškas"; }
        }
        #endregion
    }
}
