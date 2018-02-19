using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Enum = System.Linq.Enumerable;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
public class CasinoGame
{
	public double expectedValue(int[] S)
    {
		return 0.0;
	}

// CUT begin
    public static void Main(string[] args)
    {
        var stream = new System.IO.StreamWriter("dbg.out");
        System.Diagnostics.Debug.Listeners.Add(new System.Diagnostics.TextWriterTraceListener(stream));
        var sc= new Scanner(Console.In);
        var t = new CasinoGame();
        var u = new CasinoGameTest();
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

    public void ManualTest(int[] S)
    {
        var sw = new System.Diagnostics.Stopwatch();
        Console.WriteLine(string.Format("S:{0}",string.Join(" ",S)));        sw.Start();
        var ret = expectedValue(S);
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
