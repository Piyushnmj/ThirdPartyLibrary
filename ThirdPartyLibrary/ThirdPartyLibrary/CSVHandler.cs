using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.Globalization;

namespace ThirdPartyLibrary
{
    public class CSVHandler
    {
        public void ImplementCSVDataHandling()
        {
            string importFilePath = @"F:\Bridgelabz Codin\ThirdPartyLibrary\ThirdPartyLibrary\ThirdPartyLibrary\Utilities\Address.csv";
            string exportFilePath = @"F:\Bridgelabz Codin\ThirdPartyLibrary\ThirdPartyLibrary\ThirdPartyLibrary\Utilities\ExportAddress.csv";

            Console.WriteLine("\n**********Reading from csv file**********");
            using (var reader = new StreamReader(importFilePath))
            using (var csvImport = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csvImport.GetRecords<AddressBookModel>().ToList();
                Console.WriteLine("\nRead Data Successfully form addresses.csv, here are city:");
                foreach (AddressBookModel addressData in records)
                {
                    Console.WriteLine(addressData.city);
                }

                Console.WriteLine("\n**********Writing to csv file**********");
                using (var writer = new StreamWriter(exportFilePath))
                using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvExport.WriteRecords(records);
                }
            }
        }
    }
}
