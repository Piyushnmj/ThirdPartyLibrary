namespace ThirdPartyLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom to File Converted Program");

            Console.WriteLine("\n\nCSV to CSV ===>");
            CSVHandler objCsv = new CSVHandler();
            objCsv.ImplementCSVDataHandling();

            Console.WriteLine("\n\nCSV To Json ===>");
            CSV_TO_JSON_Converter objCsvToJson = new CSV_TO_JSON_Converter();
            objCsvToJson.ImplementCSVTOJSON();

            Console.WriteLine("\n\nJson To CSV ===>");
            JSON_TO_CSV_Converter objJsonToCsv = new JSON_TO_CSV_Converter();
            objJsonToCsv.ImplementJSONTOCSV();
        }
    }
}