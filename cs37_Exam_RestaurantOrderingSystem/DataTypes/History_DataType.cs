using System;
using System.Collections.Generic;
using cs37_Exam_RestaurantOrderingSystem.DataType;

namespace cs37_Exam_RestaurantOrderingSystem.DataTypes
{
	public class History_DataType
	{
        public string Cheques { get; set; }
		public string InventorySold { get; set; }
		public decimal TotalSalesInProgramInstance { get; set; }

        public History_DataType(string cheques = null, string inventorySold = "", decimal totalSalesInProgramInstance = 0)
        {
            Cheques = cheques;
            InventorySold = inventorySold;
            TotalSalesInProgramInstance = totalSalesInProgramInstance;
        }
    }
}

