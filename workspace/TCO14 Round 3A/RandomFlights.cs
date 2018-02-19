using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class RandomFlights
{
    public double expectedDistance(int[] x, int[] y, string[] g)
    {
        var n = x.Length;
        var s = new DisjointSet(n);
        var d = Enumerate(n, v => new double[n]);
        for (int i = 0; i < n; i++)
            for (int j = i + 1; j < n; j++)
                d[i][j] = d[j][i] = 1e9;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                if (g[i][j] == '1')
                {
                    s.Unite(i, j);
                    var dx = x[i] - x[j];
                    var dy = y[i] - y[j];
                    d[i][j] = d[j][i] = Math.Sqrt(dx * dx + dy * dy);
                }

        for (int k = 0; k < n; k++)
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    d[i][j] = Math.Min(d[i][j], d[i][k] + d[k][j]);
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
            {
                if (s[i] == s[j]) continue;
                d[i][j] = 0;
                for (int k = 0; k < n; k++)
                {
                    if (s[i] != s[k]) continue;
                    var dx = x[k] - x[j];
                    var dy = y[k] - y[j];
                    d[i][j] += d[i][k] + Math.Sqrt(dx * dx + dy * dy);
                }
                d[i][j] /= s.Size(i);
            }

        var ans = 0.0;
        var mask = new int[n];
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                if (s[i] == s[j]) mask[i] |= 1 << j;
        var P = new double[1 << n, n];
        var E = new double[1 << n, n];
        P[mask[0], 0] = 1.0;
        for (int i = 0; i < 1 << n; i++)
            for (int j = 0; j < n; j++)
            {
                if (P[i, j] == 0) continue;
                if ((i >> 1 & 1) == 1)
                {
                    if (s[j] == s[1])
                        ans += E[i, j] + P[i, j] * d[j][1];
                    continue;
                }
                var sz = 0;
                for (int k = 0; k < n; k++)
                    if ((i >> k & 1) == 1) sz++;
                for (int k = 0; k < n; k++)
                {
                    if ((i >> k & 1) == 1) continue;
                    {
                        var p = 1.0;
                        p /= sz;
                        p *= s.Size(j);
                        p /= n - sz;
                        P[i | mask[k], j] += p * P[i, j];
                        P[i | mask[k], k] += p * P[i, j];
                        E[i | mask[k], j] += p * E[i, j];
                        E[i | mask[k], k] += p * (E[i, j] + P[i, j] * d[j][k]);
                    }
                    {
                        var p = 1.0;
                        p /= sz;
                        p *= sz - s.Size(j);
                        p /= n - sz;
                        P[i | mask[k], j] += p * P[i, j];
                        E[i | mask[k], j] += p * E[i, j];
                    }
                }
            }
        return ans;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public double Naive_Test(int[] x, int[] y, string[] flight)
    {
        return 0.0;
    }

    // CUT end
}
static public class EnumerableEX
{
    static public string AsString(this IEnumerable<char> e) { return new string(e.ToArray()); }
    static public string AsJoinedString<T>(this IEnumerable<T> e, string s = " ") { return string.Join(s, e); }
}
// CUT begin
public partial class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public void OnInit()
    {
        //Tests.Add(null);
    }
}
// CUT end
#region DisjointSet
public class DisjointSet
{
    int[] par;
    byte[] rank;
    public DisjointSet(int n)
    {
        par = new int[n];
        for (int i = 0; i < n; i++)
            par[i] = -1;
        rank = new byte[n];
    }
    public int this[int id]
    {
        get
        {
            if ((par[id] < 0)) return id;
            return par[id] = this[par[id]];
        }
    }
    public bool Unite(int x, int y)
    {
        x = this[x]; y = this[y];
        if (x == y) return false;
        if (rank[x] < rank[y])
        {
            par[y] += par[x];
            par[x] = y;
        }
        else
        {
            par[x] += par[y];
            par[y] = x;
            if (rank[x] == rank[y])
                rank[x]++;
        }
        return true;
    }
    public int Size(int x) { return -par[this[x]]; }
    public bool IsUnited(int x, int y) { return this[x] == this[y]; }

}
#endregion