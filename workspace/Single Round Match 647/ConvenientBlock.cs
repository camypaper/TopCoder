using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
public class ConvenientBlock
{
	public long minCost(int N, int[] from, int[] to, int[] cost)
    {
		return 0;
	}

// CUT begin
    public static void Main(string[] args)
    {
        var stream = new System.IO.StreamWriter("dbg.out");
        System.Diagnostics.Debug.Listeners.Add(new System.Diagnostics.TextWriterTraceListener(stream));
        var sc= new Scanner(Console.In);
        var t = new ConvenientBlock();
        var u = new ConvenientBlockTest();
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

    public void ManualTest(int N, int[] from, int[] to, int[] cost)
    {
        var sw = new System.Diagnostics.Stopwatch();
        Console.WriteLine("N:{0}",N);
        Console.WriteLine(string.Format("from:{0}",string.Join(" ",from)));Console.WriteLine(string.Format("to:{0}",string.Join(" ",to)));Console.WriteLine(string.Format("cost:{0}",string.Join(" ",cost)));        sw.Start();
        var ret = minCost(N, from, to, cost);
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
