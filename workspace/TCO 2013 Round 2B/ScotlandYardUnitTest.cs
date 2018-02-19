using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(string[] taxi, string[] bus, string[] metro,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine(string.Format("taxi:{0}", string.Join(" ",taxi)));
        Console.WriteLine(string.Format("bus:{0}", string.Join(" ",bus)));
        Console.WriteLine(string.Format("metro:{0}", string.Join(" ",metro)));
        }
        int __result = new ScotlandYard().maxMoves(taxi, bus, metro);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        string[] taxi = new string[] {
            "NYN",
            "NNY",
            "NNN"
        };
        Console.WriteLine(string.Format("taxi:{0}", string.Join(" ", taxi)));
        string[] bus = new string[] {
            "NNN",
            "NNN",
            "NNN"
        };
        Console.WriteLine(string.Format("bus:{0}", string.Join(" ", bus)));
        string[] metro = new string[] {
            "NNN",
            "NNN",
            "NNN"
        };
        Console.WriteLine(string.Format("metro:{0}", string.Join(" ", metro)));
        int __expected = 2;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new ScotlandYard().maxMoves(taxi, bus, metro);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        string[] taxi = new string[] {
            "NYY",
            "NNN",
            "NNN"
        };
        Console.WriteLine(string.Format("taxi:{0}", string.Join(" ", taxi)));
        string[] bus = new string[] {
            "NNN",
            "NNN",
            "NNN"
        };
        Console.WriteLine(string.Format("bus:{0}", string.Join(" ", bus)));
        string[] metro = new string[] {
            "NNN",
            "NNN",
            "NNN"
        };
        Console.WriteLine(string.Format("metro:{0}", string.Join(" ", metro)));
        int __expected = 1;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new ScotlandYard().maxMoves(taxi, bus, metro);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        string[] taxi = new string[] {
            "NYYY",
            "YNYY",
            "YYNY",
            "YYYN"
        };
        Console.WriteLine(string.Format("taxi:{0}", string.Join(" ", taxi)));
        string[] bus = new string[] {
            "NNNN",
            "NNNN",
            "NNNN",
            "NNNN"
        };
        Console.WriteLine(string.Format("bus:{0}", string.Join(" ", bus)));
        string[] metro = new string[] {
            "NNNN",
            "NNNN",
            "NNNN",
            "NNNN"
        };
        Console.WriteLine(string.Format("metro:{0}", string.Join(" ", metro)));
        int __expected = -1;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new ScotlandYard().maxMoves(taxi, bus, metro);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        string[] taxi = new string[] {
            "NNY",
            "NNY",
            "NNN"
        };
        Console.WriteLine(string.Format("taxi:{0}", string.Join(" ", taxi)));
        string[] bus = new string[] {
            "NYN",
            "NNY",
            "NNN"
        };
        Console.WriteLine(string.Format("bus:{0}", string.Join(" ", bus)));
        string[] metro = new string[] {
            "NNN",
            "NNN",
            "YNN"
        };
        Console.WriteLine(string.Format("metro:{0}", string.Join(" ", metro)));
        int __expected = 2;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new ScotlandYard().maxMoves(taxi, bus, metro);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        string[] taxi = new string[] {
            "NNN",
            "YNY",
            "NNN"
        };
        Console.WriteLine(string.Format("taxi:{0}", string.Join(" ", taxi)));
        string[] bus = new string[] {
            "NNN",
            "YNN",
            "YNN"
        };
        Console.WriteLine(string.Format("bus:{0}", string.Join(" ", bus)));
        string[] metro = new string[] {
            "NNN",
            "NNN",
            "YYN"
        };
        Console.WriteLine(string.Format("metro:{0}", string.Join(" ", metro)));
        int __expected = -1;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new ScotlandYard().maxMoves(taxi, bus, metro);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example5(bool fast = false)
    {
        Console.WriteLine("Example5");
        string[] taxi = new string[] {
            "NNNNYNNNYY",
            "NNYNNYYYYY",
            "NNNNNNNNNN",
            "YYNNYYNNNY",
            "NNYNNNNNNN",
            "YNYNYNNNYN",
            "NNYNYNNNYN",
            "NNNNNNYNNN",
            "NNNNNNNNNN",
            "NNNNNNYNNN"
        };
        Console.WriteLine(string.Format("taxi:{0}", string.Join(" ", taxi)));
        string[] bus = new string[] {
            "NNYNNNYNNY",
            "YNYNNYYNYY",
            "NNNNNNNNNN",
            "YNYNNYNYNY",
            "NNYNNNNNYN",
            "YNYNYNYNYN",
            "NNYNNNNNNY",
            "YNYNNNNNNN",
            "NNNNNNNNNN",
            "NNYNYNNNNN"
        };
        Console.WriteLine(string.Format("bus:{0}", string.Join(" ", bus)));
        string[] metro = new string[] {
            "NNNNNNNYNN",
            "YNYNNNNNYN",
            "NNNNNNNNNN",
            "NYNNYNNNYY",
            "NNYNNNNNNN",
            "YNYNNNNNYY",
            "NNNNYNNNYN",
            "NNYNNNYNNN",
            "NNNNNNNNNY",
            "NNYNYNNNNN"
        };
        Console.WriteLine(string.Format("metro:{0}", string.Join(" ", metro)));
        int __expected = 21;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new ScotlandYard().maxMoves(taxi, bus, metro);
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
