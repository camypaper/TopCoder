using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using StringBuilder = System.Text.StringBuilder;
public class ThePermutationGame
{
    public int findMin(int N)
    {
        var primes = SieveList(N);
        long ans = 1;
        const long mod=(long)1e9+7;
        foreach(var p in primes)
        {
            long v = p;
            while (v * p <= N) v *= p;
            ans = ans * v % mod;
        }
        return (int)ans;
    }
    static public List<int> SieveList(int p)
    {
        var isPrime = new bool[p + 1];
        for (int i = 2; i <= p; i++)
            isPrime[i] = true;
        for (int i = 2; i * i <= p; i++)
        {
            if (!isPrime[i])
                continue;
            for (int j = i * i; j <= p; j += i)
                isPrime[j] = false;
        }
        var ret = new List<int>();
        for (int i = 0; i <= p; i++) if (isPrime[i]) ret.Add(i);
        return ret;
    }
}
