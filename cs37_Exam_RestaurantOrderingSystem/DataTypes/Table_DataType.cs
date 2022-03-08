using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs37_Exam_RestaurantOrderingSystem.DataType_Directory
{
    public class Table_DataType
    {
        public string TableID { get; set; }
        public int PeaopleCanBeSeated { get; set; }
        public bool TableTaken { get; set; }
        public decimal OrderSum { get; set; }
        public List<string> Orders { get; set; }

        public Table_DataType(string tableID = "", int peaopleCanBeSeated = 0, bool tableTaken = false, decimal orderSum = 0, List<string> orders = null)
        {
            TableID = tableID;
            PeaopleCanBeSeated = peaopleCanBeSeated;
            TableTaken = tableTaken;
            OrderSum = orderSum;
            Orders = orders;
        }

        #region DataPrintingHelpers
        public static string AvalabilityPrintingHelper(bool check)
        {
            if (check){return "Užimtas";}
            else {return "Neužimtas";}
        }

        public static string ListPrintingHelper(List<string> orders)
        {
            string temp = "";
            foreach (var item in orders)
            {
                temp += $"\n {item}";
            }
            return temp;
        }
        #endregion
    }
}
