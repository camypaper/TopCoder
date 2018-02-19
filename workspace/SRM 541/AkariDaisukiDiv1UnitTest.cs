using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(string Waai, string Akari, string Daisuki, string S, string F, int k,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine("Waai:{0}", Waai);
        Console.WriteLine("Akari:{0}", Akari);
        Console.WriteLine("Daisuki:{0}", Daisuki);
        Console.WriteLine("S:{0}", S);
        Console.WriteLine("F:{0}", F);
        Console.WriteLine("k:{0}", k);
        }
        int __result = new AkariDaisukiDiv1().countF(Waai, Akari, Daisuki, S, F, k);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        string Waai = "a";
        Console.WriteLine("Waai:{0}", Waai);
        string Akari = "b";
        Console.WriteLine("Akari:{0}", Akari);
        string Daisuki = "c";
        Console.WriteLine("Daisuki:{0}", Daisuki);
        string S = "x";
        Console.WriteLine("S:{0}", S);
        string F = "axb";
        Console.WriteLine("F:{0}", F);
        int k = 2;
        Console.WriteLine("k:{0}", k);
        int __expected = 2;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new AkariDaisukiDiv1().countF(Waai, Akari, Daisuki, S, F, k);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        string Waai = "a";
        Console.WriteLine("Waai:{0}", Waai);
        string Akari = "b";
        Console.WriteLine("Akari:{0}", Akari);
        string Daisuki = "c";
        Console.WriteLine("Daisuki:{0}", Daisuki);
        string S = "x";
        Console.WriteLine("S:{0}", S);
        string F = "abcdefghij";
        Console.WriteLine("F:{0}", F);
        int k = 1;
        Console.WriteLine("k:{0}", k);
        int __expected = 0;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new AkariDaisukiDiv1().countF(Waai, Akari, Daisuki, S, F, k);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        string Waai = "a";
        Console.WriteLine("Waai:{0}", Waai);
        string Akari = "a";
        Console.WriteLine("Akari:{0}", Akari);
        string Daisuki = "a";
        Console.WriteLine("Daisuki:{0}", Daisuki);
        string S = "b";
        Console.WriteLine("S:{0}", S);
        string F = "aba";
        Console.WriteLine("F:{0}", F);
        int k = 2;
        Console.WriteLine("k:{0}", k);
        int __expected = 4;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new AkariDaisukiDiv1().countF(Waai, Akari, Daisuki, S, F, k);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        string Waai = "a";
        Console.WriteLine("Waai:{0}", Waai);
        string Akari = "b";
        Console.WriteLine("Akari:{0}", Akari);
        string Daisuki = "c";
        Console.WriteLine("Daisuki:{0}", Daisuki);
        string S = "d";
        Console.WriteLine("S:{0}", S);
        string F = "baadbdcbadbdccccbaaaadbdcbadbdccbaadbdcba";
        Console.WriteLine("F:{0}", F);
        int k = 58;
        Console.WriteLine("k:{0}", k);
        int __expected = 191690599;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new AkariDaisukiDiv1().countF(Waai, Akari, Daisuki, S, F, k);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        string Waai = "a";
        Console.WriteLine("Waai:{0}", Waai);
        string Akari = "x";
        Console.WriteLine("Akari:{0}", Akari);
        string Daisuki = "y";
        Console.WriteLine("Daisuki:{0}", Daisuki);
        string S = "b";
        Console.WriteLine("S:{0}", S);
        string F = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab";
        Console.WriteLine("F:{0}", F);
        int k = 49;
        Console.WriteLine("k:{0}", k);
        int __expected = 1;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new AkariDaisukiDiv1().countF(Waai, Akari, Daisuki, S, F, k);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example5(bool fast = false)
    {
        Console.WriteLine("Example5");
        string Waai = "waai";
        Console.WriteLine("Waai:{0}", Waai);
        string Akari = "akari";
        Console.WriteLine("Akari:{0}", Akari);
        string Daisuki = "daisuki";
        Console.WriteLine("Daisuki:{0}", Daisuki);
        string S = "usushio";
        Console.WriteLine("S:{0}", S);
        string F = "id";
        Console.WriteLine("F:{0}", F);
        int k = 10000000;
        Console.WriteLine("k:{0}", k);
        int __expected = 127859200;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new AkariDaisukiDiv1().countF(Waai, Akari, Daisuki, S, F, k);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example6(bool fast = false)
    {
        Console.WriteLine("Example6");
        string Waai = "vfsebgjfyfgerkqlr";
        Console.WriteLine("Waai:{0}", Waai);
        string Akari = "ezbiwls";
        Console.WriteLine("Akari:{0}", Akari);
        string Daisuki = "kjerx";
        Console.WriteLine("Daisuki:{0}", Daisuki);
        string S = "jbmjvaawoxycfndukrjfg";
        Console.WriteLine("S:{0}", S);
        string F = "bgjfyfgerkqlrvfsebgjfyfgerkqlrvfsebgjfyfgerkqlrvfs";
        Console.WriteLine("F:{0}", F);
        int k = 1575724;
        Console.WriteLine("k:{0}", k);
        int __expected = 483599313;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new AkariDaisukiDiv1().countF(Waai, Akari, Daisuki, S, F, k);
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
