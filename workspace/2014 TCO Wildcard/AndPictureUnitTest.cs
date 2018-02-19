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
    public void ManualTest(int n, string[] picture)
    {
        Console.WriteLine("n:{0}", n);
        Console.WriteLine(string.Format("picture:{0}", string.Join(" ",picture)));
        string __result = new AndPicture().isPossible(n, picture);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int n = 2;
        Console.WriteLine("n:{0}", n);
        string[] picture = new string[] {
            "0011",
            "1010",
            "0000",
            "1011"
        };
        Console.WriteLine(string.Format("picture:{0}", string.Join(" ", picture)));
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new AndPicture().isPossible(n, picture);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int n = 2;
        Console.WriteLine("n:{0}", n);
        string[] picture = new string[] {
            "0011",
            "1000",
            "0001",
            "1011"
        };
        Console.WriteLine(string.Format("picture:{0}", string.Join(" ", picture)));
        string __expected = "Impossible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new AndPicture().isPossible(n, picture);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int n = 1;
        Console.WriteLine("n:{0}", n);
        string[] picture = new string[] {
            "01",
            "00"
        };
        Console.WriteLine(string.Format("picture:{0}", string.Join(" ", picture)));
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new AndPicture().isPossible(n, picture);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int n = 3;
        Console.WriteLine("n:{0}", n);
        string[] picture = new string[] {
            "01010011",
            "11110111",
            "11110011",
            "00000000",
            "11110101",
            "11010111",
            "11110000",
            "11000101"
        };
        Console.WriteLine(string.Format("picture:{0}", string.Join(" ", picture)));
        string __expected = "Possible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new AndPicture().isPossible(n, picture);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int n = 4;
        Console.WriteLine("n:{0}", n);
        string[] picture = new string[] {
            "0000000000000000",
            "0000011111100000",
            "0000000110000000",
            "0000000110000000",
            "0000000110000000",
            "0000000000000000",
            "0000011111000000",
            "0000110000000000",
            "0000110000000000",
            "0000011111000000",
            "0000000000000000",
            "0000001111100000",
            "0000011000110000",
            "0000011000110000",
            "0000001111100000",
            "0000000000000000"
        };
        Console.WriteLine(string.Format("picture:{0}", string.Join(" ", picture)));
        string __expected = "Impossible";
        Console.WriteLine("__expected:{0}", __expected);
        string __result = new AndPicture().isPossible(n, picture);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
