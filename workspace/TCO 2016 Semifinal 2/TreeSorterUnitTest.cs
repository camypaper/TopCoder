using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int[] p,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine(string.Format("p:{0}", string.Join(" ",p)));
        }
        int __result = new TreeSorter().minimalCosts(p);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int[] p = new int[] {
            1,
            3,
            2,
            0
        };
        Console.WriteLine(string.Format("p:{0}", string.Join(" ", p)));
        int __expected = 14;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new TreeSorter().minimalCosts(p);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int[] p = new int[] {
            0,
            2,
            3,
            1
        };
        Console.WriteLine(string.Format("p:{0}", string.Join(" ", p)));
        int __expected = 16;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new TreeSorter().minimalCosts(p);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int[] p = new int[] {
            0,
            1,
            2,
            3,
            4,
            5,
            6,
            7
        };
        Console.WriteLine(string.Format("p:{0}", string.Join(" ", p)));
        int __expected = 72;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new TreeSorter().minimalCosts(p);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        int[] p = new int[] {
            6,
            5,
            4,
            3,
            2,
            1,
            0
        };
        Console.WriteLine(string.Format("p:{0}", string.Join(" ", p)));
        int __expected = 26;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new TreeSorter().minimalCosts(p);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        int[] p = new int[] {
            0
        };
        Console.WriteLine(string.Format("p:{0}", string.Join(" ", p)));
        int __expected = 2;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new TreeSorter().minimalCosts(p);
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
