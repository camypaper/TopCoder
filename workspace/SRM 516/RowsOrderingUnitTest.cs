using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(string[] rows,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine(string.Format("rows:{0}", string.Join(" ",rows)));
        }
        int __result = new RowsOrdering().order(rows);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        string[] rows = new string[] {
            "bb",
            "cb",
            "ca"
        };
        Console.WriteLine(string.Format("rows:{0}", string.Join(" ", rows)));
        int __expected = 54;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new RowsOrdering().order(rows);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        string[] rows = new string[] {
            "abcd",
            "ABCD"
        };
        Console.WriteLine(string.Format("rows:{0}", string.Join(" ", rows)));
        int __expected = 127553;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new RowsOrdering().order(rows);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        string[] rows = new string[] {
            "Example",
            "Problem"
        };
        Console.WriteLine(string.Format("rows:{0}", string.Join(" ", rows)));
        int __expected = 943877448;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new RowsOrdering().order(rows);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        string[] rows = new string[] {
            "a",
            "b",
            "c",
            "d",
            "e",
            "f",
            "g"
        };
        Console.WriteLine(string.Format("rows:{0}", string.Join(" ", rows)));
        int __expected = 28;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new RowsOrdering().order(rows);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        string[] rows = new string[] {
            "a",
            "a"
        };
        Console.WriteLine(string.Format("rows:{0}", string.Join(" ", rows)));
        int __expected = 2;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new RowsOrdering().order(rows);
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
