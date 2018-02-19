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
    public void ManualTest(int[] capacities, int[] bottles, int[] fromId, int[] toId)
    {
        Console.WriteLine(string.Format("capacities:{0}", string.Join(" ",capacities)));
        Console.WriteLine(string.Format("bottles:{0}", string.Join(" ",bottles)));
        Console.WriteLine(string.Format("fromId:{0}", string.Join(" ",fromId)));
        Console.WriteLine(string.Format("toId:{0}", string.Join(" ",toId)));
        int[] __result = new KiwiJuiceEasy().thePouring(capacities, bottles, fromId, toId);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
    }

    [TestMethod]
    public void Example0()
    {
        int[] capacities = new int[] {
            20,
            20
        };
        Console.WriteLine(string.Format("capacities:{0}", string.Join(" ", capacities)));
        int[] bottles = new int[] {
            5,
            8
        };
        Console.WriteLine(string.Format("bottles:{0}", string.Join(" ", bottles)));
        int[] fromId = new int[] {
            0
        };
        Console.WriteLine(string.Format("fromId:{0}", string.Join(" ", fromId)));
        int[] toId = new int[] {
            1
        };
        Console.WriteLine(string.Format("toId:{0}", string.Join(" ", toId)));
        int[] __expected = new int[] {
            0,
            13
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new KiwiJuiceEasy().thePouring(capacities, bottles, fromId, toId);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example1()
    {
        int[] capacities = new int[] {
            10,
            10
        };
        Console.WriteLine(string.Format("capacities:{0}", string.Join(" ", capacities)));
        int[] bottles = new int[] {
            5,
            8
        };
        Console.WriteLine(string.Format("bottles:{0}", string.Join(" ", bottles)));
        int[] fromId = new int[] {
            0
        };
        Console.WriteLine(string.Format("fromId:{0}", string.Join(" ", fromId)));
        int[] toId = new int[] {
            1
        };
        Console.WriteLine(string.Format("toId:{0}", string.Join(" ", toId)));
        int[] __expected = new int[] {
            3,
            10
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new KiwiJuiceEasy().thePouring(capacities, bottles, fromId, toId);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example2()
    {
        int[] capacities = new int[] {
            30,
            20,
            10
        };
        Console.WriteLine(string.Format("capacities:{0}", string.Join(" ", capacities)));
        int[] bottles = new int[] {
            10,
            5,
            5
        };
        Console.WriteLine(string.Format("bottles:{0}", string.Join(" ", bottles)));
        int[] fromId = new int[] {
            0,
            1,
            2
        };
        Console.WriteLine(string.Format("fromId:{0}", string.Join(" ", fromId)));
        int[] toId = new int[] {
            1,
            2,
            0
        };
        Console.WriteLine(string.Format("toId:{0}", string.Join(" ", toId)));
        int[] __expected = new int[] {
            10,
            10,
            0
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new KiwiJuiceEasy().thePouring(capacities, bottles, fromId, toId);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example3()
    {
        int[] capacities = new int[] {
            14,
            35,
            86,
            58,
            25,
            62
        };
        Console.WriteLine(string.Format("capacities:{0}", string.Join(" ", capacities)));
        int[] bottles = new int[] {
            6,
            34,
            27,
            38,
            9,
            60
        };
        Console.WriteLine(string.Format("bottles:{0}", string.Join(" ", bottles)));
        int[] fromId = new int[] {
            1,
            2,
            4,
            5,
            3,
            3,
            1,
            0
        };
        Console.WriteLine(string.Format("fromId:{0}", string.Join(" ", fromId)));
        int[] toId = new int[] {
            0,
            1,
            2,
            4,
            2,
            5,
            3,
            1
        };
        Console.WriteLine(string.Format("toId:{0}", string.Join(" ", toId)));
        int[] __expected = new int[] {
            0,
            14,
            65,
            35,
            25,
            35
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new KiwiJuiceEasy().thePouring(capacities, bottles, fromId, toId);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example4()
    {
        int[] capacities = new int[] {
            700000,
            800000,
            900000,
            1000000
        };
        Console.WriteLine(string.Format("capacities:{0}", string.Join(" ", capacities)));
        int[] bottles = new int[] {
            478478,
            478478,
            478478,
            478478
        };
        Console.WriteLine(string.Format("bottles:{0}", string.Join(" ", bottles)));
        int[] fromId = new int[] {
            2,
            3,
            2,
            0,
            1
        };
        Console.WriteLine(string.Format("fromId:{0}", string.Join(" ", fromId)));
        int[] toId = new int[] {
            0,
            1,
            1,
            3,
            2
        };
        Console.WriteLine(string.Format("toId:{0}", string.Join(" ", toId)));
        int[] __expected = new int[] {
            0,
            156956,
            900000,
            856956
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new KiwiJuiceEasy().thePouring(capacities, bottles, fromId, toId);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

}
