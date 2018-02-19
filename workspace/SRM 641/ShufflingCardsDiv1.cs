using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class ShufflingCardsDiv1
{
    public int shuffle(int[] P)
    {
        var n = P.Length;
        for (int i = 0; i < n; i++)
            P[i]--;
        var cnt = 0;
        {
            var ok = true;
            for (int i = 0; i < n; i++)
                if (P[i] != i) ok = false;
            if (ok) return 0;
            for (int i = 0; i < n; i += 2)
                if (P[i] < n / 2) cnt++;
            if (cnt == n / 2) return 1;
        }
        //‹ô””Ô–Ú‚É‚¢‚«‚½‚¢0‚Ì”
        Debug.WriteLine(cnt);
        Debug.WriteLine("");
        n /= 2;
        //0,1,2,...,N/2, N/2+1,...2N‚ð
        //0,0,0,...,0,1,...1‚Æ‚·‚é
        //‚±‚ê‚©‚çP‚ðì‚è‚½‚¢


        //‘O”¼‚É0‚ª‰½–‡‚ ‚é‚©H
        var dp = Enumerate(n + 1, x => 1000000000);

        var q = new Queue<int>();
        q.Enqueue(n);
        dp[n] = 0;

        while (q.Any())
        {
            var a = q.Dequeue();
            Debug.WriteLine(a);
            var b = n - a;
            var min = Math.Max(0, a - (n - (n + 1) / 2)) + Math.Max(0, b - (n + 1) / 2);
            var max = Math.Min((n + 1) / 2, a) + Math.Min(b, n / 2);
            for (int j = min; j <= max; j++)
            {
                if (dp[j] > dp[a] + 1)
                {
                    dp[j] = dp[a] + 1;
                    q.Enqueue(j);
                }
            }
        }
        if (dp[cnt] >= 1000000000) return -1;

        return dp[cnt] + 1;
    }

    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
}
// CUT begin
public class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
    }
}
// CUT end
