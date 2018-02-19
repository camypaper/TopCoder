using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int n, int m, int[] moves,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine("n:{0}", n);
        Console.WriteLine("m:{0}", m);
        Console.WriteLine(string.Format("moves:{0}", string.Join(" ",moves)));
        }
        int __result = new MovingTokens().move(n, m, moves);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int n = 2;
        Console.WriteLine("n:{0}", n);
        int m = 2;
        Console.WriteLine("m:{0}", m);
        int[] moves = new int[] {
            0,
            1,
            0,
            1
        };
        Console.WriteLine(string.Format("moves:{0}", string.Join(" ", moves)));
        int __expected = 2;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new MovingTokens().move(n, m, moves);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int n = 2;
        Console.WriteLine("n:{0}", n);
        int m = 2;
        Console.WriteLine("m:{0}", m);
        int[] moves = new int[] {
            0,
            0,
            1,
            1
        };
        Console.WriteLine(string.Format("moves:{0}", string.Join(" ", moves)));
        int __expected = 1;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new MovingTokens().move(n, m, moves);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int n = 3;
        Console.WriteLine("n:{0}", n);
        int m = 1;
        Console.WriteLine("m:{0}", m);
        int[] moves = new int[] {
            0,
            1,
            1
        };
        Console.WriteLine(string.Format("moves:{0}", string.Join(" ", moves)));
        int __expected = 2;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new MovingTokens().move(n, m, moves);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        int n = 2;
        Console.WriteLine("n:{0}", n);
        int m = 5;
        Console.WriteLine("m:{0}", m);
        int[] moves = new int[] {
            0,
            0,
            0,
            0,
            0,
            0,
            1,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("moves:{0}", string.Join(" ", moves)));
        int __expected = 1;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new MovingTokens().move(n, m, moves);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        int n = 3;
        Console.WriteLine("n:{0}", n);
        int m = 2;
        Console.WriteLine("m:{0}", m);
        int[] moves = new int[] {
            0,
            2,
            2,
            1,
            1,
            0
        };
        Console.WriteLine(string.Format("moves:{0}", string.Join(" ", moves)));
        int __expected = 1;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new MovingTokens().move(n, m, moves);
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
