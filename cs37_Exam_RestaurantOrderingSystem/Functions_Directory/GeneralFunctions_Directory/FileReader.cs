using cs37_Exam_RestaurantOrderingSystem.DataType_Directory;
using System;
using System.Collections.Generic;
using System.IO;


namespace cs37_Exam_RestaurantOrderingSystem.Functions_Directory.GeneralFunctions_Directory
{
    public class FileReader
    {
        #region TableDataManipulation
        static string tableDataPath = $@"D:\GitHub\cs37_Exam_RestaurantOrderingSystem\cs37_Exam_RestaurantOrderingSystem\CSV_Directory\Tables.csv";
        public List<Table_DataType> ReadTableData()
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
            table.PeaopleCanBeSeated = int.Parse(tempCache[0]);
            table.TableTaken = bool.Parse(tempCache[1]);
            table.PeaopleCanBeSeated = int.Parse(tempCache[2]);

            return table;
        }
        public static void WriteTableData(List<Table_DataType> tableList) // <-- metodas nenaudojamas
        {
            File.WriteAllText(tableDataPath, string.Empty); // <-- išvalau rinkmėną, pridedu modifikuotą kontentą
            string temporaryString;
            tableList.ForEach(tableData => File.AppendAllText(tableDataPath, $"{tableData.PeaopleCanBeSeated}, " +
                                                                             $"{tableData.TableTaken}, " +
                                                                             $"{tableData.PeaopleCanBeSeated}" +
                                                                             Environment.NewLine));
        }
        #endregion

        #region FoodDataManipulation
        static string foodDataPath = $@"D:\GitHub\cs37_Exam_RestaurantOrderingSystem\cs37_Exam_RestaurantOrderingSystem\CSV_Directory\Food.csv";
        public List<Food_DataType> ReadFoodData()
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
            food.ID = tempCache[0];
            food.Price = decimal.Parse(tempCache[1]);
            food.TimeToPrepare = int.Parse(tempCache[2]);
            food.IsVegan = bool.Parse(tempCache[3]);

            return food;
        }
        public static void WriteFoodData(List<Food_DataType> foodList) // <-- metodas nenaudojamas
        {
            File.WriteAllText(foodDataPath, string.Empty); // <-- išvalau rinkmėną, pridedu modifikuotą kontentą
            string temporaryString;
            foodList.ForEach(foodData => File.AppendAllText(foodDataPath, $"{foodData.ID}, " +
                                                                          $"{foodData.Price}, " +
                                                                          $"{foodData.TimeToPrepare}" +
                                                                          $"{foodData.IsVegan}" +
                                                                          Environment.NewLine));
        }
        #endregion

        #region DrinksDataManipulation
        static string drinksDataPath = $@"D:\GitHub\cs37_Exam_RestaurantOrderingSystem\cs37_Exam_RestaurantOrderingSystem\CSV_Directory\Food.csv";
        public List<Drinks_DataType> ReadDrinksData()
        {
            var csvLineReader = new StreamReader(foodDataPath);

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
            drink.ID = tempCache[0];
            drink.Price = decimal.Parse(tempCache[1]);
            drink.TimeToPrepare = int.Parse(tempCache[2]);
            drink.NoSuggar = bool.Parse(tempCache[3]);

            return drink;
        }
        public static void WriteDrinksData(List<Drinks_DataType> drinksList) // <-- metodas nenaudojamas
        {
            File.WriteAllText(drinksDataPath, string.Empty); // <-- išvalau rinkmėną, pridedu modifikuotą kontentą
            string temporaryString;
            drinksList.ForEach(drinksData => File.AppendAllText(drinksDataPath, $"{drinksData.ID}, " +
                                                                                $"{drinksData.Price}, " +
                                                                                $"{drinksData.TimeToPrepare}" +
                                                                                $"{drinksData.NoSuggar}" +
                                                                                Environment.NewLine));
        }
        #endregion
    }
}
