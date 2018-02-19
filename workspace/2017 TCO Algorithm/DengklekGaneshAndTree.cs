using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class DengklekGaneshAndTree
{
    public int getCount(string labels, int[] parents)
    {
        var n = parents.Length + 1;
        var s = new DisjointSet(n);
        var lv = new int[n];
        for (int i = 0; i < n - 1; i++)
        {
            var p = parents[i];
            lv[i + 1] = lv[p] + 1;
            if (labels[p] == labels[i + 1]) s.Unite(p, i + 1);
        }
        var min = Enumerate(n, x => 1000000000);
        var max = Enumerate(n, x => -1);
        for (int i = 0; i < n; i++)
        {
            var p = s[i];
            min[p] = Math.Min(min[p], lv[i]);
            max[p] = Math.Max(max[p], lv[i]);
        }
        var L = max.Max() + 1;
        var G = Enumerate(L, x => new List<int>());
        for (int i = 0; i < n; i++)
            if (s[i] == i)
            {
                //Debug.WriteLine(i);
                //Debug.WriteLine("{0} {1}", min[i], max[i]);
                G[min[i]].Add(max[i]);
            }
        var dp = new long[L];
        dp[max[s[0]]] = 1;
        const long MOD = (long)1e9 + 7;
        for (int l = 1; l < L; l++)
        {
            foreach (var x in G[l])
            {
                //Debug.WriteLine(dp.AsJoinedString());
                var next = new long[L];
                for (int i = 0; i < L; i++)
                {
                    if (dp[i] == 0) continue;
                    if (i < l - 1) continue;
                    next[i] = (next[i] + dp[i]) % MOD;
                    var to = Math.Max(i, x);
                    next[to] = (next[to] + dp[i]) % MOD;
                }
                dp = next;
            }
        }



        return (int)dp.Last();
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(string labels, int[] parents)
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
    public override void Run()
    {
        var n = 1000;
        var p = Enumerate(n, x => rand.Next() % (x + 1));
        var s = new StringBuilder();
        for (int i = 0; i < n + 1; i++)
        {
            var x = rand.Next() % 26;
            s.Append((char)(x + 'a'));
        }
        ManualTest(s.ToString(), p, false);
        //Tests.Add(null);
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);
        Test(Example4);

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