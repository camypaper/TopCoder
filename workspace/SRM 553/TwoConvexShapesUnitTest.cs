using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(string[] grid,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine(string.Format("grid:{0}", string.Join(" ",grid)));
        }
        int __result = new TwoConvexShapes().countWays(grid);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        string[] grid = new string[] {
            "??",
            "??"
        };
        Console.WriteLine(string.Format("grid:{0}", string.Join(" ", grid)));
        int __expected = 14;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new TwoConvexShapes().countWays(grid);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        string[] grid = new string[] {
            "B?",
            "??"
        };
        Console.WriteLine(string.Format("grid:{0}", string.Join(" ", grid)));
        int __expected = 7;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new TwoConvexShapes().countWays(grid);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        string[] grid = new string[] {
            "WWB",
            "WWW",
            "WWW",
            "WWW"
        };
        Console.WriteLine(string.Format("grid:{0}", string.Join(" ", grid)));
        int __expected = 1;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new TwoConvexShapes().countWays(grid);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        string[] grid = new string[] {
            "BBBBBB",
            "WWBBBB",
            "WBBBBB"
        };
        Console.WriteLine(string.Format("grid:{0}", string.Join(" ", grid)));
        int __expected = 0;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new TwoConvexShapes().countWays(grid);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        string[] grid = new string[] {
            "?BB?",
            "BBBB",
            "?BB?"
        };
        Console.WriteLine(string.Format("grid:{0}", string.Join(" ", grid)));
        int __expected = 5;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new TwoConvexShapes().countWays(grid);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example5(bool fast = false)
    {
        Console.WriteLine("Example5");
        string[] grid = new string[] {
            "?WWWWWWWWWWWWWWWWWWWWWWWWWWWWWW",
            "B?WWWWWWWWWWWWWWWWWWWWWWWWWWWWW",
            "BB?WWWWWWWWWWWWWWWWWWWWWWWWWWWW",
            "BBB?WWWWWWWWWWWWWWWWWWWWWWWWWWW",
            "BBBB?WWWWWWWWWWWWWWWWWWWWWWWWWW",
            "BBBBB?WWWWWWWWWWWWWWWWWWWWWWWWW",
            "BBBBBB?WWWWWWWWWWWWWWWWWWWWWWWW",
            "BBBBBBB?WWWWWWWWWWWWWWWWWWWWWWW",
            "BBBBBBBB?WWWWWWWWWWWWWWWWWWWWWW",
            "BBBBBBBBB?WWWWWWWWWWWWWWWWWWWWW",
            "BBBBBBBBBB?WWWWWWWWWWWWWWWWWWWW",
            "BBBBBBBBBBB?WWWWWWWWWWWWWWWWWWW",
            "BBBBBBBBBBBB?WWWWWWWWWWWWWWWWWW",
            "BBBBBBBBBBBBB?WWWWWWWWWWWWWWWWW",
            "BBBBBBBBBBBBBB?WWWWWWWWWWWWWWWW",
            "BBBBBBBBBBBBBBB?WWWWWWWWWWWWWWW",
            "BBBBBBBBBBBBBBBB?WWWWWWWWWWWWWW",
            "BBBBBBBBBBBBBBBBB?WWWWWWWWWWWWW",
            "BBBBBBBBBBBBBBBBBB?WWWWWWWWWWWW",
            "BBBBBBBBBBBBBBBBBBB?WWWWWWWWWWW",
            "BBBBBBBBBBBBBBBBBBBB?WWWWWWWWWW",
            "BBBBBBBBBBBBBBBBBBBBB?WWWWWWWWW",
            "BBBBBBBBBBBBBBBBBBBBBB?WWWWWWWW",
            "BBBBBBBBBBBBBBBBBBBBBBB?WWWWWWW",
            "BBBBBBBBBBBBBBBBBBBBBBBB?WWWWWW",
            "BBBBBBBBBBBBBBBBBBBBBBBBB?WWWWW",
            "BBBBBBBBBBBBBBBBBBBBBBBBBB?WWWW",
            "BBBBBBBBBBBBBBBBBBBBBBBBBBB?WWW",
            "BBBBBBBBBBBBBBBBBBBBBBBBBBBB?WW",
            "BBBBBBBBBBBBBBBBBBBBBBBBBBBBB?W"
        };
        Console.WriteLine(string.Format("grid:{0}", string.Join(" ", grid)));
        int __expected = 73741817;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new TwoConvexShapes().countWays(grid);
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
