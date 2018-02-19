using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class OrderOfOperations
{
    public int minTime(string[] s)
    {
        var n = s[0].Length;
        var cnt = Enumerate(25, x => new List<char[]>());
        foreach (var x in s)
        {
            var t = x.ToCharArray();
            var c = x.Count(y => y == '1');
            cnt[c].Add(t);
        }
        var ans = 0;
        for (int _ = 0; _ < s.Length; _++)
        {
            var next = Enumerate(25, x => new List<char[]>());

            for (int i = 0; i < 25; i++)
            {
                if (cnt[i].Count == 0) continue;
                var t = cnt[i][0];
                Debug.WriteLine(new string(t));
                ans += i * i;
                cnt[i].RemoveAt(0);
                for (int j = i; j < 25; j++)
                {
                    foreach (var x in cnt[j])
                    {
                        var to = j;
                        var add = x;
                        for (int k = 0; k < n; k++)
                        {
                            if (t[k] == '1' && add[k] == '1')
                            {
                                add[k] = '0';
                                to--;
                            }
                        }
                        next[to].Add(add);
                    }
                }
                break;
            }
            cnt = next;

        }
        return ans;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
}
// CUT begin
public class Tester : AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public override void Test()
    {
        var rand = new Random();
        var sss = new string[50];
        for (int i = 0; i < 50; i++)
        {
            var a = Enumerate(20, x => rand.Next() % 2);
            sss[i] = string.Join("", a);
        }
        var ss = string.Join(",", sss);
        var s = "10101010101010101010,01010101010101010101,00100100100100100100,01001001001001001001,10010010010010010010,10110110110110110110,11011011011011011010,01101101101101101101,11101110111011101110,11011101110111011101,10111011101110111011,01110111011101110111".Split(',');
        test.ManualTest(sss);
        base.Test();
    }
}
// CUT end