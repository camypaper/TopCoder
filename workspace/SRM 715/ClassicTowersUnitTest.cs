using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(long k, int[] count,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine("k:{0}", k);
        Console.WriteLine(string.Format("count:{0}", string.Join(" ",count)));
        }
        string __result = new ClassicTowers().findTowers(k, count);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        long k = 4L;
        Console.WriteLine("k:{0}", k);
        int[] count = new int[] {
            1,
            1,
            2
        };
        Console.WriteLine(string.Format("count:{0}", string.Join(" ", count)));
        string __expected = "CCAB";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new ClassicTowers().findTowers(k, count);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        long k = 0L;
        Console.WriteLine("k:{0}", k);
        int[] count = new int[] {
            0,
            0,
            50
        };
        Console.WriteLine(string.Format("count:{0}", string.Join(" ", count)));
        string __expected = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new ClassicTowers().findTowers(k, count);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        long k = 0L;
        Console.WriteLine("k:{0}", k);
        int[] count = new int[] {
            10,
            20,
            20
        };
        Console.WriteLine(string.Format("count:{0}", string.Join(" ", count)));
        string __expected = "";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new ClassicTowers().findTowers(k, count);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        long k = 123456123456123L;
        Console.WriteLine("k:{0}", k);
        int[] count = new int[] {
            10,
            10,
            30
        };
        Console.WriteLine(string.Format("count:{0}", string.Join(" ", count)));
        string __expected = "CCACCCACCABACCABBACCCBBCCBCCCBACCCCABBACCCCCACBCCC";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new ClassicTowers().findTowers(k, count);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        long k = 314159265358979L;
        Console.WriteLine("k:{0}", k);
        int[] count = new int[] {
            15,
            16,
            17
        };
        Console.WriteLine(string.Format("count:{0}", string.Join(" ", count)));
        string __expected = "";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new ClassicTowers().findTowers(k, count);
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
