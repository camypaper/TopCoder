using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
using Number = System.Int64;
public class PolynomialRemainder
{
    public int findRoot(int a, int b, int c)
    {
        var mod = new int[] { 512, 1953125 };
        var ok = Enumerate(2, x => new List<long>());
        for (int k = 0; k < 2; k++)
        {
            for (int i = 0; i < mod[k]; i++)
            {
                long res = 0;
                res = ((Math.BigMul(i, i) % mod[k]) * (a % mod[k])) % mod[k];
                res = (res + Math.BigMul(i, b)) % mod[k];
                res = (res + c) % mod[k];
                if (res == 0) ok[k].Add(i); ;
            }
        }
        var OK = new bool[512];
        foreach (var x in ok[0]) OK[x] = true;

        var used = new bool[512];
        for (long k = 0; k < mod[1]; k++)
        {
            var rem = k * mod[1] % 512;
            if (used[rem]) continue;
            used[rem] = true;


            foreach (var y in ok[1])
            {
                {
                    var v = y + k * mod[1];
                    if (v >= 1000000000) continue;
                    if (OK[v % 512]) return (int)v;
                }
            }
        }
        return -1;
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
        test.ManualTest(575312500, 450900000, 858371875);
    }
}
// CUT end
