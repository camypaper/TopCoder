using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(string[] palette, int n, int m,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine(string.Format("palette:{0}", string.Join(" ",palette)));
        Console.WriteLine("n:{0}", n);
        Console.WriteLine("m:{0}", m);
        }
        int __result = new MagicalGirlLevelTwoDivOne().theCount(palette, n, m);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        string[] palette = new string[] {
            "12",
            "2."
        };
        Console.WriteLine(string.Format("palette:{0}", string.Join(" ", palette)));
        int n = 2;
        Console.WriteLine("n:{0}", n);
        int m = 2;
        Console.WriteLine("m:{0}", m);
        int __expected = 5;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new MagicalGirlLevelTwoDivOne().theCount(palette, n, m);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        string[] palette = new string[] {
            "21",
            "1."
        };
        Console.WriteLine(string.Format("palette:{0}", string.Join(" ", palette)));
        int n = 2;
        Console.WriteLine("n:{0}", n);
        int m = 2;
        Console.WriteLine("m:{0}", m);
        int __expected = 4;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new MagicalGirlLevelTwoDivOne().theCount(palette, n, m);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        string[] palette = new string[] {
            "...",
            "...",
            "..."
        };
        Console.WriteLine(string.Format("palette:{0}", string.Join(" ", palette)));
        int n = 1;
        Console.WriteLine("n:{0}", n);
        int m = 1;
        Console.WriteLine("m:{0}", m);
        int __expected = 1953125;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new MagicalGirlLevelTwoDivOne().theCount(palette, n, m);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        string[] palette = new string[] {
            "..58..",
            "..47.."
        };
        Console.WriteLine(string.Format("palette:{0}", string.Join(" ", palette)));
        int n = 2;
        Console.WriteLine("n:{0}", n);
        int m = 3;
        Console.WriteLine("m:{0}", m);
        int __expected = 0;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new MagicalGirlLevelTwoDivOne().theCount(palette, n, m);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        string[] palette = new string[] {
            "...1.2.3",
            "4.5.6...",
            "...7.8.9",
            "1.2.3..."
        };
        Console.WriteLine(string.Format("palette:{0}", string.Join(" ", palette)));
        int n = 4;
        Console.WriteLine("n:{0}", n);
        int m = 4;
        Console.WriteLine("m:{0}", m);
        int __expected = 886073030;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new MagicalGirlLevelTwoDivOne().theCount(palette, n, m);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example5(bool fast = false)
    {
        Console.WriteLine("Example5");
        string[] palette = new string[] {
            "....................",
            "....................",
            "....................",
            "....................",
            "....................",
            "....................",
            "....................",
            "....................",
            "....................",
            "....................",
            "....................",
            "....................",
            "....................",
            "....................",
            "....................",
            "....................",
            "....................",
            "....................",
            "....................",
            "...................."
        };
        Console.WriteLine(string.Format("palette:{0}", string.Join(" ", palette)));
        int n = 10;
        Console.WriteLine("n:{0}", n);
        int m = 10;
        Console.WriteLine("m:{0}", m);
        int __expected = 240076532;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new MagicalGirlLevelTwoDivOne().theCount(palette, n, m);
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
