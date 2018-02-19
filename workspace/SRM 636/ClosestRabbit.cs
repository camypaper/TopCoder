using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class ClosestRabbit
{
    public double getExpected(string[] board, int r)
    {
        var n = board.Length;
        var m = board[0].Length;
        var comb = new CombinationTable(500);
        var all = 0;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                if (board[i][j] == '.') all++;

        var ans = 0.0;
        var p = 1.0 / all;
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
            {
                if (board[i][j] == '#') continue;

                for (int u = 0; u < n; u++)
                    for (int v = 0; v < m; v++)
                    {
                        if (board[u][v] == '#') continue;
                        if (i == u && j == v) continue;
                        var d = (u - i) * (u - i) + (v - j) * (v - j);
                        var cnt = 0;
                        for (int x = 0; x < n; x++)
                            for (int y = 0; y < m; y++)
                            {
                                if (board[x][y] == '#') continue;
                                if (x == i && y == j) continue;
                                if (x == u && y == v) continue;

                                var d1 = (x - i) * (x - i) + (y - j) * (y - j);
                                var d2 = (x - u) * (x - u) + (y - v) * (y - v);
                                if (d1 < d) cnt++;
                                else if (d2 < d) cnt++;
                                else if (d1 == d && x < u) cnt++;
                                else if (d1 == d && x == u && y < v) cnt++;
                                else if (d2 == d && x < i) cnt++;
                                else if (d2 == d && x == i && y < j) cnt++;
                            }
                        var rem = all - 2 - cnt;
                        if (rem >= r - 2)
                        {
                            //Debug.WriteLine("({0} {1}) ({2} {3})", i, j, u, v);
                            ans += comb[rem, r - 2] / comb[all, r];
                        }
                    }

            }
        return ans / 2;
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
#region CombinationTable
public class CombinationTable
{
    double[][] nCr;
    //const long mod = (long)1e9;
    public CombinationTable(int n)
    {
        nCr = new double[n + 1][];
        for (int i = 0; i <= n; i++)
            nCr[i] = new double[i + 2];
        nCr[0][0] = 1;
        for (int i = 0; i <= n; i++)
        {
            nCr[i][0] = 1;
            for (int j = 1; j <= i; j++)
                nCr[i][j] = (nCr[i - 1][j - 1] + nCr[i - 1][j]);// % mod;
        }
    }
    public double this[int n, int r]
    {
        get
        {
            if (n < 0 || n >= nCr.Length)
                throw new IndexOutOfRangeException("n<=0 || n>N ");
            if (r < 0 || r > n)
                throw new IndexOutOfRangeException("r<=0 ||r>n");
            return nCr[n][r];
        }
    }
}
#endregion