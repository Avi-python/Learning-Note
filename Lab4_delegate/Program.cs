﻿// See https://aka.ms/new-console-template for more information

using Lab4_delegate;
using System;

/// <summary>
/// This is MainClass
/// <summary>
namespace MainSpace
{
    internal class MainClass
    {
        private static void Main()
        {
            Tree T1 = new Tree("Chamaecyparis formosensis", 3); // 紅檜木學名
            Tree T2 = new Tree("Taiwan Cypress", 5); // 台灣扁柏
            Weather w1 = new Weather("Dainel");

            w1.WeatherMother += new Weather.WeatherHandler(T1.WeatherReciever); // 註冊
            w1.WeatherMother += new Weather.WeatherHandler(T2.WeatherReciever);
            w1.WeatherMother.Invoke("大雞雞"); // 加上 "event" 關鍵字後就不能調用Invoke了

            w1.WeatherImplementer("大雷雨");
            // Tester("Good Job", w1.WeatherMother);
        }

        private static void Tester(string input, Weather.WeatherHandler e)
        {
            e.Invoke(input);
            Console.WriteLine("我是代理的代理");
        }
    }

    
}

