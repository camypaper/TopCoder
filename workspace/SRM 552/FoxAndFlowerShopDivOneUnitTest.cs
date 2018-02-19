using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(string[] flowers, int maxDiff,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine(string.Format("flowers:{0}", string.Join(" ",flowers)));
        Console.WriteLine("maxDiff:{0}", maxDiff);
        }
        int __result = new FoxAndFlowerShopDivOne().theMaxFlowers(flowers, maxDiff);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        string[] flowers = new string[] {
            "LLL",
            "PPP",
            "LLL"
        };
        Console.WriteLine(string.Format("flowers:{0}", string.Join(" ", flowers)));
        int maxDiff = 1;
        Console.WriteLine("maxDiff:{0}", maxDiff);
        int __expected = 7;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new FoxAndFlowerShopDivOne().theMaxFlowers(flowers, maxDiff);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        string[] flowers = new string[] {
            "LLL",
            "PPP",
            "LLL"
        };
        Console.WriteLine(string.Format("flowers:{0}", string.Join(" ", flowers)));
        int maxDiff = 0;
        Console.WriteLine("maxDiff:{0}", maxDiff);
        int __expected = 6;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new FoxAndFlowerShopDivOne().theMaxFlowers(flowers, maxDiff);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        string[] flowers = new string[] {
            "...",
            "...",
            "..."
        };
        Console.WriteLine(string.Format("flowers:{0}", string.Join(" ", flowers)));
        int maxDiff = 3;
        Console.WriteLine("maxDiff:{0}", maxDiff);
        int __expected = 0;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new FoxAndFlowerShopDivOne().theMaxFlowers(flowers, maxDiff);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        string[] flowers = new string[] {
            "LLPL.LPP",
            "PLPPPPLL",
            "L.P.PLLL",
            "LPL.PP.L",
            ".LLL.P.L",
            "PPLP..PL"
        };
        Console.WriteLine(string.Format("flowers:{0}", string.Join(" ", flowers)));
        int maxDiff = 2;
        Console.WriteLine("maxDiff:{0}", maxDiff);
        int __expected = 38;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new FoxAndFlowerShopDivOne().theMaxFlowers(flowers, maxDiff);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        string[] flowers = new string[] {
            "LLLLLLLLLL",
            "LLLLLLLLLL",
            "LLLLLLLLLL",
            "LLLLLLLLLL",
            "LLLLLLLLLL"
        };
        Console.WriteLine(string.Format("flowers:{0}", string.Join(" ", flowers)));
        int maxDiff = 0;
        Console.WriteLine("maxDiff:{0}", maxDiff);
        int __expected = -1;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new FoxAndFlowerShopDivOne().theMaxFlowers(flowers, maxDiff);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example5(bool fast = false)
    {
        Console.WriteLine("Example5");
        string[] flowers = new string[] {
            "LLLP..LLP.PLL.LL..LP",
            "L.PL.L.LLLL.LPLLPLP.",
            "PLL.LL.LLL..PL...L..",
            ".LPPP.PPPLLLLPLP..PP",
            "LP.P.PPL.L...P.L.LLL",
            "L..LPLPP.PP...PPPL..",
            "PP.PLLL.LL...LP..LP.",
            "PL...P.PPPL..PLP.L..",
            "P.PPPLPLP.LL.L.LLLPL",
            "PLLPLLP.LLL.P..P.LPL",
            "..LLLPLPPPLP.P.LP.LL",
            "..LP..L..LLPPP.LL.LP",
            "LPLL.PLLPPLP...LL..P",
            "LL.....PLL.PLL.P....",
            "LLL...LPPPPL.PL...PP",
            ".PLPLLLLP.LPP...L...",
            "LL...L.LL.LLLPLPPPP.",
            "PLPLLLL..LP.LLPLLLL.",
            "PP.PLL..L..LLLPPL..P",
            ".LLPL.P.PP.P.L.PLPLL"
        };
        Console.WriteLine(string.Format("flowers:{0}", string.Join(" ", flowers)));
        int maxDiff = 9;
        Console.WriteLine("maxDiff:{0}", maxDiff);
        int __expected = 208;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new FoxAndFlowerShopDivOne().theMaxFlowers(flowers, maxDiff);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    bool check(double ex, double res)
    {
        var d = Math.Abs(res - ex);
        if (d <= 1e-9) return true;
        d /= Math.Abs(ex);
        if (d <= 1e-9) return true;
        return false;
    }
    bool check(double[] ex, double[] res)
    {
        if (ex.Length != res.Length) return false;
        for (int i = 0; i < ex.Length; i++)
            if (!check(ex[i], res[i])) return false;
        return true;
    }
    bool check<T>(T ex, T res)
        where T : IComparable<T>
    {
        return ex.CompareTo(res) == 0;
    }
    bool check<T>(T[] ex, T[] res)
        where T : IComparable<T>
    {
        if (ex.Length != res.Length) return false;
        for (int i = 0; i < ex.Length; i++)
            if (!check(ex[i], res[i])) return false;
        return true;
    }
}
