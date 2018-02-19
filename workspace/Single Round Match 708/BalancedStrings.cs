using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class BalancedStrings
{
    public string[] findAny(int N)
    {

        if (N == 1) return new string[] { "a" };
        var s = new List<string>();
        var str = "efghijklmnopqrstuvwxyz";
        var ptr = 0;
        while (s.Count < N - 2)
        {
            s.Add(str[ptr % str.Length].ToString());
            ptr++;
        }
        var cnt = 0;
        for (int i = 0; i < s.Count; i++)
            for (int j = i + 1; j < s.Count; j++)
                if (s[i] == s[j]) cnt++;
        Debug.WriteLine(cnt);
        var otaku = "a";
        var t = "ba";
        Console.WriteLine(cnt);
        for (int i = 0; cnt > 0 && i < 100; i++, cnt--)
            otaku += t[i % 2];
        s.Add(otaku);
        otaku = "c";
        t = "dc";
        for (int i = 0; cnt > 0 && i < 100; i++, cnt--)
            otaku += t[i % 2];
        s.Add(otaku);
        Debug.WriteLine(cnt);
        Debug.WriteLine(s.Count);
        Debug.WriteLine(s.Max(x => x.Length));
        Debug.Assert(cnt == 0);
        return s.ToArray();
    }

    // CUT begin
    public string[] Naive_Test(int n)
    {
        var m = n;
        var res = Enumerate(n, x => "");

        return res;
    }
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }

    // CUT end
}
// CUT begin
public partial class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public void OnInit()
    {
        ManualTest(80);
        //Tests.Add(null);
    }
}
// CUT end
