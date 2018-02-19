using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int N, string[] streets,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine(string.Format("streets:{0}", string.Join(" ",streets)));
        }
        int __result = new SafeReturn().minRisk(N, streets);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int N = 3;
        Console.WriteLine("N:{0}", N);
        string[] streets = new string[] {
            "-234",
            "2---",
            "3---",
            "4---"
        };
        Console.WriteLine(string.Format("streets:{0}", string.Join(" ", streets)));
        int __expected = 3;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new SafeReturn().minRisk(N, streets);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int N = 2;
        Console.WriteLine("N:{0}", N);
        string[] streets = new string[] {
            "-12",
            "1-1",
            "21-"
        };
        Console.WriteLine(string.Format("streets:{0}", string.Join(" ", streets)));
        int __expected = 1;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new SafeReturn().minRisk(N, streets);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int N = 3;
        Console.WriteLine("N:{0}", N);
        string[] streets = new string[] {
            "-----7",
            "--1---",
            "-1-5--",
            "--5-1-",
            "---1-3",
            "7---3-"
        };
        Console.WriteLine(string.Format("streets:{0}", string.Join(" ", streets)));
        int __expected = 1;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new SafeReturn().minRisk(N, streets);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        int N = 2;
        Console.WriteLine("N:{0}", N);
        string[] streets = new string[] {
            "-11",
            "1-1",
            "11-"
        };
        Console.WriteLine(string.Format("streets:{0}", string.Join(" ", streets)));
        int __expected = 2;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new SafeReturn().minRisk(N, streets);
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
