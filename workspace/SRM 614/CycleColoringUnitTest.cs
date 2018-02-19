using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);Tests.Add(Example4);Tests.Add(Example5);    }
    public void ManualTest(int[] vertexCount, int[] fromVertex, int[] toVertex, int K)
    {
        Console.WriteLine(string.Format("vertexCount:{0}", string.Join(" ",vertexCount)));
        Console.WriteLine(string.Format("fromVertex:{0}", string.Join(" ",fromVertex)));
        Console.WriteLine(string.Format("toVertex:{0}", string.Join(" ",toVertex)));
        Console.WriteLine("K:{0}", K);
        int __result = new CycleColoring().countColorings(vertexCount, fromVertex, toVertex, K);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] vertexCount = new int[] {
            3,
            3
        };
        Console.WriteLine(string.Format("vertexCount:{0}", string.Join(" ", vertexCount)));
        int[] fromVertex = new int[] {
            0,
            0
        };
        Console.WriteLine(string.Format("fromVertex:{0}", string.Join(" ", fromVertex)));
        int[] toVertex = new int[] {
            0,
            0
        };
        Console.WriteLine(string.Format("toVertex:{0}", string.Join(" ", toVertex)));
        int K = 3;
        Console.WriteLine("K:{0}", K);
        int __expected = 12;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CycleColoring().countColorings(vertexCount, fromVertex, toVertex, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] vertexCount = new int[] {
            6
        };
        Console.WriteLine(string.Format("vertexCount:{0}", string.Join(" ", vertexCount)));
        int[] fromVertex = new int[] {
            4
        };
        Console.WriteLine(string.Format("fromVertex:{0}", string.Join(" ", fromVertex)));
        int[] toVertex = new int[] {
            1
        };
        Console.WriteLine(string.Format("toVertex:{0}", string.Join(" ", toVertex)));
        int K = 3;
        Console.WriteLine("K:{0}", K);
        int __expected = 12;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CycleColoring().countColorings(vertexCount, fromVertex, toVertex, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] vertexCount = new int[] {
            3,
            3
        };
        Console.WriteLine(string.Format("vertexCount:{0}", string.Join(" ", vertexCount)));
        int[] fromVertex = new int[] {
            0,
            1
        };
        Console.WriteLine(string.Format("fromVertex:{0}", string.Join(" ", fromVertex)));
        int[] toVertex = new int[] {
            1,
            2
        };
        Console.WriteLine(string.Format("toVertex:{0}", string.Join(" ", toVertex)));
        int K = 3;
        Console.WriteLine("K:{0}", K);
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CycleColoring().countColorings(vertexCount, fromVertex, toVertex, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] vertexCount = new int[] {
            9,
            5
        };
        Console.WriteLine(string.Format("vertexCount:{0}", string.Join(" ", vertexCount)));
        int[] fromVertex = new int[] {
            8,
            3
        };
        Console.WriteLine(string.Format("fromVertex:{0}", string.Join(" ", fromVertex)));
        int[] toVertex = new int[] {
            0,
            2
        };
        Console.WriteLine(string.Format("toVertex:{0}", string.Join(" ", toVertex)));
        int K = 8;
        Console.WriteLine("K:{0}", K);
        int __expected = 589124602;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CycleColoring().countColorings(vertexCount, fromVertex, toVertex, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] vertexCount = new int[] {
            14,
            15,
            16,
            17
        };
        Console.WriteLine(string.Format("vertexCount:{0}", string.Join(" ", vertexCount)));
        int[] fromVertex = new int[] {
            5,
            10,
            4,
            6
        };
        Console.WriteLine(string.Format("fromVertex:{0}", string.Join(" ", fromVertex)));
        int[] toVertex = new int[] {
            10,
            3,
            14,
            10
        };
        Console.WriteLine(string.Format("toVertex:{0}", string.Join(" ", toVertex)));
        int K = 614;
        Console.WriteLine("K:{0}", K);
        int __expected = 818050159;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CycleColoring().countColorings(vertexCount, fromVertex, toVertex, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int[] vertexCount = new int[] {
            482373,
            283712,
            883,
            12834,
            5,
            5,
            482734,
            99912,
            35881,
            277590
        };
        Console.WriteLine(string.Format("vertexCount:{0}", string.Join(" ", vertexCount)));
        int[] fromVertex = new int[] {
            59283,
            49782,
            0,
            0,
            3,
            2,
            84791,
            40017,
            2263,
            461
        };
        Console.WriteLine(string.Format("fromVertex:{0}", string.Join(" ", fromVertex)));
        int[] toVertex = new int[] {
            150173,
            709,
            11108,
            0,
            4,
            7,
            5902,
            712,
            190232,
            390331
        };
        Console.WriteLine(string.Format("toVertex:{0}", string.Join(" ", toVertex)));
        int K = 479360784;
        Console.WriteLine("K:{0}", K);
        int __expected = 763634309;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new CycleColoring().countColorings(vertexCount, fromVertex, toVertex, K);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
