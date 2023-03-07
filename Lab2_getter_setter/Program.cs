// See https://aka.ms/new-console-template for more information
using System;

namespace MainSpace
{
    internal class MainClass
    {
        private static void Main()
        {
            WaterBottle b1 = new WaterBottle("LittleGreen", 100, true);
            b1.PrintWater();
            // b1.ingredient.Add(1);
            
            Person p2 = Person.DefaultInstance; // 單例模式，一種設計方式。
            p2.PrintPerson();
            p2.name = "Daniel";
            p2.height = 322;
            p2.PrintPerson();

            Person p3 = Person.DefaultInstance;
            p3.height = 123;
            p3.PrintPerson();
        }
    }
}
