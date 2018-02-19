using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int c, int s,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine("c:{0}", c);
        Console.WriteLine("s:{0}", s);
        }
        string __result = new FoxAndCake2().isPossible(c, s);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int c = 74;
        Console.WriteLine("c:{0}", c);
        int s = 109;
        Console.WriteLine("s:{0}", s);
        string __expected = "Possible";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new FoxAndCake2().isPossible(c, s);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int c = 1000000000;
        Console.WriteLine("c:{0}", c);
        int s = 1000000000;
        Console.WriteLine("s:{0}", s);
        string __expected = "Possible";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new FoxAndCake2().isPossible(c, s);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int c = 1;
        Console.WriteLine("c:{0}", c);
        int s = 58;
        Console.WriteLine("s:{0}", s);
        string __expected = "Impossible";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new FoxAndCake2().isPossible(c, s);
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
