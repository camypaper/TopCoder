using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Enum = System.Linq.Enumerable;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
public class AliceGameEasy
{
	public long findMinimumValue(long x, long y)
    {
        //x = y = (long)1e12;
        long ans = 0;
        long sum = x + y;
        long t = 1;
        while (ans<sum)
        {
            ans += t;
            if (ans == sum) break;
            t++;
        }
        if (ans > sum) return -1;
        long k = 0;
        while (t > 0)
        {
            if (x >= t)
            {
                x -= t;
                k++;
            }
            t--;
        }
        if (x != 0) return -1;
        return k;
	}

// CUT begin
    public static void Main(string[] args)
    {
        var stream = new System.IO.StreamWriter("dbg.out");
        System.Diagnostics.Debug.Listeners.Add(new System.Diagnostics.TextWriterTraceListener(stream));
        var sc= new Scanner(Console.In);
        var t = new AliceGameEasy();
        var u = new AliceGameEasyTest();
        try
        {
            t.ManualTest(0, 1);
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

    public void ManualTest(long x, long y)
    {
        var sw = new System.Diagnostics.Stopwatch();
        Console.WriteLine("x:{0}",x);
        Console.WriteLine("y:{0}",y);
                sw.Start();
        var ret = findMinimumValue(x, y);
        Console.WriteLine("Result:{0}",ret);
        sw.Stop();
        Console.WriteLine("Time:{0}ms",sw.ElapsedMilliseconds);

    }
    
// CUT end
}
static public class EnumerableEX
{
    static public string AsString(this IEnumerable<char> e)
    {
        return new string(e.ToArray());
    }
    static public string AsJoinedString<T>(this IEnumerable<T> e,string s=" ")
    {
        return string.Join(s, e);
    }
}
