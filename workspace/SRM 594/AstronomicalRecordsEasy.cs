using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
public class AstronomicalRecordsEasy
{
    public int minimalPlanets(int[] A, int[] B)
    {
        var ans = int.MaxValue;
        var s = new HashSet<int>();
        foreach (var x in A) s.Add(x);
        foreach (var x in B) s.Add(x);
        foreach(var i in s)
        {
            foreach(var j in s)
            {
                var set = new HashSet<int>();
                foreach (var x in A)
                    set.Add(i * x);
                foreach (var x in B)
                    set.Add(j * x);
                ans = Math.Min(ans, set.Count);
            }
        }
        return ans;
    }
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
