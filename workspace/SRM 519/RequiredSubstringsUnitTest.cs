using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(string[] words, int C, int L,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine(string.Format("words:{0}", string.Join(" ",words)));
        Console.WriteLine("C:{0}", C);
        Console.WriteLine("L:{0}", L);
        }
        int __result = new RequiredSubstrings().solve(words, C, L);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        string[] words = new string[] {
            "a",
            "aa",
            "aaa",
            "aaaa"
        };
        Console.WriteLine(string.Format("words:{0}", string.Join(" ", words)));
        int C = 2;
        Console.WriteLine("C:{0}", C);
        int L = 3;
        Console.WriteLine("L:{0}", L);
        int __expected = 50;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new RequiredSubstrings().solve(words, C, L);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        string[] words = new string[] {
            "abcdefgh"
        };
        Console.WriteLine(string.Format("words:{0}", string.Join(" ", words)));
        int C = 0;
        Console.WriteLine("C:{0}", C);
        int L = 7;
        Console.WriteLine("L:{0}", L);
        int __expected = 31810104;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new RequiredSubstrings().solve(words, C, L);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        string[] words = new string[] {
            "abcdefgh"
        };
        Console.WriteLine(string.Format("words:{0}", string.Join(" ", words)));
        int C = 1;
        Console.WriteLine("C:{0}", C);
        int L = 7;
        Console.WriteLine("L:{0}", L);
        int __expected = 0;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new RequiredSubstrings().solve(words, C, L);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        string[] words = new string[] {
            "a",
            "b",
            "c",
            "d"
        };
        Console.WriteLine(string.Format("words:{0}", string.Join(" ", words)));
        int C = 3;
        Console.WriteLine("C:{0}", C);
        int L = 3;
        Console.WriteLine("L:{0}", L);
        int __expected = 24;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new RequiredSubstrings().solve(words, C, L);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        string[] words = new string[] {
            "ab",
            "bc",
            "xy",
            "yz"
        };
        Console.WriteLine(string.Format("words:{0}", string.Join(" ", words)));
        int C = 2;
        Console.WriteLine("C:{0}", C);
        int L = 3;
        Console.WriteLine("L:{0}", L);
        int __expected = 2;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new RequiredSubstrings().solve(words, C, L);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    bool check(double ex, double res)
    {
        var d = Math.Abs(res - ex);
        if (d <= 1e-9) return true;
        d /= Math.Abs(ex);
        if (d <= 1e-9) return true;
        return false;
    }
    bool check(double[] ex, double[] res)
    {
        if (ex.Length != res.Length) return false;
        for (int i = 0; i < ex.Length; i++)
            if (!check(ex[i], res[i])) return false;
        return true;
    }
    bool check<T>(T ex, T res)
        where T : IComparable<T>
    {
        return ex.CompareTo(res) == 0;
    }
    bool check<T>(T[] ex, T[] res)
        where T : IComparable<T>
    {
        if (ex.Length != res.Length) return false;
        for (int i = 0; i < ex.Length; i++)
            if (!check(ex[i], res[i])) return false;
        return true;
    }
}
