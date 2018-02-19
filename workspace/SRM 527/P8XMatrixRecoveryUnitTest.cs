using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(string[] rows, string[] columns,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine(string.Format("rows:{0}", string.Join(" ",rows)));
        Console.WriteLine(string.Format("columns:{0}", string.Join(" ",columns)));
        }
        string[] __result = new P8XMatrixRecovery().solve(rows, columns);
        if(!__fast)
        {
        Console.WriteLine(string.Format("Result:{0}",string.Join(" ", __result)));
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        string[] rows = new string[] {
            "10?",
            "?11"
        };
        Console.WriteLine(string.Format("rows:{0}", string.Join(" ", rows)));
        string[] columns = new string[] {
            "01",
            "10",
            "1?"
        };
        Console.WriteLine(string.Format("columns:{0}", string.Join(" ", columns)));
        string[] __expected = new string[] {
            "101",
            "011"
        };
        Console.WriteLine(string.Format("Expected:{0}", string.Join(" ",__expected)));
        string[] __result = new P8XMatrixRecovery().solve(rows, columns);
        Console.WriteLine(string.Format("Result:{0}",string.Join(" ", __result)));
            return check(__expected, __result);
     }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        string[] rows = new string[] {
            "0",
            "?",
            "1"
        };
        Console.WriteLine(string.Format("rows:{0}", string.Join(" ", rows)));
        string[] columns = new string[] {
            "0?1"
        };
        Console.WriteLine(string.Format("columns:{0}", string.Join(" ", columns)));
        string[] __expected = new string[] {
            "0",
            "0",
            "1"
        };
        Console.WriteLine(string.Format("Expected:{0}", string.Join(" ",__expected)));
        string[] __result = new P8XMatrixRecovery().solve(rows, columns);
        Console.WriteLine(string.Format("Result:{0}",string.Join(" ", __result)));
            return check(__expected, __result);
     }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        string[] rows = new string[] {
            "10",
            "01"
        };
        Console.WriteLine(string.Format("rows:{0}", string.Join(" ", rows)));
        string[] columns = new string[] {
            "10",
            "01"
        };
        Console.WriteLine(string.Format("columns:{0}", string.Join(" ", columns)));
        string[] __expected = new string[] {
            "10",
            "01"
        };
        Console.WriteLine(string.Format("Expected:{0}", string.Join(" ",__expected)));
        string[] __result = new P8XMatrixRecovery().solve(rows, columns);
        Console.WriteLine(string.Format("Result:{0}",string.Join(" ", __result)));
            return check(__expected, __result);
     }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        string[] rows = new string[] {
            "??0",
            "11?",
            "?01",
            "1?1"
        };
        Console.WriteLine(string.Format("rows:{0}", string.Join(" ", rows)));
        string[] columns = new string[] {
            "1???",
            "?111",
            "0?1?"
        };
        Console.WriteLine(string.Format("columns:{0}", string.Join(" ", columns)));
        string[] __expected = new string[] {
            "010",
            "110",
            "101",
            "101"
        };
        Console.WriteLine(string.Format("Expected:{0}", string.Join(" ",__expected)));
        string[] __result = new P8XMatrixRecovery().solve(rows, columns);
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
