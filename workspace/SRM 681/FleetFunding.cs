using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class FleetFunding
{
    public int maxShips(int m, int[] k, int[] a, int[] b)
    {
        for (int i = 0; i < a.Length; i++)
        {
            a[i]--; b[i]--;
        }
        var id = Enumerate(a.Length, x => x);
        Array.Sort(id, (u, v) => b[u].CompareTo(b[v]));
        int l = 0; int r = 1000000000;
        for (int _ = 0; _ < 50; _++)
        {
            var v = (l + r) / 2;
            if (calc(m, v, k, a, b, id))
            {
                l = v;
            }
            else
            {
                r = v;
            }

        }
        for (int i = l + 2; i >= l; i--)
            if (calc(m, i, k, a, b, id)) return i;
        return l;
    }
    public bool calc(int m, int goal, int[] k, int[] a, int[] b, int[] id)
    {
        var part = new int[m];
        var n = a.Length;
        for (int i = 0; i < n; i++)
        {
            var rem = k[id[i]];
            for (int j = a[id[i]]; j <= b[id[i]] && rem > 0; j++)
            {
                if (part[j] >= goal) continue;
                else
                {
                    var need = goal - part[j];
                    if (rem >= need) { part[j] = goal; rem -= need; }
                    else
                    {
                        part[j] += rem;
                        rem = 0;
                        break;
                    }
                }
            }
        }
        for (int i = 0; i < m; i++)
            if (part[i] < goal) return false;
        return true;
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
        var m = Enumerable.Repeat(1000000, 50).ToArray();
        var a = Enumerable.Repeat(1, 50).ToArray();
        var b = Enumerable.Repeat(1, 50).ToArray();
        test.ManualTest(1, m, a, b);
    }
}
// CUT end
