using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class BearPermutations
{
    public int countPermutations(int n, int s, int MOD)
    {
        ModInteger.Mod = MOD;
        var comb = new ModCombinationTable(n + 1);
        var dp = Enumerate(n + 1, x => new ModInteger[s + 2]);
        for (int i = 0; i <= n; i++)
            for (int j = 0; j <= s; j++)
                dp[i][j].num = -1;
        var DP = Enumerate(n + 1, x => Enumerate(n + 1, y => new ModInteger[s + 2]));
        for (int i = 0; i <= n; i++)
            for (int j = 0; j <= n; j++)
                for (int k = 0; k <= s + 1; k++)
                    DP[i][j][k].num = -1;
        for (int i = 0; i <= n; i++)
            for (int j = i; j <= n; j++)
                for (int k = 0; k <= s + 1; k++)
                    DP[i][j][k] = 0;
        for (int i = 0; i <= n; i++)
            for (int j = 0; j <= s + 1; j++)
                dp[1][j] = DP[1][i][j] = 0;
        dp[1][1] = DP[1][0][0] = 1;

        Func<int, int, ModInteger> rec = null;
        Func<int, int, int, ModInteger> dfs = null;
        dfs = (m, pid, t) =>
          {
              if (DP[m][pid][t].num != -1) return DP[m][pid][t];

              ModInteger ret = 0;
              var lst = pid;
              var rst = m - 1 - pid;
              if (lst == 0 || rst == 0)
              {
                  for (int i = 0; i < m - 1; i++)
                      ret += dfs(m - 1, i, t);
              }
              else
              {
                  for (int u = 0; u <= t; u++)
                      ret += rec(lst, u) * rec(rst, t - u);

              }
              ret *= comb[m - 1, lst];
              return DP[m][pid][t] = ret;
          };
        rec = (m, t) =>
          {
              if (dp[m][t].num != -1) return dp[m][t];
              ModInteger ret = 0;
              for (int pid = 0; pid < m; pid++)
              {
                  if (t - pid - 1 < 0) break;
                  ret += dfs(m, pid, t - pid - 1);
              }

              return dp[m][t] = ret;
          };


        ModInteger.Mod = MOD;

        ModInteger ans = 0;
        for (int i = 0; i < n; i++)
            for (int j = 0; j <= s; j++)
                ans += dfs(n, i, j);
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
        // test.ManualTest(100, 100, 1000000007);
    }
}
// CUT end


#region ModNumber
public partial struct ModInteger
{
    public static long Mod = (long)1e9 + 7;
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
#region CombinationTable
public class ModCombinationTable
{
    ModInteger[][] nCr;
    public ModCombinationTable(int n)
    {
        nCr = new ModInteger[n + 1][];
        for (int i = 0; i <= n; i++)
            nCr[i] = new ModInteger[i + 2];
        nCr[0][0] = 1;
        for (int i = 0; i <= n; i++)
        {
            nCr[i][0] = 1;
            for (int j = 1; j <= i; j++)
                nCr[i][j] = nCr[i - 1][j - 1] + nCr[i - 1][j];
        }
    }
    public ModInteger this[int n, int r]
    {
        get
        {
            if (n < 0 || n >= nCr.Length)
            {
                Debug.WriteLine("n<=0 || n>N ");
                return 0;
            }
            if (r < 0 || r > n)
            {
                Debug.WriteLine("r<=0 ||r>n");
                return 0;
            }
            return nCr[n][r];
        }
    }
    public ModInteger RepeatedCombination(int n, int k)
    {
        if (k == 0) return 1;
        return this[n + k - 1, k];
    }
}
#endregion