using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class FoxAverageSequence
{
    public int theCount(int[] seq)
    {
        const int MAX = 42;
        const int S = MAX * MAX;
        const int MOD = (int)1e9 + 7;
        var dp = new int[S, MAX, 2];
        dp[0, 0, 0] = 1;
        for (int i = 0; i < seq.Length; i++)
        {
            var next = new int[S, MAX, 2];
            for (int v = 0; v <= 40; v++)
            {
                if (seq[i] == -1 || seq[i] == v)
                {
                    for (int s = 0; s + v < S; s++)
                        for (int lv = 0; lv < MAX; lv++)
                            for (int l = 0; l < 2; l++)
                            {
                                if (dp[s, lv, l] == 0) continue;
                                if (v * i > s) continue;
                                var nl = l;
                                if (lv > v) nl++;
                                else nl = 0;
                                if (nl == 2) continue;
                                //Debug.WriteLine("{0} {1} {2} {3}", s, lv, l, v);
                                next[s + v, v, nl] = (next[s + v, v, nl] + dp[s, lv, l]) % MOD;
                            }

                }
            }
            dp = next;
        }
        int ans = 0;
        for (int i = 0; i < S; i++)
            for (int j = 0; j < MAX; j++)
                for (int k = 0; k < 2; k++)
                {
                    ans = (ans + dp[i, j, k]) % MOD;
                }

        return ans;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(int[] seq)
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

    }
}
// CUT end
