// See https://aka.ms/new-console-template for more information
using System;
using Lab8_Inheritance;

internal class MainClass
{
    public static void Main()
    {
        Sunny day1 = new Sunny(20);
        Sunny day2 = new Sunny(30);
        Rainy day3 = new Rainy(15); 
        // 很奇妙，這邊會執行到 Weather 的 static int _degree = 15;
        // 然而不同基底的但是 static int _degree會使得 Sunny 用到父類的 _degree。 

        day2.SoHot(50);
        Console.WriteLine(Sunny._degree);
        Console.WriteLine(Rainy._degree);
        Console.WriteLine(Weather._childCounter);
        Console.WriteLine(day3.GetTest());
        // 而我們Rainy 有自己的 static in _degree，但最初建構子設定的是基底的字段而不是自己本身的。
        // Console.WriteLine(day2._degree);
    }
}
