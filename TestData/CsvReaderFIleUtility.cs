using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;

namespace UnitTestProject1
{
    public class CsvReaderFileUtility
    {
        public static List<DataModel> ReadTestData(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                return new List<DataModel>(csv.GetRecords<DataModel>());
            }

        }
    }
}
