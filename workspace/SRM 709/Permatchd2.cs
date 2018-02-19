using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class Permatchd2
{
    public int fix(string[] graph)
    {
        var n = graph.Length;
        var s = new DisjointSet(n);
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                if (graph[i][j] == 'Y') s.Unite(i, j);
        var a = new int[n];
        for (int i = 0; i < n; i++)
        {
            if (s[i] != i) continue;
            for (int j = 0; j < n; j++)
                for (int k = 0; k < n; k++)
                    if (s[j] == s[i] && graph[j][k] == 'Y')
                        a[i]++;
        }
        var oo = 0;
        var o = 0;
        var e = 0;
        for (int i = 0; i < n; i++)
            if (s[i] == i)
            {
                a[i] /= 2;
                if (a[i] % 2 == 0) e++;
                else
                {
                    if (a[i] == s.Size(i) * (s.Size(i) - 1) / 2) oo++;
                    else o++;
                }
            }
        if (oo + o == 0) return 0;
        if (e > 0) return oo + o;
        if (o >= 1 || oo + o > 1)
        {
            return oo + o;
        }
        return -1;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(string[] graph)
    {
        return 0;
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