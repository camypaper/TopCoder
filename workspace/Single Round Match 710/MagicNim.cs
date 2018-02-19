using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class MagicNim
{
    public string findWinner(int[] a)
    {

        return f(a) ? "Alice" : "Bob";
    }
    bool f(int[] a)
    {
        var n = a.Length;
        var max = a.Max();
        if (max == 1) return true;

        var xor = 0;
        foreach (var x in a) xor ^= x;
        if (xor == 0) return true;
        var s = a.Distinct().ToList();
        s.Sort();
        var b = new int[s.Count];
        foreach (var x in a)
            b[s.BinarySearch(x)] ^= 1;
        for (int i = b.Length - 1; i >= 0; i--)
        {
            if (b[i] == 0) continue;
            if (s[i] >= 4) return true;
            if (s[i] == 3)
            {
                if (a.Count(x => x == 1) % 2 == 1) return false;
                else return true;
            }
            if (s[i] == 2)
            {
                return false;
            }

        }
        return false;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public string Naive_Test(int[] arr)
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
        Test(Example5);
        Test(Example7);
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);
        Test(Example4);
        Test(Example6);

    }
}
// CUT end
#region miserenim
static public class MisereNim
{
    static public bool IsWin(long[] a)
    {
        var win = 0L;
        var max = 0L;
        var n = a.Length;
        for (int i = 0; i < n; i++)
        {
            max = Math.Max(max, a[i]);
            win ^= a[i];
        }
        if (max == 0) return true;
        if (max > 1) return win > 0;
        return win == 0;

    }
}
#endregion