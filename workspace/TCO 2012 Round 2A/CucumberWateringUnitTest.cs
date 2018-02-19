using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int[] x, int K,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine(string.Format("x:{0}", string.Join(" ",x)));
        Console.WriteLine("K:{0}", K);
        }
        long __result = new CucumberWatering().theMin(x, K);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int[] x = new int[] {
            0,
            6,
            8,
            2
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int K = 2;
        Console.WriteLine("K:{0}", K);
        long __expected = 6L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new CucumberWatering().theMin(x, K);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int[] x = new int[] {
            -1000000000,
            1000000000,
            0
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int K = 1;
        Console.WriteLine("K:{0}", K);
        long __expected = 3000000000L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new CucumberWatering().theMin(x, K);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int[] x = new int[] {
            58,
            2012
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int K = 50;
        Console.WriteLine("K:{0}", K);
        long __expected = 0L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new CucumberWatering().theMin(x, K);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        int[] x = new int[] {
            9,
            -3,
            14,
            6,
            5,
            -9,
            32,
            7,
            -5,
            26,
            2,
            11
        };
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x)));
        int K = 3;
        Console.WriteLine("K:{0}", K);
        long __expected = 58L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new CucumberWatering().theMin(x, K);
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
