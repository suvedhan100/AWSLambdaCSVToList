using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace AWSLambdaCSVToList
{
    public class Function
    {
        
        /// <summary>
        /// A simple function that takes a string and returns both the upper and lower case version of the string.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public List<Book> FunctionHandler(string input, ILambdaContext context)
        {
            List<Book> values = File.ReadAllLines("D:\\Projects\\Sample Code For Works\\Book1.csv")
                                          .Skip(1)
                                          .Select(v => Book.FromCsv(v))
                                          .ToList();
           
            return values;
        }

    }

    
}
