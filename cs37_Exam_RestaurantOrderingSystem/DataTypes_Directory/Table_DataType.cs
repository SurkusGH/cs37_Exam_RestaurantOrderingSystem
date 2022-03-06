using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs37_Exam_RestaurantOrderingSystem.DataType_Directory
{
    public class Table_DataType
    {
        public int PeaopleCanBeSeated { get; set; }
        public bool TableTaken { get; set; }
        public int TableSaturation { get; set; }

        public Table_DataType(int peaopleCanBeSeated = 0, bool tableTaken = false, int tableSaturation = 0)
        {
            PeaopleCanBeSeated = peaopleCanBeSeated;
            TableTaken = tableTaken;
            TableSaturation = tableSaturation;
        }
    }
}
