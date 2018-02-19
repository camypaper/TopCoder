using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using StringBuilder = System.Text.StringBuilder;
public class ThePermutationGameDiv2
{
    public long findMin(int N)
    {
        long ans = 1;
        for (int i = 1; i <= N; i++)
        {
            ans = MathEx.LCM(ans, i);
        }
        return ans;
    }

}
#region gcd,lcm
static public partial class MathEx
{

    static public long GCD(long x, long y)
    {
        byte i = 0;
        while (x != 0 && y != 0)
        {
            if (i == 0)
                y %= x;
            else x %= y;
            i ^= 1;
        }
        return x == 0 ? y : x;
    }
    static public long LCM(long x, long y)
    {
        return x * y / GCD(x, y);
    }

}
#endregion
