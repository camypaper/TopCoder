using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int[] socks, int colorDiff,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine(string.Format("socks:{0}", string.Join(" ",socks)));
        Console.WriteLine("colorDiff:{0}", colorDiff);
        }
        double __result = new RainbowSocks().getPairProb(socks, colorDiff);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int[] socks = new int[] {
            1,
            2,
            3,
            4,
            5,
            6,
            7
        };
        Console.WriteLine(string.Format("socks:{0}", string.Join(" ", socks)));
        int colorDiff = 7;
        Console.WriteLine("colorDiff:{0}", colorDiff);
        double __expected = 1.0;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new RainbowSocks().getPairProb(socks, colorDiff);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
}

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int[] socks = new int[] {
            1,
            50,
            50,
            1
        };
        Console.WriteLine(string.Format("socks:{0}", string.Join(" ", socks)));
        int colorDiff = 0;
        Console.WriteLine("colorDiff:{0}", colorDiff);
        double __expected = 0.3333333333333333;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new RainbowSocks().getPairProb(socks, colorDiff);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
}

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int[] socks = new int[] {
            44,
            14,
            24,
            31,
            30,
            32,
            46,
            23,
            27,
            2
        };
        Console.WriteLine(string.Format("socks:{0}", string.Join(" ", socks)));
        int colorDiff = 24;
        Console.WriteLine("colorDiff:{0}", colorDiff);
        double __expected = 0.8222222222222222;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new RainbowSocks().getPairProb(socks, colorDiff);
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
