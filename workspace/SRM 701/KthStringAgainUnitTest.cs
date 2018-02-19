using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(string s, long k,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine("s:{0}", s);
        Console.WriteLine("k:{0}", k);
        }
        string __result = new KthStringAgain().getKth(s, k);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        string s = "xyz";
        Console.WriteLine("s:{0}", s);
        long k = 5L;
        Console.WriteLine("k:{0}", k);
        string __expected = "yzx";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new KthStringAgain().getKth(s, k);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        string s = "abc";
        Console.WriteLine("s:{0}", s);
        long k = 1L;
        Console.WriteLine("k:{0}", k);
        string __expected = "abc";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new KthStringAgain().getKth(s, k);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        string s = "abc";
        Console.WriteLine("s:{0}", s);
        long k = 8L;
        Console.WriteLine("k:{0}", k);
        string __expected = "cba";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new KthStringAgain().getKth(s, k);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        string s = "topcoder";
        Console.WriteLine("s:{0}", s);
        long k = 58L;
        Console.WriteLine("k:{0}", k);
        string __expected = "ooredcpt";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new KthStringAgain().getKth(s, k);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        string s = "aaaabcdeeeghhhhhiijjjkllmmooooqqrrrrssttuuvvvvvwyy";
        Console.WriteLine("s:{0}", s);
        long k = 38517901796974L;
        Console.WriteLine("k:{0}", k);
        string __expected = "aaaacdeehhhijklmmqqrsttvvvvwyyvuusrrrooooljjihhgeb";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new KthStringAgain().getKth(s, k);
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
