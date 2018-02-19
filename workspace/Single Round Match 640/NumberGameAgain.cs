using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Enum = System.Linq.Enumerable;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
public class NumberGameAgain
{
    public long solve(int k, long[] table)
    {
        k = 40;
        var goal = (1L << k) - 1;
        Array.Sort(table);
        var n = table.Length;
        var use = new bool[n];
        var set = new HashSet<long>();
        for (int i = 0; i < n; i++)
        {
            var v = table[i];
            int t = 0;
            while (v > 1)
            {
                if (set.Contains(v))
                {
                    use[i] = true;
                    break;
                }
                v >>= 1;
                t++;
            }
            set.Add(table[i]);
            if (!use[i])
            {
                goal -= (1L << (k - t)) -1;
            }
        }


        return goal - 1;
    }

    // CUT begin
    public static void Main(string[] args)
    {
        var stream = new System.IO.StreamWriter("dbg.out");
        System.Diagnostics.Debug.Listeners.Add(new System.Diagnostics.TextWriterTraceListener(stream));
        var sc = new Scanner(Console.In);
        var t = new NumberGameAgain();
        var u = new NumberGameAgainTest();
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

    public void ManualTest(int k, long[] table)
    {
        var sw = new System.Diagnostics.Stopwatch();
        Console.WriteLine("k:{0}", k);
        Console.WriteLine(string.Format("table:{0}", string.Join(" ", table))); sw.Start();
        var ret = solve(k, table);
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
