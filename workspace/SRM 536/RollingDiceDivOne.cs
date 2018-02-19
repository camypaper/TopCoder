using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class RollingDiceDivOne
{
    public long mostLikely(int[] dice)
    {
        long ans = 0;
        long half = 0;

        var dp = new long[3000];
        dp[0] = 1;
        foreach (var x in dice)
        {
            var next = new long[3000];
            for (int y = 1; y <= x; y++)
                for (int i = 0; i + y < 3000; i++)
                    next[i + y] += dp[i];
            dp = next;
        }
        var max = dp.Max();
        var id = -1;
        for (int i = 0; i < 3000; i++) if (dp[i] == max) { id = i; break; }

        if (dice.Length == 1) return 1;
        else
        {
            var cnt = dice.Count(x => x == 1);
            if (cnt >= dice.Length - 1) return dice.Length;
        }
        foreach (var x in dice)
        {
            if (x % 2 == 1) ans += (x + 1) / 2;
            else { ans += x / 2; half++; }
        }
        if (id != ans + half / 2)
        {

        }
        return ans + half / 2;
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
        var rand = new Random(0);
        test.ManualTest(new int[] { 2, 100 });
        while (true)
        {
            var n = rand.Next(1, 15);
            var a = Enumerate(n, x => 1 + (rand.Next() % 20));
            test.ManualTest(a);
        }
    }
}
// CUT end
