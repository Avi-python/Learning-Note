namespace MyHashLibrary.Component;
using System;
public abstract class HashTable
{
    protected int[] _array;
    protected bool[] _check;
    protected int _tableSize;
    protected int[] Array { get { return _array; } set{ _array = value; } }
    protected bool[] Check { get { return _check; } set{ _check = value; } }
    public delegate int HashFunction(int key, int size);

    // abstract 可以修飾屬性
    public int TableSize { get { return _tableSize; } }

    public abstract void StartHash(int[] array, HashFunction hFun);
    // public abstract void Add(int n);
    public virtual void ShowTable()
    {
        if(TableSize <= 0) throw new Exception("tablesize = 0");
        Console.Write($"[{Array[0]}");
        for(int i = 1; i < TableSize; i++)
        {
            Console.Write($", {Array[i]}");
        }
        Console.WriteLine("]");
    }
    public abstract int this[int n] { get; } // 索引器

    protected HashTable() {} // 無參構造器 // 把預設構造器藏起來
    public HashTable(int tableSize)
    {   
        // if(array == null) throw new NullReferenceException("array");
        _tableSize = tableSize;
        _array = new int[tableSize];
        // _array = new T[_tableSize]; 因為我們需要把它給我們的data hash進我們的裡面。
        _check = new bool[_tableSize];
    }
}
