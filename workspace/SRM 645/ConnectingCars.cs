using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
public class ConnectingCars
{
    public long minimizeCost(int[] positions, int[] length)
    {
        var n = positions.Length;
        Array.Sort(positions, length);
        long ans = long.MaxValue;

        for (int i = 0; i < n; i++)
        {
            long x = positions[i];
            long s = 0;
            for (int j = i - 1; j >= 0; j--)
            {
                s += x- (positions[j] + length[j]);
                x -= length[j];
            }
            x = positions[i] + length[i];
            for (int j = i+1; j < n; j++)
            {
                s += positions[j] - x;
                x += length[j];
            }
            ans = Math.Min(ans, s);
        }

        return ans;
    }

    // CUT begin
    public static void Main(string[] args)
    {
        var stream = new System.IO.StreamWriter("dbg.out");
        System.Diagnostics.Debug.Listeners.Add(new System.Diagnostics.TextWriterTraceListener(stream));
        var sc = new Scanner(Console.In);
        var t = new ConnectingCars();
        var u = new ConnectingCarsTest();
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

    public void ManualTest(int[] positions, int[] lengths)
    {
        var sw = new System.Diagnostics.Stopwatch();
        Console.WriteLine(string.Format("positions:{0}", string.Join(" ", positions))); Console.WriteLine(string.Format("lengths:{0}", string.Join(" ", lengths))); sw.Start();
        var ret = minimizeCost(positions, lengths);
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
