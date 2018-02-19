using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using StringBuilder = System.Text.StringBuilder;
public class ProductOfDigits
{
    public int smallestNumber(int N)
    {
        if (N == 1)
            return 1;
        var map = new HashMap<int, int>();
        for (int i = 2; i <= 7; i++)
        {
            while (N % i == 0)
            {
                N /= i;
                map[i]++;
            }

        }
        if (N > 1)
            return -1;
        var k = map[5] + map[7];
        var two = map[2];
        var three = map[3];
        var dp = new int[60, 60];
        for (int i = 0; i < 60; i++)
            for (int j = 0; j < 60; j++)
                dp[i, j] = int.MaxValue;
        dp[0, 0] = 0;
        for (int i = 0; i < 50; i++)
            for (int j = 0; j < 50; j++)
            {
                dp[i + 1, j] = Math.Min(dp[i, j] + 1, dp[i + 1, j]);
                dp[i + 2, j] = Math.Min(dp[i, j] + 1, dp[i + 2, j]);
                dp[i + 3, j] = Math.Min(dp[i, j] + 1, dp[i + 3, j]);
                dp[i, j + 1] = Math.Min(dp[i, j] + 1, dp[i, j + 1]);
                dp[i + 1, j + 1] = Math.Min(dp[i, j] + 1, dp[i + 1, j + 1]);
                dp[i, j + 2] = Math.Min(dp[i, j] + 1, dp[i, j + 2]);
            }
        return k + dp[two, three];
    }
}
#region HashMap
class HashMap<K, V> : Dictionary<K, V>
{
    new public V this[K i]
    {
        get
        {
            V v;
            return TryGetValue(i, out v) ? v : base[i] = default(V);
        }
        set { base[i] = value; }
    }
}
#endregion