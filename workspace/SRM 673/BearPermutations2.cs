using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
using P = System.Collections.Generic.KeyValuePair<ModInteger, ModInteger>;
public class BearPermutations2
{
    public int getSum(int n, int MOD)
    {
        ModInteger.Mod = MOD;
        //pattern, strength
        var dp = Enumerate(n + 1, x => new P?[n + 1]);
        dp[1][0] = new P(1, 0);
        var table = new ModCombinationTable(n + 1);
        Func<int, int, P> dfs = null;
        dfs = (m, pid) =>
          {
              if (dp[m][pid] != null) return dp[m][pid].Value;
              ModInteger p = 0;
              ModInteger s = 0;
              if (pid == 0 || pid == m - 1)
              {
                  for (int i = 0; i < m - 1; i++)
                  {
                      var res = dfs(m - 1, i);
                      p += res.Key;
                      s += res.Value;
                  }
              }
              else
              {
                  var lst = pid;
                  var rst = m - 1 - pid;
                  for (int i = 0; i < lst; i++)
                      for (int j = 0; j < rst; j++)
                      {
                          var l = dfs(lst, i);
                          var r = dfs(rst, j);
                          p += l.Key * r.Key;
                          s += l.Value * r.Key;
                          s += r.Value * l.Key;
                          s += (pid + j + 1 - i) * l.Key * r.Key;
                      }
              }
              p *= table[m - 1, pid];
              s *= table[m - 1, pid];
              dp[m][pid] = new P(p, s);
              return (dp[m][pid]).Value;
          };
        ModInteger ans = 0;
        for (int i = 0; i < n; i++)
            ans += dfs(n, i).Value;
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
#region Inverse
public partial struct ModInteger
{
    static public ModInteger Inverse(ModInteger v)
    {
        long p, q;
        ExGCD(v.num, Mod, out p, out q);
        return new ModInteger(p % Mod + Mod);
    }
    static public long ExGCD(long a, long b, out long x, out long y)
    {
        var u = new long[] { a, 1, 0 };
        var v = new long[] { b, 0, 1 };
        while (v[0] != 0)
        {
            var t = u[0] / v[0];
            for (int i = 0; i < 3; i++)
            {
                var tmp = u[i] - t * v[i];
                u[i] = v[i];
                v[i] = tmp;
            }
        }
        x = u[1];
        y = u[2];
        if (u[0] > 0)
            return u[0];
        for (int i = 0; i < 3; i++)
            u[i] = -u[i];
        return u[0];

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