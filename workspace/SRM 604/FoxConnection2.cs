using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class FoxConnection2
{
    public int ways(int[] A, int[] B, int k)
    {
        var n = A.Length + 1;
        var G = Enumerate(n, x => new List<int>());
        for (int i = 0; i < n - 1; i++)
        {
            A[i]--; B[i]--;
            G[A[i]].Add(B[i]);
            G[B[i]].Add(A[i]);
        }
        Func<int, int, ModInteger[]> dfs = null;
        ModInteger ans = 0;
        dfs = (prev, cur) =>
          {
              var dp = new ModInteger[120];
              dp[1] = 1;
              foreach (var to in G[cur])
              {
                  if (prev == to) continue;
                  var res = dfs(cur, to);
                  res[0] = 1;
                  var next = new ModInteger[120];
                  for (int i = 0; i <= 50; i++)
                      for (int j = 0; j <= 50; j++)
                          next[i + j] += dp[i] * res[j];
                  dp = next;
              }
              ans += dp[k];
              return dp;
          };
        dfs(-1, 0);
        return (int)ans.num;
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

#region ModNumber
public partial struct ModInteger
{
    public const long Mod = (long)1e9 + 7;
    public long num;
    public ModInteger(long n) : this() { num = n % Mod; if (num < 0) num += Mod; }
    public override string ToString() { return num.ToString(); }
    public static ModInteger operator +(ModInteger l, ModInteger r) { var n = l.num + r.num; if (n >= Mod) n -= Mod; return new ModInteger() { num = n }; }
    public static ModInteger operator -(ModInteger l, ModInteger r) { var n = l.num + Mod - r.num; if (n >= Mod) n -= Mod; return new ModInteger() { num = n }; }
    public static ModInteger operator *(ModInteger l, ModInteger r) { return new ModInteger(l.num * r.num); }
    public static implicit operator ModInteger(long n) { return new ModInteger(n); }
}
#endregion