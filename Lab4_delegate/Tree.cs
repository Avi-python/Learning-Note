namespace Lab4_delegate;
using System;
public class Tree
{
    private string _name{set; get;}
    private int _height{set; get;} // meter

    public int Height
    {
        set
        {
            if(value < 0)
            {
                throw new ArgumentException("value");
            }
            else
            {
                _height = Height;
            }
        }
        get
        {
            return _height;
        }
    }

    public Tree(string name, int height)
    {
        _name = name;
        _height = height;
    }


    public void WeatherReciever(string input)
    {
        System.Console.WriteLine("My name is {0}. Oh, it's {1}.", this._name, input);
    }

}

