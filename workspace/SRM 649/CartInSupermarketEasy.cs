using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Watch = System.Diagnostics.Stopwatch;
using StringBuilder = System.Text.StringBuilder;
public class CartInSupermarketEasy
{
    public int calc(int N, int K)
    {
        var set = new SortedSet<Pair>();
        var iter = 0;
        set.Add(new Pair(iter++, N, 0));
        var t = 0;
        var ans = 0;
        while (set.Any() && t < K)
        {
            var max = set.Max;
            set.Remove(max);
            if (max.val <= 2)
                ans = Math.Max(max.count + max.val, ans);
            else
            {
                set.Add(new Pair(iter++, max.val / 2, max.count + 1));
                set.Add(new Pair(iter++, max.val / 2 + max.val % 2, max.count + 1));
                t++;
            }
        }
        foreach (var x in set)
            ans = Math.Max(ans, x.val + x.count);
        return ans;
    }
    struct Pair : IComparable<Pair>
    {
        public int key, val, count;
        public Pair(int k, int v, int t) : this() { key = k; val = v; count = t; }


        public int CompareTo(Pair other)
        {
            var cmp = val.CompareTo(other.val);
            if (cmp == 0)
                return key.CompareTo(other.key);
            return cmp;
        }
    }
}