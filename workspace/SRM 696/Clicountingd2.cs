using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class Clicountingd2
{
    public int count(string[] g)
    {
        var n = g.Length;
        var id = new int[n, n];
        var k = 0;
        for (int i = 0; i < n; i++)
            for (int j = i + 1; j < n; j++)
            {
                id[i, j] = -1;
                if (g[i][j] == '?') id[i, j] = k++;
            }
        var ans = new int[1 << k];
        for (int mask = 0; mask < 1 << n; mask++)
        {
            var ok = true;
            var flag = 0;
            var cnt = 0;
            for (int i = 0; i < n; i++)
            {
                if ((mask >> i & 1) == 0) continue;
                cnt++;
                for (int j = i + 1; j < n; j++)
                {
                    if ((mask >> j & 1) == 0) continue;
                    if (g[i][j] == '1') continue;
                    else if (g[i][j] == '0') ok = false;
                    else flag |= 1 << id[i, j];
                }
            }
            if (ok) ans[flag] = Math.Max(ans[flag], cnt);
        }
        for (int i = 0; i < 1 << k; i++)
        {
            for (int j = 0; j < k; j++)
                ans[i | (1 << j)] = Math.Max(ans[i | (1 << j)], ans[i]);
        }
        return ans.Sum();
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(string[] g)
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
    public void OnInit()
    {
        //Tests.Add(null);
    }
}
// CUT end
