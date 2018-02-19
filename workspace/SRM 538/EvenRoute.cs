using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class EvenRoute
{
    public string isItPossible(int[] x, int[] y, int wantedParity)
    {
        // EE OE EO OO
        var cnt = new int[4];
        var n = x.Length;
        for (int i = 0; i < n; i++)
        {
            var a = x[i] % 2 == 0 ? 0 : 1;
            var b = y[i] % 2 == 0 ? 0 : 2;
            cnt[a + b]++;
        }
        var mat = new int[4, 4];
        mat[0, 1] = mat[1, 0] = mat[0, 2] = mat[2, 0] = 1;
        mat[1, 3] = mat[3, 1] = mat[2, 3] = mat[3, 2] = 1;
        var dp = new bool[cnt[0] + 4, cnt[1] + 4, cnt[2] + 4, cnt[3] + 4, 4, 2];
        dp[0, 0, 0, 0, 0, 0] = true;
        for (int i = 0; i <= cnt[0]; i++)
            for (int j = 0; j <= cnt[1]; j++)
                for (int k = 0; k <= cnt[2]; k++)
                    for (int l = 0; l <= cnt[3]; l++)
                        for (int p = 0; p < 4; p++)
                            for (int q = 0; q < 2; q++)
                            {
                                if (!dp[i, j, k, l, p, q]) continue;
                                dp[i + 1, j, k, l, 0, q ^ mat[p, 0]] |= true;
                                dp[i, j + 1, k, l, 1, q ^ mat[p, 1]] |= true;
                                dp[i, j, k + 1, l, 2, q ^ mat[p, 2]] |= true;
                                dp[i, j, k, l + 1, 3, q ^ mat[p, 3]] |= true;
                            }
        var ok = false;
        for (int i = 0; i < 4; i++)
            ok |= dp[cnt[0], cnt[1], cnt[2], cnt[3], i, wantedParity];
        if (ok) return "CAN";
        return "CANNOT";
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
