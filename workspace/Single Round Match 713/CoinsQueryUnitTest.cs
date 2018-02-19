using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int[] w, int[] v, int[] query,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine(string.Format("w:{0}", string.Join(" ",w)));
        Console.WriteLine(string.Format("v:{0}", string.Join(" ",v)));
        Console.WriteLine(string.Format("query:{0}", string.Join(" ",query)));
        }
        long[] __result = new CoinsQuery().query(w, v, query);
        if(!__fast)
        {
        Console.WriteLine(string.Format("Result:{0}",string.Join(" ", __result)));
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int[] w = new int[] {
            2,
            3,
            5
        };
        Console.WriteLine(string.Format("w:{0}", string.Join(" ", w)));
        int[] v = new int[] {
            20,
            30,
            50
        };
        Console.WriteLine(string.Format("v:{0}", string.Join(" ", v)));
        int[] query = new int[] {
            1,
            2,
            3,
            4,
            5,
            6
        };
        Console.WriteLine(string.Format("query:{0}", string.Join(" ", query)));
        long[] __expected = new long[] {
            -1L,
            -1L,
            20L,
            1L,
            30L,
            1L,
            40L,
            1L,
            50L,
            3L,
            60L,
            2L
        };
        Console.WriteLine(string.Format("Expected:{0}", string.Join(" ",__expected)));
        long[] __result = new CoinsQuery().query(w, v, query);
        Console.WriteLine(string.Format("Result:{0}",string.Join(" ", __result)));
            return check(__expected, __result);
     }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int[] w = new int[] {
            7,
            4,
            3,
            8
        };
        Console.WriteLine(string.Format("w:{0}", string.Join(" ", w)));
        int[] v = new int[] {
            10,
            20,
            17,
            13
        };
        Console.WriteLine(string.Format("v:{0}", string.Join(" ", v)));
        int[] query = new int[] {
            10,
            100,
            1000,
            100000
        };
        Console.WriteLine(string.Format("query:{0}", string.Join(" ", query)));
        long[] __expected = new long[] {
            54L,
            3L,
            564L,
            33L,
            5664L,
            333L,
            566664L,
            33333L
        };
        Console.WriteLine(string.Format("Expected:{0}", string.Join(" ",__expected)));
        long[] __result = new CoinsQuery().query(w, v, query);
        Console.WriteLine(string.Format("Result:{0}",string.Join(" ", __result)));
            return check(__expected, __result);
     }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int[] w = new int[] {
            2,
            3,
            5
        };
        Console.WriteLine(string.Format("w:{0}", string.Join(" ", w)));
        int[] v = new int[] {
            1,
            10,
            100
        };
        Console.WriteLine(string.Format("v:{0}", string.Join(" ", v)));
        int[] query = new int[] {
            1,
            2,
            3,
            4,
            5,
            6
        };
        Console.WriteLine(string.Format("query:{0}", string.Join(" ", query)));
        long[] __expected = new long[] {
            -1L,
            -1L,
            1L,
            1L,
            10L,
            1L,
            2L,
            1L,
            100L,
            1L,
            20L,
            1L
        };
        Console.WriteLine(string.Format("Expected:{0}", string.Join(" ",__expected)));
        long[] __result = new CoinsQuery().query(w, v, query);
        Console.WriteLine(string.Format("Result:{0}",string.Join(" ", __result)));
            return check(__expected, __result);
     }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        int[] w = new int[] {
            1,
            1
        };
        Console.WriteLine(string.Format("w:{0}", string.Join(" ", w)));
        int[] v = new int[] {
            1,
            1
        };
        Console.WriteLine(string.Format("v:{0}", string.Join(" ", v)));
        int[] query = new int[] {
            10,
            20,
            30,
            40,
            50
        };
        Console.WriteLine(string.Format("query:{0}", string.Join(" ", query)));
        long[] __expected = new long[] {
            10L,
            1024L,
            20L,
            1048576L,
            30L,
            73741817L,
            40L,
            511620083L,
            50L,
            898961331L
        };
        Console.WriteLine(string.Format("Expected:{0}", string.Join(" ",__expected)));
        long[] __result = new CoinsQuery().query(w, v, query);
        Console.WriteLine(string.Format("Result:{0}",string.Join(" ", __result)));
            return check(__expected, __result);
     }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        int[] w = new int[] {
            1
        };
        Console.WriteLine(string.Format("w:{0}", string.Join(" ", w)));
        int[] v = new int[] {
            1000000000
        };
        Console.WriteLine(string.Format("v:{0}", string.Join(" ", v)));
        int[] query = new int[] {
            1,
            1000000000
        };
        Console.WriteLine(string.Format("query:{0}", string.Join(" ", query)));
        long[] __expected = new long[] {
            1000000000L,
            1L,
            1000000000000000000L,
            1L
        };
        Console.WriteLine(string.Format("Expected:{0}", string.Join(" ",__expected)));
        long[] __result = new CoinsQuery().query(w, v, query);
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
