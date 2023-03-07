namespace MainSpace
{
    /// <summery>
    /// Create a Water Bottle.
    /// </summery>
    internal class WaterBottle
    {
        public readonly string name;
        public readonly int size;
        public readonly bool isIron;
        public bool haveWater;

        public WaterBottle(string _name, int _size, bool _isIron)
        {
            name = _name;
            size = _size;
            isIron = _isIron;
        } 

        
    }
}