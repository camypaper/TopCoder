using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class TreeAndPathLength3
{
    public int[] construct(int s)
    {

        var ans = new List<int>();
        for (int i = 1; i <= 500; i++)
        {
            for (int j = 1; j <= 500; j++)
            {
                if (i + j + 2 > 500) break;
                if (i * j == s)
                {
                    var L = 0; var R = 1;
                    ans.Add(L); ans.Add(R);
                    var p = 2;
                    for (int t = 0; t < i; t++)
                    {
                        ans.Add(L); ans.Add(p++);
                    }
                    for (int u = 0; u < j; u++)
                    {
                        ans.Add(R); ans.Add(p++);
                    }
                    return ans.ToArray();

                }
                for (int k = 1; k <= 500; k++)
                {
                    if (i + j + k + 3 > 500) break;


                    if (i * (j + 1) + k * (j + 1) == s)
                    {
                        var L = 0; var R = 1; var U = 2;
                        ans.Add(L); ans.Add(R);
                        ans.Add(R); ans.Add(U);
                        var p = 3;
                        for (int t = 0; t < i; t++)
                        {
                            ans.Add(L); ans.Add(p++);
                        }
                        for (int u = 0; u < j; u++)
                        {
                            ans.Add(R); ans.Add(p++);
                        }
                        for (int t = 0; t < k; t++)
                        {
                            ans.Add(U); ans.Add(p++);
                        }
                        return ans.ToArray();

                    }
                    continue;
                    for (int l = 1; l <= 500; l++)
                    {
                        if (i + j + k + l + 4 > 500) break;
                        var sum = i * j + i + k * (j + 1) + (j + 1) + l * (i + 1);
                        if (sum == s)
                        {
                            var L = 0; var R = 1; var U = 2; var T = 3;
                            ans.Add(L); ans.Add(R);
                            ans.Add(R); ans.Add(U);
                            ans.Add(L); ans.Add(T);
                            var p = 4;
                            for (int t = 0; t < i; t++)
                            {
                                ans.Add(L); ans.Add(p++);
                            }
                            for (int u = 0; u < j; u++)
                            {
                                ans.Add(R); ans.Add(p++);
                            }
                            for (int t = 0; t < k; t++)
                            {
                                ans.Add(U); ans.Add(p++);
                            }
                            for (int t = 0; t < l; t++)
                            {
                                ans.Add(T); ans.Add(p++);
                            }
                            return ans.ToArray();
                        }
                    }

                }
            }
        }

        return new int[] { };
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
        test.ManualTest(996);
        //test.ManualTest();
        base.Test();
    }
}
// CUT end
