using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(string S,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine("S:{0}", S);
        }
        int __result = new Subrectangle().minMissed(S);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        string S = "..###.##";
        Console.WriteLine("S:{0}", S);
        int __expected = 2;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new Subrectangle().minMissed(S);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        string S = "#.##.#.#..";
        Console.WriteLine("S:{0}", S);
        int __expected = 2;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new Subrectangle().minMissed(S);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        string S = "####";
        Console.WriteLine("S:{0}", S);
        int __expected = 0;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new Subrectangle().minMissed(S);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        string S = "";
        Console.WriteLine("S:{0}", S);
        int __expected = 1;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new Subrectangle().minMissed(S);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        string S = "........................................";
        Console.WriteLine("S:{0}", S);
        int __expected = 1;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new Subrectangle().minMissed(S);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example5(bool fast = false)
    {
        Console.WriteLine("Example5");
        string S = "###...###";
        Console.WriteLine("S:{0}", S);
        int __expected = 3;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new Subrectangle().minMissed(S);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example6(bool fast = false)
    {
        Console.WriteLine("Example6");
        string S = ".#.###.##...#.####.###...###.##";
        Console.WriteLine("S:{0}", S);
        int __expected = 15;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new Subrectangle().minMissed(S);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example7(bool fast = false)
    {
        Console.WriteLine("Example7");
        string S = ".................................................##..##...##..............................";
        Console.WriteLine("S:{0}", S);
        int __expected = 5;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new Subrectangle().minMissed(S);
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
