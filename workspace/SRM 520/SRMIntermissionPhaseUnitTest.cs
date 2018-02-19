using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int[] points, string[] description,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine(string.Format("points:{0}", string.Join(" ",points)));
        Console.WriteLine(string.Format("description:{0}", string.Join(" ",description)));
        }
        int __result = new SRMIntermissionPhase().countWays(points, description);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int[] points = new int[] {
            25000,
            50000,
            100000
        };
        Console.WriteLine(string.Format("points:{0}", string.Join(" ", points)));
        string[] description = new string[] {
            "YNN",
            "NNN"
        };
        Console.WriteLine(string.Format("description:{0}", string.Join(" ", description)));
        int __expected = 25000;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new SRMIntermissionPhase().countWays(points, description);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int[] points = new int[] {
            30000,
            60000,
            90000
        };
        Console.WriteLine(string.Format("points:{0}", string.Join(" ", points)));
        string[] description = new string[] {
            "NYN",
            "NYN"
        };
        Console.WriteLine(string.Format("description:{0}", string.Join(" ", description)));
        int __expected = 799969993;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new SRMIntermissionPhase().countWays(points, description);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int[] points = new int[] {
            25000,
            45000,
            110000
        };
        Console.WriteLine(string.Format("points:{0}", string.Join(" ", points)));
        string[] description = new string[] {
            "NNN",
            "YYY"
        };
        Console.WriteLine(string.Format("description:{0}", string.Join(" ", description)));
        int __expected = 0;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new SRMIntermissionPhase().countWays(points, description);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        int[] points = new int[] {
            25600,
            51200,
            102400
        };
        Console.WriteLine(string.Format("points:{0}", string.Join(" ", points)));
        string[] description = new string[] {
            "NYY",
            "YNY",
            "YYY",
            "YNN",
            "YYN",
            "NNY",
            "NYN",
            "NNN"
        };
        Console.WriteLine(string.Format("description:{0}", string.Join(" ", description)));
        int __expected = 867560805;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new SRMIntermissionPhase().countWays(points, description);
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
