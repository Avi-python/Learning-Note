// See https://aka.ms/new-console-template for more information
using Test4;
namespace MainSpace
{
    internal class MainClass
    {
        private static void Main()
        {
            C c = new C();
            c.printA();
            Console.WriteLine(c is A);
            c.printA("daniel");
        }
    }
}
