using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class ClassicTowers
{
    public string findTowers(long k, int[] count)
    {
        for (int i = 0; i < 3; i++)
        {
            dp = new int[52, 52, 52, 3];
            s = new string[52, 52, 52, 3];
            var a = count.ToArray();
            a[i]--;
            if (rec(k, a[0], a[1], a[2], i))
                return s[a[0], a[1], a[2], i] + (char)(i + 'A');
        }
        return "";
    }
    int[,,,] dp = new int[52, 52, 52, 3];
    string[,,,] s = new string[52, 52, 52, 3];
    bool rec(long k, int a, int b, int c, int p)
    {
        if (a < 0 || b < 0 || c < 0) return false;
        if (a + b + c == 0)
        {
            s[a, b, c, p] = "";
            if (k == 0) dp[a, b, c, p] = 1;
            else dp[a, b, c, p] = -1;
            return dp[a, b, c, p] == 1;

        }
        Debug.WriteLine($"{k} {a} {b} {c} {p}");
        if (dp[a, b, c, p] != 0) return dp[a, b, c, p] == 1;
        var n = a + b + c - 1;
        if ((k >> n & 1) == 0)
        {
            var na = new int[] { a, b, c };
            na[p]--;
            if (rec(k, na[0], na[1], na[2], p))
            {
                s[a, b, c, p] = s[na[0], na[1], na[2], p] + (char)(p + 'A');
                return true;
            }
        }
        else
        {
            for (int i = 0; i < 3; i++)
            {
                if (i == p) continue;
                for (int j = 0; j < 3; j++)
                {
                    if (j == p) continue;
                    if (i == j) continue;
                    var na = new int[] { a, b, c };
                    na[i]--;
                    var nk = k;
                    nk -= 1L << n;
                    if (rec(nk, na[0], na[1], na[2], j))
                    {
                        s[a, b, c, p] = s[na[0], na[1], na[2], j] + (char)(i + 'A');
                        return true;
                    }

                }
            }
        }

        return false;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public string Naive_Test(long k, int[] count)
    {
        return "";
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

    }
}
// CUT end
