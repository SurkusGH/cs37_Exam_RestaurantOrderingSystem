using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs37_Exam_RestaurantOrderingSystem.DataType_Directory
{
    public class Food_DataType : Item_DataType
    {
        public bool IsVegan { get; set; }

        public Food_DataType(string id, decimal price, int timeToPrepare, bool isVegan) 
        {
            ID = id;
            Price = price;
            IsVegan = isVegan;
            TimeToPrepare = timeToPrepare;
        }
    }
}
