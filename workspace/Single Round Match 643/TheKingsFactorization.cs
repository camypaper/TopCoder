using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Enum = System.Linq.Enumerable;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
public class TheKingsFactorization
{
	public long[] getVector(long N, long[] primes)
    {
        var s = Enumerable.Repeat('S', 100).AsString();
        var ans = new List<long>();
        var prime = Sieve((int)1e6);
        var pl = new List<long>();
        for (int i = 0; i < prime.Length; i++)
        {
            if (prime[i]) pl.Add(i);
        }
        foreach (var p in primes)
        {
            N /= p;
            ans.Add(p);
        }
        foreach (var p in pl)
        {
            while (N % p == 0)
            {
                N /= p;
                ans.Add(p);
            }
        }
        if (N > 1)
            ans.Add(N);
        ans.Sort();
        return ans.ToArray();
	}
    static public bool[] Sieve(int p)
    {
        var isPrime = new bool[p + 1];
        for (int i = 2; i <= p; i++)
            isPrime[i] = true;
        for (int i = 2; i * i <= p; i++)
        {
            if (!isPrime[i])
                continue;
            for (int j = i * i; j <= p; j += i)
                isPrime[j] = false;
        }
        return isPrime;
    }

// CUT begin
    public static void Main(string[] args)
    {
        var stream = new System.IO.StreamWriter("dbg.out");
        System.Diagnostics.Debug.Listeners.Add(new System.Diagnostics.TextWriterTraceListener(stream));
        var sc= new Scanner(Console.In);
        var t = new TheKingsFactorization();
        var u = new TheKingsFactorizationTest();
        try
        {
            t.ManualTest(2, new long[] { 2 });
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

    public void ManualTest(long N, long[] primes)
    {
        var sw = new System.Diagnostics.Stopwatch();
        Console.WriteLine("N:{0}",N);
        Console.WriteLine(string.Format("primes:{0}",string.Join(" ",primes)));        sw.Start();
        var ret = getVector(N, primes);
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
