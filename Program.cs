// See https://aka.ms/new-console-template for more information
using CountConsole.Services;

Console.WriteLine("Hello, World!");

List<string> input = new List<string>{
 "1","2","3","a","b","d","2","1","1","2","3","5","a","b","c","a","1","2","3","2","3",
};

Functions.GetDistinctValues(input);

var distinctValues = input.Distinct().ToList();

foreach(string val in distinctValues)
{
    var values = input.Where(x => x == val).ToList();
    Console.WriteLine($"{val}:{values.Count}");
}
