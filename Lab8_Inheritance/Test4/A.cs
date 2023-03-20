namespace Test4;
using System;
public abstract class A
{
    public virtual void printA()
    {
        Console.WriteLine("A");
    }

    public abstract void printA(string str);
}

public class B : A
{
    public sealed override void printA(){}
    public override void printA(string str)
    {
        Console.WriteLine(str + "BB");
    }
}
public class C : B
{
    public new void printA()
    {
        Console.WriteLine("C");
        // A.printA(); // 是調用B的方法
    }

    public override void printA(string str)
    {
        base.printA(str + "CC"); // base 是調用B的
    }

}
