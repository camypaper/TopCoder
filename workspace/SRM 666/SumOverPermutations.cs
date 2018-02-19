using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class SumOverPermutations
{
    public int findSum(int n)
    {
        var dp = Enumerate(3, x => new ModInteger[n + 1]);
        for (int i = 0; i < 3; i++)
            for (int j = 0; j <= n; j++)
                dp[i][j].num = -1;
        dp[2][1] = n - 2;
        dp[1][1] = n - 1;
        dp[0][1] = n;
        dp[0][0] = dp[1][0] = dp[2][0] = 1;

        var binomial = Enumerate(n + 1, x => new ModInteger[n + 1]);
        binomial[0][0] = 1;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
            {
                binomial[i + 1][j] += binomial[i][j];
                binomial[i + 1][j + 1] += binomial[i][j];
            }
        Func<int, int, ModInteger> dfs = null;
        dfs = (k, rem) =>
          {
              if (dp[k][rem].num >= 0) return dp[k][rem];
              Debug.WriteLine("{0} {1}", k, rem);
              ModInteger ret = 0;
              for (int i = 0; i < rem; i++)
              {
                  var a = n;
                  var lk = -1;
                  var rk = -1;
                  if (i == 0 && k > 0) a--;
                  if (i == rem - 1 && k == 2) a--;
                  var l = i; var r = rem - i - 1;
                  if (k == 0) { lk = 1; rk = 1; }
                  else if (k == 1) { lk = 2; rk = 1; }
                  else { lk = rk = 2; }
                  ret += a * binomial[l + r][l] * dfs(lk, l) * dfs(rk, r);
              }

              return dp[k][rem] = ret;
          };
        var ans = dfs(0, n);
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