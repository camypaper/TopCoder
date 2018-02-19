using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class GraphInversions
{
    public int getMinimumInversions(int[] A, int[] B, int[] V, int K)
    {
        var n = A.Length;
        var xs = V.Distinct().ToList();
        xs.Add(-1); xs.Sort();
        for (int i = 0; i < n; i++)
            V[i] = xs.BinarySearch(V[i]);
        var G = Enumerate(n, x => new List<int>());
        for (int i = 0; i < n; i++)
        {
            G[A[i]].Add(B[i]);
            G[B[i]].Add(A[i]);
        }
        var min = int.MaxValue;
        Func<int, SortedSet<int>, FenwickTree, int, int> dfs = null;
        dfs = (cur, set, bit, inv) =>
          {
              if (set.Count >= K)
              {
                  min = Math.Min(min, inv);
                  return 0;
              }
              foreach (var to in G[cur])
              {
                  if (set.Contains(to)) continue;
                  var ninv = inv;
                  ninv += set.Count - bit[V[to]];
                  set.Add(to);
                  bit.Add(V[to], 1);
                  dfs(to, set, bit, ninv);
                  bit.Add(V[to], -1);
                  set.Remove(to);
              }
              return 0;
          };
        for (int i = 0; i < n; i++)
        {

            var s = new SortedSet<int>() { i };
            var bit = new FenwickTree(xs.Count);
            bit.Add(V[i], 1);
            dfs(i, s, bit, 0);
        }
        if (min == int.MaxValue) return -1;
        return min;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(int[] A, int[] B, int[] V, int K)
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

#region FenwickTree
[System.Diagnostics.DebuggerDisplay("Data={ToString()}")]
public class FenwickTree
{
    int n;
    int[] bit;
    int max = 1;
    public FenwickTree(int size)
    {
        n = size; bit = new int[n + 1];
        while ((max << 1) <= n) max <<= 1;
    }
    /// <summary>sum[a,b]</summary>
    public int this[int i, int j] { get { return this[j] - this[i - 1]; } }
    /// <summary>sum[0,i]</summary>
    public int this[int i] { get { int s = 0; for (; i > 0; i -= i & -i) s += bit[i]; return s; } }
    /// <summary>add v to bit[i]</summary>
    public void Add(int i, int v)
    {
        if (i == 0) System.Diagnostics.Debug.Fail("BIT is 1 indexed");
        for (; i <= n; i += i & -i) bit[i] += v;
    }
    public override string ToString() { return string.Join(",", Enumerable.Range(0, n + 1).Select(i => this[i, i])); }
}
#endregion