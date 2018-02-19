using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Enum = System.Linq.Enumerable;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
public class RandomOption
{
    public double getProbability(int keyCount, int[] badLane1, int[] badLane2)
    {
        var pair = new bool[keyCount + 1, keyCount + 1];
        for (int i = 0; i < badLane1.Length; i++)
        {
            pair[badLane1[i], badLane2[i]] = pair[badLane2[i], badLane1[i]] = true;
        }
        var a = new int[keyCount + 2];
        a[0] = a[keyCount + 1] = keyCount;
        Func<int, bool[], object> dfs = null;
        int ans = 0;
        dfs = (pos, used) =>
            {
                if (pos == keyCount + 1)
                {
                    ans++; return null;
                }
                for (int i = 0; i < keyCount; i++)
                {
                    if (used[i]) continue;
                    if (pair[a[pos - 1], i]) continue;
                    var tmp = a[pos];
                    a[pos] = i;
                    used[i] = true;
                    dfs(pos + 1, used);
                    used[i] = false;
                    a[pos] = tmp;
                }
                return null;
            };
        dfs(1, new bool[keyCount]);
        long count = 1;
        for (int i = 1; i <= keyCount; i++)
            count *= i;


        return 1.0 * ans / count;
    }

    // CUT begin
    public static void Main(string[] args)
    {
        var stream = new System.IO.StreamWriter("dbg.out");
        System.Diagnostics.Debug.Listeners.Add(new System.Diagnostics.TextWriterTraceListener(stream));
        var sc = new Scanner(Console.In);
        var t = new RandomOption();
        var u = new RandomOptionTest();
        try
        {
            t.ManualTest(11,new int[] {5, 8, 10},new int[] {8, 7, 8});

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

    public void ManualTest(int keyCount, int[] badLane1, int[] badLane2)
    {
        var sw = new System.Diagnostics.Stopwatch();
        Console.WriteLine("keyCount:{0}", keyCount);
        Console.WriteLine(string.Format("badLane1:{0}", string.Join(" ", badLane1))); Console.WriteLine(string.Format("badLane2:{0}", string.Join(" ", badLane2))); sw.Start();
        var ret = getProbability(keyCount, badLane1, badLane2);
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
