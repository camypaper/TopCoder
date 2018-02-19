using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class PalindromicSubseq
{
    public int solve(string s)
    {
        var n = s.Length;
        //[i,j]‚É‘¶Ý‚·‚é‰ñ•¶•”•ª—ñ‚Ì‘”
        var dp = Enumerate(n, x => new ModInteger[n]);
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                dp[i][j].num = -1;
        Func<int, int, ModInteger> dfs = null;
        dfs = (l, r) =>
          {
              if (l > r) return 0;
              if (l == r) return dp[l][r] = 1;
              if (dp[l][r].num != -1) return dp[l][r];
              ModInteger ret = dfs(l, r - 1) + dfs(l + 1, r) - dfs(l + 1, r - 1);
              if (s[l] == s[r])
                  ret += dfs(l + 1, r - 1) + 1;
              return dp[l][r] = ret;
          };
        //i],[j‚É‘¶Ý‚·‚é‰ñ•¶•”•ª—ñ‚Ì”
        var ep = Enumerate(n, x => new ModInteger[n]);
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                ep[i][j].num = -1;
        Func<int, int, ModInteger> efs = null;
        efs = (l, r) =>
          {
              if (l < 0 || r >= n) return 0;
              if (ep[l][r].num != -1) return ep[l][r];
              ModInteger ret = 0;
              ret += efs(l, r + 1) + efs(l - 1, r) - efs(l - 1, r + 1);
              if (s[l] == s[r]) ret += efs(l - 1, r + 1) + 1;
              return ep[l][r] = ret;
          };
        Debug.WriteLine(efs(1, 2));
        var a = new ModInteger[n];
        for (int i = 0; i < n; i++)
            for (int j = i; j < n; j++)
            {
                if (s[i] != s[j]) continue;
                var x = dfs(i + 1, j - 1) + 1;
                x *= efs(i - 1, j + 1) + 1;
                a[i] += x;
                if (i != j)
                    a[j] += x;
            }
        var ans = 0L;
        for (int i = 0; i < n; i++)
        {
            a[i] *= (i + 1);
            ans ^= a[i].num;
        }
        return (int)ans;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    // CUT begin
    public int Naive_Test(string s)
    {
        return 0;
    }

    // CUT end
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
    public static implicit operator ModInteger(long n) { return new ModInteger() { num = n }; }
}
#endregion