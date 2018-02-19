using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(long n, string[] special,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine("n:{0}", n);
        Console.WriteLine(string.Format("special:{0}", string.Join(" ",special)));
        }
        long __result = new EllysNumbers().getSubsets(n, special);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        long n = 12L;
        Console.WriteLine("n:{0}", n);
        string[] special = new string[] {
            "4 2 5 6 3"
        };
        Console.WriteLine(string.Format("special:{0}", string.Join(" ", special)));
        long __expected = 1L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new EllysNumbers().getSubsets(n, special);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        long n = 42L;
        Console.WriteLine("n:{0}", n);
        string[] special = new string[] {
            "1 2 3 4 5 6 7 13 14 21 42"
        };
        Console.WriteLine(string.Format("special:{0}", string.Join(" ", special)));
        long __expected = 10L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new EllysNumbers().getSubsets(n, special);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        long n = 1337L;
        Console.WriteLine("n:{0}", n);
        string[] special = new string[] {
            "1 13 42 666 2674"
        };
        Console.WriteLine(string.Format("special:{0}", string.Join(" ", special)));
        long __expected = 0L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new EllysNumbers().getSubsets(n, special);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        long n = 1073741824L;
        Console.WriteLine("n:{0}", n);
        string[] special = new string[] {
            "1 2 4 8 16 32 64 128 256 512 1024 2048 4096 8192 1",
            "6384 32768 65536 131072 262144 524288 1048576 2097",
            "152 4194304 8388608 16777216 33554432 67108864 134",
            "217728 268435456 536870912"
        };
        Console.WriteLine(string.Format("special:{0}", string.Join(" ", special)));
        long __expected = 0L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new EllysNumbers().getSubsets(n, special);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        long n = 7420738134810L;
        Console.WriteLine("n:{0}", n);
        string[] special = new string[] {
            "435 625199055 4199 33263 17 222870 284870433 72093",
            "2379 7 11 31 247110827 23 1771 81809 851968487 13 ",
            "476379795 1001 5 435274114 38264554 7429 239906525",
            " 3 227183706 887045414 606786670 3795 797605175 29",
            " 30 747186719 19 2 562347843 74 2294 588002688 743",
            "6429 703 591740547 36657492 37 444178205 1002001 2",
            "17626404"
        };
        Console.WriteLine(string.Format("special:{0}", string.Join(" ", special)));
        long __expected = 110L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new EllysNumbers().getSubsets(n, special);
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
