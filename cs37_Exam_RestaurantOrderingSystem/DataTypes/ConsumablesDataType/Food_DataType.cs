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

        public Food_DataType(int id = 0, decimal price = 0, int timeToPrepare = 0, bool isVegan = false) 
        {
            ID = id;
            Price = price;
            TimeToPrepare = timeToPrepare;
            IsVegan = isVegan;
        }
    }
}
