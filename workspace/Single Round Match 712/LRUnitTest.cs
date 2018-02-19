using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(long[] s, long[] t,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine(string.Format("s:{0}", string.Join(" ",s)));
        Console.WriteLine(string.Format("t:{0}", string.Join(" ",t)));
        }
        string __result = new LR().construct(s, t);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        long[] s = new long[] {
            0L,
            1L,
            0L,
            0L,
            0L
        };
        Console.WriteLine(string.Format("s:{0}", string.Join(" ", s)));
        long[] t = new long[] {
            0L,
            1L,
            2L,
            1L,
            0L
        };
        Console.WriteLine(string.Format("t:{0}", string.Join(" ", t)));
        string __expected = "LL";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new LR().construct(s, t);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        long[] s = new long[] {
            0L,
            0L,
            0L,
            1L
        };
        Console.WriteLine(string.Format("s:{0}", string.Join(" ", s)));
        long[] t = new long[] {
            0L,
            1L,
            0L,
            0L
        };
        Console.WriteLine(string.Format("t:{0}", string.Join(" ", t)));
        string __expected = "No solution";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new LR().construct(s, t);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        long[] s = new long[] {
            1L,
            2L,
            3L,
            4L,
            5L,
            6L,
            7L,
            8L,
            9L,
            10L
        };
        Console.WriteLine(string.Format("s:{0}", string.Join(" ", s)));
        long[] t = new long[] {
            12L,
            24L,
            56L,
            95L,
            12L,
            78L,
            0L,
            100L,
            54L,
            88L
        };
        Console.WriteLine(string.Format("t:{0}", string.Join(" ", t)));
        string __expected = "No solution";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new LR().construct(s, t);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        long[] s = new long[] {
            1L,
            0L,
            0L
        };
        Console.WriteLine(string.Format("s:{0}", string.Join(" ", s)));
        long[] t = new long[] {
            11L,
            11L,
            10L
        };
        Console.WriteLine(string.Format("t:{0}", string.Join(" ", t)));
        string __expected = "RRRRR";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new LR().construct(s, t);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        long[] s = new long[] {
            1L,
            1L
        };
        Console.WriteLine(string.Format("s:{0}", string.Join(" ", s)));
        long[] t = new long[] {
            562949953421312L,
            562949953421312L
        };
        Console.WriteLine(string.Format("t:{0}", string.Join(" ", t)));
        string __expected = "RLLLRRRLLRRRLRLRRLLLLRLLRRLRRRLRRLRRLLRRRLLRRRLLL";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new LR().construct(s, t);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example5(bool fast = false)
    {
        Console.WriteLine("Example5");
        long[] s = new long[] {
            0L,
            0L,
            0L,
            0L,
            0L
        };
        Console.WriteLine(string.Format("s:{0}", string.Join(" ", s)));
        long[] t = new long[] {
            0L,
            0L,
            0L,
            1L,
            0L
        };
        Console.WriteLine(string.Format("t:{0}", string.Join(" ", t)));
        string __expected = "No solution";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new LR().construct(s, t);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example6(bool fast = false)
    {
        Console.WriteLine("Example6");
        long[] s = new long[] {
            123L,
            456L
        };
        Console.WriteLine(string.Format("s:{0}", string.Join(" ", s)));
        long[] t = new long[] {
            123L,
            456L
        };
        Console.WriteLine(string.Format("t:{0}", string.Join(" ", t)));
        string __expected = "";
        Console.WriteLine("Expected:{0}", __expected);
        string __result = new LR().construct(s, t);
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
