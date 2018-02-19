using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(long age,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine("age:{0}", age);
        }
        int[] __result = new AutomorphicTree().construct(age);
        if(!__fast)
        {
        Console.WriteLine(string.Format("Result:{0}",string.Join(" ", __result)));
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        long age = 1L;
        Console.WriteLine("age:{0}", age);
        int[] __expected = new int[] {
            1
        };
        Console.WriteLine(string.Format("Expected:{0}", string.Join(" ",__expected)));
        int[] __result = new AutomorphicTree().construct(age);
        Console.WriteLine(string.Format("Result:{0}",string.Join(" ", __result)));
            return check(__expected, __result);
     }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        long age = 8L;
        Console.WriteLine("age:{0}", age);
        int[] __expected = new int[] {
            6,
            0,
            1,
            1,
            2,
            3,
            4,
            4,
            5,
            4,
            1
        };
        Console.WriteLine(string.Format("Expected:{0}", string.Join(" ",__expected)));
        int[] __result = new AutomorphicTree().construct(age);
        Console.WriteLine(string.Format("Result:{0}",string.Join(" ", __result)));
            return check(__expected, __result);
     }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        long age = 1000000000000000000L;
        Console.WriteLine("age:{0}", age);
        int[] __expected = new int[] {
        };
        Console.WriteLine(string.Format("Expected:{0}", string.Join(" ",__expected)));
        int[] __result = new AutomorphicTree().construct(age);
        Console.WriteLine(string.Format("Result:{0}",string.Join(" ", __result)));
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
