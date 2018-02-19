using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(string[] G, int A, int D,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine(string.Format("G:{0}", string.Join(" ",G)));
        Console.WriteLine("A:{0}", A);
        Console.WriteLine("D:{0}", D);
        }
        string __result = new AngelDemonGame().winner(G, A, D);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        string[] G = new string[] {
            "NYNY",
            "YNYY",
            "NYNN",
            "YYNN"
        };
        Console.WriteLine(string.Format("G:{0}", string.Join(" ", G)));
        int A = 2;
        Console.WriteLine("A:{0}", A);
        int D = 2;
        Console.WriteLine("D:{0}", D);
        string __expected = "Angel";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new AngelDemonGame().winner(G, A, D);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        string[] G = new string[] {
            "NYNY",
            "YNYY",
            "NYNN",
            "YYNN"
        };
        Console.WriteLine(string.Format("G:{0}", string.Join(" ", G)));
        int A = 6;
        Console.WriteLine("A:{0}", A);
        int D = 6;
        Console.WriteLine("D:{0}", D);
        string __expected = "Demon";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new AngelDemonGame().winner(G, A, D);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        string[] G = new string[] {
            "NNNN",
            "NNNN",
            "NNNN",
            "NNNN"
        };
        Console.WriteLine(string.Format("G:{0}", string.Join(" ", G)));
        int A = 2;
        Console.WriteLine("A:{0}", A);
        int D = 2;
        Console.WriteLine("D:{0}", D);
        string __expected = "Unknown";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new AngelDemonGame().winner(G, A, D);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        string[] G = new string[] {
            "NYNNNY",
            "YNNYNN",
            "NNNNYN",
            "NYNNNN",
            "NNYNNN",
            "YNNNNN"
        };
        Console.WriteLine(string.Format("G:{0}", string.Join(" ", G)));
        int A = 4;
        Console.WriteLine("A:{0}", A);
        int D = 4;
        Console.WriteLine("D:{0}", D);
        string __expected = "Unknown";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new AngelDemonGame().winner(G, A, D);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        string[] G = new string[] {
            "NYNNNY",
            "YNNYNN",
            "NNNNYN",
            "NYNNNN",
            "NNYNNN",
            "YNNNNN"
        };
        Console.WriteLine(string.Format("G:{0}", string.Join(" ", G)));
        int A = 8;
        Console.WriteLine("A:{0}", A);
        int D = 4;
        Console.WriteLine("D:{0}", D);
        string __expected = "Angel";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new AngelDemonGame().winner(G, A, D);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example5(bool fast = false)
    {
        Console.WriteLine("Example5");
        string[] G = new string[] {
            "NYNNNY",
            "YNNYNN",
            "NNNNYN",
            "NYNNNN",
            "NNYNNN",
            "YNNNNN"
        };
        Console.WriteLine(string.Format("G:{0}", string.Join(" ", G)));
        int A = 4;
        Console.WriteLine("A:{0}", A);
        int D = 8;
        Console.WriteLine("D:{0}", D);
        string __expected = "Demon";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new AngelDemonGame().winner(G, A, D);
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
