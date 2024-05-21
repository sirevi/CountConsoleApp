using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountConsole.Services
{
    public class Functions
    {
        public static List<string> GetDistinctValues(List<string> data)
        {
            List<string> output = new List<string>();

            foreach(string val in data)
            {
                if (!output.Contains(val))
                {
                    output.Add(val);
                    Console.WriteLine($"GetDistinctValues: {val}");
                }
            }
            return output;
        }
    }
}