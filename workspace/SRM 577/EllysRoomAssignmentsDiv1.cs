using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class EllysRoomAssignmentsDiv1
{
    public double getAverage(string[] ratings)
    {
        var a = new List<int>();
        var s = "";
        foreach (var x in ratings) s += x;
        foreach (var x in s.Split().Select(int.Parse)) a.Add(x);
        var n = a.Count;
        Debug.WriteLine(a.AsJoinedString());
        var v = a[0];
        a.Sort();
        a.Reverse();
        var R = (n + 19) / 20;
        var pos = (a.IndexOf(v) / R) * R;
        var sum = 0.0;
        var cnt = 0;
        var ans = 0.0;
        for (int i = 0; i < n; i += R)
        {
            if (i + R >= n)
            {
                if (i == pos) return 1.0 * (sum + v) / (cnt + 1);
                var x = 0.0;
                var k = 0;
                for (int j = i; j < n; j++) { x += a[j]; k++; }
                x /= k;
                ans += 1.0 * (sum + x) / (cnt + 1) * k / R;
                ans += 1.0 * sum / cnt * (R - k) / R;
            }
            else
            {
                if (i == pos) { sum += v; cnt++; continue; }
                var x = 0;
                for (int j = 0; j < R; j++)
                    x += a[i + j];
                sum += 1.0 * x / R;
                cnt++;
            }
        }
        return ans;

    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public double Naive_Test(string[] ratings)
    {
        return 0.0;
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
