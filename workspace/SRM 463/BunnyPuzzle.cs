using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class BunnyPuzzle
{
    public int theCount(int[] bunnies)
    {
        var ans = 0;
        var set = new HashSet<int>(bunnies);
        for (int i = 0; i < bunnies.Length; i++)
        {
            var l = i - 1;

            if (l >= 0)
            {
                var next = bunnies[l] - (bunnies[i] - bunnies[l]);
                var lb = Array.BinarySearch(bunnies, next);
                if (lb < 0)
                {
                    lb = ~lb;
                    if (lb == l) ans++;
                }
            }
            var r = i + 1;
            if (r < bunnies.Length)
            {
                var next = bunnies[r] + (bunnies[r] - bunnies[i]);
                var lb = Array.BinarySearch(bunnies, next);
                if (lb < 0)
                {
                    lb = ~lb;
                    if (lb == r + 1) ans++;
                }
            }
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
