using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(long a, long b, long jLen, long bLen,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine("a:{0}", a);
        Console.WriteLine("b:{0}", b);
        Console.WriteLine("jLen:{0}", jLen);
        Console.WriteLine("bLen:{0}", bLen);
        }
        int __result = new TheLuckyGameDivOne().find(a, b, jLen, bLen);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        long a = 1L;
        Console.WriteLine("a:{0}", a);
        long b = 10L;
        Console.WriteLine("b:{0}", b);
        long jLen = 2L;
        Console.WriteLine("jLen:{0}", jLen);
        long bLen = 1L;
        Console.WriteLine("bLen:{0}", bLen);
        int __expected = 0;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new TheLuckyGameDivOne().find(a, b, jLen, bLen);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        long a = 1L;
        Console.WriteLine("a:{0}", a);
        long b = 100L;
        Console.WriteLine("b:{0}", b);
        long jLen = 100L;
        Console.WriteLine("jLen:{0}", jLen);
        long bLen = 100L;
        Console.WriteLine("bLen:{0}", bLen);
        int __expected = 6;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new TheLuckyGameDivOne().find(a, b, jLen, bLen);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        long a = 4L;
        Console.WriteLine("a:{0}", a);
        long b = 8L;
        Console.WriteLine("b:{0}", b);
        long jLen = 3L;
        Console.WriteLine("jLen:{0}", jLen);
        long bLen = 2L;
        Console.WriteLine("bLen:{0}", bLen);
        int __expected = 1;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new TheLuckyGameDivOne().find(a, b, jLen, bLen);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        long a = 1L;
        Console.WriteLine("a:{0}", a);
        long b = 100L;
        Console.WriteLine("b:{0}", b);
        long jLen = 75L;
        Console.WriteLine("jLen:{0}", jLen);
        long bLen = 50L;
        Console.WriteLine("bLen:{0}", bLen);
        int __expected = 2;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new TheLuckyGameDivOne().find(a, b, jLen, bLen);
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
