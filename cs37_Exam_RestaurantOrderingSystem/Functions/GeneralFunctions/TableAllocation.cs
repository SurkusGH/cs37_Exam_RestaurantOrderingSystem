using cs37_Exam_RestaurantOrderingSystem.Functions.GUI;
using cs37_Exam_RestaurantOrderingSystem.DataType;
using System;
using System.Linq;
using System.Threading;

namespace cs37_Exam_RestaurantOrderingSystem.Functions.GeneralFunctions
{
    public class TableAllocation
    {
        /// <summary>
        /// This method checks if Table is free
        /// </summary>
        /// <param name="seats"></param>
        public static void TableAvailabilityCheck(int seats)
        {
            if (RootFunction.tables.Where(t => t.PeaopleCanBeSeated == seats).All(t => t.TableTaken == true))
            {
                Console.Clear();
                Console.WriteLine($"\n\n(!) Visi {seats} sėdimų vietų staliukai užimti");

                Thread.Sleep(2000);
                RootFunction.MainMenu();
            }
        }

        /// <summary>
        /// This method uses LINQ to automatically select table by seat parameter
        /// </summary>
        /// <param Indicates the table which has cetrain amount of seats="seats"></param>
        /// <returns></returns>
        public static Table_DataType AutomaticTableSelector(int seats)
        {
            if (RootFunction.tables.Where(t => t.PeaopleCanBeSeated == seats).All(t => t.TableTaken != true)
            || !RootFunction.tables.Where(t => t.PeaopleCanBeSeated == seats).All(t => t.TableTaken == false))
            {
                return RootFunction.tables.Where(t => t.PeaopleCanBeSeated == seats).First(t => t.TableTaken == false);
            }
            else
            {
                return default;
            }
        }

        /// <summary>
        /// This method allocates to witch table ordering is made to
        /// </summary>
        /// <returns></returns>
        public static int TableIndexer()
        {
            int indexer = FunctionCalls.tableIndex;
            return indexer;
        }

        /// <summary>
        /// This method sets table as "Taken"
        /// </summary>
        public static void SetTableAsTaken()
        {
            RootFunction.tables.Where(t => t.PeaopleCanBeSeated == TableIndexer()).Where(t => t.TableTaken == false).First(t => t.TableTaken = true);
        }

        /// <summary>
        /// This method sorts and prints taken tables
        /// This method changes tables availability
        /// Clears associated global variables once table is freed
        /// (!) Disobeys single responsibility rule
        /// </summary>
        public static void TableAvailabilityChange()
        {
            var takenTables = (RootFunction.tables.Where(t => t.TableTaken == true));
            Console.WriteLine("Užimti staliukai:");
            foreach (var item in takenTables)
            {
                Console.WriteLine($"#{RootFunction.tables.IndexOf(item)+1} yra { Table_DataType.AvalabilityPrintingHelper(item.TableTaken)}");
            }
            Console.WriteLine("Kūrį staliuką iš jų norėtumėte atlaisvinti?");
            var input = ValidationHelper.InputValidationListGeneric(RootFunction.tables);
            RootFunction.tables[input - 1].TableTaken = false;
            RootFunction.tables[input - 1].Orders.Clear();
            RootFunction.tables[input - 1].OrderSum = 0;
            Console.WriteLine($"\n\n(!) Staliukas #{RootFunction.tables[input - 1].TableID} yra atlaisvinamas");
            Thread.Sleep(2000);

            RootFunction.MainMenu();
        }
    }
}
