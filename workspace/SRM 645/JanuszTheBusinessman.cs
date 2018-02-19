using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
public class JanuszTheBusinessman
{
    static public class Pair
    {
        static public Pair<FT, ST> Create<FT, ST>(FT f, ST s)
            where FT : IComparable<FT>
            where ST : IComparable<ST>
        { return new Pair<FT, ST>(f, s); }
    }
    public struct Pair<FT, ST> : IComparable<Pair<FT, ST>>
        where FT : IComparable<FT>
        where ST : IComparable<ST>
    {
        public FT x;
        public ST y;
        public Pair(FT f, ST s) : this() { x = f; y = s; }

        public int CompareTo(Pair<FT, ST> other)
        {
            var cmp = x.CompareTo(other.x);
            return cmp != 0 ? cmp : y.CompareTo(other.y);
        }
    }
    public int makeGuestsReturn(int[] arrivals, int[] departures)
    {
        var n = arrivals.Length;
        Array.Sort(arrivals, departures);
        var pq = new SortedSet<Pair<int, int>>();
        for (int i = 0; i < n; i++)
            pq.Add(Pair.Create(departures[i], i));
        var ans = 0;
        var used = new bool[n];
        while (pq.Any())
        {
            var min = pq.Min;
            var pos = min.y;
            pq.Remove(min);
            if (used[pos]) continue;
            ans++;
            var f = arrivals[pos];
            var t = departures[pos];
            for (int j = 0; j < n; j++)
            {
                if (departures[j] < arrivals[pos]) continue;
                if (departures[pos] < arrivals[j]) continue;
                if (departures[j] > t)
                {
                    f = arrivals[j];
                    t = departures[j];
                }
            }
            for (int j = 0; j < n; j++)
            {
                if (t < arrivals[j] || departures[j] < f) continue;
                used[j] |= true;
            }
        }
        return ans;
    }
    // CUT begin
    public static void Main(string[] args)
    {
        var stream = new System.IO.StreamWriter("dbg.out");
        System.Diagnostics.Debug.Listeners.Add(new System.Diagnostics.TextWriterTraceListener(stream));
        var sc = new Scanner(Console.In);
        var t = new JanuszTheBusinessman();
        var u = new JanuszTheBusinessmanTest();
        try
        {
            t.ManualTest(new int[] { 154, 1, 340, 111, 92, 237, 170, 113, 241, 91, 228, 134, 191, 86, 59, 115, 277, 328, 12, 6 }, new int[] { 159, 4, 341, 118, 101, 244, 177, 123, 244, 96, 231, 136, 193, 95, 64, 118, 282, 330, 17, 13 });
            u.Example2();
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

    public void ManualTest(int[] arrivals, int[] departures)
    {
        var sw = new System.Diagnostics.Stopwatch();
        Console.WriteLine(string.Format("arrivals:{0}", string.Join(" ", arrivals))); Console.WriteLine(string.Format("departures:{0}", string.Join(" ", departures))); sw.Start();
        var ret = makeGuestsReturn(arrivals, departures);
        Console.WriteLine("Result:{0}", ret);
        sw.Stop();
        Console.WriteLine("Time:{0}ms", sw.ElapsedMilliseconds);

    }

    // CUT end
}
