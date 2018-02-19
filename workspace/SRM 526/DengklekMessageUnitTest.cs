using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(string[] pieces, string[] goodSubstring, long K,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine(string.Format("pieces:{0}", string.Join(" ",pieces)));
        Console.WriteLine(string.Format("goodSubstring:{0}", string.Join(" ",goodSubstring)));
        Console.WriteLine("K:{0}", K);
        }
        double __result = new DengklekMessage().theExpected(pieces, goodSubstring, K);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        string[] pieces = new string[] {
            "0"
        };
        Console.WriteLine(string.Format("pieces:{0}", string.Join(" ", pieces)));
        string[] goodSubstring = new string[] {
            "00"
        };
        Console.WriteLine(string.Format("goodSubstring:{0}", string.Join(" ", goodSubstring)));
        long K = 10L;
        Console.WriteLine("K:{0}", K);
        double __expected = 9.0;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new DengklekMessage().theExpected(pieces, goodSubstring, K);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
}

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        string[] pieces = new string[] {
            "0"
        };
        Console.WriteLine(string.Format("pieces:{0}", string.Join(" ", pieces)));
        string[] goodSubstring = new string[] {
            "00"
        };
        Console.WriteLine(string.Format("goodSubstring:{0}", string.Join(" ", goodSubstring)));
        long K = 1L;
        Console.WriteLine("K:{0}", K);
        double __expected = 0.0;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new DengklekMessage().theExpected(pieces, goodSubstring, K);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
}

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        string[] pieces = new string[] {
            "0",
            "1"
        };
        Console.WriteLine(string.Format("pieces:{0}", string.Join(" ", pieces)));
        string[] goodSubstring = new string[] {
            "00"
        };
        Console.WriteLine(string.Format("goodSubstring:{0}", string.Join(" ", goodSubstring)));
        long K = 3L;
        Console.WriteLine("K:{0}", K);
        double __expected = 0.5;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new DengklekMessage().theExpected(pieces, goodSubstring, K);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
}

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        string[] pieces = new string[] {
            "0",
            "10",
            "110"
        };
        Console.WriteLine(string.Format("pieces:{0}", string.Join(" ", pieces)));
        string[] goodSubstring = new string[] {
            "0",
            "1"
        };
        Console.WriteLine(string.Format("goodSubstring:{0}", string.Join(" ", goodSubstring)));
        long K = 5L;
        Console.WriteLine("K:{0}", K);
        double __expected = 2.6666666666666665;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new DengklekMessage().theExpected(pieces, goodSubstring, K);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
}

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        string[] pieces = new string[] {
            "0",
            "10"
        };
        Console.WriteLine(string.Format("pieces:{0}", string.Join(" ", pieces)));
        string[] goodSubstring = new string[] {
            "000101000101010100"
        };
        Console.WriteLine(string.Format("goodSubstring:{0}", string.Join(" ", goodSubstring)));
        long K = 526L;
        Console.WriteLine("K:{0}", K);
        double __expected = 0.25146484375;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new DengklekMessage().theExpected(pieces, goodSubstring, K);
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
