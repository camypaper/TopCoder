using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int[] seq,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine(string.Format("seq:{0}", string.Join(" ",seq)));
        }
        int __result = new FoxAverageSequence().theCount(seq);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int[] seq = new int[] {
            3,
            -1
        };
        Console.WriteLine(string.Format("seq:{0}", string.Join(" ", seq)));
        int __expected = 4;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new FoxAverageSequence().theCount(seq);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int[] seq = new int[] {
            5,
            3,
            -1
        };
        Console.WriteLine(string.Format("seq:{0}", string.Join(" ", seq)));
        int __expected = 2;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new FoxAverageSequence().theCount(seq);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int[] seq = new int[] {
            -1,
            0,
            40
        };
        Console.WriteLine(string.Format("seq:{0}", string.Join(" ", seq)));
        int __expected = 0;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new FoxAverageSequence().theCount(seq);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        int[] seq = new int[] {
            -1,
            40,
            -1,
            -1,
            -1,
            10,
            -1,
            -1,
            -1,
            21,
            -1
        };
        Console.WriteLine(string.Format("seq:{0}", string.Join(" ", seq)));
        int __expected = 579347890;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new FoxAverageSequence().theCount(seq);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        int[] seq = new int[] {
            -1,
            12,
            25,
            0,
            18,
            -1
        };
        Console.WriteLine(string.Format("seq:{0}", string.Join(" ", seq)));
        int __expected = 58;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new FoxAverageSequence().theCount(seq);
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
