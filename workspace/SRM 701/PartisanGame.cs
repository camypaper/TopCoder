using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class PartisanGame
{
    public string getWinner(int n, int[] a, int[] b)
    {
        Array.Sort(a);
        Array.Sort(b);

        var ans = get(n, a, b);
        return ans ? "Alice" : "Bob";
    }
    bool get(int n, int[] a, int[] b)
    {
        if (n == 0) return false;
        n = Math.Min(n, 2520 + n % 2520);
        var dp = Enumerate(n + 50, x => new int[2]);
        for (int i = 0; i < n + 1; i++)
            for (int j = 0; j < 2; j++)
                dp[i][j] = -1;
        Func<int, int, int> dfs = null;
        dfs = (m, p) =>
        {
            if (dp[m][p] != -1) return dp[m][p];
            int[] A;
            if (p == 0) A = a;
            else A = b;
            foreach (var x in A)
                if (x <= m && dfs(m - x, p ^ 1) == 0) return dp[m][p] = 1;
            return dp[m][p] = 0;
        };
        var ret = dfs(n, 0);
        if (ret == 0) return false;

        return true;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public bool Naive_Test(int n, int[] a, int[] b)
    {
        var dp = Enumerate(n + 1, x => new int[2]);
        for (int i = 0; i < n + 1; i++)
            for (int j = 0; j < 2; j++)
                dp[i][j] = -1;
        for (int i = 0; i < a.Min(); i++)
            dp[i][0] = 0;
        for (int i = 0; i < b.Min(); i++)
            dp[i][1] = 0;
        Func<int, int, int> dfs = null;
        dfs = (m, p) =>
        {
            if (dp[m][p] != -1) return dp[m][p];
            int[] A;
            if (p == 0) A = a;
            else A = b;
            foreach (var x in A)
                if (x <= m && dfs(m - x, p ^ 1) == 0) return dp[m][p] = 1;
            return dp[m][p] = 0;
        };
        var ret = dfs(n, 0);
        return ret == 1;
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
        Tests.Add(() => ManualTest(32, new int[] { 1, 2 }, new int[] { 1, 2 }));
        //Tests.Add(null);
    }
}
// CUT end
