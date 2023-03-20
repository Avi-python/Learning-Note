namespace MyHashLibrary.Component;
// 我有個大膽的想法
// 或許 class 應該是 Open-addressing 的方式
// 而我們用 delegate的方式可以決定我要使用時麼hashing function。


public sealed class LinearProbingTable : HashTable // 我的繼承到這邊 
{ // 嘗試複寫 == !=   
    public LinearProbingTable(int size) : base(size) {}
    public sealed override void StartHash(int[] inputArr, HashFunction hFun) // 可以傳入我要使用的邏輯
    {
        int hashResult, j = 0;
        for(int i = 0; i < inputArr.Length; i++)
        {
            hashResult = hFun.Invoke(inputArr[i], TableSize); // 有隱患是因為，我們tableSize不能隨便改變，因為會影響到hash的結果
            j = 0;
            if(Check[hashResult])
            {
                j++;
                while(Check[hashResult + j]) // 可以這樣寫嗎?
                {
                    j++;
                }
            }
            Array[hashResult + j] = inputArr[i]; // 目前我只是要看結果而已
            Check[hashResult + j] = true;
        }
    }

    // public sealed override void Add(int n)
    // {
        
    // }

    public sealed override int this[int n] 
    {
        get
        {
            if(n < 0 || n >= TableSize - 1) throw new ArgumentOutOfRangeException("n");
            else return Array[n];
        }
    }

}
