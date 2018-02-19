using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class XorLists
{
    public int countLists(int[] s, int m)
    {
        var ans = 0;
        var n = 1;
        while (n * n < s.Length) n++;


        {
            var b = new int[n];
            var ok = true;
            for (int j = 1; j < n; j++)
                b[j] = s[j];
            for (int j = 0; j < s.Length && ok; j++)
            {
                if (s[j] != (b[j / n] ^ b[j % n])) { return 0; }
            }
        }


        for (int i = 0; i <= m; i++)
        {

            var ok = true;
            for (int j = 1; j < n; j++)
                if ((s[j] ^ i) > m) ok = false;

            if (ok) ans++;
        }
        return ans;
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
