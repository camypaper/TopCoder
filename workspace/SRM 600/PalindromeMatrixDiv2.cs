using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class PalindromeMatrixDiv2
{
    public int minChange(string[] A, int rowCount, int columnCount)
    {
        var n = A.Length;
        var m = A[0].Length;
        var min = 1 << 20;
        for (int _ = 0; _ < 1 << m; _++)
        {
            var isPalindrome = new bool[m];
            {
                for (int i = 0; i < m; i++)
                    if ((_ >> i & 1) == 1) isPalindrome[i] = true;
                if (isPalindrome.Count(x => x) != columnCount)
                    continue;
            }
            var dp = new int[n + 1];
            for (int i = 1; i <= n; i++)
                dp[i] = 1 << 20;
            Debug.WriteLine(_);
            for (int i = 0, j = n - 1; i < n / 2; i++, j--)
            {
                Debug.WriteLine(i);
                var next = new int[n + 1];
                for (int k = 0; k <= n; k++)
                    next[k] = 1 << 20;
                for (int p = 0; p < n; p++)
                {
                    if (dp[p] == 1 << 20)
                        continue;
                    int a = 0, b = 0, c = 0, d = 0;
                    for (int k = 0, l = m - 1; k < m / 2; k++, l--)
                    {
                        if (isPalindrome[k] && isPalindrome[l])
                        {
                            a += ((A[i][k] != A[j][k]) ? 1 : 0) + ((A[i][l] != A[j][l]) ? 1 : 0);
                            var cnt = (A[i][k] - '0') + (A[j][k] - '0') + (A[i][l] - '0') + (A[j][l] - '0');
                            b += Math.Min(cnt, 4 - cnt);
                            c += Math.Min(cnt, 4 - cnt);
                            d += Math.Min(cnt, 4 - cnt);

                        }
                        else if (isPalindrome[k])
                        {
                            a += (A[i][k] != A[j][k]) ? 1 : 0;
                            b += (A[i][k] != A[i][l]) || (A[i][k] != A[j][k]) ? 1 : 0;
                            c += (A[j][k] != A[j][l] || (A[i][k] != A[j][k])) ? 1 : 0;
                            var cnt = (A[i][k] - '0') + (A[j][k] - '0') + (A[i][l] - '0') + (A[j][l] - '0');
                            d += Math.Min(cnt, 4 - cnt);
                        }
                        else if (isPalindrome[l])
                        {
                            a += (A[i][l] != A[j][l]) ? 1 : 0;
                            b += (A[i][k] != A[i][l]) || (A[i][l] != A[j][l]) ? 1 : 0;
                            c += (A[j][k] != A[j][l] || (A[i][l] != A[j][l])) ? 1 : 0;
                            var cnt = (A[i][k] - '0') + (A[j][k] - '0') + (A[i][l] - '0') + (A[j][l] - '0');
                            d += Math.Min(cnt, 4 - cnt);
                        }
                        else
                        {
                            b += (A[i][k] != A[i][l]) ? 1 : 0;
                            c += (A[j][k] != A[j][l]) ? 1 : 0;
                            d += ((A[i][k] != A[i][l]) ? 1 : 0) + ((A[j][k] != A[j][l]) ? 1 : 0);
                        }
                    }
                    next[p] = Math.Min(dp[p] + a, next[p]);
                    next[p + 1] = Math.Min(dp[p] + Math.Min(b, c), next[p + 1]);
                    next[p + 2] = Math.Min(dp[p] + d, next[p + 2]);

                }
                dp = next;

            }
            for (int i = rowCount; i <= n; i++)
                min = Math.Min(min, dp[i]);

        }
        return min;
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
    public override void Test()
    {
        //test.ManualTest();
        base.Test();
    }
}
// CUT end
