using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class SimilarRatingGraph
{
    public double maxLength(int[] date, int[] rating)
    {
        var n = date.Length;
        var ans = 0.0;
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                var ue = -1L;
                var sita = -1L;
                var p = i;
                var q = j;
                var s = 0.0;
                var t = 0.0;
                while (q + 1 < n)
                {
                    long dx = date[p + 1] - date[p];
                    long ex = date[q + 1] - date[q];
                    if (ue == -1) { ue = ex; sita = dx; }
                    else if (ue * dx != sita * ex) break;

                    var dy = rating[p + 1] - rating[p];
                    var ey = rating[q + 1] - rating[q];

                    if (ue * dy != sita * ey) break;
                    s += Math.Sqrt(dx * dx + dy * dy);
                    t += Math.Sqrt(ex * ex + ey * ey);
                    ans = Math.Max(ans, s);
                    ans = Math.Max(ans, t);
                    p++;
                    q++;

                }

            }
        }
        return ans;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public double Naive_Test(int[] date, int[] rating)
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
        Test(Example5);

    }
}
// CUT end
