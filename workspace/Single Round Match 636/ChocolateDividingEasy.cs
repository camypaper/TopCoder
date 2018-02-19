using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
using BitVector = System.Collections.Specialized.BitVector32;
public class ChocolateDividingEasy
{
    public int findBest(string[] chocolate)
    {
        var n = chocolate.Length;
        var m = chocolate[0].Length;
        var s = new int[n + 1][];
        for (int i = 0; i <= n; i++)
            s[i] = new int[m + 1];

        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                s[i + 1][j + 1] = s[i + 1][j] + s[i][j + 1] - s[i][j] + chocolate[i][j] - '0';
        var ret = 0;
        for (int i = 1; i <= n; i++)
            for (int j = i + 1; j <= n; j++)
                for (int k = 1; k <= m; k++)
                    for (int l = k + 1; l <= m; l++)
                    {
                        var a = new int[9];
                        a[0] = s[i][k];
                        a[1] = s[j][k] - s[i][k];
                        a[2] = s[n][k] - s[j][k];
                        a[3] = s[i][l] - s[i][k];
                        a[4] = s[i][m] - s[i][l];
                        a[5] = s[j][l] - s[j][k] - s[i][l] + s[i][k];
                        a[6] = s[j][m] - s[j][l] - s[i][m] + s[i][l];
                        a[7] = s[n][l] - s[n][k] - s[j][l] + s[j][k];
                        a[8] = s[n][m] - s[n][l] - s[j][m] + s[j][l];
                        var min = a.Min();
                        if (min == 2)
                        { 
                        }
                        if (a.Sum() != s[n][m])
                        { 
                        }
                        ret = Math.Max(min, ret);
                    }
        return ret;
    }

    // CUT begin
    public static void Main(string[] args)
    {
        var stream = new System.IO.StreamWriter("dbg.out");
        System.Diagnostics.Debug.Listeners.Add(new System.Diagnostics.TextWriterTraceListener(stream));
        var sc = new Scanner(Console.In);
        var t = new ChocolateDividingEasy();
        var u = new ChocolateDividingEasyTest();
        try
        {
            t.ManualTest(new string[] { "11111", "11111", "11111", "11111", "11111" });
           // t.ManualTest(Enumerable.Repeat(Enumerable.Repeat((char)'9', 50).AsString(), 50).ToArray());
            u.Example0();
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

    public void ManualTest(string[] chocolate)
    {
        //var joined = chocolate.AsJoinedString(",");
        var sw = new System.Diagnostics.Stopwatch();
        Console.WriteLine(string.Format("chocolate:{0}", string.Join(" ", chocolate))); sw.Start();
        var ret = findBest(chocolate);
        Console.WriteLine("Result:{0}", ret);
        sw.Stop();
        Console.WriteLine("Time:{0}ms", sw.ElapsedMilliseconds);

    }

    // CUT end
}
static public partial class EnumerableEX
{
    static public string AsString(this IEnumerable<char> source)
    {
        return new string(source.ToArray());
    }
    static public string AsJoinedString<T>(this IEnumerable<T> source, string s = " ")
    {
        return string.Join(s, source);
    }
}
