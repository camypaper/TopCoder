using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class ColorfulGarden
{
    public string[] rearrange(string[] garden)
    {
        var n = garden[0].Length;
        var str = new char[2][];
        for (int i = 0; i < 2; i++)
            str[i] = new char[n];
        var ch = new int[26];
        foreach (var x in garden.SelectMany(x => x))
            ch[x - 'a']++;
        var id = Enumerate(26, x => x);
        Array.Sort(id, (l, r) => ch[r].CompareTo(ch[l]));
        var ptr = 0;
        var pos = 0;
        for (int i = 0; i < 26; i++)
        {

            var c = (char)(id[i] + 'a');
            var k = ch[id[i]];
            for (int j = 0; j < k; j++)
            {
                str[pos][ptr] = c;
                pos ^= 1;
                ptr++;
                if (ptr == n)
                {
                    ptr = 0;
                    pos = 1;
                }

            }
        }

        for (int i = 0; i < n; i++)
        {
            if (str[0][i] == str[1][i]) return new string[] { };
            if (i + 1 < n)
            {
                for (int k = 0; k < 2; k++)
                    if (str[k][i] == str[k][i + 1]) return new string[] { };
            }
        }
        return new string[] { str[0].AsString(), str[1].AsString() };
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
    }
}
// CUT end
