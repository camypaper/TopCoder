using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int n, int m,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine("n:{0}", n);
        Console.WriteLine("m:{0}", m);
        }
        int __result = new DerangementsStrikeBack().count(n, m);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int n = 0;
        Console.WriteLine("n:{0}", n);
        int m = 3;
        Console.WriteLine("m:{0}", m);
        int __expected = 3;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new DerangementsStrikeBack().count(n, m);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int n = 1;
        Console.WriteLine("n:{0}", n);
        int m = 3;
        Console.WriteLine("m:{0}", m);
        int __expected = 9;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new DerangementsStrikeBack().count(n, m);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int n = 3;
        Console.WriteLine("n:{0}", n);
        int m = 3;
        Console.WriteLine("m:{0}", m);
        int __expected = 73;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new DerangementsStrikeBack().count(n, m);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        int n = 4;
        Console.WriteLine("n:{0}", n);
        int m = 1;
        Console.WriteLine("m:{0}", m);
        int __expected = 4;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new DerangementsStrikeBack().count(n, m);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        int n = 70;
        Console.WriteLine("n:{0}", n);
        int m = 39;
        Console.WriteLine("m:{0}", m);
        int __expected = 319676671;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new DerangementsStrikeBack().count(n, m);
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
