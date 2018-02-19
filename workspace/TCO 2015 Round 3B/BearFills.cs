using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class BearFills
{
    public long countSets(int N, long W, long H)
    {
        if (H > W) Swap(ref W, ref H);
        Func<int, long, long, long> dfs = null;
        var dp = new Dictionary<Triplet<int, long, long>, long>();
        dfs = (i, h, w) =>
          {
              if (i < 0) return 0;
              long ret = 0;
              var s = new Triplet<int, long, long>(i, h, w);
              if (dp.TryGetValue(s, out ret)) return ret;
              if ((1L << i) < h)
                  return dp[s] = 0;
              ret += dfs(i - 1, h, w);
              if (w >= (2L << i)) return dp[s] = 0;
              else if (w <= (1L << i))
              {
                  ret += 1L << i;
              }
              else
              {
                  w -= (1L << i);
                  if (h > w) Swap(ref h, ref w);
                  ret += dfs(i - 1, h, w);
              }
              return dp[s] = ret;
          };
        var ans = dfs(N - 1, H, W);
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
        test.ManualTest(60, (long)1e15, (int)8);
    }
}
// CUT end
#region Triplet<ST,FT,TT>
public struct Triplet<FT, ST, TT> : IComparable<Triplet<FT, ST, TT>>
    where FT : IComparable<FT>
    where ST : IComparable<ST>
    where TT : IComparable<TT>
{
    public FT I;
    public ST J;
    public TT K;
    public Triplet(FT i, ST j, TT k) : this() { I = i; J = j; K = k; }
    public int CompareTo(Triplet<FT, ST, TT> other)
    {
        var cmp = I.CompareTo(other.I);
        if (cmp != 0) return cmp;
        cmp = J.CompareTo(other.J);
        if (cmp != 0) return cmp;
        return K.CompareTo(other.K);
    }
    public override string ToString() { return string.Format("{0} {1} {2}", I, J, K); }
}
#endregion