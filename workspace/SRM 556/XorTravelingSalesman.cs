using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class XorTravelingSalesman
{
    public int maxProfit(int[] cityValues, string[] roads)
    {
        var n = cityValues.Length;
        var dp = Enumerate(n, x => new bool[1024]);
        dp[0][cityValues[0]] = true;
        var q = new Queue<KeyValuePair<int, int>>();
        q.Enqueue(new KeyValuePair<int, int>(0, cityValues[0]));
        while (q.Any())
        {
            var p = q.Dequeue();
            var v = p.Key;
            var x = p.Value;
            //Debug.WriteLine("{0} {1}", v, x);
            for (int to = 0; to < n; to++)
            {
                if (roads[v][to] == 'Y')
                {
                    var y = x ^ cityValues[to];
                    if (dp[v][y]) continue;
                    dp[v][y] = true;
                    q.Enqueue(new KeyValuePair<int, int>(to, y));
                }
            }
        }
        var max = 0;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < 1024; j++)
                if (dp[i][j]) max = Math.Max(max, j);
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
public class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
    }
}
// CUT end
