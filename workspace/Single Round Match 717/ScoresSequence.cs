using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class ScoresSequence
{
    public int count(int[] s)
    {
        var otaku = Naive_Test(s.ToArray());
        Array.Sort(s);
        Array.Reverse(s);
        var ans = 0;
        while (s.Length > 0)
        {
            var sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                sum += s[i];
                var cnt = i + 1;
                var rem = s.Length - i - 1;
                if (sum - cnt * rem == cnt * (cnt - 1) / 2)
                {
                    ans += cnt * cnt;
                    ans += cnt * rem;
                    s = s.Skip(i + 1).ToArray();
                    break;
                }
            }
        }
        if (otaku != ans)
        {

        }
        return ans;
    }

    // CUT begin
    public int Naive_Test(int[] s)
    {
        Array.Sort(s);
        var n = s.Length;
        var ans = n * (n - 1) / 2 + n;
        for (int i = 0; i < n; i++)
            s[i] -= i; 
        for (int i = 0; i < n; i++)
            if (i - 1 >= 0) s[i] += s[i - 1];
        for (int i = 0; i < n; i++)
        {
            if (s[i] == 0) continue;
            var j = i;
            while (j < n && s[j] > 0) { s[j] = 0; j++; }
            var ln = j - i + 1;
            ans += ln * (ln - 1) / 2;
        }
        Debug.WriteLine(ans);
        return ans;
    }
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }

    // CUT end
}
// CUT begin
public partial class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public override void Run()
    {
        Test(Example0);
        Test(Example1);
        Test(Example2);
        Test(Example3);
        Test(Example4);
        var n = 100;
        var a = new int[n];
        for (int i = 0; i < n; i++)
            for (int j = i + 1; j < n; j++)
            {
                if (j == n - 1 || rand.Next() % 2 == 0) a[i]++;
                else a[j]++;
            }
        var s = string.Join(",", a);
        ManualTest(a, false);
            a = new int[100];
        for (int i = 0; i < n; i++)
            for (int j = i + 1; j < n; j++)
            {
                if (rand.Next() % 8 != 0) a[i]++;
                else a[j]++;
            }
        s = string.Join(",", a);
        ManualTest(a, false);
        //Tests.Add(null);


    }
}
// CUT end
