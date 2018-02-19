using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Enum = System.Linq.Enumerable;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
public class TheKingsArmyDiv1
{
    public int getNumber(string[] state)
    {
        var a = calc1(Enumerable.Range(1, 10000000).ToList());
        var b = calc2(Enumerable.Range(1, 10000000).ToList());
        Console.WriteLine(a);
        Console.WriteLine(b);
        return -1;
    }
    static long calc1(List<int> l)
    {
        var sw = new System.Diagnostics.Stopwatch();
        sw.Start();
        var k = l.Count - 1;
        for (int i = 0; i < 100; i++)
            l.Insert(k++, i);
        sw.Stop();
        return sw.ElapsedMilliseconds;
    }
    static long calc2(List<int> l)
    {
        var sw = new System.Diagnostics.Stopwatch();
        sw.Start();
        var last = l[l.Count - 1];
        l.RemoveAt(l.Count - 1);
        for (int i = 0; i < 100; i++)
            l.Add(i);
        l.Add(last);
        sw.Stop();
        return sw.ElapsedMilliseconds;
    }
    // CUT begin
    public static void Main(string[] args)
    {
        var stream = new System.IO.StreamWriter("dbg.out");
        System.Diagnostics.Debug.Listeners.Add(new System.Diagnostics.TextWriterTraceListener(stream));
        var sc = new Scanner(Console.In);
        var t = new TheKingsArmyDiv1();
        var u = new TheKingsArmyDiv1Test();
        try
        {
            t.ManualTest(new string[] { "HHSSHH", "SSHHSS" });
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

    public void ManualTest(string[] state)
    {
        var sw = new System.Diagnostics.Stopwatch();
        Console.WriteLine(string.Format("state:{0}", string.Join(" ", state))); sw.Start();
        var ret = getNumber(state);
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
