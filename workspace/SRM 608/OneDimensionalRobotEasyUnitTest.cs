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
    public void ManualTest(string commands, int A, int B)
    {
        Console.WriteLine("commands:{0}", commands);
        Console.WriteLine("A:{0}", A);
        Console.WriteLine("B:{0}", B);
        int __result = new OneDimensionalRobotEasy().finalPosition(commands, A, B);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string commands = "RRLRRLLR";
        Console.WriteLine("commands:{0}", commands);
        int A = 10;
        Console.WriteLine("A:{0}", A);
        int B = 10;
        Console.WriteLine("B:{0}", B);
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new OneDimensionalRobotEasy().finalPosition(commands, A, B);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string commands = "RRRRR";
        Console.WriteLine("commands:{0}", commands);
        int A = 3;
        Console.WriteLine("A:{0}", A);
        int B = 4;
        Console.WriteLine("B:{0}", B);
        int __expected = 4;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new OneDimensionalRobotEasy().finalPosition(commands, A, B);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string commands = "LLLLLLLLLLR";
        Console.WriteLine("commands:{0}", commands);
        int A = 2;
        Console.WriteLine("A:{0}", A);
        int B = 6;
        Console.WriteLine("B:{0}", B);
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new OneDimensionalRobotEasy().finalPosition(commands, A, B);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string commands = "RRRRRRRLRRLRRRRRRRRRRRRLRLRRRRRRRRLRRRRRLRRRRRRRRR";
        Console.WriteLine("commands:{0}", commands);
        int A = 5;
        Console.WriteLine("A:{0}", A);
        int B = 20;
        Console.WriteLine("B:{0}", B);
        int __expected = 20;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new OneDimensionalRobotEasy().finalPosition(commands, A, B);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string commands = "RLRLLLLLLLRLLLRLLLLLLLLRLLLLLRLLLRRLLLLLRLLLLLRLLL";
        Console.WriteLine("commands:{0}", commands);
        int A = 34;
        Console.WriteLine("A:{0}", A);
        int B = 15;
        Console.WriteLine("B:{0}", B);
        int __expected = -30;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new OneDimensionalRobotEasy().finalPosition(commands, A, B);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
