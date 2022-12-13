using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdPartyLibrary
{
    public class JSON_TO_CSV_Converter
    {
        public void ImplementJSONTOCSV()
        {
            string importFilePath = @"F:\Bridgelabz Codin\ThirdPartyLibrary\ThirdPartyLibrary\ThirdPartyLibrary\Utilities\ExportJson.json";
            string exportFilePath = @"F:\Bridgelabz Codin\ThirdPartyLibrary\ThirdPartyLibrary\ThirdPartyLibrary\Utilities\ExportCsv.csv";

            Console.WriteLine("\n**********Reading from json file**********");
            IList<AddressBookModel> addressData = JsonConvert.DeserializeObject<IList<AddressBookModel>>(File.ReadAllText(importFilePath));
            foreach (AddressBookModel Data in addressData)
            {
                Console.Write(Data.firstName + "\t");
                Console.Write(Data.lastName + "\t");
                Console.Write(Data.address + "\t");
                Console.Write(Data.city + "\t");
                Console.Write(Data.state + "\t");
                Console.Write(Data.code + "\t");
                Console.WriteLine();
            }

            Console.WriteLine("\n**********Writing to csv file**********");
            using (var writer = new StreamWriter(exportFilePath))
            using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csvExport.WriteRecords(addressData);
            }
        }
    }
}
