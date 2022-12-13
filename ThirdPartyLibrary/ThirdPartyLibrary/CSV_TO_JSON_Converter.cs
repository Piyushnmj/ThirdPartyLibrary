using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdPartyLibrary
{
    public class CSV_TO_JSON_Converter
    {
        public void ImplementCSVTOJSON()
        {
            string importFilePath = @"F:\Bridgelabz Codin\ThirdPartyLibrary\ThirdPartyLibrary\ThirdPartyLibrary\Utilities\Address.csv";
            string exportFilePath = @"F:\Bridgelabz Codin\ThirdPartyLibrary\ThirdPartyLibrary\ThirdPartyLibrary\Utilities\ExportJson.json";

            Console.WriteLine("\n**********Reading from csv file**********");
            using (var reader = new StreamReader(importFilePath))
            using (var csvImport = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csvImport.GetRecords<AddressBookModel>().ToList();
                Console.WriteLine("\nRead data Successfully from addresses.csv");
                foreach (AddressBookModel addressData in records)
                {
                    Console.Write("\t" + addressData.firstName);
                    Console.Write("\t" + addressData.lastName);
                    Console.Write("\t" + addressData.address);
                    Console.Write("\t" + addressData.city);
                    Console.Write("\t" + addressData.state);
                    Console.Write("\t" + addressData.code);
                    Console.WriteLine();
                }
                
                Console.WriteLine("\n**********Writing to json file**********");
                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(exportFilePath))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, records);
                }
            }
        }
    }
}
