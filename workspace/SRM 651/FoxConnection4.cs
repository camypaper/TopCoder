using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class FoxConnection4
{
    public int howManyWays(string[] board, int k)
    {
        var n = board.Length;
        var m = board[0].Length;
        var dp = new HashSet<string>();
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
            {
                if (board[i][j] == '#') continue;
                var str = board.SelectMany(x => x).ToArray();
                str[i * m + j] = '$';
                dp.Add(new string(str));
            }
        int[] dx = { 1, 0, -1, 0 };
        int[] dy = { 0, 1, 0, -1 };
        for (int _ = 1; _ < k; _++)
        {
            var next = new HashSet<string>();
            foreach (var str in dp)
            {
                var st = str.ToCharArray();
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < m; j++)
                    {
                        if (st[i * m + j] == '#') continue;
                        if (st[i * m + j] == '$') continue;
                        var ok = false;
                        for (int d = 0; d < 4; d++)
                        {
                            var nx = i + dx[d];
                            var ny = j + dy[d];
                            if (nx < 0 || nx >= n || ny < 0 || ny >= m) continue;
                            if (st[nx * m + ny] == '$') { ok = true; break; }
                        }
                        if (ok)
                        {
                            var tmp = st[i * m + j];
                            st[i * m + j] = '$';
                            next.Add(new string(st));
                            st[i * m + j] = tmp;
                        }
                    }
            }
            dp = next;
        }
        return dp.Count;
    }

}
// CUT begin
public class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
        var S = Enumerate(10, x => new string('.', 10));
        var str = string.Join(",", S);
        test.ManualTest(S, 8);
    }
}
// CUT end
    