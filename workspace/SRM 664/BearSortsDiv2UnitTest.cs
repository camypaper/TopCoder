using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);    }
    public void ManualTest(int[] seq)
    {
        Console.WriteLine(string.Format("seq:{0}", string.Join(" ",seq)));
        double __result = new BearSortsDiv2().getProbability(seq);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] seq = new int[] {
            1,
            2
        };
        Console.WriteLine(string.Format("seq:{0}", string.Join(" ", seq)));
        double __expected = -0.6931471805599453;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new BearSortsDiv2().getProbability(seq);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example1()
    {
        int[] seq = new int[] {
            1,
            3,
            2
        };
        Console.WriteLine(string.Format("seq:{0}", string.Join(" ", seq)));
        double __expected = -1.3862943611198906;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new BearSortsDiv2().getProbability(seq);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

    [TestMethod]
    public void Example2()
    {
        int[] seq = new int[] {
            10,
            13,
            18,
            2,
            4,
            6,
            24,
            22,
            19,
            5,
            7,
            20,
            23,
            14,
            21,
            17,
            25,
            3,
            1,
            11,
            12,
            8,
            15,
            16,
            9
        };
        Console.WriteLine(string.Format("seq:{0}", string.Join(" ", seq)));
        double __expected = -57.53121598647546;
        Console.WriteLine("__expected:{0}", __expected);
        double __result = new BearSortsDiv2().getProbability(seq);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result, 1e-9);
}

}
