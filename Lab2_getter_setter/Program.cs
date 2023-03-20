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

            Person p4 = new Person("p4", 2, true);

            // Plist is property with only getter
            // p4.Plist = null; // Error
            // p4.Plist.Add(3); // accept 

            // Plist is field with readonly
            // p4.Preadonly = null; // Error    
            // p4.Preadonly.Add(2); // accept
            Console.WriteLine((int)'c');
            Person[] a = new Person[5];
            Console.WriteLine(ReferenceEquals(a[0], null));

        }
    }
}
