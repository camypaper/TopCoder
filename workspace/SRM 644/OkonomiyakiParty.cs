using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Enum = System.Linq.Enumerable;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
public class OkonomiyakiParty
{
	public int count(int[] osize, int M, int K)
    {
        Array.Sort(osize);
        var n=osize.Length;
        var dp = new long[n + 1, 10050];
        const long mod=(long)1e9+7;
        for (int i = 0; i < n; i++)
        {
            for (int j = M - 1; j >= 0; j--)
            {
                for (int k = 0; k < 10050; k++)
                {
                    if (j == 0 && k == 0)
                        dp[1, osize[i]] = (dp[1, osize[i]] + 1) % mod;
                    else if (osize[i] < k) continue;
                    else if (osize[i] - k > K) continue;
                    else dp[j + 1, k] = (dp[j + 1, k] + dp[j, k]) % mod;
                }
            }
				 
        }
        long ans = 0;
        for (int i = 0; i < 10050; i++)
            ans = (ans + dp[M, i]) % mod;

		return (int)ans;
	}

// CUT begin
    public static void Main(string[] args)
    {
        var stream = new System.IO.StreamWriter("dbg.out");
        System.Diagnostics.Debug.Listeners.Add(new System.Diagnostics.TextWriterTraceListener(stream));
        var sc= new Scanner(Console.In);
        var t = new OkonomiyakiParty();
        var u = new OkonomiyakiPartyTest();
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

    public void ManualTest(int[] osize, int M, int K)
    {
        var sw = new System.Diagnostics.Stopwatch();
        Console.WriteLine(string.Format("osize:{0}",string.Join(" ",osize)));Console.WriteLine("M:{0}",M);
        Console.WriteLine("K:{0}",K);
                sw.Start();
        var ret = count(osize, M, K);
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
