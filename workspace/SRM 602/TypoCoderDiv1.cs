using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class TypoCoderDiv1
{
    public int getmax(int[] D, int X)
    {
        var dp = new HashMap<long, int>();
        dp[X] = 0;
        var C = 2200;
        foreach (var d in D)
        {
            var next = new HashMap<long, int>();
            foreach (var kv in dp)
            {
                var add = 0;
                var x = kv.Key;
                var v = kv.Value;
                var p = x + d;
                var q = Math.Max(x - d, 0);
                if (x >= C)
                {
                    if (q < C) next[q] = Math.Max(next[q], v + 1);
                }
                else
                {
                    if (p < C) next[p] = Math.Max(next[p], v);
                    else next[p] = Math.Max(next[p], v + 1);
                    next[q] = Math.Max(next[q], v);

                }
            }
            dp = next;
        }
        return dp.Max(x => x.Value);
    }
}
// CUT begin
public class Tester : AbstractTester
{
    public override void Test()
    {
        //test.ManualTest();
        base.Test();
    }
}
// CUT end
#region HashMap
class HashMap<K, V> : Dictionary<K, V>
//where V : new()
{
    public HashMap() : base() { }
    public HashMap(int cap) : base(cap) { }
    new public V this[K i]
    {
        get
        {
            V v;
            return TryGetValue(i, out v) ? v :
                base[i] = default(V);
            //base[i] = new V();
        }
        set { base[i] = value; }
    }
}
#endregion