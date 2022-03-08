using cs37_Exam_RestaurantOrderingSystem.CSV_Directory.Functions_Directory;
using cs37_Exam_RestaurantOrderingSystem.CSV_Directory.Functions_Directory.GUI_Directory;
using cs37_Exam_RestaurantOrderingSystem.DataType_Directory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs37_Exam_RestaurantOrderingSystem.Functions_Directory.GeneralFunctions
{
    public class TableAllocation
    {
        public static void TableAvailabilityCheck(int seats)
        {
            if (RootFunction.tables.Where(t => t.PeaopleCanBeSeated == seats).All(t => t.TableTaken == true))
            {
                Console.WriteLine($"(!) Visi {seats} sėdimų vietų staliukai užimti");
                FunctionCalls.MenuChoice();
                ConsoleStringInterpolation.GUI_Menu_TablesGraphicRepresentation();
            }
        }
        public static Table_DataType AutomaticTableSelector(int seats)
        {

            if (RootFunction.tables.Where(t => t.PeaopleCanBeSeated == seats).All(t => t.TableTaken != true)
                || !RootFunction.tables.Where(t => t.PeaopleCanBeSeated == seats).All(t => t.TableTaken != true))
            {
                return RootFunction.tables.Where(t => t.PeaopleCanBeSeated == seats).First(t => t.TableTaken == false);
            }
            //if(!RootFunction.tables.Where(t => t.PeaopleCanBeSeated == seats).All(t => t.TableTaken != true))
            //{
            //    Console.WriteLine("(!) Visi šio tipo staliukai užimti");
            //    return RootFunction.tables.Where(t => t.PeaopleCanBeSeated == seats).Where(t => t.TableTaken == false).First();
            //}
            else
            {
                return default;
            }
        }

        public static int TableIndexer()
        {
            int indexer = FunctionCalls.tableIndex;
            return indexer;
        }

        public static void SetTableAsTaken()
        {
            RootFunction.tables.Where(t => t.PeaopleCanBeSeated == TableIndexer()).Where(t => t.TableTaken == false).First(t => t.TableTaken = true);
        }
    }
}
