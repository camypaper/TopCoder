using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int k, bool __fast = true)
    {
        if (!__fast)
        {
            Console.WriteLine("k:{0}", k);
        }
        string[] __result = new MazeConstruct().construct(k);
        if (!__fast)
        {
            Console.WriteLine(string.Format("Result:{0}", string.Join(" ", __result)));
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int k = 3;
        Console.WriteLine("k:{0}", k);
        string[] __expected = new string[] {
            "...."
        };
        Console.WriteLine(string.Format("Expected:{0}", string.Join(" ", __expected)));
        string[] __result = new MazeConstruct().construct(k);
        Console.WriteLine(string.Format("Result:{0}", string.Join(" ", __result)));
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int k = 4;
        Console.WriteLine("k:{0}", k);
        string[] __expected = new string[] {
            "...",
            "...",
            "..."
        };
        Console.WriteLine(string.Format("Expected:{0}", string.Join(" ", __expected)));
        string[] __result = new MazeConstruct().construct(k);
        Console.WriteLine(string.Format("Result:{0}", string.Join(" ", __result)));
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int k = 10;
        Console.WriteLine("k:{0}", k);
        string[] __expected = new string[] {
            "..#..",
            "#.#..",
            "..#..",
            ".#...",
            "....."
        };
        Console.WriteLine(string.Format("Expected:{0}", string.Join(" ", __expected)));
        string[] __result = new MazeConstruct().construct(k);
        Console.WriteLine(string.Format("Result:{0}", string.Join(" ", __result)));
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
