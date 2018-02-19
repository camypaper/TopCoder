using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
using Number = System.Int64;
public class ModuloFourDivisor
{
    public int countQuadruplets(long[] A, long[] B, long[] C, long[] D)
    {
        int ans = 0;
        foreach (var a in A)
            foreach (var b in B)
                foreach (var c in C)
                    foreach (var d in D)
                    {
                        if (b == 0) continue;

                        {
                            var x = b + d;
                            if (x != 0 && c % x != 0) continue;
                            if (c == 0)
                            {
                                if (a != 0) continue;
                            }
                            else if (c == x)
                            {
                                if (a % c != 0) continue;
                            }
                            else continue;
                        }

                        {
                            var gcd = BigInteger.GreatestCommonDivisor(b, d);
                            var x = b / gcd;
                            var y = d / gcd;
                            if (x - y == 0 || x - y == 1)
                            {
                                //Debug.WriteLine("{0} {1} {2} {3}", a, b, c, d);
                                ans++;
                            }
                        }
                    }
        return ans;
    }

    // CUT begin
    public int Naive_Test(long[] A, long[] B, long[] C, long[] D)
    {
        return 0;
    }

    // CUT end
}
// CUT begin
public partial class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public void OnInit()
    {
        var a = Enumerate(50, x => (long)x);
        Tests.Add(() => ManualTest(a, a, a, a));
        //Tests.Add(null);
    }
}
// CUT end
