using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(string[] output,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine(string.Format("output:{0}", string.Join(" ",output)));
        }
        int __result = new AlgridTwo().makeProgram(output);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        string[] output = new string[] {
            "BB",
            "WB"
        };
        Console.WriteLine(string.Format("output:{0}", string.Join(" ", output)));
        int __expected = 1;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new AlgridTwo().makeProgram(output);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        string[] output = new string[] {
            "BBWBBB",
            "WBWBBW"
        };
        Console.WriteLine(string.Format("output:{0}", string.Join(" ", output)));
        int __expected = 8;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new AlgridTwo().makeProgram(output);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        string[] output = new string[] {
            "BWBWBW",
            "WWWWWW",
            "WBBWBW"
        };
        Console.WriteLine(string.Format("output:{0}", string.Join(" ", output)));
        int __expected = 0;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new AlgridTwo().makeProgram(output);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        string[] output = new string[] {
            "WWBWBWBWBWBWBWBW",
            "BWBWBWBWBWBWBWBB",
            "BWBWBWBWBWBWBWBW"
        };
        Console.WriteLine(string.Format("output:{0}", string.Join(" ", output)));
        int __expected = 73741817;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new AlgridTwo().makeProgram(output);
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
