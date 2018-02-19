using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(string knowledge, string[] graph,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine("knowledge:{0}", knowledge);
        Console.WriteLine(string.Format("graph:{0}", string.Join(" ",graph)));
        }
        int __result = new Rumor().getMinimum(knowledge, graph);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        string knowledge = "YNN";
        Console.WriteLine("knowledge:{0}", knowledge);
        string[] graph = new string[] {
            "NYN",
            "NNY",
            "NNN"
        };
        Console.WriteLine(string.Format("graph:{0}", string.Join(" ", graph)));
        int __expected = 3;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new Rumor().getMinimum(knowledge, graph);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        string knowledge = "YNNY";
        Console.WriteLine("knowledge:{0}", knowledge);
        string[] graph = new string[] {
            "NYYN",
            "YNNY",
            "YNNY",
            "NYYN"
        };
        Console.WriteLine(string.Format("graph:{0}", string.Join(" ", graph)));
        int __expected = 1;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new Rumor().getMinimum(knowledge, graph);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        string knowledge = "YYYY";
        Console.WriteLine("knowledge:{0}", knowledge);
        string[] graph = new string[] {
            "NYNN",
            "YNYN",
            "NYNY",
            "NNYN"
        };
        Console.WriteLine(string.Format("graph:{0}", string.Join(" ", graph)));
        int __expected = 0;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new Rumor().getMinimum(knowledge, graph);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        string knowledge = "YYYYYN";
        Console.WriteLine("knowledge:{0}", knowledge);
        string[] graph = new string[] {
            "NYYYYN",
            "YNYYYN",
            "YYNYYN",
            "YYYNYN",
            "YYYYNN",
            "NNNNNN"
        };
        Console.WriteLine(string.Format("graph:{0}", string.Join(" ", graph)));
        int __expected = -1;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new Rumor().getMinimum(knowledge, graph);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        string knowledge = "NNNY";
        Console.WriteLine("knowledge:{0}", knowledge);
        string[] graph = new string[] {
            "NNNN",
            "YNNN",
            "YNNN",
            "NYYN"
        };
        Console.WriteLine(string.Format("graph:{0}", string.Join(" ", graph)));
        int __expected = 3;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new Rumor().getMinimum(knowledge, graph);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example5(bool fast = false)
    {
        Console.WriteLine("Example5");
        string knowledge =  "NNNNNNNYYY";
        Console.WriteLine("knowledge:{0}", knowledge);
        string[] graph = new string[] {
            "NYNNYNNYNN",
            "NNYNYNNNNY",
            "YYNNNYNNNN",
            "YNNNYNYNNN",
            "NNYNNYNNYN",
            "NNNNYNNNYY",
            "NYNYNYNNNN",
            "NNNNNNYNYY",
            "NNNYNNNYNY",
            "NYYNNNNYNN"
        };
        Console.WriteLine(string.Format("graph:{0}", string.Join(" ", graph)));
        int __expected = 2;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new Rumor().getMinimum(knowledge, graph);
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
