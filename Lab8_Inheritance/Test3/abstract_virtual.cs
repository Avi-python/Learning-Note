namespace Test3;
using System;
public class D
{
    public virtual void DoWork(int i)
    {
       Console.WriteLine("DoWork in D:{0}", i); 
    }
}

public abstract /*override*/ class E : D // 不加那個override 就會顯示 "'E.DoWork(int)' 會隱藏繼承的成員"
{
    public abstract void DoWork(int i);
}

public class F : E
{
    public override void DoWork(int i)
    {
        // New implementation.
        Console.WriteLine("DoWork in F:{0}", i); 
    }
}
