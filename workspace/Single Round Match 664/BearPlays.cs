using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class BearPlays
{
    public int pileSize(int A, int B, int K)
    {
        int x = A;
        int y = B;
        if (x > y)
            Swap(ref x, ref y);
        var dic = new Dictionary<int, int>();
        for (int i = 0; i < K; i++)
        {
            if (!dic.ContainsKey(x))
                dic[x] = i;
            else
            {
                var d = i - dic[x];
                var r = ((K - i) % d) + dic[x];
                for (int j = 0; j < r; j++)
                {
                    y -= x;
                    x += x;
                    if (x > y) Swap(ref x, ref y);
                }
                return (int)x;
            }

            y -= x;
            x += x;
            if (x > y) Swap(ref x, ref y);
            //Debug.WriteLine("{0} {1}", x, y);
        }
        return (int)x;
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
    public override void Test()
    {
        var rand = new Random(0);
        while (true)
        {
            test.ManualTest(rand.Next(1, 1000000000), rand.Next(1, 1000000000), rand.Next(1000000000, 2000000000));
        }
        
        base.Test();
    }
}
// CUT end
