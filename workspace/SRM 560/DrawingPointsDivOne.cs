using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class DrawingPointsDivOne
{
    public int maxSteps(int[] x, int[] y)
    {
        if (x.Length == 1) return -1;
        var n = x.Length;
        var mat = new int[800, 800];
        var ADD = 400;
        var a = new List<KeyValuePair<int, int>>();
        var na = new List<KeyValuePair<int, int>>();
        for (int i = 0; i < n; i++)
        {

            x[i] *= 2;
            y[i] *= 2;
            a.Add(new KeyValuePair<int, int>(x[i], y[i]));
            mat[ADD + x[i], ADD + y[i]] = 1;
        }
        Func<int, bool> ok = k =>
           {
               na = new List<KeyValuePair<int, int>>();
               var next = new int[800, 800];
               for (int i = 0; i < 800; i++)
                   for (int j = 0; j < 800; j++)
                   {
                       if (mat[i, j] != 1) continue;
                       next[i - 1, j - 1] =
                       next[i - 1, j + 1] =
                       next[i + 1, j - 1] =
                       next[i + 1, j + 1] = 1;
                   }
               for (int i = 0; i < 800; i++) for (int j = 0; j < 800; j++) if (next[i, j] == 1) na.Add(new KeyValuePair<int, int>(i, j));

               for (int i = 1; i < 799; i++)
                   for (int j = 1; j < 799; j++)
                   {
                       if (
                       next[i - 1, j - 1] == 1 &&
                       next[i - 1, j + 1] == 1 &&
                       next[i + 1, j - 1] == 1 &&
                       next[i + 1, j + 1] == 1 &&
                       mat[i, j] == 0)
                           mat[i, j] = 2;
                   }
               for (int i = 0; i < 800; i++)
                   for (int j = 0; j < 800; j++)
                   {
                       if (mat[i, j] != 2) continue;
                       if (k == 1) return false;
                       var d = (k - 1) * 2;
                       if (
                       i + d < 800 && mat[i + d, j] >= 1 &&
                       j + d < 800 && mat[i, j + d] >= 1 &&
                       mat[i + d, j + d] >= 1)
                           return false;
                       if (
                       i - d >= 0 && mat[i - d, j] >= 1 &&
                       j + d < 800 && mat[i, j + d] >= 1 &&
                       mat[i - d, j + d] >= 1)
                           return false;
                       if (
                       i + d < 800 && mat[i + d, j] >= 1 &&
                       j - d >= 0 && mat[i, j - d] >= 1 &&
                       mat[i + d, j - d] >= 1)
                           return false;
                       if (
                       i - d >= 0 && mat[i - d, j] >= 1 &&
                       j - d >= 0 && mat[i, j - d] >= 1 &&
                       mat[i - d, j - d] >= 1)
                           return false;
                   }
               mat = next;
               return true;
           };
        for (int i = 1; i < 300; i++)
        {
            if (ok(i))
            {
                a = na;
            }
            else
            {
                var unko = Enumerate(800, z => new int[800]);
                foreach (var p in a)
                    unko[p.Key][p.Value] |= 1;
                foreach (var p in na)
                    unko[p.Key][p.Value] |= 2;
                if (n >= 5)
                {
                    var sb = new StringBuilder();
                    foreach (var z in unko)
                        sb.AppendLine(z.AsJoinedString(""));
                    var t = sb.ToString();
                }
                return i - 1;
            }
        }
        return -1;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
}
static public class EnumerableEX
{
    static public string AsString(this IEnumerable<char> e) { return new string(e.ToArray()); }
    static public string AsJoinedString<T>(this IEnumerable<T> e, string s = " ") { return string.Join(s, e); }
}
// CUT begin
public class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
    }
}
// CUT end
