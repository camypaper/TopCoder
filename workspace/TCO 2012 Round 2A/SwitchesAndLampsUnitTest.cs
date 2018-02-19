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
    public void ManualTest(string[] switches, string[] lamps)
    {
        Console.WriteLine(string.Format("switches:{0}", string.Join(" ",switches)));
        Console.WriteLine(string.Format("lamps:{0}", string.Join(" ",lamps)));
        int __result = new SwitchesAndLamps().theMin(switches, lamps);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string[] switches = new string[] {
            "NYNN",
            "NNYN"
        };
        Console.WriteLine(string.Format("switches:{0}", string.Join(" ", switches)));
        string[] lamps = new string[] {
            "NNNY",
            "NNYN"
        };
        Console.WriteLine(string.Format("lamps:{0}", string.Join(" ", lamps)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SwitchesAndLamps().theMin(switches, lamps);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string[] switches = new string[] {
            "YYN",
            "YNY",
            "YYN"
        };
        Console.WriteLine(string.Format("switches:{0}", string.Join(" ", switches)));
        string[] lamps = new string[] {
            "YNY",
            "NYY",
            "YNY"
        };
        Console.WriteLine(string.Format("lamps:{0}", string.Join(" ", lamps)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SwitchesAndLamps().theMin(switches, lamps);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string[] switches = new string[] {
            "NYYYNYNNYYYNYNNNNY",
            "NYYYNYNNYYYNYNNNNY"
        };
        Console.WriteLine(string.Format("switches:{0}", string.Join(" ", switches)));
        string[] lamps = new string[] {
            "YYYNNNYNNYNYNYNYNY",
            "YYYNNNYNNYNYYNNYNY"
        };
        Console.WriteLine(string.Format("lamps:{0}", string.Join(" ", lamps)));
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SwitchesAndLamps().theMin(switches, lamps);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string[] switches = new string[] {
            "YYNNN",
            "NNYYN"
        };
        Console.WriteLine(string.Format("switches:{0}", string.Join(" ", switches)));
        string[] lamps = new string[] {
            "NYNNY",
            "NNNYY"
        };
        Console.WriteLine(string.Format("lamps:{0}", string.Join(" ", lamps)));
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SwitchesAndLamps().theMin(switches, lamps);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string[] switches = new string[] {
            "YNNYNNYNYY",
            "NYNNYNYNYN",
            "YNYNYYYYYN",
            "NNYYNYNYNN"
        };
        Console.WriteLine(string.Format("switches:{0}", string.Join(" ", switches)));
        string[] lamps = new string[] {
            "NYYNYNNYNY",
            "NYYYNNYNNN",
            "YYYYNYNNYY",
            "YNNNNYNYYN"
        };
        Console.WriteLine(string.Format("lamps:{0}", string.Join(" ", lamps)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new SwitchesAndLamps().theMin(switches, lamps);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
