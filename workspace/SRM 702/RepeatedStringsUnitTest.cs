using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(string s, int k,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine("s:{0}", s);
        Console.WriteLine("k:{0}", k);
        }
        string __result = new RepeatedStrings().findKth(s, k);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        string s = "()))((()())";
        Console.WriteLine("s:{0}", s);
        int k = 3;
        Console.WriteLine("k:{0}", k);
        string __expected = "(())";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new RepeatedStrings().findKth(s, k);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        string s = "))))))))))))((((((((((";
        Console.WriteLine("s:{0}", s);
        int k = 1;
        Console.WriteLine("k:{0}", k);
        string __expected = "";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new RepeatedStrings().findKth(s, k);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        string s = "(())(()(()))";
        Console.WriteLine("s:{0}", s);
        int k = 1;
        Console.WriteLine("k:{0}", k);
        string __expected = "(((())))";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new RepeatedStrings().findKth(s, k);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        string s = "(())))()((())())";
        Console.WriteLine("s:{0}", s);
        int k = 8;
        Console.WriteLine("k:{0}", k);
        string __expected = "()";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new RepeatedStrings().findKth(s, k);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        string s = "(()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()()())";
        Console.WriteLine("s:{0}", s);
        int k = 64;
        Console.WriteLine("k:{0}", k);
        string __expected = "(((((((((((((()()()())(()()()())))))))))))))";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new RepeatedStrings().findKth(s, k);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example5(bool fast = false)
    {
        Console.WriteLine("Example5");
        string s = "(";
        Console.WriteLine("s:{0}", s);
        int k = 1000000000;
        Console.WriteLine("k:{0}", k);
        string __expected = "";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new RepeatedStrings().findKth(s, k);
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
