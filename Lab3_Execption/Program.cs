// See https://aka.ms/new-console-template for more information

namespace Project
{
    internal class MainClass
    {
        private static void Main()
        {
            int[] arr = new int[20];
            int b = 0;
            int index = 30;
            try
            {
                int a = arr[index];
                int temporary = a / b;
            }
            catch(IndexOutOfRangeException ex)
            {
                System.Console.WriteLine("Errorhoho: {0}", ex.Message);
            }
            catch(DivideByZeroException ex)
            {
                System.Console.WriteLine("Errorhaha: {0}", ex.Message);
            }
        }
    }
}
