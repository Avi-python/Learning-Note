namespace Lab7_OperatorOverloading;
using System;

/// <summary>
/// This is a class about Level, which have three things:
/// </summary>
/// <remarks> 
///     <para>
///         1. When one of two levels low it means low.
///     </para>
///     <para>
///         2. When two levels are all Uncertainty we decide it to be low.
///     </para>
///     <para>
///         3. When one of two levels is Uncertainty, we decide it to be Uncertainty.
///     </para>
///     <para>
///         4. else : when two of them are high it means high.
///     </para>
/// </remarks> 

public class Level
{
    // 這些就是我們內建的狀態
    public static readonly Level High = new Level(1); 
    // 注意，如果不加static就會出現無窮迴圈喔喔，因為會不斷構造在構造
    public static readonly Level Low = new Level(0);
    public static readonly Level Uncertainty = new Level(-1);
    private readonly int _level;
    public int levelAttr
    {
        get
        {
            return _level;
        }
    }
    public Level(int input) 
    { 
        if(input >= 1)
        {
            _level = 1;
        }
        else if(input <= -1)
        {
            _level = -1;
        }
        else if(input == 0)
        {
            _level = 0;
        }
        else
        {
            throw new Exception("input");
        }
    }

    // public static bool operator == (Level l, Level r)
    // {   
    //     // 確認傳進來的參數是否為null，因為如果不進行check，就沒有辦法取值。
    //     bool a = ReferenceEquals(l, null);
    //     bool b = ReferenceEquals(r, null);
        
    //     // 我們也不能使用 == 來進行位址比較，因為 == 已經被重載，會出現無限的遞迴。
    //     // if(l == r && l == null) return true; //無限遞迴


    //     // 實作不出來 => 要去csproj 新增"<AllowUnsafeBlocks> true </AllowUnsafeBlocks>"
    //     // 依然是會overflow
    //     // 會一直顯示p1不存在於目前的內容中
    //     // unsafe
    //     // {
    //     //     Emo *pl = &l;
    //     //     Emo *p2 = &r;
    //     //     // if(l == r) return true;
    //     //     if(p1 == null) return false;
    //     //     if(p2 == null) return false;
    //     // }

    //     if(a && b) return true; // 因為兩個都為null
        
    //     if(a ^ b) return false; // xor

    //     return l._level == r._level;
    // }

    // public static bool operator != (Level l, Level r)
    // {
    //     bool a = ReferenceEquals(null, l), b = ReferenceEquals(null, r);

    //     if(a && b) return false;

    //     if(a ^ b) return true;
        
    //     return l._level != r._level;
    // }

    // // 重頭戲 多載&&，又透過重載false() true()和&來達成
    // // x && y 可以表達成 false(x) ? x : x & y
    // // x || y 可以表達成 true(x) ? x : x | y

    // // 我們要先多載 true(), false()邏輯元運算，因為我們有三個狀態，
    // // 所以我們想要表達的true false不太一樣，透過重載的方式重新定義
    // // 我們的true和false。
    public static bool operator true(Level x)
    {
        return x == High;
    }

    public static bool operator false(Level x)
    {
        // 教程的寫法
        // return x == Uncertainty || x == Low;

        return x == Low;
    }

    // //再來要重載&，就好像我們重新定義了一套"類bool"的值
    // public static Level operator &(Level l, Level r)
    // {
    //     if(l == Low || r == Low || (r == Uncertainty && l == Uncertainty))
    //     {
    //         return Low;
    //     }
    //     else if(l == Uncertainty || r == Uncertainty) 
    //     {
    //         return Uncertainty;
    //     }
    //     else
    //     {
    //         return High;
    //     }

    //     // one line
    //     // return l == Low || r == Low || (l == Uncertainty && r == Uncertainty) 
    //     //        ? Low : (l == Uncertainty || r == Uncertainty)
    //     //        ? Uncertainty : High;
    // }
    // // 重載了 & 和 false() 就可以使用 && 了。



}
