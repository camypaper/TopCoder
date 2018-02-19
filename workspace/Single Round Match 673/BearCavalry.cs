using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using Number = System.Int32;
public class BearCavalry
{
    int[] a;
    public const long Mod = (long)1e9 + 7;
    public int countAssignments(int[] warriors, int[] horses)
    {
        a = warriors.Skip(1).ToArray();
        Array.Sort(a);
        Array.Sort(horses);
        var n = horses.Length;
        long ans = 0;
        for (int i = 0; i < n; i++)
        {
            var b = new List<int>();
            for (int j = 0; j < n; j++)
            {
                if (i == j) continue;
                b.Add(horses[j]);
            }
            ans = (ans + f(warriors[0] * horses[i], b.ToArray())) % Mod;
        }
        return (int)ans;
    }
    public long f(int max, int[] b)
    {
        long ans = 1;
        var k = 0;
        for (int i = a.Length - 1; i >= 0; i--)
        {
            var v = a[i];
            var cnt = 0;
            for (int j = 0; j < b.Length; j++)
            {
                if (a[i] * b[j] < max)
                {
                    cnt++; continue;
                }
                break;
            }
            if (cnt <= k) return 0;
            ans = (ans * (cnt - k)) % Mod;
            k++;
        }
        return ans;
    }
}

// CUT begin
public class Tester : AbstractTester
{
    public override void Test()
    {
        var random = new Random(0);
        var a = Enumerable.Range(1, 50).Select(x => random.Next(1, 1000));
        var b = Enumerable.Range(1, 50).Select(x => random.Next(1, 1000));
        var s = string.Join(",", a);
        var t = string.Join(",", b);
        test.ManualTest(a.ToArray(), b.ToArray());
        base.Test();
    }
}
// CUT end

