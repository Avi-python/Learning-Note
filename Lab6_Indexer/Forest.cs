namespace Lab6_Indexer;
using System;
public class Forest
{   
    private readonly int _area = 0;
    public readonly string _name;
    private readonly bool _developing; 
    public int Area
    {
        set
        {
            if(value < 0)
            {
                throw new IndexOutOfRangeException("value");
            }
        }
        get
        {
            return _area;
        }
    }
    public int Num
    {
        get
        {
            Tree it = _start;
            int tmp = 0;
            while(it != null)
            {
                it = it.Next;
                tmp++;
            }
            return tmp;
        }
    }

    public Tree _start;

    public Tree this[int index]
    {
        get
        {
            if(index < 0 || index >= this.Num)
            {
                throw new IndexOutOfRangeException("index");
            }
            else
            {
                int cnt = 0;
                Tree it = _start;
                for(; it != null && cnt != index; it = it.Next)
                {
                    cnt++;
                }
                return it; 
            }
        }
        set
        {
            if(index < 0 || index >= this.Num)
            {
                throw new IndexOutOfRangeException("index");
            }
            else // 這邊或許需要再加一個檢查value型別的東西
            {
                if(index == 0)
                {   
                    value.Next = _start.Next;
                    _start = value;
                }
                else
                {
                    Tree cur = _start.Next, pre = _start;
                    int tmp = 0;
                    while(tmp != index && cur.Next != null)
                    {
                        pre = cur;
                        cur = cur.Next;
                        tmp++;
                    }
                    value.Next = cur.Next;
                    pre.Next = value;
                }
            }
        }
    }

    // 需要構造器建立一串樹
    public Forest(string name) : this(name, 0){}

    public Forest(int area) : this("<unknown>", area, false, new Tree()){}

    public Forest(string name, int area) : this(name, area, true, new Tree()){}

    public Forest(string name, int area, bool developing, Tree head)
    {
        _name = name;
        _area = area;
        _developing = developing;
        _start = head; 
    }

    public void AddTree(string name, int height)
    {
        Tree it = _start;
        while(it.Next != null)
        {
            it = it.Next;
        }
        it.Next = new Tree(name, height);
    }
    
}
