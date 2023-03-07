// See https://aka.ms/new-console-template for more information


namespace main
{
    public class Haha
    {
        public static void PrintHaha()
        {
            Console.WriteLine("Haha");
        }
    }
}
namespace another
{
    internal class MainClass
    {
        public static void Main()
        {
            Haha.PrintHaha();
        }
    }
}
