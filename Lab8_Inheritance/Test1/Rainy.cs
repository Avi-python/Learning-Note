namespace Lab8_Inheritance;
public class Rainy : Weather
{
    public Rainy(int degree) : base(degree){}
    public Rainy(int degree, string wind) : base(degree, wind){}
    public Rainy(int degree, string wind, int humidity) : base(degree, wind, humidity){}

    public string GetTest()
    {
        return pro;
    }

    public static int _degree;
        
    
}
