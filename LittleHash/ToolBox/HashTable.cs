namespace ToolBox;
using System;
public abstract class HashTable 
{
    protected int[] _array;

    protected readonly int _tableSize;
    public int TableSize
    {
        get
        {
            return _tableSize;
        }
    }

    public HashTable() {} // 無餐構造器
    public HashTable(int tableSize, int[] array)
    {   
        if(array == null) throw new NullReferenceException("array");
        _tableSize = tableSize;
        _array = array;
    }
}
