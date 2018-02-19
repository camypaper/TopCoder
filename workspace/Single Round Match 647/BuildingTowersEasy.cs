using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
public class BuildingTowersEasy
{
    public int maxHeight(int N, int[] x, int[] t)
    {
        var m = x.Length;
        var a = new int[m + 1];
        var b = new int[m + 1];
        var pass = new bool[m + 1];
        for (int i = 0; i < m; i++)
        {
            a[i + 1] = (x[i] - 1) + t[i];
            b[i + 1] = t[i] - (x[i] - 1);
        }
        var heights = new int[m + 1];
        for (int i = 0; i <= m; i++)
            heights[i] = int.MaxValue;
        for (int i = 1; i <= m; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (pass[j]) continue;
                var u = x[i - 1] - 1;
                var h = u + b[j];
                if (h < t[i - 1])
                {
                    pass[i] = true;
                    continue;
                }
                var p = (a[i] - b[j]) / 2;
                heights[j] = Math.Min(p + b[j], heights[j]);
            }
        }
        var ans = int.MaxValue;
        for (int i = m; i >= 0; i--)
        {
            if (pass[i]) continue;
            ans = (N - 1) + b[i];
            break;
        }
        for (int i = 0; i <= m; i++)
            if (heights[i] == int.MaxValue) continue;
            else ans = Math.Max(ans, heights[i]);
            
        return ans;
    }

    // CUT begin
    public static void Main(string[] args)
    {
        var stream = new System.IO.StreamWriter("dbg.out");
        System.Diagnostics.Debug.Listeners.Add(new System.Diagnostics.TextWriterTraceListener(stream));
        var sc = new Scanner(Console.In);
        var t = new BuildingTowersEasy();
        var u = new BuildingTowersEasyTest();
        try
        {
            //u.Example2();
            t.ManualTest(100000, new int[] { 1, 2, 3, 4, 5 }, new int[] { 0, 0, 0, 0, 0 });
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

    public void ManualTest(int N, int[] x, int[] t)
    {
        var sw = new System.Diagnostics.Stopwatch();
        Console.WriteLine("N:{0}", N);
        Console.WriteLine(string.Format("x:{0}", string.Join(" ", x))); Console.WriteLine(string.Format("t:{0}", string.Join(" ", t))); sw.Start();
        var ret = maxHeight(N, x, t);
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
}
