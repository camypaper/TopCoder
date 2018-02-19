using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);Tests.Add(Example4);    }
    public void ManualTest(int M, int[] count, int[] first, int[] mult, int[] add)
    {
        Console.WriteLine("M:{0}", M);
        Console.WriteLine(string.Format("count:{0}", string.Join(" ",count)));
        Console.WriteLine(string.Format("first:{0}", string.Join(" ",first)));
        Console.WriteLine(string.Format("mult:{0}", string.Join(" ",mult)));
        Console.WriteLine(string.Format("add:{0}", string.Join(" ",add)));
        int __result = new EllysPairing().getMax(M, count, first, mult, add);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int M = 16;
        Console.WriteLine("M:{0}", M);
        int[] count = new int[] {
            4,
            7
        };
        Console.WriteLine(string.Format("count:{0}", string.Join(" ", count)));
        int[] first = new int[] {
            5,
            3
        };
        Console.WriteLine(string.Format("first:{0}", string.Join(" ", first)));
        int[] mult = new int[] {
            2,
            3
        };
        Console.WriteLine(string.Format("mult:{0}", string.Join(" ", mult)));
        int[] add = new int[] {
            1,
            0
        };
        Console.WriteLine(string.Format("add:{0}", string.Join(" ", add)));
        int __expected = 5;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new EllysPairing().getMax(M, count, first, mult, add);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int M = 8;
        Console.WriteLine("M:{0}", M);
        int[] count = new int[] {
            6,
            4,
            3
        };
        Console.WriteLine(string.Format("count:{0}", string.Join(" ", count)));
        int[] first = new int[] {
            0,
            3,
            2
        };
        Console.WriteLine(string.Format("first:{0}", string.Join(" ", first)));
        int[] mult = new int[] {
            3,
            7,
            5
        };
        Console.WriteLine(string.Format("mult:{0}", string.Join(" ", mult)));
        int[] add = new int[] {
            0,
            3,
            2
        };
        Console.WriteLine(string.Format("add:{0}", string.Join(" ", add)));
        int __expected = 5;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new EllysPairing().getMax(M, count, first, mult, add);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int M = 128;
        Console.WriteLine("M:{0}", M);
        int[] count = new int[] {
            42,
            13,
            666,
            17,
            1337,
            42,
            1
        };
        Console.WriteLine(string.Format("count:{0}", string.Join(" ", count)));
        int[] first = new int[] {
            18,
            76,
            3,
            122,
            0,
            11,
            11
        };
        Console.WriteLine(string.Format("first:{0}", string.Join(" ", first)));
        int[] mult = new int[] {
            33,
            17,
            54,
            90,
            41,
            122,
            20
        };
        Console.WriteLine(string.Format("mult:{0}", string.Join(" ", mult)));
        int[] add = new int[] {
            66,
            15,
            10,
            121,
            122,
            1,
            30
        };
        Console.WriteLine(string.Format("add:{0}", string.Join(" ", add)));
        int __expected = 1059;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new EllysPairing().getMax(M, count, first, mult, add);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int M = 1048576;
        Console.WriteLine("M:{0}", M);
        int[] count = new int[] {
            4242,
            42,
            9872,
            13,
            666,
            21983,
            17,
            1337,
            42,
            1
        };
        Console.WriteLine(string.Format("count:{0}", string.Join(" ", count)));
        int[] first = new int[] {
            19,
            18,
            76,
            42,
            3,
            112,
            0,
            11,
            11,
            12
        };
        Console.WriteLine(string.Format("first:{0}", string.Join(" ", first)));
        int[] mult = new int[] {
            27,
            33,
            10,
            8,
            17,
            9362,
            90,
            41,
            122,
            20
        };
        Console.WriteLine(string.Format("mult:{0}", string.Join(" ", mult)));
        int[] add = new int[] {
            98,
            101,
            66,
            15,
            10,
            144,
            3,
            1,
            5,
            1
        };
        Console.WriteLine(string.Format("add:{0}", string.Join(" ", add)));
        int __expected = 16232;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new EllysPairing().getMax(M, count, first, mult, add);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int M = 1073741824;
        Console.WriteLine("M:{0}", M);
        int[] count = new int[] {
            894602,
            946569,
            887230,
            856152,
            962583,
            949356,
            904847,
            829100,
            842183,
            958440,
            811081,
            864078,
            809209,
            938727,
            949135,
            892809,
            816528,
            961237,
            979142,
            890922
        };
        Console.WriteLine(string.Format("count:{0}", string.Join(" ", count)));
        int[] first = new int[] {
            844085078,
            898937259,
            243490172,
            887804102,
            187696417,
            156820442,
            237600210,
            618812924,
            153000239,
            912364033,
            254936966,
            650298774,
            982988140,
            649258331,
            566444626,
            201481721,
            492943390,
            1061953081,
            492672963,
            960519711
        };
        Console.WriteLine(string.Format("first:{0}", string.Join(" ", first)));
        int[] mult = new int[] {
            1036482037,
            583219072,
            819168094,
            253755052,
            548208982,
            401830167,
            638626082,
            43642932,
            123607749,
            485521178,
            860368129,
            30334704,
            219771462,
            733375600,
            130839219,
            415503960,
            294132484,
            1044831462,
            256910484,
            198852170
        };
        Console.WriteLine(string.Format("mult:{0}", string.Join(" ", mult)));
        int[] add = new int[] {
            889169006,
            604831366,
            967292994,
            980686280,
            844875791,
            1027687492,
            357734882,
            295879743,
            48284748,
            421729100,
            1049536313,
            327207332,
            948053446,
            271229570,
            664579359,
            795815285,
            842856528,
            876662975,
            675611938,
            634229925
        };
        Console.WriteLine(string.Format("add:{0}", string.Join(" ", add)));
        int __expected = 8971965;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new EllysPairing().getMax(M, count, first, mult, add);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
