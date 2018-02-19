using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class ORSolitaire
{
    public int getMinimum(int[] numbers, int goal)
    {
        var n=numbers.Length;
        var a = new long[n];
        for (int i = 0; i < n; i++)
            a[i] = numbers[i];
        var cnt = new int[64];
        long v = goal;
        foreach (var x in a)
        {
            var pass = false;
            for (int i = 0; i < 64; i++)
                if ((v >> i & 1) == 0 && (x >> i & 1) == 1)
                   pass = true;
            if (pass)
                continue;
            for (int i = 0; i < 64; i++)
                if ((x >> i & 1) == 1) cnt[i]++;
        }
        var ans = int.MaxValue;
        for (int i = 0; i < 64; i++)
            if ((v >> i & 1) == 1) ans = Math.Min(cnt[i], ans);
        return ans;
    }

// CUT begin
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
}
static public class EnumerableEX
{
    static public string AsString(this IEnumerable<char> e) { return new string(e.ToArray()); }
    static public string AsJoinedString<T>(this IEnumerable<T> e,string s=" ") { return string.Join(s, e);}
}
public class Tester : AbstractTester
{
    public override void Test()
    {
        test.ManualTest();
        //base.Test();
    }
// CUT end
}
