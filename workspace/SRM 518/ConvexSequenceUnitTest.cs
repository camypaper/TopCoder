using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int[] a,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine(string.Format("a:{0}", string.Join(" ",a)));
        }
        long __result = new ConvexSequence().getMinimum(a);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int[] a = new int[] {
            6,
            5,
            1,
            5,
            3,
            3
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        long __expected = 7L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new ConvexSequence().getMinimum(a);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int[] a = new int[] {
            3,
            0,
            1,
            4
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        long __expected = 0L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new ConvexSequence().getMinimum(a);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int[] a = new int[] {
            1,
            1,
            1,
            0,
            2,
            2,
            2
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        long __expected = 5L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new ConvexSequence().getMinimum(a);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        int[] a = new int[] {
            854159326,
            317144183,
            781399725,
            287076509,
            894967145,
            882577367,
            174517516,
            134415519,
            274494874,
            709819883,
            59717133,
            732212854,
            40551288,
            232526958,
            811785438,
            930853743,
            946882902,
            321325300,
            397702677,
            376192501,
            599310562,
            889156198,
            135776890,
            882710939,
            823196361,
            681959076,
            318666702,
            94469186,
            536320456,
            116468376,
            530320850,
            436708006,
            903344748,
            659080120,
            774722507,
            967315412,
            566063635,
            43970906,
            497687103,
            781266213,
            876086123,
            366960001,
            587364849,
            191948103,
            172568553,
            539762057,
            83507466,
            71569625,
            686305822,
            663789601
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        long __expected = 20178337330L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new ConvexSequence().getMinimum(a);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        int[] a = new int[] {
            5
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        long __expected = 0L;
        Console.WriteLine("Expected:{0}", __expected);
        long __result = new ConvexSequence().getMinimum(a);
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
