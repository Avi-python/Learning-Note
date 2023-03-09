namespace Lab4_delegate;
public class Weather
{
    private string nickName;
    public delegate void WeatherHandler(string input);
    public event WeatherHandler WeatherMother; 
    // event 關鍵字是可以避免WetherMother在外面使用Invoke調用或是賦值。

    public Weather(string _nickName)
    {
        nickName = _nickName;
    }
    // Implement
    public void WeatherImplementer(string input)
    {
        WeatherMother.Invoke(input);
    }
}
