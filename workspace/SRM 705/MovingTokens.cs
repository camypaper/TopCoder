using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class MovingTokens
{
    public int move(int n, int m, int[] moves)
    {
        var a = Enumerate(m, x => new int[n]);
        var b = Enumerate(m, x => Enumerate(n, y => new List<int>()));
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
            {
                a[j][i] = moves[j * n + i];
                b[j][a[j][i]].Add(i);
            }
        var dp = new KeyValuePair<bool, int[]>[n, n];
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                dp[i, j] = i == j ? new KeyValuePair<bool, int[]>(true, Enumerate(n, x => x))
                : new KeyValuePair<bool, int[]>(false, new int[] { });
        {
            var q = new Queue<KeyValuePair<int, int>>();
            for (int i = 0; i < n; i++)
                q.Enqueue(new KeyValuePair<int, int>(i, i));
            while (q.Any())
            {
                var p = q.Dequeue();
                var x = p.Key;
                var y = p.Value;
                Debug.WriteLine(p);
                for (int i = 0; i < m; i++)
                {
                    foreach (var u in b[i][x])
                        foreach (var v in b[i][y])
                            if (!dp[u, v].Key)
                            {
                                var nc = new int[n];
                                for (int j = 0; j < n; j++)
                                    nc[j] = dp[x, y].Value[a[i][j]];
                                dp[u, v] = new KeyValuePair<bool, int[]>(true, nc);
                                q.Enqueue(new KeyValuePair<int, int>(u, v));
                            }

                }
            }
        }
        var c = Enumerate(n, x => 1);
        for (int k = 0; k < n; k++)
        {
            Debug.WriteLine(c.AsJoinedString());
            var ok = true;
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                    if (dp[i, j].Key && c[i] == 1 && c[j] == 1)
                    {

                        var id = dp[i, j];
                        var nc = new int[n];
                        for (int go = 0; go < n; go++)
                            nc[dp[i, j].Value[go]] |= c[go];
                        c = nc;
                        ok = false;
                        break;
                    }
            if (ok) break;
        }

        return c.Sum();
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    static public void Swap<T>(ref T a, ref T b) { var tmp = a; a = b; b = tmp; }
    // CUT begin
    public int Naive_Test(int n, int m, int[] moves)
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
    public override void Run()
    {
        Test(f => ManualTest(4, 2, new int[] { 1, 2, 0, 1, 1, 2, 0, 0 }, f));
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);
        Test(Example4);

    }
}
// CUT end
