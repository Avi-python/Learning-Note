// See https://aka.ms/new-console-template for more information
using System;
using Lab6_Indexer;
namespace MainSpace
{
    internal class MainClass
    {
        private static void Main()
        {
            Forest F1 = new Forest("Dickson");
        
            F1.AddTree("Fucker", 2);  

            Console.WriteLine("This is \"{0}\" Forest, with area:{1}.", F1._name, F1.Area);
            Console.WriteLine($"I have {F1.Num} Trees.");
            Console.WriteLine($"I am Tree:{F1[1].Name} in the Forest:{F1._name}. "
                            +$"I have height:{F1[1].Height} meters");
            F1[0] = new Tree("Goomer", 3);
            Console.WriteLine($"I am Tree:{F1[0].Name} in the Forest:{F1._name}. "
                            +$"I have height:{F1[0].Height} meters");
        }
    }
}
