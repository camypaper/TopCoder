using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Enum = System.Linq.Enumerable;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
using BitVector = System.Collections.Specialized.BitVector32;
public class DigitMultiple
{
	public int calc(int x)
    {
        long v=x;
        while (v >= 10)
        {
            v = v.ToString().Select(t => t - '0').Aggregate(1, (l, r) => l * r);
        }
		return (int)v;
	}

// CUT begin
    public static void Main(string[] args)
    {
        var stream = new System.IO.StreamWriter("dbg.out");
        System.Diagnostics.Debug.Listeners.Add(new System.Diagnostics.TextWriterTraceListener(stream));
        var sc= new Scanner(Console.In);
        var t = new DigitMultiple();
        var u = new DigitMultipleTest();
        try
        {
            u.Example1();
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

    public void ManualTest(int x)
    {
        var sw = new System.Diagnostics.Stopwatch();
        Console.WriteLine("x:{0}",x);
                sw.Start();
        var ret = calc(x);
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
    static public T[] Enumerate<T>(this int n, Func<int, T> f)
    {
        var a = new T[n];
        for (int i = 0; i < n; i++)
            a[i] = f(i);
        return a;
    }
}
