using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
public class PolygonTraversal2
{
    public int count(int n, int[] p)
    {
        var m = p.Length;
        var G = new bool[n, n];
        for (int i = 0; i < m - 1; i++)
            G[p[i] - 1, p[i + 1] - 1] = G[p[i + 1] - 1, p[i] - 1] = true;
        Func<int, int, bool[], int> dfs = null;
        dfs = (k, cur, used) =>
            {
                System.Diagnostics.Debug.WriteLine(cur);
                if (k == n)
                    if (cur == p[0] - 1) return 1;
                    else return 0;
                var ret = 0;
                for (int i = 0; i < n; i++)
                {
                    if ((cur + 1) % n == i || (cur + n - 1) % n == i)
                        continue;
                    if (used[i]) continue;
                    var f = false;
                    for (int j = i + 1; true; j++)
                    {
                        var u = j % n;
                        if (u == cur) break;
                        for (int l = cur + 1; true; l++)
                        {
                            var v = l % n;
                            if (v == i) break;
                            if (G[u, v])
                            {
                                f = true;
                                break;
                            }
                        }
                        if (f) break;
                    }
                    if (!f) continue;
                    used[i] = true;
                    G[cur, i] = G[i, cur] = true;
                    ret += dfs(k + 1, i, used);
                    G[cur, i] = G[i, cur] = false;
                    used[i] = false;
                }
                if (ret == 0)
                    System.Diagnostics.Debug.WriteLine("");
                return ret;
            };
        var flag = new bool[n];
        for (int i = 1; i < m; i++)
        {
            var pos = p[i] - 1;
            flag[pos] = true;
        }
        var ans = dfs(m - 1, p[m - 1] - 1, flag);
        return ans;
    }
}
static public class EnumerableEX
{
    static public string AsString(this IEnumerable<char> e)
    {
        return new string(e.ToArray());
    }
    static public string AsJoinedString<T>(this IEnumerable<T> e, string s = " ")
    {
        return string.Join(s, e);
    }
}
