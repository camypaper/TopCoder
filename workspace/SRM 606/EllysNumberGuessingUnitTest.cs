using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);Tests.Add(Example4);Tests.Add(Example5);Tests.Add(Example6);    }
    public void ManualTest(int[] guesses, int[] answers)
    {
        Console.WriteLine(string.Format("guesses:{0}", string.Join(" ",guesses)));
        Console.WriteLine(string.Format("answers:{0}", string.Join(" ",answers)));
        int __result = new EllysNumberGuessing().getNumber(guesses, answers);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] guesses = new int[] {
            600,
            594
        };
        Console.WriteLine(string.Format("guesses:{0}", string.Join(" ", guesses)));
        int[] answers = new int[] {
            6,
            12
        };
        Console.WriteLine(string.Format("answers:{0}", string.Join(" ", answers)));
        int __expected = 606;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new EllysNumberGuessing().getNumber(guesses, answers);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] guesses = new int[] {
            100,
            50,
            34,
            40
        };
        Console.WriteLine(string.Format("guesses:{0}", string.Join(" ", guesses)));
        int[] answers = new int[] {
            58,
            8,
            8,
            2
        };
        Console.WriteLine(string.Format("answers:{0}", string.Join(" ", answers)));
        int __expected = 42;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new EllysNumberGuessing().getNumber(guesses, answers);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] guesses = new int[] {
            500000,
            600000,
            700000
        };
        Console.WriteLine(string.Format("guesses:{0}", string.Join(" ", guesses)));
        int[] answers = new int[] {
            120013,
            220013,
            79987
        };
        Console.WriteLine(string.Format("answers:{0}", string.Join(" ", answers)));
        int __expected = -2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new EllysNumberGuessing().getNumber(guesses, answers);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] guesses = new int[] {
            500000000
        };
        Console.WriteLine(string.Format("guesses:{0}", string.Join(" ", guesses)));
        int[] answers = new int[] {
            133742666
        };
        Console.WriteLine(string.Format("answers:{0}", string.Join(" ", answers)));
        int __expected = -1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new EllysNumberGuessing().getNumber(guesses, answers);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] guesses = new int[] {
            76938260,
            523164588,
            14196746,
            296286419,
            535893832,
            41243148,
            364561227,
            270003278,
            472017422,
            367932361,
            395758413,
            301278456,
            186276934,
            316343129,
            336557549,
            52536121,
            98343562,
            356769915,
            89249181,
            335191879
        };
        Console.WriteLine(string.Format("guesses:{0}", string.Join(" ", guesses)));
        int[] answers = new int[] {
            466274085,
            20047757,
            529015599,
            246925926,
            7318513,
            501969197,
            178651118,
            273209067,
            71194923,
            175279984,
            147453932,
            241933889,
            356935411,
            226869216,
            206654796,
            490676224,
            444868783,
            186442430,
            453963164,
            208020466
        };
        Console.WriteLine(string.Format("answers:{0}", string.Join(" ", answers)));
        int __expected = 543212345;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new EllysNumberGuessing().getNumber(guesses, answers);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int[] guesses = new int[] {
            42
        };
        Console.WriteLine(string.Format("guesses:{0}", string.Join(" ", guesses)));
        int[] answers = new int[] {
            42
        };
        Console.WriteLine(string.Format("answers:{0}", string.Join(" ", answers)));
        int __expected = 84;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new EllysNumberGuessing().getNumber(guesses, answers);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example6()
    {
        int[] guesses = new int[] {
            999900000
        };
        Console.WriteLine(string.Format("guesses:{0}", string.Join(" ", guesses)));
        int[] answers = new int[] {
            100001
        };
        Console.WriteLine(string.Format("answers:{0}", string.Join(" ", answers)));
        int __expected = 999799999;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new EllysNumberGuessing().getNumber(guesses, answers);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
