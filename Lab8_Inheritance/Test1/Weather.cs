namespace Lab8_Inheritance;
public class Weather
{
    public static int _degree; 
    public static int _childCounter = 0;
    // 很特別，派生類可以使用他們的類別名稱來呼叫_degree，並且所有派生類都共同使用這個_degree。

    public string? _wind; // "?"：可為null
    public double _humidity;
    private string pri = "cannot"; // 子類還是會繼承，但是我們在子類內無法使用
    protected string pro = "cannot"; // 子類可以繼承，但外界無法直接用.存取。

    public Weather(){} 
    // 如果我們自己定義了別的構造器，預設的無參構造器就不會出來，需要自己寫出來。
    public Weather(int degree) : this(degree, "Uncertainty"){}
    public Weather(int degree, string wind) : this(degree, wind, -1){}
    public Weather(int degree, string wind, int humidity)
    {
         _degree = degree;
         _wind = wind; 
         _humidity = humidity; 
         _childCounter++;
    }

    
}
