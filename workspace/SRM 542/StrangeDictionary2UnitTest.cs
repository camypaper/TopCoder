using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(string[] words,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine(string.Format("words:{0}", string.Join(" ",words)));
        }
        double[] __result = new StrangeDictionary2().getProbabilities(words);
        if(!__fast)
        {
        Console.WriteLine(string.Format("Result:{0}",string.Join(" ", __result)));
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        string[] words = new string[] {
            "hardesttestever"
        };
        Console.WriteLine(string.Format("words:{0}", string.Join(" ", words)));
        double[] __expected = new double[] {
            1.0
        };
        Console.WriteLine(string.Format("Expected:{0}", string.Join(" ",__expected)));
        double[] __result = new StrangeDictionary2().getProbabilities(words);
        Console.WriteLine(string.Format("Result:{0}",string.Join(" ", __result)));
        return check(__expected, __result);
}

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        string[] words = new string[] {
            "ab",
            "ba"
        };
        Console.WriteLine(string.Format("words:{0}", string.Join(" ", words)));
        double[] __expected = new double[] {
            0.5,
            0.5
        };
        Console.WriteLine(string.Format("Expected:{0}", string.Join(" ",__expected)));
        double[] __result = new StrangeDictionary2().getProbabilities(words);
        Console.WriteLine(string.Format("Result:{0}",string.Join(" ", __result)));
        return check(__expected, __result);
}

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        string[] words = new string[] {
            "aza",
            "aab",
            "bba"
        };
        Console.WriteLine(string.Format("words:{0}", string.Join(" ", words)));
        double[] __expected = new double[] {
            0.3333333333333333,
            0.5,
            0.16666666666666666
        };
        Console.WriteLine(string.Format("Expected:{0}", string.Join(" ",__expected)));
        double[] __result = new StrangeDictionary2().getProbabilities(words);
        Console.WriteLine(string.Format("Result:{0}",string.Join(" ", __result)));
        return check(__expected, __result);
}

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        string[] words = new string[] {
            "abababab",
            "babababa",
            "acacacac",
            "cacacaca",
            "bcbcbcbc",
            "cbcbcbcb"
        };
        Console.WriteLine(string.Format("words:{0}", string.Join(" ", words)));
        double[] __expected = new double[] {
            0.5,
            0.5,
            0.0,
            0.0,
            0.0,
            0.0
        };
        Console.WriteLine(string.Format("Expected:{0}", string.Join(" ",__expected)));
        double[] __result = new StrangeDictionary2().getProbabilities(words);
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
