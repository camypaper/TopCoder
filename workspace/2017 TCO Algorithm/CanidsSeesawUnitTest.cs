using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int[] wolf, int[] fox, int k,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine(string.Format("wolf:{0}", string.Join(" ",wolf)));
        Console.WriteLine(string.Format("fox:{0}", string.Join(" ",fox)));
        Console.WriteLine("k:{0}", k);
        }
        int[] __result = new CanidsSeesaw().construct(wolf, fox, k);
        if(!__fast)
        {
        Console.WriteLine(string.Format("Result:{0}",string.Join(" ", __result)));
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int[] wolf = new int[] {
            3,
            1
        };
        Console.WriteLine(string.Format("wolf:{0}", string.Join(" ", wolf)));
        int[] fox = new int[] {
            4,
            2
        };
        Console.WriteLine(string.Format("fox:{0}", string.Join(" ", fox)));
        int k = 1;
        Console.WriteLine("k:{0}", k);
        int[] __expected = new int[] {
            1,
            0
        };
        Console.WriteLine(string.Format("Expected:{0}", string.Join(" ",__expected)));
        int[] __result = new CanidsSeesaw().construct(wolf, fox, k);
        Console.WriteLine(string.Format("Result:{0}",string.Join(" ", __result)));
            return check(__expected, __result);
     }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int[] wolf = new int[] {
            1,
            3
        };
        Console.WriteLine(string.Format("wolf:{0}", string.Join(" ", wolf)));
        int[] fox = new int[] {
            4,
            2
        };
        Console.WriteLine(string.Format("fox:{0}", string.Join(" ", fox)));
        int k = 1;
        Console.WriteLine("k:{0}", k);
        int[] __expected = new int[] {
        };
        Console.WriteLine(string.Format("Expected:{0}", string.Join(" ",__expected)));
        int[] __result = new CanidsSeesaw().construct(wolf, fox, k);
        Console.WriteLine(string.Format("Result:{0}",string.Join(" ", __result)));
            return check(__expected, __result);
     }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int[] wolf = new int[] {
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10
        };
        Console.WriteLine(string.Format("wolf:{0}", string.Join(" ", wolf)));
        int[] fox = new int[] {
            1,
            100,
            1,
            100,
            1,
            100,
            1,
            100,
            1,
            100
        };
        Console.WriteLine(string.Format("fox:{0}", string.Join(" ", fox)));
        int k = 7;
        Console.WriteLine("k:{0}", k);
        int[] __expected = new int[] {
            0,
            2,
            4,
            1,
            6,
            3,
            5,
            7,
            9,
            8
        };
        Console.WriteLine(string.Format("Expected:{0}", string.Join(" ",__expected)));
        int[] __result = new CanidsSeesaw().construct(wolf, fox, k);
        Console.WriteLine(string.Format("Result:{0}",string.Join(" ", __result)));
            return check(__expected, __result);
     }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        int[] wolf = new int[] {
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10,
            10
        };
        Console.WriteLine(string.Format("wolf:{0}", string.Join(" ", wolf)));
        int[] fox = new int[] {
            1,
            100,
            1,
            100,
            1,
            100,
            1,
            100,
            1,
            100
        };
        Console.WriteLine(string.Format("fox:{0}", string.Join(" ", fox)));
        int k = 4;
        Console.WriteLine("k:{0}", k);
        int[] __expected = new int[] {
        };
        Console.WriteLine(string.Format("Expected:{0}", string.Join(" ",__expected)));
        int[] __result = new CanidsSeesaw().construct(wolf, fox, k);
        Console.WriteLine(string.Format("Result:{0}",string.Join(" ", __result)));
            return check(__expected, __result);
     }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        int[] wolf = new int[] {
            2
        };
        Console.WriteLine(string.Format("wolf:{0}", string.Join(" ", wolf)));
        int[] fox = new int[] {
            1
        };
        Console.WriteLine(string.Format("fox:{0}", string.Join(" ", fox)));
        int k = 0;
        Console.WriteLine("k:{0}", k);
        int[] __expected = new int[] {
            0
        };
        Console.WriteLine(string.Format("Expected:{0}", string.Join(" ",__expected)));
        int[] __result = new CanidsSeesaw().construct(wolf, fox, k);
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
