// using System.Collections;

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
        public readonly List<int> ingredient; // ingredient 這個變數的本身無法指向其他。
        public List<int> history{get;} // history這個list可以做Add或之類的操作，比readonly寬鬆一點。

        public WaterBottle(string _name, int _size, bool _isIron)
        {
            name = _name;
            size = _size;
            isIron = _isIron;
            ingredient = new List<int>();
        } 

        public void PrintWater()
        {
            Console.WriteLine("Bottle name: {0}, Size: {1}, Is Iron? {2}", this.name, this.size, this.isIron ? "Yes" : "No");
        }
        
    }
}