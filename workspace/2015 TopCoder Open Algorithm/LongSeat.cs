using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
using P = System.Collections.Generic.KeyValuePair<long, long>;
public class LongSeat
{
    public string[] canSit(int L, int[] width)
    {
        long len = L;
        var n = width.Length;
        var S = width.Distinct().ToList();
        S.Add(0);
        S.Sort();
        var enable = new bool[n];
        var disable = new bool[n];
        var set = new HashSet<P>();
        set.Add(new P(0, 0));//used,臒l
        for (int i = 0; i < n; i++)
        {
            var next = new HashSet<P>();
            var w = width[i];
            foreach (var kv in set)
            {
                var used = kv.Key;
                var th = kv.Value;
                if (used + w <= len)
                {
                    enable[i] = true;
                    foreach (var x in S)
                    {
                        if (x < th)
                            continue;
                        if (used + w + th <= len)
                            next.Add(new P(used + w + th, x));
                    }

                }
                if (used + w > len)
                {
                    disable[i] = true;
                    next.Add(new P(used, th));
                }
            }
            set = next;
        }
        var ans = new string[n];
        for (int i = 0; i < n; i++)
        {
            if (enable[i] && disable[i])
                ans[i] = "Unsure";
            else if (enable[i])
                ans[i] = "Sit";
            else if (disable[i])
                ans[i] = "Stand";
            else throw new Exception();
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
    public override void Test()
    {
        //test.ManualTest();
        base.Test();
    }
}
// CUT end
