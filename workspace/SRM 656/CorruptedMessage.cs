using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class CorruptedMessage
{
    public string reconstructMessage(string s, int k)
    {
        var n = s.Length;
        var a = new int[26];
        foreach (var x in s)
            a[x - 'a']++;
        for (int i = 0; i < 26; i++)
            if (a[i] + k == n) return new string((char)(i + 'a'), n);
        return "hoge";
    }

    // CUT begin
    public string Naive_Test(string s, int k)
    {
        return "";
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
        //Tests.Add(null);
    }
}
// CUT end
