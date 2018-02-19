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
    public void ManualTest(string init, int T)
    {
        Console.WriteLine("init:{0}", init);
        Console.WriteLine("T:{0}", T);
        string __result = new GameOfLifeDivTwo().theSimulation(init, T);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string init = "01010";
        Console.WriteLine("init:{0}", init);
        int T = 2;
        Console.WriteLine("T:{0}", T);
        string __expected = "00000";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new GameOfLifeDivTwo().theSimulation(init, T);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string init = "010101";
        Console.WriteLine("init:{0}", init);
        int T = 5;
        Console.WriteLine("T:{0}", T);
        string __expected = "101010";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new GameOfLifeDivTwo().theSimulation(init, T);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string init = "111010";
        Console.WriteLine("init:{0}", init);
        int T = 58;
        Console.WriteLine("T:{0}", T);
        string __expected = "111111";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new GameOfLifeDivTwo().theSimulation(init, T);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string init = "111111111";
        Console.WriteLine("init:{0}", init);
        int T = 511;
        Console.WriteLine("T:{0}", T);
        string __expected = "111111111";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new GameOfLifeDivTwo().theSimulation(init, T);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string init = "110010000010111110010100001001";
        Console.WriteLine("init:{0}", init);
        int T = 1000;
        Console.WriteLine("T:{0}", T);
        string __expected = "110000000001111110000000000001";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new GameOfLifeDivTwo().theSimulation(init, T);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        string init = "00101110011";
        Console.WriteLine("init:{0}", init);
        int T = 0;
        Console.WriteLine("T:{0}", T);
        string __expected = "00101110011";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new GameOfLifeDivTwo().theSimulation(init, T);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
