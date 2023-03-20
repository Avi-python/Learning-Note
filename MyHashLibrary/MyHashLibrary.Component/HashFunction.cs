namespace MyHashLibrary.Component;
public static class HashFunction
{
    // 全部寫成static
    private static readonly int[] _primeTable = {1, 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53};
    private static int[] PrimeTable { get{ return _primeTable;} }
    private static int BinerySearchPrime(int num) // 需要修改，因為我們要找到剛不會超過size的prime
    {
        int left = 0;
        int right = PrimeTable.Length;
        int mid;
        while(left < right)
        {
            mid = left + (right - left) / 2;
            if(PrimeTable[mid] >= num) // 從 > 改 >=
            {
                right = mid;
            }
            else
            {
                left = mid + 1;
            }
        }
        try
        {
            if(PrimeTable[left] == num) return PrimeTable[left - 1]; // 如果遇到left = 0該怎麼辦 
        }
        catch(Exception e)
        {
            throw e;
        }
        return PrimeTable[left]; // left == right;  
    }
    public static int DivisionHash(int key, int size)
    {
    //    Console.WriteLine($"{key}, {key % BinerySearchPrime(size)}");
       return (key % BinerySearchPrime(size));
    }
}
