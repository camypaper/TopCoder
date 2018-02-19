using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class AdjacentSwaps
{
    public int theCount(int[] p)
    {
        var n = p.Length;
        var dp = new ModInteger[n, n];
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                dp[i, j].num = -1;
        for (int i = 0; i < n; i++)
            dp[i, i] = 1;

        var binomial = new ModInteger[n + 10, n + 10];
        binomial[0, 0] = 1;
        for (int i = 0; i <= n; i++)
            for (int j = 0; j <= n; j++)
            {
                binomial[i + 1, j] += binomial[i, j];
                binomial[i + 1, j + 1] += binomial[i, j];
            }
        Func<int, int, ModInteger> dfs = null;
        dfs = (l, r) =>
          {
              if (dp[l, r].num != -1) return dp[l, r];
              Debug.WriteLine("{0} {1}: {2}", l, r, p.AsJoinedString());
              ModInteger ret = 0;
              var sorted = new List<int>();
              for (int i = l; i <= r; i++)
                  sorted.Add(p[i]);
              sorted.Sort();
              for (int k = l; k < r; k++)
              {
                  var count = new int[n];
                  for (int i = l; i < k; i++)
                      count[p[i]] = 1;
                  count[p[k + 1]] = 1;
                  var ok = true;
                  for (int i = l; i <= k; i++)
                      if (count[sorted[i - l]] == 0) ok = false;
                  if (ok)
                  {
                      Swap(ref p[k], ref p[k + 1]);
                      ret += binomial[r - l - 1, k - l] * dfs(l, k) * dfs(k + 1, r);
                      Swap(ref p[k], ref p[k + 1]);
                  }

              }
              return dp[l, r] = ret;
          };
        var ans = dfs(0, n - 1);
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
public class Tester: AbstractTester
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
    public static ModInteger operator ^(ModInteger l, long r) { return ModInteger.Pow(l, r); }
    public static implicit operator ModInteger(long n) { return new ModInteger(n); }
    public static ModInteger Pow(ModInteger v, long k)
    {
        ModInteger ret = 1;
        var n = k;
        for (; n > 0; n >>= 1, v *= v)
        {
            if ((n & 1) == 1)
                ret = ret * v;
        }
        return ret;
    }
}
#endregion