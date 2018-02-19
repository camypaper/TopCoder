using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class PalindromeMatrix
{
    public int minChange(string[] A, int rowCount, int columnCount)
    {
        var n = A.Length;
        var m = A[0].Length;
        var min = 1 << 30;
        for (int _ = 0; _ < 1 << m; _++)
        {
            var isPalindrome = new bool[m];
            {
                var cnt = 0;
                for (int j = 0; j < m; j++)
                    if ((_ >> j & 1) == 1) { cnt++; isPalindrome[j] = true; }
                if (cnt != columnCount) continue;
                //columncount palindrome
            }
            var dp = new int[n + 1];//dp[i] i row is palindrome
            for (int i = 1; i <= n; i++)
                dp[i] = 1 << 20;
            const string pair = "01";
            for (int i = 0, j = n - 1; i < n / 2; i++, j--)
            {
                var next = new int[n + 1];
                for (int p = 0; p <= n; p++)
                    next[p] = 1 << 20;
                for (int p = 0; p < n; p++)
                {
                    if (dp[p] == 1 << 20)
                        continue;
                    //row i,j is not palindrome
                    {
                        var cnt = 0;
                        for (int k = 0; k < m; k++)
                            if (isPalindrome[k] && A[i][k] != A[j][k]) cnt++;
                        next[p] = Math.Min(next[p], dp[p] + cnt);
                    }
                    //row i is palindrome
                    {
                        var cnt = 0;
                        for (int k = 0, l = m - 1; k < m / 2; k++, l--)
                        {
                            var v = 1000;
                            for (int t = 0; t < 2; t++)
                            {
                                var c = 0;
                                if (A[i][k] != pair[t]) c++;
                                if (A[i][l] != pair[t]) c++;
                                if (isPalindrome[k] && A[j][k] != pair[t]) c++;
                                if (isPalindrome[l] && A[j][l] != pair[t]) c++;
                                v = Math.Min(c, v);
                            }
                            cnt += v;

                        }
                        next[p + 1] = Math.Min(next[p + 1], dp[p] + cnt);
                    }

                    //row j is palindrome
                    {
                        var cnt = 0;
                        for (int k = 0, l = m - 1; k < m / 2; k++, l--)
                        {

                            var v = 1000;
                            for (int t = 0; t < 2; t++)
                            {
                                var c = 0;
                                if (A[j][k] != pair[t]) c++;
                                if (A[j][l] != pair[t]) c++;
                                if (isPalindrome[k] && A[i][k] != pair[t]) c++;
                                if (isPalindrome[l] && A[i][l] != pair[t]) c++;
                                v = Math.Min(c, v);
                            }
                            cnt += v;

                        }
                        next[p + 1] = Math.Min(next[p + 1], dp[p] + cnt);
                    }
                    //row i,j is palindrome
                    {
                        var cnt = 0;
                        for (int k = 0, l = m - 1; k < m / 2; k++, l--)
                        {
                            var v = 1000;
                            for (int t = 0; t < 2; t++)
                            {
                                var c = 0;
                                if (isPalindrome[k] || isPalindrome[l])
                                {
                                    if (A[i][k] != pair[t]) c++;
                                    if (A[j][k] != pair[t]) c++;
                                    if (A[i][l] != pair[t]) c++;
                                    if (A[j][l] != pair[t]) c++;
                                }
                                else
                                {
                                    if (A[i][k] != A[i][l]) c++;
                                    if (A[j][k] != A[j][l]) c++;
                                }
                                v = Math.Min(c, v);
                            }
                            cnt += v;

                        }
                        next[p + 2] = Math.Min(next[p + 2], dp[p] + cnt);
                    }
                }
                dp = next;

            }
            for (int i = rowCount; i <= n; i++)
                min = Math.Min(dp[i], min);
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
