using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using StringBuilder = System.Text.StringBuilder;
public class StrengthOrIntellect
{
    public int numberOfMissions(int[] strength, int[] intellect, int[] points)
    {
        var n = strength.Length;
        var a = new otaku[n + 2];
        var b = new otaku[n + 2];
        var dp = new int[n + 2, n + 2, 1050];
        for (int i = 0; i <= n; i++)
            for (int j = 0; j <= n; j++)
                for (int k = 0; k < 1050; k++)
                    dp[i, j, k] = -1000;
        int fir = 0, cnt = 0;
        for (int i = 0; i < n; i++)
        {
            var p = new otaku(strength[i], intellect[i], points[i]);
            a[i] = p;
            b[i] = p;
            if (a[i].x == 1 && a[i].y == 1)
            {
                fir += a[i].z;
                cnt++;
            }
        }
        a[n] = b[n] = new otaku(1, 1, 0);
        a[n + 1] = b[n + 1] = new otaku(100000, 100000, 0);
        Array.Sort(a, (l, r) =>
        {
            var cmp = l.x.CompareTo(r.x);
            if (cmp != 0) return cmp;
            cmp = l.y.CompareTo(r.y);
            if (cmp != 0)
                return cmp;
            return l.z.CompareTo(r.z);
        });
        Array.Sort(b, (l, r) =>
        {
            var cmp = l.y.CompareTo(r.y);
            if (cmp != 0) return cmp;
            cmp = l.x.CompareTo(r.x);
            if (cmp != 0)
                return cmp;
            return l.z.CompareTo(r.z);
        });
        Func<int, int, int, int> dfs = null;
        dfs = (x, y, z) =>
            {
                System.Diagnostics.Debug.WriteLine("{0} {1} {2}", x, y, z);
                if (dp[x, y, z] > 0)
                    return dp[x, y, z];
                var ret = 0;
                var str = a[x].x;
                var it = b[y].y;
                if (a[x + 1].x <= str + z)
                {
                    var nx = x + 1;
                    var nz = z - (a[x + 1].x - str);
                    var plus = 0;
                    var nstr = a[x + 1].x;
                    while (a[nx].x == nstr)
                    {
                        if (a[nx].y > it)
                        {
                            plus++; nz += a[nx].z;
                        }
                        nx++;
                    }
                    ret = Math.Max(ret, plus + dfs(nx - 1, y, Math.Min(nz, 1000)));
                }
                if (b[y + 1].y <= it + z)
                {
                    var ny = y + 1;
                    var nz = z - (b[y + 1].y - it);
                    var plus = 0;
                    var nit = b[y + 1].y;
                    while (b[ny].y == nit)
                    {
                        if (b[ny].x > str)
                        {
                            plus++; nz += b[ny].z;
                        }
                        ny++;
                    }
                    ret = Math.Max(ret, plus + dfs(x, ny - 1, Math.Min(nz, 1000)));
                }
                return dp[x, y, z] = ret;
            };
        return cnt + dfs(0, 0, Math.Min(1000, fir));
    }
}
public struct otaku
{
    public int x, y, z;
    public otaku(int a, int b, int c) : this() { x = a; y = b; z = c; }
    public override string ToString()
    {
        return string.Format("{0} {1} {2}", x, y, z);
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
