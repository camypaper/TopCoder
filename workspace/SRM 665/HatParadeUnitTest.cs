using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);    }
    public void ManualTest(int[] value, int[] sum)
    {
        Console.WriteLine(string.Format("value:{0}", string.Join(" ",value)));
        Console.WriteLine(string.Format("sum:{0}", string.Join(" ",sum)));
        int __result = new HatParade().getPermutation(value, sum);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] value = new int[] {
            2,
            1,
            3
        };
        Console.WriteLine(string.Format("value:{0}", string.Join(" ", value)));
        int[] sum = new int[] {
            3,
            1,
            6
        };
        Console.WriteLine(string.Format("sum:{0}", string.Join(" ", sum)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new HatParade().getPermutation(value, sum);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] value = new int[] {
            1,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("value:{0}", string.Join(" ", value)));
        int[] sum = new int[] {
            9,
            1,
            2,
            3
        };
        Console.WriteLine(string.Format("sum:{0}", string.Join(" ", sum)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new HatParade().getPermutation(value, sum);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] value = new int[] {
            4,
            4,
            4,
            4
        };
        Console.WriteLine(string.Format("value:{0}", string.Join(" ", value)));
        int[] sum = new int[] {
            16,
            16,
            8,
            8
        };
        Console.WriteLine(string.Format("sum:{0}", string.Join(" ", sum)));
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new HatParade().getPermutation(value, sum);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] value = new int[] {
            1,
            2,
            3,
            4,
            5,
            6,
            7
        };
        Console.WriteLine(string.Format("value:{0}", string.Join(" ", value)));
        int[] sum = new int[] {
            1,
            27,
            6,
            22,
            18,
            21,
            7
        };
        Console.WriteLine(string.Format("sum:{0}", string.Join(" ", sum)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new HatParade().getPermutation(value, sum);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
