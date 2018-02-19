using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int N, int K,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine("K:{0}", K);
        }
        int __result = new PrimeCompositeGame().theOutcome(N, K);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int N = 3;
        Console.WriteLine("N:{0}", N);
        int K = 2;
        Console.WriteLine("K:{0}", K);
        int __expected = 1;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new PrimeCompositeGame().theOutcome(N, K);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int N = 58;
        Console.WriteLine("N:{0}", N);
        int K = 1;
        Console.WriteLine("K:{0}", K);
        int __expected = 0;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new PrimeCompositeGame().theOutcome(N, K);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int N = 30;
        Console.WriteLine("N:{0}", N);
        int K = 3;
        Console.WriteLine("K:{0}", K);
        int __expected = -2;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new PrimeCompositeGame().theOutcome(N, K);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        int N = 6;
        Console.WriteLine("N:{0}", N);
        int K = 3;
        Console.WriteLine("K:{0}", K);
        int __expected = 1;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new PrimeCompositeGame().theOutcome(N, K);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        int N = 526;
        Console.WriteLine("N:{0}", N);
        int K = 58;
        Console.WriteLine("K:{0}", K);
        int __expected = 19;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new PrimeCompositeGame().theOutcome(N, K);
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
