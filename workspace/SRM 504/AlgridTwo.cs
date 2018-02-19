using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class AlgridTwo
{
    public int makeProgram(string[] output)
    {
        var cnt = 0;
        var n = output[0].Length;
        for (int i = 0; i < output.Length - 1; i++)
        {
            var s = output[i];
            var next = Enumerate(n, x => '?');
            for (int j = 0; j < n - 1; j++)
            {
                if (s[j] == 'W')
                {
                    if (s[j + 1] == 'W') { }
                    else
                    {
                        if (next[j] == '?') cnt++;
                        if (next[j + 1] == '?') cnt++;
                        next[j] = 'W';
                        next[j + 1] = 'W';
                    }
                }
                else
                {
                    if (s[j + 1] == 'W')
                    {
                        if (next[j] == '?') cnt++;
                        if (next[j + 1] == '?') cnt++;
                        next[j] = 'B';
                        next[j + 1] = 'B';
                    }
                    else { Swap(ref next[j], ref next[j + 1]); }
                }
            }
            for (int j = 0; j < n; j++)
                if (next[j] != '?' && next[j] != output[i + 1][j]) return 0;
        }
        var ans = 1;
        for (int i = 0; i < cnt; i++)
            ans = (ans * 2) % 1000000007;
        return ans;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(string[] output)
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

    }
}
// CUT end
