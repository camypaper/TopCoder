using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class RepeatString
{
    public int minimalModify(string str)
    {
        var len = str.Length;

        Func<string, string, int> f = (s, t) =>
        {
            var n = s.Length;
            var m = t.Length;
            var dp = new int[n, m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    dp[i, j] = -1;
            Func<int, int, int> dfs = null;
            dfs = (x, y) =>
            {
                if (x >= n)
                    return m - y;
                if (y >= m)
                    return n - x;
                if (dp[x, y] >= 0)
                    return dp[x, y];
                var ret = int.MaxValue;
                ret = Math.Min(ret, 1 + dfs(x + 1, y));
                ret = Math.Min(ret, 1 + dfs(x, y + 1));
                var ch = s[x] == t[y] ? 0 : 1;
                ret = Math.Min(ret, ch + dfs(x + 1, y + 1));
                return dp[x, y] = ret;
            };
            return dfs(0, 0);
        };
        var min = 1000000;
        for (int i = 0; i <= len; i++)
        {
            var u = str.Substring(0, i);
            var v = str.Substring(i);
            //Debug.WriteLine("{0} {1}: {2}", u, v, f(u, v));
            min = Math.Min(min, f(u, v));

        }
        var val = Naive_Test(str);
        if (min != val)
        {
            Debug.WriteLine("!!!");
            Debug.WriteLine(str);
            Debug.WriteLine("!!!");
            Console.ReadKey();
        }
        return min;
    }

    // CUT begin
    public int Naive_Test(string str)
    {
        var len = str.Length;

        Func<string, string, int> f = (s, t) =>
        {
            var n = s.Length;
            var m = t.Length;
            var dp = new int[n + 1, m + 1];
            for (int i = 0; i <= n; i++)
                dp[i, 0] = i;
            for (int i = 0; i <= m; i++)
                dp[0, i] = i;
            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= m; j++)
                {
                    var c = dp[i - 1, j - 1];
                    if (s[i - 1] != t[j - 1]) c++;
                    dp[i, j] = Math.Min(c, Math.Min(dp[i - 1, j] + 1, dp[i, j - 1] + 1));
                }

            return dp[n, m];
        };
        var min = 1000000;
        for (int i = 0; i < len; i++)
        {
            var u = str.Substring(0, i);
            var v = str.Substring(i);
            //Debug.WriteLine("{0} {1}: {2}", u, v, f(u, v));
            min = Math.Min(min, f(u, v));

        }
        return min;
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
        Tests.Add(() => ManualTest("aay"));
        var n = 7;
        var a = new char[n];
        for (int i = 0; i < n; i++)
            a[i] = (char)(rand.Next() % 26 + 'a');
        while (true)
        {
            var p = rand.Next() % n;
            a[p] = (char)(rand.Next() % 26 + 'a');
            ManualTest(new string(a));
        }
    }
}
// CUT end
