using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class TreasureOfWinedag
{
    public int solvePuzzle(int N, int K, int m, int c0, int[] c1, int[] c2, int[] c3, int[] c4, string s)
    {
        var sb = new StringBuilder(s);
        for (int i = s.Length; i < N; i++)
        {
            var t = Math.BigMul(i, c0) % m;
            var nc = 'z';
            for (int j = 0; j < 25; j++)
            {
                if (t >= c3[j] && t <= c4[j] && ((t % c1[j]) == c2[j])) { nc = (char)('a' + j); break; }
            }
            sb.Append(nc);
        }

        return solve(sb.ToString(), K);
    }
    int solve(string s, int m)
    {
        var n = s.Length;
        //Debug.WriteLine(s);
        // dp[i][j] = i 個見て j 個仕切りを入れたときの最小コスト
        // dp[0][0]=0;dp[0][i]=INF;
        // dp[i][j] = min (dp[k][j-1] + f[k,i])
        // 冷静になると，k-1 + 26 ぐらいで済みますねぇ！

        var f = Enumerate(n + 1, x => Enumerate(27, y => n));
        for (int i = n - 1; i >= 0; i--)
        {
            for (int j = 0; j < 26; j++)
            {
                if (s[i] - 'a' == j) f[i][j] = i;
                else f[i][j] = f[i + 1][j];
            }
        }
        //dp[i][x] = コスト - 分割数 が x となるような最小の 分割数 j
        var dp = Enumerate(n + 5, x => Enumerate(26, y => n + 5));
        dp[0][0] = 0;
        for (int i = 0; i < n; i++)
        {
            Array.Sort(f[i]);
            for (int j = 0; j < 26; j++)
            {
                if (dp[i][j] > n) continue;
                for (int k = 0; j + k < 26; k++)
                {
                    var to = f[i][k + 1];
                    dp[to][j + k] = Math.Min(dp[to][j + k], dp[i][j] + 1);
                }
            }
        }
        var min = n + 50;
        for (int i = 0; i < 26; i++)
        {
            if (dp[n][i] <= m) { min = i; break; }
        }
        return m + min;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(int N, int K, int m, int c0, int[] c1, int[] c2, int[] c3, int[] c4, string s)
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
    public override void Run()
    {
        //Tests.Add(null);
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);
        Test(Example4);
        Test(Example5);

    }
}
// CUT end
