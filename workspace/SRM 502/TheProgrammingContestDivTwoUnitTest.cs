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
    public void ManualTest(int T, int[] requiredTime)
    {
        Console.WriteLine("T:{0}", T);
        Console.WriteLine(string.Format("requiredTime:{0}", string.Join(" ",requiredTime)));
        int[] __result = new TheProgrammingContestDivTwo().find(T, requiredTime);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
    }

    [TestMethod]
    public void Example0()
    {
        int T = 74;
        Console.WriteLine("T:{0}", T);
        int[] requiredTime = new int[] {
            47
        };
        Console.WriteLine(string.Format("requiredTime:{0}", string.Join(" ", requiredTime)));
        int[] __expected = new int[] {
            1,
            47
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new TheProgrammingContestDivTwo().find(T, requiredTime);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example1()
    {
        int T = 74;
        Console.WriteLine("T:{0}", T);
        int[] requiredTime = new int[] {
            4747
        };
        Console.WriteLine(string.Format("requiredTime:{0}", string.Join(" ", requiredTime)));
        int[] __expected = new int[] {
            0,
            0
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new TheProgrammingContestDivTwo().find(T, requiredTime);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example2()
    {
        int T = 47;
        Console.WriteLine("T:{0}", T);
        int[] requiredTime = new int[] {
            8,
            5
        };
        Console.WriteLine(string.Format("requiredTime:{0}", string.Join(" ", requiredTime)));
        int[] __expected = new int[] {
            2,
            18
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new TheProgrammingContestDivTwo().find(T, requiredTime);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example3()
    {
        int T = 47;
        Console.WriteLine("T:{0}", T);
        int[] requiredTime = new int[] {
            12,
            3,
            21,
            6,
            4,
            13
        };
        Console.WriteLine(string.Format("requiredTime:{0}", string.Join(" ", requiredTime)));
        int[] __expected = new int[] {
            5,
            86
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new TheProgrammingContestDivTwo().find(T, requiredTime);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example4()
    {
        int T = 58;
        Console.WriteLine("T:{0}", T);
        int[] requiredTime = new int[] {
            4,
            5,
            82,
            3,
            4,
            65,
            7,
            6,
            8,
            7,
            6,
            4,
            8,
            7,
            6,
            37,
            8
        };
        Console.WriteLine(string.Format("requiredTime:{0}", string.Join(" ", requiredTime)));
        int[] __expected = new int[] {
            10,
            249
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new TheProgrammingContestDivTwo().find(T, requiredTime);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example5()
    {
        int T = 100000;
        Console.WriteLine("T:{0}", T);
        int[] requiredTime = new int[] {
            100000
        };
        Console.WriteLine(string.Format("requiredTime:{0}", string.Join(" ", requiredTime)));
        int[] __expected = new int[] {
            1,
            100000
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new TheProgrammingContestDivTwo().find(T, requiredTime);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

}
