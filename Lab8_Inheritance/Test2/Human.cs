namespace Test2;
public abstract class Person // 可以加abstract修飾，但我們就沒有辦法建立一個Person實體，他只是一個提供資料的來源
{
    protected string ssn = "444-55-6666";
    protected string name = "John L. Malgraine";
    public virtual void GetInfo()
    {
        Console.WriteLine("Name: {0}", name);
        Console.WriteLine("SSN: {0}", ssn);
    }
}
class Employee : Person
{
    public string id = "ABC567EFG";

    public override void GetInfo()
    {
        base.GetInfo(); // Calling the base class GetInfo method.

        Console.WriteLine("Employee ID: {0}", id);
    }
}


