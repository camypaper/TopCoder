using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class FavouriteDigits
{
    public long findNext(long N, int digit1, int count1, int digit2, int count2)
    {
        if (digit2 < digit1)
        {
            Swap(ref digit1, ref digit2);
            Swap(ref count1, ref count2);
        }
        var len = Math.Max(N.ToString().Length, count1 + count2);
        var min = long.MaxValue;
        for (int L = len; L < 17; L++)
        {
            var s = N.ToString();
            while (s.Length < L) s = "$" + s;

            for (int l = 0; l <= L; l++)
            {
                var A = 0;
                var B = 0;
                var sb = new StringBuilder();
                for (int i = 0; i < l; i++)
                {
                    if (s[i] == '$') continue;
                    var v = s[i] - '0';
                    if (v == digit1) A++;
                    if (v == digit2) B++;
                    sb.Append(s[i]);
                }
                if (l == L)
                {
                    if (A >= count1 && B >= count2) return N;
                    break;
                }
                for (int p = 0; p < 10; p++)
                {
                    if (p <= s[l] - '0') continue;
                    var a = A;
                    var b = B;
                    if (p == digit1) a++;
                    if (p == digit2) b++;
                    var ss = new StringBuilder();
                    ss.Append(p);
                    var rem = Math.Max(0, L - l - Math.Max(0, count1 - a) - Math.Max(0, count2 - b) - 1);
                    for (int i = 0; i < rem; i++)
                        ss.Append(0);
                    for (int i = 0; i < count1 - a; i++)
                        ss.Append(digit1);
                    for (int i = 0; i < count2 - b; i++)
                        ss.Append(digit2);
                    var str = (sb.ToString() + ss.ToString());
                    if (str.Length == L)
                    {
                        var v = long.Parse(str);
                        if (v.ToString().Length == L)
                            min = Math.Min(min, v);
                    }
                }


            }

        }
        return min;
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
        test.ManualTest(701234568901234, 6, 14, 0, 0);
    }
}
// CUT end
