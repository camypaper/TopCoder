using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class OddEvenTreeHard
{
    int[] fail = { -1 };
    public int[] getTree(string[] s)
    {
        var n = s.Length;
        var g = Enumerate(n, x => new int[n]);
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
            {
                if (s[i][j] == 'O') g[i][j] = 1;
                else if (s[i][j] == 'E') g[i][j] = 0;
                else g[i][j] = -1;
            }
        for (int i = 0; i < n; i++)
            if (g[i][i] == 1) return fail;
            else if (g[i][i] == -1) g[i][i] = 0;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
            {
                if (g[i][j] == 1 && g[j][i] == 0) return fail;
                if (g[i][j] == -1) g[i][j] = g[j][i];
                else if (g[j][i] == -1) g[j][i] = g[i][j];
            }
        for (int k = 0; k < n; k++)
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    var v = 0;
                    if (g[i][k] == -1 || g[k][j] == -1) continue;

                    if (g[i][k] == 1) v ^= 1;
                    if (g[k][j] == 1) v ^= 1;
                    if (g[i][j] == -1) g[i][j] = v;
                    else if (g[i][j] != v) return fail;
                }
        var E = new List<int>();
        var used = new bool[n]; used[0] = true;
        for (int _ = 0; _ < n - 1; _++)
        {
            var x = -1; var y = -1;
            for (int i = 0; i < n && x == -1; i++)
            {
                if (used[i]) continue;
                for (int j = 0; j < n && x == -1; j++)
                {
                    if (!used[j]) continue;
                    if (g[i][j] == 0) continue;
                    var ok = true;

                    for (int k = 0; k < n; k++)
                    {
                        if (!used[k]) continue;
                        if (g[i][k] == -1) continue;
                        if (g[k][j] == -1) continue;
                        if (g[i][k] != -1 && (1 ^ g[k][j]) != g[i][k])
                            ok = false;
                    }
                    if (ok) {
                        x = i; y = j; }
                }
            }
            if (x == -1)
                return fail;
            E.Add(y); E.Add(x);
            used[x] = true;
        }
        Console.WriteLine(E.AsJoinedString());
        {
            var gg = Enumerate(n, x => new int[n]);
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                    gg[i][j] = gg[j][i] = 1000000000;
            for (int i = 0; i < E.Count; i += 2)
                gg[E[i]][E[i + 1]] = gg[E[i + 1]][E[i]] = 1;
            for (int k = 0; k < n; k++)
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < n; j++)
                        gg[i][j] = Math.Min(gg[i][j], gg[i][k] + gg[k][j]);
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (g[i][j] != -1 && gg[i][j] % 2 != g[i][j])
                        return fail;

        }
        return E.ToArray();
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int[] Naive_Test(string[] x)
    {
        return new int[] { };
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
        //Tests.Add(null);
    }
}
// CUT end
