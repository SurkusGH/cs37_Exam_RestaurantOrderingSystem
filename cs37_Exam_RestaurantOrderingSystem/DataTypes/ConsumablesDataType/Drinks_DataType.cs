﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs37_Exam_RestaurantOrderingSystem.DataType_Directory
{
    public  class Drinks_DataType : Item_DataType
    {
        public bool NoSuggar { get; set; }
        
        public Drinks_DataType(int id = 0, decimal price = 0, int timeToPrepare = 0, bool noSuggar = false)
        {
            ID = id;
            Price = price;
            TimeToPrepare = timeToPrepare;
            NoSuggar = noSuggar;
        }
    }
}