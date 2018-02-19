using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class RepeatedStrings
{
    public string findKth(string s, int k)
    {
        enumerate(0, s, 0, "");
        ret.Sort();
        //Debug.WriteLine(ret.AsJoinedString());
        k--;
        if (k < ret.Count) return ret[k];
        return "";
    }
    List<string> ret = new List<string>();
    void enumerate(int p, string s, int d, string t)
    {
        //Debug.WriteLine("{0} {1}{2}", p, new string('(', d), t);
        if (d == 0 & t.Length != 0)
        {
            ret.Add(t);
            return;
        }
        if (t.Length == 0)
            for (int i = p; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    enumerate(i + 1, s, d + 1, t);
                    break;
                }

            }
        if (d > 0)
        {

            for (int i = p; i < s.Length; i++)
            {
                if (s[i] == ')')
                {
                    enumerate(i + 1, s, d - 1, "(" + t + ")");
                    break;
                }
            }
            if (t.Length > 0)
            {
                var ptr = 0;
                var nt = t;
                for (int i = p; i < s.Length; i++)
                {
                    if (s[i] == t[ptr]) ptr++;
                    if (ptr == t.Length)
                    {
                        nt += t;
                        for (int j = i + 1; j < s.Length; j++)
                        {
                            if (s[j] == ')')
                            {
                                enumerate(j + 1, s, d - 1, "(" + nt + ")");
                                break;
                            }
                        }
                        ptr = 0;
                    }
                }
            }
        }

    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public string Naive_Test(string s, int k)
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
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);
        Test(Example4);
        Test(Example5);

    }
}
// CUT end
