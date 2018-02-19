using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class StrIIRec
{
    public string recovstr(int n, int minInv, string minStr)
    {
        var s = minStr;
        for (char c = 'a'; c < 'a' + n; c++)
            if (!minStr.Contains(c)) s += c;
        var t = s.ToCharArray();
        while (get(t) < minInv)
        {
            var go = true;
            for (int i = n - 1; i >= 0 && go; i--)
                for (int j = n - 1; j > i && go; j--)
                    if (t[i] < t[j])
                    {
                        Swap(ref t[i], ref t[j]);
                        go = false;
                        break;
                    }
            Debug.WriteLine("{0} {1}", get(t), t.AsString());
            if (go) return "";
        }
        Debug.WriteLine(t.AsString());
        Debug.WriteLine(minInv);
        Debug.WriteLine(get(t));
        return t.AsString();
    }
    public int get(char[] s)
    {
        var ans = 0;
        for (int i = 0; i < s.Length; i++)
            for (int j = i + 1; j < s.Length; j++)
                if (s[i] > s[j]) ans++;
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
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
        test.ManualTest(20, 190, "a");
    }
}
// CUT end
