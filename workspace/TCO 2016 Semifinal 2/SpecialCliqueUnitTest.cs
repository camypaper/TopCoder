using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(long[] s,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine(string.Format("s:{0}", string.Join(" ",s)));
        }
        string __result = new SpecialClique().exist(s);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        long[] s = new long[] {
            3L,
            6L,
            5L,
            8L,
            24L,
            56L
        };
        Console.WriteLine(string.Format("s:{0}", string.Join(" ", s)));
        string __expected = "Possible";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new SpecialClique().exist(s);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        long[] s = new long[] {
            6L,
            5L,
            8L,
            24L,
            56L
        };
        Console.WriteLine(string.Format("s:{0}", string.Join(" ", s)));
        string __expected = "Impossible";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new SpecialClique().exist(s);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        long[] s = new long[] {
            585858585858585858L,
            585858585858585858L,
            585858585858585858L,
            585858585858585858L
        };
        Console.WriteLine(string.Format("s:{0}", string.Join(" ", s)));
        string __expected = "Impossible";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new SpecialClique().exist(s);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        long[] s = new long[] {
            2L,
            3L,
            5L,
            7L,
            11L,
            13L,
            17L,
            19L,
            23L,
            29L,
            31L,
            37L,
            41L,
            43L,
            47L
        };
        Console.WriteLine(string.Format("s:{0}", string.Join(" ", s)));
        string __expected = "Impossible";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new SpecialClique().exist(s);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        long[] s = new long[] {
            1L,
            1L,
            2L,
            3L,
            5L,
            8L,
            13L,
            21L,
            34L,
            55L,
            89L,
            144L,
            233L,
            377L,
            610L,
            987L,
            1597L
        };
        Console.WriteLine(string.Format("s:{0}", string.Join(" ", s)));
        string __expected = "Possible";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new SpecialClique().exist(s);
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
