using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class HatRack
{
    public long countWays(int[] a, int[] b)
    {
        var n = a.Length + 1;
        var G = Enumerate(n, x => new List<int>());
        for (int i = 0; i < a.Length; i++)
        {
            a[i]--;
            b[i]--;
            G[a[i]].Add(b[i]);
            G[b[i]].Add(a[i]);
        }
        for (int i = 0; i < n; i++)
            if (G[i].Count > 3) return 0;
        return f(n, G);
    }
    long f(int n, List<int>[] G)
    {
        long ans = 0;
        for (int r = 0; r < n; r++)
        {
            var ok = true;
            var cnt = 0;
            Func<int, int, KeyValuePair<int, int>> dfs = null;

            dfs = (prev, cur) =>
              {
                  var A = new List<KeyValuePair<int, int>>();
                  foreach (var to in G[cur])
                  {
                      if (to == prev) continue;
                      A.Add(dfs(cur, to));
                  }
                  if (A.Count >= 3)
                  {
                      ok = false;
                      return new KeyValuePair<int, int>(0, 0);
                  }
                  else if (A.Count == 2)
                  {

                      if (A[0].Key == A[1].Key)
                      {
                          if (1L << A[0].Key == A[0].Value + 1 && 1L << A[1].Key == A[1].Value + 1) cnt++;
                          if (1L << A[0].Key != A[0].Value + 1 && 1L << A[1].Key != A[1].Value + 1) ok = false;
                      }
                      else if (Math.Abs(A[0].Key - A[1].Key) == 1)
                      {
                          if (A[0].Key > A[1].Key && 1L << A[1].Key != A[1].Value + 1) ok = false;
                          if (A[0].Key < A[1].Key && 1L << A[0].Key != A[0].Value + 1) ok = false;
                      }
                      else ok = false;

                      return new KeyValuePair<int, int>(A.Max(x => x.Key) + 1, A.Sum(x => x.Value) + 1);
                  }
                  else if (A.Count == 1)
                  {
                      if (A[0].Value == 1) return new KeyValuePair<int, int>(2, 2);
                      else
                      {
                          ok = false;
                          return new KeyValuePair<int, int>(0, 0);
                      }
                  }
                  else return new KeyValuePair<int, int>(1, 1);
              };

            var ret = dfs(-1, r);

            if (ok)
                ans += 1L << cnt;




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
public class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
        test.ManualTest(
           new int[] { 7, 5, 5, 7, 4, 5, 6, 2, 2 },
           new int[] { 3, 2, 3, 8, 1, 1, 1, 10, 9 }
             );
    }
}
// CUT end
