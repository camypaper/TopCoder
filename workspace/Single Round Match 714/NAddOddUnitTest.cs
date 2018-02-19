using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(long L, long R, int K,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine("L:{0}", L);
        Console.WriteLine("R:{0}", R);
        Console.WriteLine("K:{0}", K);
        }
        long __result = new NAddOdd().solve(L, R, K);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        long L = 5L;
        Console.WriteLine("L:{0}", L);
        long R = 5L;
        Console.WriteLine("R:{0}", R);
        int K = 1;
        Console.WriteLine("K:{0}", K);
        long __expected = 5L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new NAddOdd().solve(L, R, K);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        long L = 1L;
        Console.WriteLine("L:{0}", L);
        long R = 99999L;
        Console.WriteLine("R:{0}", R);
        int K = 99999;
        Console.WriteLine("K:{0}", K);
        long __expected = 0L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new NAddOdd().solve(L, R, K);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        long L = 16L;
        Console.WriteLine("L:{0}", L);
        long R = 17L;
        Console.WriteLine("R:{0}", R);
        int K = 3;
        Console.WriteLine("K:{0}", K);
        long __expected = 9L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new NAddOdd().solve(L, R, K);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        long L = 3L;
        Console.WriteLine("L:{0}", L);
        long R = 7L;
        Console.WriteLine("R:{0}", R);
        int K = 5;
        Console.WriteLine("K:{0}", K);
        long __expected = 4L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new NAddOdd().solve(L, R, K);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        long L = 1645805087361625L;
        Console.WriteLine("L:{0}", L);
        long R = 9060129311830846L;
        Console.WriteLine("R:{0}", R);
        int K = 74935;
        Console.WriteLine("K:{0}", K);
        long __expected = 421014795656548226L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new NAddOdd().solve(L, R, K);
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
