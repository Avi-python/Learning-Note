namespace MainSpace
{
    /// <summery>
    /// Create a Water Bottle.
    /// </summery>
    internal class Person
    {
        public static readonly Person DefaultInstance = new Person(); // 大家都會使用同一個默認個體
        public string name;
        public int height;
        public bool isBoy;

        public Person(string _name, int _height, bool _isBoy)
        {
            name = _name;
            height = _height;
            isBoy = _isBoy;
        } 

        private Person() {} // 使用DefaultInstance的方式，可以避免大家使用這個最初模式

        public void PrintPerson()
        {
            Console.WriteLine("Bottle name: {0}, Size: {1}, Is Iron? {2}", this.name, this.height, this.isBoy ? "Yes" : "No");
        }
        
    }
}