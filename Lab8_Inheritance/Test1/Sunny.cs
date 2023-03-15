namespace Lab8_Inheritance;
public class Sunny : Weather
{
    // 繼承Weather 之後，我之需要定義建構子就好，Weather 的 field會繼承下來
    public Sunny(int degree) : base(degree){}
    public Sunny(int degree, string wind) : base(degree, wind){}
    public Sunny(int degree, string wind, int humidity) : base(degree, wind, humidity){}

    public void SoHot(int add)
    {
        _degree += add;
    }
    // public int _degree
    // 測試，如果我有一個同名的field in Sunny
    // 結果，取 Sunny._degree 會出現 Sunny自己的_degree而不是父類別的。

    // public new int _degree; 
    // 因為他和父類的_degree同名，所以會影藏父類的而顯示自己，
    // 使用new關鍵字來表明我就是要用我自己的隱藏父類的。
}
