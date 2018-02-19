using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Enum = System.Linq.Enumerable;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
public class ChristmasTreeDecorationDiv2
{
	public int solve(int[] col, int[] x, int[] y)
    {
        var n = x.Length;
        var ans = 0;
        for (int i = 0; i < n; i++)
        {
            var p = x[i] - 1;
            var q = y[i] - 1;
            if (col[p] != col[q]) ans++;
        }
		return ans;
	}

// CUT begin
    public static void Main(string[] args)
    {
        var stream = new System.IO.StreamWriter("dbg.out");
        System.Diagnostics.Debug.Listeners.Add(new System.Diagnostics.TextWriterTraceListener(stream));
        var sc= new Scanner(Console.In);
        var t = new ChristmasTreeDecorationDiv2();
        var u = new ChristmasTreeDecorationDiv2Test();
        try
        {
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

    public void ManualTest(int[] col, int[] x, int[] y)
    {
        var sw = new System.Diagnostics.Stopwatch();
        Console.WriteLine(string.Format("col:{0}",string.Join(" ",col)));Console.WriteLine(string.Format("x:{0}",string.Join(" ",x)));Console.WriteLine(string.Format("y:{0}",string.Join(" ",y)));        sw.Start();
        var ret = solve(col, x, y);
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
