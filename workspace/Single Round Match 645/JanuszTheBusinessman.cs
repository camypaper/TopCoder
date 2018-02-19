using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
public class JanuszTheBusinessman
{

    public int makeGuestsReturn(int[] arrivals, int[] departures)
    {
        Array.Sort(arrivals, departures);
        var n = arrivals.Length;
        var a = new int[n + 1];
        var b = new int[n + 1];
        a[0] = -1;
        b[0] = -1;
        for (int i = 0; i < n; i++)
        {
            a[i + 1] = arrivals[i];
            b[i + 1] = departures[i];
        }
        var dp = new int[n + 2];
        for (int i = 1; i <= n + 1; i++)
            dp[i] = 1 << 30;
        for (int i = 1; i <= n; i++)
        {
            var f = a[i];
            var t = b[i];
            int k = i;
            var max = t;
            for (; k < n; k++)
            {
                if (a[k] > t) break;
                max = Math.Max(b[k], max);
            }
            for (int j = i; j <= n; j++)
            {
                if (max < a[j]) break;
                dp[j] = Math.Min(dp[i - 1] + 1, dp[j]);
            }

        }
        return dp[n];
    }
    // CUT begin
    public static void Main(string[] args)
    {
        var stream = new System.IO.StreamWriter("dbg.out");
        System.Diagnostics.Debug.Listeners.Add(new System.Diagnostics.TextWriterTraceListener(stream));
        var sc = new Scanner(Console.In);
        var t = new JanuszTheBusinessman();
        var u = new JanuszTheBusinessmanTest();
        try
        {
            u.Example2();
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

    public void ManualTest(int[] arrivals, int[] departures)
    {
        var sw = new System.Diagnostics.Stopwatch();
        Console.WriteLine(string.Format("arrivals:{0}", string.Join(" ", arrivals))); Console.WriteLine(string.Format("departures:{0}", string.Join(" ", departures))); sw.Start();
        var ret = makeGuestsReturn(arrivals, departures);
        Console.WriteLine("Result:{0}", ret);
        sw.Stop();
        Console.WriteLine("Time:{0}ms", sw.ElapsedMilliseconds);

    }

    // CUT end
}
