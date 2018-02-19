using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class ConsecutiveFloors
{
    public string isConsistent(int[] X, int[] Y)
    {
        var a = new List<KeyValuePair<long, long>>();
        var max = long.MaxValue;
        for (int i = X.Length - 1; i >= 0; i--)
        {
            //Debug.WriteLine(a.AsJoinedString());
            long h = X[i];
            long k = Y[i];
            foreach (var x in a)
                k -= (x.Key - h + 1) * x.Value;
            if (k < 0) return "Inconsistent";
            if (k > 0)
            {
                var d = max - h;
                var kk = k / d;
                var rem = k % d;
                a.Add(new KeyValuePair<long, long>(max - 1, kk));
                if (rem > 0)
                    a.Add(new KeyValuePair<long, long>(h + rem - 1, 1));
            }
            max = h;
        }
        return "Consistent";
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public string Naive_Test(int[] x, int[] y)
    {
        return "";
    }

    // CUT end
}
// CUT begin
static public class EnumerableEX
{
    static public string AsString(this IEnumerable<char> e) { return new string(e.ToArray()); }
    static public string AsJoinedString<T>(this IEnumerable<T> e, string s = " ") { return string.Join(s, e); }
}
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
        Test(Example5);
        Test(Example6);
        Test(Example7);

    }
}
// CUT end
