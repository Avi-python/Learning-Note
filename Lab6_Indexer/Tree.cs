namespace Lab6_Indexer;
using System;
public class Tree
{
    private string _name;
    private int _height; // meter
    private Tree _next; 
    public Tree Next
    { 
        get 
        { 
            return _next; 
        }
        set
        {
            // if(value == null) throw new NullReferenceException("value");
            _next = value; 
            // 如果 _next 加上 readonly 修飾，將沒有辦法進行賦值even我們在class裡面
        }
    }

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

    public string Name
    {
        get
        {
            return _name;
        }    
    }

    public Tree() : this(1){}
    public Tree(int height) : this("unknown", height, null){}
    public Tree(string name, int height) : this(name, height, null){}
    public Tree(string name, int height, Tree next)
    {
        _name = name;
        _height = height;
        _next = next;
    }


    public void WeatherReciever(string input)
    {
        System.Console.WriteLine("My name is {0}. Oh, it's {1}.", this._name, input);
    }

}


