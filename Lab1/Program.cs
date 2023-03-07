// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

namespace Program
{
    internal class Project
    {
        private static void Main()
        {
            Dictionary<string, int> Dict = new Dictionary<string, int>();
            Dict.Add("fuck", 0);
            Dict["fuck"]++;
            Console.WriteLine(Dict.ContainsKey("a"));
            
            Console.ReadKey();
        }
    }
}
