using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
public class BacteriesColony
{
	public int[] performTheExperiment(int[] colonies)
    {
        var n=colonies.Length;
        for (int i = 0; i < 200; i++)
        {
            var next = new int[n];
            next[0] = colonies[0];
            next[n - 1] = colonies[n - 1];
            for (int j = 1; j < n - 1; j++)
            {
                if (colonies[j - 1] < colonies[j] && colonies[j + 1] < colonies[j])
                    next[j] = colonies[j] - 1;
                else if (colonies[j - 1] > colonies[j] && colonies[j + 1] > colonies[j])
                    next[j] = colonies[j] + 1;
                else next[j] = colonies[j];
            }
            colonies = next;
        }
        return colonies;
	}

// CUT begin
    public static void Main(string[] args)
    {
        var stream = new System.IO.StreamWriter("dbg.out");
        System.Diagnostics.Debug.Listeners.Add(new System.Diagnostics.TextWriterTraceListener(stream));
        var sc= new Scanner(Console.In);
        var t = new BacteriesColony();
        var u = new BacteriesColonyTest();
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

    public void ManualTest(int[] colonies)
    {
        var sw = new System.Diagnostics.Stopwatch();
        Console.WriteLine(string.Format("colonies:{0}",string.Join(" ",colonies)));        sw.Start();
        var ret = performTheExperiment(colonies);
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
