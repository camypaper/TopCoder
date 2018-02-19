using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Enum = System.Linq.Enumerable;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
public class ElectronicPetEasy
{
	public string isDifficult(int st1, int p1, int t1, int st2, int p2, int t2)
    {
        var used = new bool[1000050];
        for (int i = 0; i < t1; i++)
        {
            used[st1] = true;
            st1 += p1;
        }
        for (int i = 0; i < t2; i++)
        {
            if (used[st2])
                return "Difficult";
            st2 += p2;
        }

		return "Easy";
	}

// CUT begin
    public static void Main(string[] args)
    {
        var stream = new System.IO.StreamWriter("dbg.out");
        System.Diagnostics.Debug.Listeners.Add(new System.Diagnostics.TextWriterTraceListener(stream));
        var sc= new Scanner(Console.In);
        var t = new ElectronicPetEasy();
        var u = new ElectronicPetEasyTest();
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

    public void ManualTest(int st1, int p1, int t1, int st2, int p2, int t2)
    {
        var sw = new System.Diagnostics.Stopwatch();
        Console.WriteLine("st1:{0}",st1);
        Console.WriteLine("p1:{0}",p1);
        Console.WriteLine("t1:{0}",t1);
        Console.WriteLine("st2:{0}",st2);
        Console.WriteLine("p2:{0}",p2);
        Console.WriteLine("t2:{0}",t2);
                sw.Start();
        var ret = isDifficult(st1, p1, t1, st2, p2, t2);
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
