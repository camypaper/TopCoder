using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
public class TravellingSalesmanEasy
{
	public int getMaxProfit(int M, int[] profit, int[] city, int[] visit)
    {
        var G = new List<int>[M];
        for (int i = 0; i < M; i++)
            G[i] = new List<int>();
        var n = profit.Length;
        for (int i = 0; i < n; i++)
        {
            var v = profit[i];
            var u = city[i] - 1;
            G[u].Add(v);
        }
        for (int i = 0; i < M; i++)
        {
            G[i].Sort();
            G[i].Reverse();
        }
        var vis = new int[M];
        foreach (var u in visit)
            vis[u - 1]++;
        var ans = 0;
        for (int i = 0; i < M; i++)
        {
            var to = Math.Min(vis[i], G[i].Count);
            for (int j = 0; j < to; j++)
                ans += G[i][j];

        }
		return ans;
	}

// CUT begin
    public static void Main(string[] args)
    {
        var stream = new System.IO.StreamWriter("dbg.out");
        System.Diagnostics.Debug.Listeners.Add(new System.Diagnostics.TextWriterTraceListener(stream));
        var sc= new Scanner(Console.In);
        var t = new TravellingSalesmanEasy();
        var u = new TravellingSalesmanEasyTest();
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

    public void ManualTest(int M, int[] profit, int[] city, int[] visit)
    {
        var sw = new System.Diagnostics.Stopwatch();
        Console.WriteLine("M:{0}",M);
        Console.WriteLine(string.Format("profit:{0}",string.Join(" ",profit)));Console.WriteLine(string.Format("city:{0}",string.Join(" ",city)));Console.WriteLine(string.Format("visit:{0}",string.Join(" ",visit)));        sw.Start();
        var ret = getMaxProfit(M, profit, city, visit);
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
