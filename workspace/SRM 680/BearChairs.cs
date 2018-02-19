using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class BearChairs
{
    public int[] findPositions(int[] atLeast, int d)
    {
        var v = new List<int>();
        v.Add(atLeast[0]);
        var n = atLeast.Length;
        var ans = new int[n];
        ans[0] = v[0];
        for (int i = 1; i < n; i++)
        {
            var x = atLeast[i];
            var go = -1000;
            for (int j = 0; j < v.Count && go < 0; j++)
            {
                if (j == 0)
                {
                    if (x + d <= v[j])
                    {
                        go = x;
                    }
                }
                else
                {
                    var max = Math.Max(x, v[j - 1] + d);
                    if (max + d <= v[j])
                        go = max;
                }
            }
            if (go < 0) go = Math.Max(x, v.Last() + d);
            v.Add(go);
            v.Sort();
            ans[i] = go;
        }
        return ans;
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
public class Tester : AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
    }
}
// CUT end
