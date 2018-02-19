using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(string[] room, int K,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine(string.Format("room:{0}", string.Join(" ",room)));
        Console.WriteLine("K:{0}", K);
        }
        int __result = new ColorfulTiles().theCount(room, K);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        string[] room = new string[] {
            "RG"
        };
        Console.WriteLine(string.Format("room:{0}", string.Join(" ", room)));
        int K = 1;
        Console.WriteLine("K:{0}", K);
        int __expected = 5;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new ColorfulTiles().theCount(room, K);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        string[] room = new string[] {
            "BY"
        };
        Console.WriteLine(string.Format("room:{0}", string.Join(" ", room)));
        int K = 2;
        Console.WriteLine("K:{0}", K);
        int __expected = 12;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new ColorfulTiles().theCount(room, K);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        string[] room = new string[] {
            "RG",
            "GR"
        };
        Console.WriteLine(string.Format("room:{0}", string.Join(" ", room)));
        int K = 2;
        Console.WriteLine("K:{0}", K);
        int __expected = 8;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new ColorfulTiles().theCount(room, K);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        string[] room = new string[] {
            "BRYBGYRB",
            "GRYGYBBG",
            "RGBGYBYG",
            "YRBRGBYG",
            "RBGRBRGG",
            "RBGYRYBY"
        };
        Console.WriteLine(string.Format("room:{0}", string.Join(" ", room)));
        int K = 34;
        Console.WriteLine("K:{0}", K);
        int __expected = 489;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new ColorfulTiles().theCount(room, K);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        string[] room = new string[] {
            "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB",
            "BBBBBBYYYBBBBBBBBBBBBBBBBBBBBBBBBBYYYYYBBBBBBBBBBB",
            "BBBBBBYYYBBBBBBBBBBBBBBBBBBBBBBYYYYYYYYYYYBBBBBBBB",
            "BBBBBBYYYYYYYYYYYYYYYYBBBBBBBBYYYYBBBBBYYYYBBBBBBB",
            "BBBBBBYYYYYYYYYYYYYYYYBBBBBBBYYYBBBBBBBBBYYYBBBBBB",
            "BBBBBBYYYBBBBBBBBBBBBBBBBBBBBYYYBBBBBBBBBYYYBBBBBB",
            "BBBBBBYYYBBBBBBBBBBBBBBBBBBBBYYYBBBBBBBBBYYYBBBBBB",
            "BBBBBBYYYBBBBBBBBBBBBBBBBBBBBYYYBBBBBBBBBYYYBBBBBB",
            "BBBBBBYYYBBBBBBBBBBBBBBBBBBBBYYYBBBBBBBBBYYYBBBBBB",
            "BBBBBBYYYBBBBBBBBBBBBBBBBBBBBBYYYYBBBBBYYYYBBBBBBB",
            "BBBBBBYYYBBBBBBBBBBBBBBBBBBBBBBBYYYYYYYYYBBBBBBBBB",
            "BBBBBBYYYYYYYYYYYYBBBBBBBBBBBBBBYYYYYYYYYBBBBBBBBB",
            "BBBBBBYYYYYYYYYYYYYYBBBBBBBBBBYYYYBBBBBYYYYBBBBBBB",
            "BBBBBBBBBBBBBBBBYYYYYBBBBBBBBYYYBBBBBBBBBYYYBBBBBB",
            "BBBBBBBBBBBBBBBBBBYYYBBBBBBBBYYYBBBBBBBBBYYYBBBBBB",
            "BBBBBBBBBBBBBBBBBBYYYBBBBBBBBYYYBBBBBBBBBYYYBBBBBB",
            "BBBBBBYYYBBBBBBBBBYYYBBBBBBBBYYYBBBBBBBBBYYYBBBBBB",
            "BBBBBBYYYBBBBBBBBBYYYBBBBBBBBYYYBBBBBBBBBYYYBBBBBB",
            "BBBBBBBYYYYBBBBBYYYYBBBBBBBBBBYYYYBBBBBYYYYBBBBBBB",
            "BBBBBBBBYYYYYYYYYYYBBBBBBBBBBBBYYYYYYYYYYYBBBBBBBB",
            "BBBBBBBBBBBYYYYYBBBBBBBBBBBBBBBBBBYYYYYBBBBBBBBBBB",
            "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB"
        };
        Console.WriteLine(string.Format("room:{0}", string.Join(" ", room)));
        int K = 825;
        Console.WriteLine("K:{0}", K);
        int __expected = 404506540;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new ColorfulTiles().theCount(room, K);
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
