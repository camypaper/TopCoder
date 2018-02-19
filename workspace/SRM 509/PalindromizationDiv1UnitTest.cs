using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(string word, string[] operations,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine("word:{0}", word);
        Console.WriteLine(string.Format("operations:{0}", string.Join(" ",operations)));
        }
        int __result = new PalindromizationDiv1().getMinimumCost(word, operations);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        string word = "racecar";
        Console.WriteLine("word:{0}", word);
        string[] operations = new string[] {
        };
        Console.WriteLine(string.Format("operations:{0}", string.Join(" ", operations)));
        int __expected = 0;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new PalindromizationDiv1().getMinimumCost(word, operations);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        string word = "topcoder";
        Console.WriteLine("word:{0}", word);
        string[] operations = new string[] {
            "erase t 1",
            "erase o 1",
            "erase p 1",
            "erase c 1",
            "erase d 1",
            "erase e 1",
            "erase r 1"
        };
        Console.WriteLine(string.Format("operations:{0}", string.Join(" ", operations)));
        int __expected = 5;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new PalindromizationDiv1().getMinimumCost(word, operations);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        string word = "topcoder";
        Console.WriteLine("word:{0}", word);
        string[] operations = new string[] {
            "erase t 10",
            "erase o 1",
            "erase p 1",
            "erase c 1",
            "erase d 1",
            "erase e 1",
            "erase r 1"
        };
        Console.WriteLine(string.Format("operations:{0}", string.Join(" ", operations)));
        int __expected = 7;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new PalindromizationDiv1().getMinimumCost(word, operations);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        string word = "caaaaaab";
        Console.WriteLine("word:{0}", word);
        string[] operations = new string[] {
            "change b a 100000",
            "change c a 100000",
            "change c d 50000",
            "change b e 50000",
            "erase d 50000",
            "erase e 49999"
        };
        Console.WriteLine(string.Format("operations:{0}", string.Join(" ", operations)));
        int __expected = 199999;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new PalindromizationDiv1().getMinimumCost(word, operations);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        string word = "moon";
        Console.WriteLine("word:{0}", word);
        string[] operations = new string[] {
            "erase o 5",
            "add u 7",
            "change d p 3",
            "change m s 12",
            "change n d 6",
            "change s l 1"
        };
        Console.WriteLine(string.Format("operations:{0}", string.Join(" ", operations)));
        int __expected = -1;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new PalindromizationDiv1().getMinimumCost(word, operations);
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
