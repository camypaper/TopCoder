using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class Softmatch
{
    public int count(string S, string[] T)
    {
        var n = S.Length;
        var m = T.Length;
        T = T.OrderBy(x => x.Length).ToArray();

        if (T.Max(x => x.Length) == 1)
        {
            var max = 0;
            for (int i = 0; i < n; i++)
            {
                var u = 0; var v = 0;
                if (S[i] == 'a')
                {
                    foreach (var x in T)
                        if (x == "0" || x == "1") u++;
                        else v++;
                }
                else
                {
                    foreach (var x in T)
                        if (x == "0" || x == "2") u++;
                        else v++;
                }
                max += Math.Max(u, v);
            }
            return max;
        }
        else
        {
            var ret = 0;
            var rand = new Random();
            var s = S.ToCharArray();
            ret = check(s, T);
            ret = Math.Max(ret, check(S.ToUpper().ToCharArray(), T));
            for (int i = 0; i < n; i++)
                if (rand.Next() % 2 == 1) s[i] = char.ToUpper(s[i]);
            for (int i = 0; i < 300000; i++)
            {
                ret = Math.Max(ret, check(s, T));
                while (true)
                {
                    var x = rand.Next() % n;
                    var y = rand.Next() % m;
                    var t = T[y];
                    if (x + t.Length > n) continue;
                    for (int j = 0; j < t.Length; j++)
                    {
                        if (S[x + j] == 'a')
                        {
                            if (t[j] == '0' || t[j] == '1') s[x + j] = 'a';
                            else s[x + j] = 'A';
                        }
                        else if (S[x + j] == 'b')
                        {
                            if (t[j] == '0' || t[j] == '2') s[x + j] = 'b';
                            else s[x + j] = 'B';
                        }
                    }

                    break;
                }

            }
            return ret;
        }
    }
    int check(char[] S, string[] T)
    {
        var ret = 0;
        var n = S.Length;
        foreach (var s in T)
        {
            var m = s.Length;
            for (int i = 0; i + m <= n; i++)
            {
                var ok = true;
                for (int j = 0; j < m; j++)
                {
                    if (S[i + j] == 'a')
                    {
                        if (s[j] == '0' || s[j] == '1') continue;
                    }
                    else if (S[i + j] == 'A')
                    {
                        if (s[j] == '2' || s[j] == '3') continue;
                    }
                    else if (S[i + j] == 'b')
                    {
                        if (s[j] == '0' || s[j] == '2') continue;
                    }
                    else
                    {
                        if (s[j] == '1' || s[j] == '3') continue;
                    }
                    ok = false;
                    break;
                }
                if (ok) ret++;
            }

        }
        return ret;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(string S, string[] patterns)
    {
        return 0;
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
    public void OnInit()
    {
        var S = new String('a', 50);
        var T = Enumerate(5, x => new string('0', 50));
        Tests.Add(() => ManualTest(S, T));
        //Tests.Add(null);
    }
}
// CUT end

