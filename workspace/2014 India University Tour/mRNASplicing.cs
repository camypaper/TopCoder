using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Enum = System.Linq.Enumerable;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
using BitVector = System.Collections.Specialized.BitVector32;
public class mRNASplicing
{
    public int count(string s)
    {
        const string AUG = "AUG";
        const long mod = (long)1e9 + 7;
        var dp = new long[4, s.Length + 5];
        var n = s.Length;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (j < 3)
                {
                    if (s[i] == AUG[j])
                    {
                        if (j == 0)
                            dp[j, i + 1] = (dp[j, i] + 1) % mod;
                        else dp[j, i + 1] = (dp[j, i] + dp[j - 1, i]) % mod;
                    }
                    else dp[j, i + 1] = dp[j, i];
                }
                else dp[j, i + 1] = (dp[j, i] * 2 + dp[j - 1, i]) % mod;
            }
        }
        return (int)((dp[3, n] + dp[2, n]) % mod);
    }

    // CUT begin
    public static void Main(string[] args)
    {
        var stream = new System.IO.StreamWriter("dbg.out");
        System.Diagnostics.Debug.Listeners.Add(new System.Diagnostics.TextWriterTraceListener(stream));
        var sc = new Scanner(Console.In);
        var t = new mRNASplicing();
        var u = new mRNASplicingTest();
        try
        {
            u.Example3();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);
        }
        finally
        {
            System.Diagnostics.Debug.Close();
            System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);
        }
    }

    public void ManualTest(string s)
    {
        var sw = new System.Diagnostics.Stopwatch();
        Console.WriteLine("s:{0}", s);
        sw.Start();
        var ret = count(s);
        Console.WriteLine("Result:{0}", ret);
        sw.Stop();
        Console.WriteLine("Time:{0}ms", sw.ElapsedMilliseconds);

    }

    // CUT end
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
    static public T[] Enumerate<T>(this int n, Func<int, T> f)
    {
        var a = new T[n];
        for (int i = 0; i < n; i++)
            a[i] = f(i);
        return a;
    }
}
