using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class Egalitarianism2
{
    public double minStdev(int[] X, int[] Y)
    {

        var n = X.Length;
        var D = Enumerate(n * n, x =>
        {
            var p = x / n;
            var q = x % n;
            long dx = X[p] - X[q];
            long dy = Y[p] - Y[q];
            return Math.Sqrt(dx * dx + dy * dy);
        }).Distinct().OrderBy(x => x).ToArray();
        var min = double.MaxValue;
        foreach (var a in D)
            foreach (var b in D)
            {
                if (a <= b) break;

                var c = (a + b) / 2;
                var e = Enumerate(n * n, x =>
                {
                    var p = x / n;
                    var q = x % n;
                    long dx = X[p] - X[q];
                    long dy = Y[p] - Y[q];
                    return new KeyValuePair<int, double>(x, Math.Sqrt(dx * dx + dy * dy));
                });
                Array.Sort(e, (l, r) => ((l.Value - c) * (l.Value - c)).CompareTo((r.Value - c) * (r.Value - c)));
                var set = new DisjointSet(n);
                var cost = new List<double>();
                for (int i = 0; cost.Count < n - 1; i++)
                {
                    if (set.Unite(e[i].Key / n, e[i].Key % n))
                        cost.Add(e[i].Value);

                }
                var avg = 0.0;
                var val = 0.0;
                foreach (var x in cost)
                    avg += x / (n - 1);
                foreach (var x in cost)
                    val += (avg - x) * (avg - x);
                min = Math.Min(min, val);
            }
        return Math.Sqrt(min / (n - 1));
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
#region DisjointSet
public class DisjointSet
{
    public int[] par, ranks, count;
    public DisjointSet(int n)
    {
        par = new int[n];
        count = new int[n];
        for (int i = 0; i < n; i++)
        {
            par[i] = i;
            count[i] = 1;
        }
        ranks = new int[n];
    }
    public int this[int id] { get { return (par[id] == id) ? id : this[par[id]]; } }
    public bool Unite(int x, int y)
    {
        x = this[x]; y = this[y];
        if (x == y) return false;
        if (ranks[x] < ranks[y])
        {
            par[x] = y;
            count[y] += count[x];
        }
        else
        {
            par[y] = x;
            count[x] += count[y];
            if (ranks[x] == ranks[y])
                ranks[x]++;
        }
        return true;
    }
    public int Size(int x) { return count[this[x]]; }
    public bool IsUnited(int x, int y) { return this[x] == this[y]; }

}
#endregion