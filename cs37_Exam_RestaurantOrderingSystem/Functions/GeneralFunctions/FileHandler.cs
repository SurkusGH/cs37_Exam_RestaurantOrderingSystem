using cs37_Exam_RestaurantOrderingSystem.DataType;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace cs37_Exam_RestaurantOrderingSystem.Functions.GeneralFunctions
{
    public class FileHandler
    {
        #region PathsForFiles_WinOS_MacOS
        //WinOS
        static string tableDataPath = $@"D:\GitHub\cs37_Exam_RestaurantOrderingSystem\cs37_Exam_RestaurantOrderingSystem\CSV_DB\Tables.csv";
        static string foodDataPath = $@"D:\GitHub\cs37_Exam_RestaurantOrderingSystem\cs37_Exam_RestaurantOrderingSystem\CSV_DB\Food.csv";
        static string drinksDataPath = $@"D:\GitHub\cs37_Exam_RestaurantOrderingSystem\cs37_Exam_RestaurantOrderingSystem\CSV_DB\Drinks.csv";
        //MacOS
        //static string tableDataPath = $@"/Users/surkus/GitHub/cs37_Exam_RestaurantOrderingSystem/cs37_Exam_RestaurantOrderingSystem/CSV_DB/Tables.csv";
        //static string foodDataPath = $@"/Users/surkus/GitHub/cs37_Exam_RestaurantOrderingSystem/cs37_Exam_RestaurantOrderingSystem/CSV_DB/Food.csv";
        //static string drinksDataPath = $@"/Users/surkus/GitHub/cs37_Exam_RestaurantOrderingSystem/cs37_Exam_RestaurantOrderingSystem/CSV_DB/Drinks.csv";
        #endregion

        #region TableDataManipulation
        public static List<Table_DataType> ReadTableData()
        {
            var csvLineReader = new StreamReader(tableDataPath);

            var tableData = new List<Table_DataType>();

            while (!csvLineReader.EndOfStream)
            {
                var line = csvLineReader.ReadLine();
                string[] tempCache = line.Split(", ");

                tableData.Add(TableDataParserHelper(tempCache));
            }
            csvLineReader.Close();
            return tableData;
        }
        public static Table_DataType TableDataParserHelper(string[] tempCache)
        {
            var table = new Table_DataType();
            table.TableID = tempCache[0];
            table.PeaopleCanBeSeated = int.Parse(tempCache[1]);
            table.TableTaken = bool.Parse(tempCache[2]);
            table.OrderSum = decimal.Parse(tempCache[3]);
            table.Orders = tempCache[4].Split("> ").ToList();

            return table;
        }
        public static void WriteTableData(List<Table_DataType> tableList) // <-- metodas nenaudojamas
        {
            string tempString = "";
            File.WriteAllText(tableDataPath, string.Empty); // <-- išvalau rinkmeną, pridedu modifikuotą kontentą
            tableList.ForEach(tableData => File.AppendAllText(tableDataPath, $"{tableData.TableID}, " +
                                                                             $"{tableData.PeaopleCanBeSeated}, " +
                                                                             $"{tableData.TableTaken}, " +
                                                                             $"{tableData.PeaopleCanBeSeated}" +
                                                                             $"{tempString = string.Join("> ", tableData.Orders.ToArray())}" +
                                                                             Environment.NewLine));
        }
        #endregion

        #region FoodDataManipulation
        public static List<Food_DataType> ReadFoodData()
        {
            var csvLineReader = new StreamReader(foodDataPath);

            var foodData = new List<Food_DataType>();

            while (!csvLineReader.EndOfStream)
            {
                var line = csvLineReader.ReadLine();
                string[] tempCache = line.Split(", ");

                foodData.Add(FoodDataParserHelper(tempCache));
            }
            csvLineReader.Close();
            return foodData;
        }
        public static Food_DataType FoodDataParserHelper(string[] tempCache)
        {
            var food = new Food_DataType();
            food.ID = int.Parse(tempCache[0]);
            food.Price = decimal.Parse(tempCache[1]);
            food.TimeToPrepare = int.Parse(tempCache[2]);
            food.IsVegan = bool.Parse(tempCache[3]);
            food.ItemsSold = int.Parse(tempCache[4]);

            return food;
        }
        public static void WriteFoodData(List<Food_DataType> foodList) // <-- metodas nenaudojamas
        {
            File.WriteAllText(foodDataPath, string.Empty); // <-- išvalau rinkmeną, pridedu modifikuotą kontentą
            foodList.ForEach(foodData => File.AppendAllText(foodDataPath, $"{foodData.ID}, " +
                                                                          $"{foodData.Price}, " +
                                                                          $"{foodData.TimeToPrepare}" +
                                                                          $"{foodData.IsVegan}" +
                                                                          $"{foodData.ItemsSold}" +
                                                                          Environment.NewLine));
        }
        #endregion

        #region DrinksDataManipulation
        public static List<Drinks_DataType> ReadDrinksData()
        {
            var csvLineReader = new StreamReader(drinksDataPath);

            var drinksData = new List<Drinks_DataType>();

            while (!csvLineReader.EndOfStream)
            {
                var line = csvLineReader.ReadLine();
                string[] tempCache = line.Split(", ");

                drinksData.Add(DrinksDataParserHelper(tempCache));
            }
            csvLineReader.Close();
            return drinksData;
        }
        public static Drinks_DataType DrinksDataParserHelper(string[] tempCache)
        {
            var drink = new Drinks_DataType();
            drink.ID = int.Parse(tempCache[0]);
            drink.Price = decimal.Parse(tempCache[1]);
            drink.TimeToPrepare = int.Parse(tempCache[2]);
            drink.NoSuggar = bool.Parse(tempCache[3]);
            drink.ItemsSold = int.Parse(tempCache[4]);

            return drink;
        }
        public static void WriteDrinksData(List<Drinks_DataType> drinksList) // <-- metodas nenaudojamas
        {
            File.WriteAllText(drinksDataPath, string.Empty); // <-- išvalau rinkmeną, pridedu modifikuotą kontentą
            drinksList.ForEach(drinksData => File.AppendAllText(drinksDataPath, $"{drinksData.ID}, " +
                                                                                $"{drinksData.Price}, " +
                                                                                $"{drinksData.TimeToPrepare}" +
                                                                                $"{drinksData.NoSuggar}" +
                                                                                $"{drinksData.ItemsSold}" +
                                                                                Environment.NewLine));
        }
        #endregion
    }
}
