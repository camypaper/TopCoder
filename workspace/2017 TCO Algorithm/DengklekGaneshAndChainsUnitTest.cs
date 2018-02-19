using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(string[] chains, int[] lengths,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine(string.Format("chains:{0}", string.Join(" ",chains)));
        Console.WriteLine(string.Format("lengths:{0}", string.Join(" ",lengths)));
        }
        string __result = new DengklekGaneshAndChains().getBestChains(chains, lengths);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        string[] chains = new string[] {
            "topc",
            "oder",
            "open",
            "twob"
        };
        Console.WriteLine(string.Format("chains:{0}", string.Join(" ", chains)));
        int[] lengths = new int[] {
            2,
            1,
            3
        };
        Console.WriteLine(string.Format("lengths:{0}", string.Join(" ", lengths)));
        string __expected = "wotrod";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new DengklekGaneshAndChains().getBestChains(chains, lengths);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        string[] chains = new string[] {
            "ssh",
            "she",
            "see",
            "sea"
        };
        Console.WriteLine(string.Format("chains:{0}", string.Join(" ", chains)));
        int[] lengths = new int[] {
            2,
            3,
            2,
            3
        };
        Console.WriteLine(string.Format("lengths:{0}", string.Join(" ", lengths)));
        string __expected = "ssshesesee";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new DengklekGaneshAndChains().getBestChains(chains, lengths);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        string[] chains = new string[] {
            "wri",
            "ter",
            "who",
            "are",
            "you"
        };
        Console.WriteLine(string.Format("chains:{0}", string.Join(" ", chains)));
        int[] lengths = new int[] {
            3
        };
        Console.WriteLine(string.Format("lengths:{0}", string.Join(" ", lengths)));
        string __expected = "you";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new DengklekGaneshAndChains().getBestChains(chains, lengths);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        string[] chains = new string[] {
            "harus",
            "imfyo"
        };
        Console.WriteLine(string.Format("chains:{0}", string.Join(" ", chains)));
        int[] lengths = new int[] {
            5,
            5
        };
        Console.WriteLine(string.Format("lengths:{0}", string.Join(" ", lengths)));
        string __expected = "yoimfushar";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new DengklekGaneshAndChains().getBestChains(chains, lengths);
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
