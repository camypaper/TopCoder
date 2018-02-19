using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class PathGame
{
    public string judge(string[] board)
    {
        return f(0, board[0].Length - 1, board) ? "Snuke" : "Sothe";
    }
    public bool g(char[] a, char[] b)
    {
        var ok = new bool[2];
        ok[0] = true; ok[1] = true;
        for (int i = 0; i < a.Length; i++)
        {
            var next = new bool[2];
            if (a[i] == '.') next[0] |= ok[0];
            if (b[i] == '.') next[1] |= ok[1];
            if (a[i] == '.' && b[i] == '.')
            {
                var x = next[0] | next[1];
                next[0] |= x;
                next[1] |= x;
            }
            ok = next;
        }
        if (ok.All(x => !x)) return true;
        var win = false;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == '.')
            {
                a[i] = '#';
                if (!g(a, b)) win = true;
                a[i] = '.';
            }
            if (b[i] == '.')
            {
                b[i] = '#';
                if (!g(a, b)) win = true;
                b[i] = '.';
            }
        }

        return win;
    }
    public bool f(int l, int r, string[] board)
    {
        if (l > r) return false;
        else if (r - l <= 2)
        {
            var a = board[0].Substring(l, r - l + 1);
            var b = board[1].Substring(l, r - l + 1);
            return g(a.ToCharArray(), b.ToCharArray());
        }
        else
        {
            var L = -1;
            var R = -1;
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                {
                    if (board[j][l + i] == '#') L = j;
                    if (board[j][r - i] == '#') R = j;
                }
            if (L == -1 && R == -1) return f(l + 2, r - 2, board);
            else if (L == -1 || R == -1) return true;
            else
            {
                var all = 0;
                for (int i = l; i <= r; i++)
                    for (int j = 0; j < 2; j++)
                        if (board[j][i] == '.') all++;
                var t = r - l + 1;
                if (L != R) t++;
                all %= 2;
                t %= 2;
                return all != t;

            }

        }
    }

    // CUT begin
    public string Naive_Test(string[] board)
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
    public override void Run()
    {
        Test(f => ManualTest(new string[] { "...", "..." }, f));
        //Tests.Add(null);
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);
        Test(Example4);

    }
}
// CUT end
