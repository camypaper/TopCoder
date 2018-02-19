using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class DivisibleSetDiv1
{
    public string isPossible(int[] b)
    {
        var ans = Naive_Test(b.ToArray());
        var n = b.Length;
        Array.Sort(b.ToArray());
        for (int i = n; i <= 114514; i++)
        {
            var s = new HashSet<int>();
            var sum = 0;
            foreach (var x in b)
            {
                var k = (i + x) / (x + 1);
                while (!s.Add(k)) k++;
                sum += k;
                if (sum > i) break;
            }
            if (sum <= i)
            {
                Debug.WriteLine(string.Join(" ", s));
                Debug.WriteLine(i);
                if (ans != "Possible")
                {

                }
                return "Possible";
            }
        }
        if (ans != "Impossible")
        {

        }
        return "Impossible";
    }

    // CUT begin
    public string Naive_Test(int[] b)
    {
        var n = b.Length;
        long sum = (long)1e13;
        var a = new long[n];
        for (int i = 0; i < n; i++)
            a[i] = sum / (1L * (b[i] + 1));
        Array.Sort(a);
        for (int i = 1; i < n; i++)
            a[i] = Math.Max(a[i], a[i - 1] + 1);
        for (int i = 0; i < n; i++)
            sum -= a[i];
        if (sum < 0) return "Impossible";
        return "Possible";
    }

    // CUT end
}
// CUT begin
public partial class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public void OnInit()
    {
        ManualTest(new int[] { 1, 3, 10, 10 });
        while (true)
        {
            var a = Enumerate(5, x => rand.Next(1, 10));
            ManualTest(a);
        }
        //Tests.Add(null);
    }
}
// CUT end
