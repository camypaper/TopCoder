using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(long[] R,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine(string.Format("R:{0}", string.Join(" ",R)));
        }
        int __result = new YetAnotherORProblem().countSequences(R);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        long[] R = new long[] {
            3L,
            5L
        };
        Console.WriteLine(string.Format("R:{0}", string.Join(" ", R)));
        int __expected = 15;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new YetAnotherORProblem().countSequences(R);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        long[] R = new long[] {
            3L,
            3L,
            3L
        };
        Console.WriteLine(string.Format("R:{0}", string.Join(" ", R)));
        int __expected = 16;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new YetAnotherORProblem().countSequences(R);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        long[] R = new long[] {
            1L,
            128L
        };
        Console.WriteLine(string.Format("R:{0}", string.Join(" ", R)));
        int __expected = 194;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new YetAnotherORProblem().countSequences(R);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        long[] R = new long[] {
            26L,
            74L,
            25L,
            30L
        };
        Console.WriteLine(string.Format("R:{0}", string.Join(" ", R)));
        int __expected = 8409;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new YetAnotherORProblem().countSequences(R);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        long[] R = new long[] {
            1000000000L,
            1000000000L
        };
        Console.WriteLine(string.Format("R:{0}", string.Join(" ", R)));
        int __expected = 420352509;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new YetAnotherORProblem().countSequences(R);
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
