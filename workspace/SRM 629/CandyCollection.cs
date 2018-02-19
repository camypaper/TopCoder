using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class CandyCollection
{
    public int solve(int[] t1, int[] num1, int[] t2, int[] num2)
    {
        var n = t1.Length;


        var ans = 0;
        var used = new bool[n];
        for (int i = 0; i < n; i++)
        {
            if (used[i]) continue;
            used[i] = true;
            var dp = new int[2, 2];
            for (int j = 0; j < 2; j++)
                for (int k = 0; k < 2; k++)
                    dp[j, k] = 1000000000;
            dp[0, 0] = 0;
            dp[0, 1] = num1[i] + 1;
            dp[1, 0] = num2[i] + 1;
            dp[1, 1] = Math.Max(num1[i], num2[i]) + 1;
            var c = t2[i];
            var p = -1;
            for (int j = 0; j < n; j++)
                if (used[j]) continue;
                else
                {
                    if (t1[j] == c) { p = j; break; }
                    else if (t2[j] == c)
                    {
                        Swap(ref t1[j], ref t2[j]);
                        Swap(ref num1[j], ref num2[j]);
                        p = j; break;
                    }
                }

            for (; p != -1;)
            {
                used[p] = true;
                var next = new int[2, 2];
                for (int j = 0; j < 2; j++)
                    for (int k = 0; k < 2; k++)
                        next[j, k] = 1000000000;
                for (int j = 0; j < 2; j++)
                {
                    next[j, 0] = Math.Min(dp[j, 1], dp[j, 0] + num2[p] + 1);
                    next[j, 1] = Math.Min(dp[j, 1] + num1[p] + 1, dp[j, 0] + Math.Max(num1[p], num2[p]) + 1);
                }
                dp = next;
                c = t2[p];
                p = -1;
                for (int j = 0; j < n; j++)
                    if (used[j]) continue;
                    else
                    {
                        if (t1[j] == c) { p = j; break; }
                        else if (t2[j] == c)
                        {
                            Swap(ref t1[j], ref t2[j]);
                            Swap(ref num1[j], ref num2[j]);
                            p = j; break;
                        }
                    }
            }
            ans += Math.Min(dp[0, 1], Math.Min(dp[1, 0], dp[1, 1]));

        }


        return ans;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(int[] Type1, int[] Number1, int[] Type2, int[] Number2)
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
