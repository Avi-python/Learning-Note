// See https://aka.ms/new-console-template for more information

using Lab4_delegate;
using System;

/// <summary>
/// This is MainClass
/// <summary>
namespace MainSpace
{
    internal class MainClass
    {
        public delegate void TestMid(string a);
        
        private static void Main()
        {
            
            Tree T1 = new Tree("Chamaecyparis formosensis", 3); // 紅檜木學名
            Tree T2 = new Tree("Taiwan Cypress", 5); // 台灣扁柏
            Weather w1 = new Weather("Dainel");
            

            // 註冊方式一
            // w1.WeatherMother += new Weather.WeatherHandler(T1.WeatherReciever); // 註冊
            // w1.WeatherMother += new Weather.WeatherHandler(T2.WeatherReciever);
            // w1.WeatherMother.Invoke("大雞雞"); // 加上 "event" 關鍵字後就不能調用Invoke了

            // 註冊方式二
            // w1.WeatherMother += T1.WeatherReciever; // 我這樣就可以註冊了!!!!
            // w1.WeatherMother += T2.WeatherReciever;

            // w1.WeatherImplementer("大雷雨"); 
            // w1.WeatherImplementer("陽光明媚");
            // Tester("Good Job", w1.WeatherMother);

            TestMid t1 = T1.WeatherReciever; 
            t1.BeginInvoke();
            // 相當於 TestMid t1 = new TestMid(T1.WeatherReciever);
            // 上面這才是 delegate的實例化方式，"TestMid t1 = T1.WeatherReciever"這是簡寫，系統優化允許的。
            // t1 += T1.WeatherReciever;
            t1.Invoke("my dickson");
        }

        private static void Tester(string input, Weather.WeatherHandler e)
        {
            e.Invoke(input);
            Console.WriteLine("我是代理的代理"); 
        }
    }

    
}

