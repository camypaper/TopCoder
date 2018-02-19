using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int[] date, int[] rating,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine(string.Format("date:{0}", string.Join(" ",date)));
        Console.WriteLine(string.Format("rating:{0}", string.Join(" ",rating)));
        }
        double __result = new SimilarRatingGraph().maxLength(date, rating);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        int[] date = new int[] {
            1,
            2,
            4,
            8,
            16,
            32
        };
        Console.WriteLine(string.Format("date:{0}", string.Join(" ", date)));
        int[] rating = new int[] {
            1,
            2,
            4,
            8,
            16,
            32
        };
        Console.WriteLine(string.Format("rating:{0}", string.Join(" ", rating)));
        double __expected = 42.42640687119285;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new SimilarRatingGraph().maxLength(date, rating);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
}

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        int[] date = new int[] {
            81,
            104,
            120,
            124,
            134,
            137
        };
        Console.WriteLine(string.Format("date:{0}", string.Join(" ", date)));
        int[] rating = new int[] {
            1866,
            2332,
            2510,
            2678,
            2876,
            3002
        };
        Console.WriteLine(string.Format("rating:{0}", string.Join(" ", rating)));
        double __expected = 168.04761230080004;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new SimilarRatingGraph().maxLength(date, rating);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
}

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        int[] date = new int[] {
            10,
            11,
            13,
            15,
            19
        };
        Console.WriteLine(string.Format("date:{0}", string.Join(" ", date)));
        int[] rating = new int[] {
            10,
            14,
            15,
            23,
            25
        };
        Console.WriteLine(string.Format("rating:{0}", string.Join(" ", rating)));
        double __expected = 12.7183472062349;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new SimilarRatingGraph().maxLength(date, rating);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
}

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        int[] date = new int[] {
            1,
            2,
            3,
            4
        };
        Console.WriteLine(string.Format("date:{0}", string.Join(" ", date)));
        int[] rating = new int[] {
            1700,
            1800,
            1750,
            1850
        };
        Console.WriteLine(string.Format("rating:{0}", string.Join(" ", rating)));
        double __expected = 100.00499987500625;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new SimilarRatingGraph().maxLength(date, rating);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
}

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        int[] date = new int[] {
            1,
            2,
            3,
            4
        };
        Console.WriteLine(string.Format("date:{0}", string.Join(" ", date)));
        int[] rating = new int[] {
            1,
            4,
            9,
            16
        };
        Console.WriteLine(string.Format("rating:{0}", string.Join(" ", rating)));
        double __expected = 0.0;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new SimilarRatingGraph().maxLength(date, rating);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
}

    public bool Example5(bool fast = false)
    {
        Console.WriteLine("Example5");
        int[] date = new int[] {
            5,
            11,
            25,
            58,
            92,
            162,
            255,
            350,
            458,
            566,
            677,
            792,
            919,
            1051,
            1189,
            1331,
            1489,
            1673,
            1882,
            2093,
            2315,
            2541,
            2771,
            3012,
            3254,
            3524,
            3797,
            4087,
            4379,
            4675,
            4973,
            5278,
            5588,
            5904,
            6225,
            6550,
            6888,
            7249,
            7612,
            8018,
            8428,
            8847,
            9267,
            9688,
            10109,
            10530,
            10964,
            11407,
            11870,
            12340,
            12811,
            13288,
            13768,
            14249,
            14734,
            15242,
            15774,
            16306,
            16847,
            17400,
            17966,
            18533,
            19108,
            19692,
            20278,
            20871,
            21471,
            22074,
            22679,
            23297,
            23916,
            24553,
            25190,
            25829,
            26472,
            27135,
            27814,
            28497,
            29181,
            29865,
            30555,
            31272,
            31994,
            32729,
            33487,
            34246,
            35005,
            35764,
            36537,
            37326,
            38119,
            38913,
            39725,
            40538,
            41360,
            42185,
            43010,
            43840,
            44671,
            45509,
            46350,
            47205,
            48063,
            48932,
            49807,
            50691,
            51577,
            52464,
            53289,
            54119,
            54950,
            55788,
            56629,
            57484,
            58342,
            59211,
            60086,
            60970,
            61856,
            62743,
            63568,
            64398,
            65388
        };
        Console.WriteLine(string.Format("date:{0}", string.Join(" ", date)));
        int[] rating = new int[] {
            1505,
            1462,
            1436,
            1416,
            1463,
            1421,
            1411,
            1450,
            1497,
            1465,
            1423,
            1394,
            1391,
            1367,
            1358,
            1323,
            1310,
            1279,
            1268,
            1279,
            1311,
            1342,
            1359,
            1387,
            1414,
            1376,
            1424,
            1382,
            1373,
            1335,
            1359,
            1318,
            1275,
            1266,
            1227,
            1203,
            1168,
            1163,
            1184,
            1144,
            1169,
            1207,
            1250,
            1235,
            1209,
            1162,
            1124,
            1148,
            1168,
            1202,
            1190,
            1155,
            1179,
            1194,
            1195,
            1195,
            1203,
            1240,
            1218,
            1245,
            1220,
            1190,
            1208,
            1180,
            1182,
            1148,
            1139,
            1126,
            1152,
            1159,
            1147,
            1158,
            1112,
            1091,
            1101,
            1116,
            1123,
            1086,
            1126,
            1110,
            1128,
            1085,
            1132,
            1145,
            1135,
            1140,
            1117,
            1081,
            1120,
            1131,
            1081,
            1032,
            1071,
            1102,
            1071,
            1065,
            1068,
            1027,
            980,
            947,
            987,
            968,
            959,
            980,
            990,
            974,
            1003,
            996,
            999,
            958,
            911,
            878,
            918,
            899,
            890,
            911,
            921,
            905,
            934,
            927,
            930,
            889,
            844
        };
        Console.WriteLine(string.Format("rating:{0}", string.Join(" ", rating)));
        double __expected = 11940.179271014536;
        Console.WriteLine("Expected:{0}", __expected);
        double __result = new SimilarRatingGraph().maxLength(date, rating);
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
