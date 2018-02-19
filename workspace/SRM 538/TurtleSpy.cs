using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class TurtleSpy
{
    public double maxDistance(string[] commands)
    {
        var go = 0.0;
        var back = 0.0;
        var dp = new bool[360];
        dp[0] = true;
        foreach (var x in commands)
        {
            var s = x.Split(' ');
            if (s[0] == "forward") go += int.Parse(s[1]);
            else if (s[0] == "backward") back += int.Parse(s[1]);
            else
            {
                var v = int.Parse(s[1]);
                if (s[0] == "left") v *= -1;

                var next = new bool[360];
                for (int i = 0; i < 360; i++)
                {
                    next[i] |= dp[i];
                    next[(i + 360 + v) % 360] |= dp[i];
                }
                dp = next;
            }
        }
        var max = 0.0;
        for (int i = 0; i < 360; i++)
        {
            if (!dp[i]) continue;
            Debug.WriteLine(i);
            var t = 2 * Math.PI * i / 360.0;
            var cos = Math.Cos(t);
            var sin = Math.Sin(t);

            var x = Math.Abs(go - back * cos);
            var y = Math.Abs(back * sin);
            max = Math.Max(max, Math.Sqrt(x * x + y * y));
        }
        return max;
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
