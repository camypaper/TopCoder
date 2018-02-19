using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int N, int K, int m, int c0, int[] c1, int[] c2, int[] c3, int[] c4, string s,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine("K:{0}", K);
        Console.WriteLine("m:{0}", m);
        Console.WriteLine("c0:{0}", c0);
        Console.WriteLine(string.Format("c1:{0}", string.Join(" ",c1)));
        Console.WriteLine(string.Format("c2:{0}", string.Join(" ",c2)));
        Console.WriteLine(string.Format("c3:{0}", string.Join(" ",c3)));
        Console.WriteLine(string.Format("c4:{0}", string.Join(" ",c4)));
        Console.WriteLine("s:{0}", s);
        }
        int __result = new TreasureOfWinedag().solvePuzzle(N, K, m, c0, c1, c2, c3, c4, s);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int N = 4;
        Console.WriteLine("N:{0}", N);
        int K = 2;
        Console.WriteLine("K:{0}", K);
        int m = 1;
        Console.WriteLine("m:{0}", m);
        int c0 = 0;
        Console.WriteLine("c0:{0}", c0);
        int[] c1 = new int[] {
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("c1:{0}", string.Join(" ", c1)));
        int[] c2 = new int[] {
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("c2:{0}", string.Join(" ", c2)));
        int[] c3 = new int[] {
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("c3:{0}", string.Join(" ", c3)));
        int[] c4 = new int[] {
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("c4:{0}", string.Join(" ", c4)));
        string s = "aabb";
        Console.WriteLine("s:{0}", s);
        int __expected = 2;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new TreasureOfWinedag().solvePuzzle(N, K, m, c0, c1, c2, c3, c4, s);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int N = 12;
        Console.WriteLine("N:{0}", N);
        int K = 3;
        Console.WriteLine("K:{0}", K);
        int m = 1;
        Console.WriteLine("m:{0}", m);
        int c0 = 0;
        Console.WriteLine("c0:{0}", c0);
        int[] c1 = new int[] {
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("c1:{0}", string.Join(" ", c1)));
        int[] c2 = new int[] {
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("c2:{0}", string.Join(" ", c2)));
        int[] c3 = new int[] {
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("c3:{0}", string.Join(" ", c3)));
        int[] c4 = new int[] {
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("c4:{0}", string.Join(" ", c4)));
        string s = "abaacdddfeff";
        Console.WriteLine("s:{0}", s);
        int __expected = 6;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new TreasureOfWinedag().solvePuzzle(N, K, m, c0, c1, c2, c3, c4, s);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int N = 10;
        Console.WriteLine("N:{0}", N);
        int K = 4;
        Console.WriteLine("K:{0}", K);
        int m = 10;
        Console.WriteLine("m:{0}", m);
        int c0 = 7;
        Console.WriteLine("c0:{0}", c0);
        int[] c1 = new int[] {
            4,
            4,
            4,
            4,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("c1:{0}", string.Join(" ", c1)));
        int[] c2 = new int[] {
            0,
            1,
            2,
            3,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("c2:{0}", string.Join(" ", c2)));
        int[] c3 = new int[] {
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("c3:{0}", string.Join(" ", c3)));
        int[] c4 = new int[] {
            9,
            9,
            9,
            9,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("c4:{0}", string.Join(" ", c4)));
        string s = "";
        Console.WriteLine("s:{0}", s);
        int __expected = 6;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new TreasureOfWinedag().solvePuzzle(N, K, m, c0, c1, c2, c3, c4, s);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        int N = 100000;
        Console.WriteLine("N:{0}", N);
        int K = 2;
        Console.WriteLine("K:{0}", K);
        int m = 100000;
        Console.WriteLine("m:{0}", m);
        int c0 = 1;
        Console.WriteLine("c0:{0}", c0);
        int[] c1 = new int[] {
            2,
            2,
            2,
            2,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("c1:{0}", string.Join(" ", c1)));
        int[] c2 = new int[] {
            0,
            1,
            0,
            1,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("c2:{0}", string.Join(" ", c2)));
        int[] c3 = new int[] {
            0,
            0,
            50000,
            50000,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("c3:{0}", string.Join(" ", c3)));
        int[] c4 = new int[] {
            49999,
            49999,
            99999,
            99999,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("c4:{0}", string.Join(" ", c4)));
        string s = "";
        Console.WriteLine("s:{0}", s);
        int __expected = 4;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new TreasureOfWinedag().solvePuzzle(N, K, m, c0, c1, c2, c3, c4, s);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        int N = 100000;
        Console.WriteLine("N:{0}", N);
        int K = 99980;
        Console.WriteLine("K:{0}", K);
        int m = 987654;
        Console.WriteLine("m:{0}", m);
        int c0 = 654321;
        Console.WriteLine("c0:{0}", c0);
        int[] c1 = new int[] {
            26,
            26,
            26,
            26,
            26,
            26,
            26,
            26,
            26,
            26,
            26,
            26,
            26,
            26,
            26,
            26,
            26,
            26,
            26,
            26,
            26,
            26,
            26,
            26,
            26
        };
        Console.WriteLine(string.Format("c1:{0}", string.Join(" ", c1)));
        int[] c2 = new int[] {
            0,
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10,
            11,
            12,
            13,
            14,
            15,
            16,
            17,
            18,
            19,
            20,
            21,
            22,
            23,
            24
        };
        Console.WriteLine(string.Format("c2:{0}", string.Join(" ", c2)));
        int[] c3 = new int[] {
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("c3:{0}", string.Join(" ", c3)));
        int[] c4 = new int[] {
            987653,
            987653,
            987653,
            987653,
            987653,
            987653,
            987653,
            987653,
            987653,
            987653,
            987653,
            987653,
            987653,
            987653,
            987653,
            987653,
            987653,
            987653,
            987653,
            987653,
            987653,
            987653,
            987653,
            987653,
            987653
        };
        Console.WriteLine(string.Format("c4:{0}", string.Join(" ", c4)));
        string s = "topcoderopen";
        Console.WriteLine("s:{0}", s);
        int __expected = 99990;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new TreasureOfWinedag().solvePuzzle(N, K, m, c0, c1, c2, c3, c4, s);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example5(bool fast = false)
    {
        Console.WriteLine("Example5");
        int N = 1;
        Console.WriteLine("N:{0}", N);
        int K = 1;
        Console.WriteLine("K:{0}", K);
        int m = 424507751;
        Console.WriteLine("m:{0}", m);
        int c0 = 79193201;
        Console.WriteLine("c0:{0}", c0);
        int[] c1 = new int[] {
            93991416,
            122377683,
            100930010,
            373124588,
            366757111,
            314344105,
            335481602,
            25553224,
            271158873,
            131361019,
            331824611,
            152948279,
            126679689,
            84708668,
            6797210,
            361729904,
            145699274,
            79606375,
            264167932,
            413280894,
            15762918,
            207584964,
            154302042,
            70002530,
            194642143
        };
        Console.WriteLine(string.Format("c1:{0}", string.Join(" ", c1)));
        int[] c2 = new int[] {
            83184146,
            70533279,
            73860028,
            211278755,
            121940531,
            286864621,
            251852612,
            18877531,
            173979121,
            104440673,
            50907689,
            29428358,
            82351994,
            20366667,
            1415145,
            165813027,
            100425184,
            11939160,
            31133943,
            157023871,
            6513169,
            86669984,
            104254852,
            21419693,
            61982959
        };
        Console.WriteLine(string.Format("c2:{0}", string.Join(" ", c2)));
        int[] c3 = new int[] {
            133139882,
            123741581,
            58820135,
            40395052,
            204057998,
            220052469,
            47757992,
            135477098,
            81874422,
            38543527,
            64336686,
            54070556,
            85767758,
            394101179,
            47318637,
            141026976,
            283673073,
            227348343,
            405835722,
            203692488,
            261118934,
            76467402,
            110499099,
            179937390,
            62000638
        };
        Console.WriteLine(string.Format("c3:{0}", string.Join(" ", c3)));
        int[] c4 = new int[] {
            171061341,
            420093260,
            115970860,
            246835989,
            273845074,
            423933877,
            264762986,
            225084596,
            374349399,
            242851788,
            292230379,
            173105221,
            112972969,
            417034170,
            279113506,
            255955057,
            297052869,
            264177905,
            408974790,
            348069397,
            408363094,
            224880992,
            416173264,
            296181015,
            351748226
        };
        Console.WriteLine(string.Format("c4:{0}", string.Join(" ", c4)));
        string s = "c";
        Console.WriteLine("s:{0}", s);
        int __expected = 1;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new TreasureOfWinedag().solvePuzzle(N, K, m, c0, c1, c2, c3, c4, s);
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
