using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class FoxAirline2
{
    public string isPossible(int n, int[] a, int[] b)
    {
        Func<int, DisjointSet, DisjointSet, bool> dfs = null;
        var m = a.Length;
        dfs = (cur, s, t) =>
          {
              //Debug.WriteLine("{0}", cur);
              //Debug.WriteLine("{0} $ {1}", s.par.AsJoinedString(), t.par.AsJoinedString());
              if (s.Size(0) == n && t.Size(0) == n) return true;
              if (cur == m) return false;
              var cnt = 0;
              if (!s.IsUnited(a[cur], b[cur]))
              {
                  var ns = new DisjointSet(n);
                  ns.par = s.par.ToArray();
                  ns.ranks = s.ranks.ToArray();
                  ns.count = s.count.ToArray();
                  var nt = new DisjointSet(n);
                  nt.par = t.par.ToArray();
                  nt.ranks = t.ranks.ToArray();
                  nt.count = t.count.ToArray();
                  ns.Unite(a[cur], b[cur]);
                  if (dfs(cur + 1, ns, nt)) return true;
                  cnt++;
              }
              if (!t.IsUnited(a[cur], b[cur]))
              {
                  var ns = new DisjointSet(n);
                  ns.par = s.par.ToArray();
                  ns.ranks = s.ranks.ToArray();
                  ns.count = s.count.ToArray();
                  var nt = new DisjointSet(n);
                  nt.par = t.par.ToArray();
                  nt.ranks = t.ranks.ToArray();
                  nt.count = t.count.ToArray();
                  nt.Unite(a[cur], b[cur]);
                  if (dfs(cur + 1, ns, nt)) return true;
                  cnt++;
              }
              if (cnt == 0) return dfs(cur + 1, s, t);
              return false;
          };
        if (dfs(0, new DisjointSet(n), new DisjointSet(n))) return "Possible";
        return "Impossible";
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
        test.ManualTest(10, new int[] { 6, 0, 4, 0, 5, 5, 3, 2, 7, 8, 5, 8, 3, 2, 6, 8, 1, 5 }, new int[] { 0, 9, 2, 2, 8, 4, 5, 7, 1, 6, 9, 5, 8, 4, 7, 4, 5, 0 });

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