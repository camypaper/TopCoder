using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(string[] G,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine(string.Format("G:{0}", string.Join(" ",G)));
        }
        long __result = new DFSCount().count(G);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        string[] G = new string[] {
            "NYY",
            "YNY",
            "YYN"
        };
        Console.WriteLine(string.Format("G:{0}", string.Join(" ", G)));
        long __expected = 6L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new DFSCount().count(G);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        string[] G = new string[] {
            "NYNN",
            "YNYN",
            "NYNY",
            "NNYN"
        };
        Console.WriteLine(string.Format("G:{0}", string.Join(" ", G)));
        long __expected = 6L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new DFSCount().count(G);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        string[] G = new string[] {
            "NYYY",
            "YNYY",
            "YYNN",
            "YYNN"
        };
        Console.WriteLine(string.Format("G:{0}", string.Join(" ", G)));
        long __expected = 16L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new DFSCount().count(G);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        string[] G = new string[] {
            "NYYYYYYYYYYYYY",
            "YNYYYYYYYYYYYY",
            "YYNYYYYYYYYYYY",
            "YYYNYYYYYYYYYY",
            "YYYYNYYYYYYYYY",
            "YYYYYNYYYYYYYY",
            "YYYYYYNYYYYYYY",
            "YYYYYYYNYYYYYY",
            "YYYYYYYYNYYYYY",
            "YYYYYYYYYNYYYY",
            "YYYYYYYYYYNYYY",
            "YYYYYYYYYYYNYY",
            "YYYYYYYYYYYYNY",
            "YYYYYYYYYYYYYN"
        };
        Console.WriteLine(string.Format("G:{0}", string.Join(" ", G)));
        long __expected = 87178291200L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new DFSCount().count(G);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        string[] G = new string[] {
            "N"
        };
        Console.WriteLine(string.Format("G:{0}", string.Join(" ", G)));
        long __expected = 1L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new DFSCount().count(G);
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
