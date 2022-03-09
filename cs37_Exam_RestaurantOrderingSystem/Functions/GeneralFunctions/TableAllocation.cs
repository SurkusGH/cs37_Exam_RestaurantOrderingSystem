using cs37_Exam_RestaurantOrderingSystem.CSV_DB.Functions;
using cs37_Exam_RestaurantOrderingSystem.CSV_DB.Functions.GUI;
using cs37_Exam_RestaurantOrderingSystem.DataType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs37_Exam_RestaurantOrderingSystem.Functions.GeneralFunctions
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

        public static void PrintTableAvailability() // <-- perkelti?
        {
            var takenTables = (RootFunction.tables.Where(t => t.TableTaken == true));
            Console.WriteLine("Užimti staliukai:");
            foreach (var item in takenTables)
            {
                Console.WriteLine($"{RootFunction.tables.IndexOf(item)+1} yra { Table_DataType.AvalabilityPrintingHelper(item.TableTaken)}");
            }
            Console.WriteLine("Kūrį staliuką iš jų norėtumėte atlaisvinti?");
            var input = ValidationHelper.InputValidation(6);
            RootFunction.tables[input-1].TableTaken = false;
        }
    }
}
