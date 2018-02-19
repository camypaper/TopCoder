using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class BearPlaysDiv2
{
    public string equalPiles(int A, int B, int C)
    {
        var sum = A + B + C;
        if (sum % 3 != 0) return "impossible";
        var dp = new bool[1550, 1550];
        var q = new Queue<KeyValuePair<int, int>>();
        {
            var a = new int[] { A, B, C };
            Array.Sort(a);
            q.Enqueue(new KeyValuePair<int, int>(a[0], a[1]));
            dp[a[0], a[1]] = true;
        }
        while (q.Any())
        {
            var p = q.Dequeue();
            var a = p.Key;
            var b = p.Value;
            var c = sum - a - b;
            {
                var na = new int[] { a + a, b - a, c };
                Array.Sort(na);
                if (!dp[na[0], na[1]])
                {
                    dp[na[0], na[1]] = true;
                    q.Enqueue(new KeyValuePair<int, int>(na[0], na[1]));
                }

            }
            {
                var na = new int[] { a + a, b, c - a };
                Array.Sort(na);
                if (!dp[na[0], na[1]])
                {
                    dp[na[0], na[1]] = true;
                    q.Enqueue(new KeyValuePair<int, int>(na[0], na[1]));
                }

            }
            {
                var na = new int[] { a, b + b, c - b };
                Array.Sort(na);
                if (!dp[na[0], na[1]])
                {
                    dp[na[0], na[1]] = true;
                    q.Enqueue(new KeyValuePair<int, int>(na[0], na[1]));
                }

            }
        }
        if (dp[sum / 3, sum / 3]) return "possible";
        return "impossible";
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
