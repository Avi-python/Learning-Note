// See https://aka.ms/new-console-template for more information
using Lab7_OperatorOverloading;
using System;
internal class MainClass
{
    private static void Main()
    {
        Level l1 = new Level(1);
        Level l2 = new Level(1);
        // p1 = null;
        // unsafe
        // {
        //     // Emo *p = &p1;
        //     Console.Write((long)(&p1)); // 應該說，內容雖然是空的，但位址、空間依然在。
        // }
        // Console.WriteLine((l1 && l2).levelAttr);
        
        Console.WriteLine((l1) ? "hight" : "Low");
        // 我猜當我們寫 object ? ..時，前面就會調用 false()或是true()其中一個來達到判斷。
        // 只有當我們同時重載了false(), true()，使用 object() 編譯器才會給過。
    }
}

