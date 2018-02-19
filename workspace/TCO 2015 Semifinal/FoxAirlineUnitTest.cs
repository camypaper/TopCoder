using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int n, int[] a, int[] b, int[] c,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine("n:{0}", n);
        Console.WriteLine(string.Format("a:{0}", string.Join(" ",a)));
        Console.WriteLine(string.Format("b:{0}", string.Join(" ",b)));
        Console.WriteLine(string.Format("c:{0}", string.Join(" ",c)));
        }
        int __result = new FoxAirline().minimalCost(n, a, b, c);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int n = 3;
        Console.WriteLine("n:{0}", n);
        int[] a = new int[] {
            0,
            0,
            1,
            2,
            1,
            2
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            1,
            2,
            0,
            0,
            2,
            1
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int[] c = new int[] {
            1,
            1,
            1,
            1,
            10,
            10
        };
        Console.WriteLine(string.Format("c:{0}", string.Join(" ", c)));
        int __expected = 4;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new FoxAirline().minimalCost(n, a, b, c);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int n = 3;
        Console.WriteLine("n:{0}", n);
        int[] a = new int[] {
            0,
            1,
            0,
            1
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            1,
            0,
            2,
            2
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int[] c = new int[] {
            1,
            2,
            3,
            4
        };
        Console.WriteLine(string.Format("c:{0}", string.Join(" ", c)));
        int __expected = -1;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new FoxAirline().minimalCost(n, a, b, c);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int n = 4;
        Console.WriteLine("n:{0}", n);
        int[] a = new int[] {
            0,
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            1,
            2,
            3,
            0
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int[] c = new int[] {
            10,
            20,
            30,
            40
        };
        Console.WriteLine(string.Format("c:{0}", string.Join(" ", c)));
        int __expected = 100;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new FoxAirline().minimalCost(n, a, b, c);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        int n = 5;
        Console.WriteLine("n:{0}", n);
        int[] a = new int[] {
            0,
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            1,
            2,
            3,
            0
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int[] c = new int[] {
            10,
            20,
            30,
            40
        };
        Console.WriteLine(string.Format("c:{0}", string.Join(" ", c)));
        int __expected = -1;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new FoxAirline().minimalCost(n, a, b, c);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        int n = 12;
        Console.WriteLine("n:{0}", n);
        int[] a = new int[] {
            5,
            7,
            1,
            9,
            5,
            7,
            3,
            1,
            11,
            8,
            1,
            10,
            2,
            7,
            8,
            7,
            2,
            11,
            6,
            4,
            6,
            9,
            4,
            4,
            3,
            7,
            1,
            0,
            4,
            10,
            0,
            6,
            6,
            8,
            9,
            0,
            6,
            6,
            11,
            10,
            5,
            5,
            9,
            0,
            11,
            3,
            5,
            0,
            9,
            7,
            7,
            5,
            11,
            8,
            1,
            8,
            3,
            4,
            7,
            4,
            3,
            8,
            3,
            4,
            3,
            8,
            10,
            0,
            11,
            11,
            0,
            6,
            4,
            0,
            1,
            6,
            0,
            3,
            0,
            9,
            11,
            2,
            1,
            3,
            8,
            1,
            2,
            4,
            11,
            1,
            7,
            5,
            5,
            9,
            9,
            7,
            5,
            2,
            4,
            8,
            2,
            10,
            3,
            9,
            5,
            0,
            11,
            3,
            2,
            6,
            6,
            1,
            6,
            4,
            2,
            9,
            10,
            11,
            10,
            2,
            7,
            8,
            8,
            2,
            10,
            2,
            10,
            9,
            1,
            5,
            10,
            10
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
            0,
            3,
            2,
            3,
            3,
            11,
            0,
            4,
            1,
            0,
            9,
            3,
            1,
            8,
            5,
            9,
            5,
            2,
            11,
            1,
            1,
            2,
            7,
            9,
            4,
            2,
            0,
            10,
            0,
            0,
            7,
            2,
            9,
            4,
            4,
            9,
            7,
            8,
            8,
            8,
            9,
            2,
            11,
            11,
            10,
            10,
            4,
            6,
            5,
            10,
            6,
            10,
            0,
            2,
            3,
            10,
            1,
            3,
            0,
            2,
            2,
            6,
            5,
            11,
            6,
            3,
            5,
            8,
            6,
            3,
            2,
            4,
            10,
            5,
            5,
            5,
            4,
            9,
            3,
            8,
            7,
            4,
            7,
            11,
            7,
            10,
            11,
            8,
            4,
            8,
            4,
            11,
            8,
            7,
            10,
            5,
            6,
            7,
            5,
            1,
            9,
            2,
            8,
            0,
            1,
            1,
            5,
            7,
            0,
            3,
            0,
            11,
            10,
            6,
            8,
            6,
            1,
            9,
            9,
            6,
            1,
            9,
            11,
            3,
            6,
            10,
            7,
            1,
            6,
            7,
            11,
            4
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int[] c = new int[] {
            25984,
            89713,
            21689,
            14734,
            59359,
            53691,
            32670,
            17291,
            10665,
            7734,
            78780,
            41871,
            51780,
            29833,
            83512,
            65961,
            1102,
            19919,
            82940,
            78302,
            33977,
            93139,
            34297,
            40731,
            43477,
            27993,
            57723,
            12152,
            3980,
            70786,
            35521,
            70833,
            64827,
            59029,
            43895,
            90715,
            48944,
            83551,
            24446,
            16475,
            87602,
            93225,
            97981,
            94059,
            22358,
            99691,
            62932,
            90503,
            97309,
            87273,
            52990,
            70178,
            95405,
            60529,
            54542,
            18236,
            3626,
            390,
            7246,
            93273,
            91896,
            95133,
            94136,
            17526,
            40131,
            66971,
            3155,
            80877,
            27302,
            35933,
            20726,
            36474,
            60672,
            64932,
            97730,
            17345,
            80773,
            3805,
            33962,
            10994,
            41796,
            94727,
            81676,
            52518,
            36032,
            67199,
            99638,
            79108,
            39564,
            48423,
            20062,
            43372,
            78076,
            70519,
            6529,
            80526,
            64653,
            68090,
            49366,
            82926,
            96800,
            46972,
            3187,
            21071,
            40295,
            59157,
            98610,
            21594,
            64406,
            26409,
            54502,
            32364,
            42991,
            32988,
            31586,
            90087,
            48361,
            86876,
            32023,
            64035,
            36642,
            25221,
            35100,
            6541,
            61459,
            22219,
            93856,
            34767,
            87048,
            90635,
            29986,
            21603
        };
        Console.WriteLine(string.Format("c:{0}", string.Join(" ", c)));
        int __expected = 189591;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new FoxAirline().minimalCost(n, a, b, c);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example5(bool fast = false)
    {
        Console.WriteLine("Example5");
        int n = 1;
        Console.WriteLine("n:{0}", n);
        int[] a = new int[] {
        };
        Console.WriteLine(string.Format("a:{0}", string.Join(" ", a)));
        int[] b = new int[] {
        };
        Console.WriteLine(string.Format("b:{0}", string.Join(" ", b)));
        int[] c = new int[] {
        };
        Console.WriteLine(string.Format("c:{0}", string.Join(" ", c)));
        int __expected = 0;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new FoxAirline().minimalCost(n, a, b, c);
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
