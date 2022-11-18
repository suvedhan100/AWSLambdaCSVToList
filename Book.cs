using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWSLambdaCSVToList
{
    public class Book
    {
        public string name;
        public string age;

        public static Book FromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            Book dailyValues = new Book();
            dailyValues.name = Convert.ToString(values[0]);
            dailyValues.age = Convert.ToString(values[1]);
           
            return dailyValues;
        }
    }
}
