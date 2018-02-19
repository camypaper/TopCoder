using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public int[] TestCases = new int[] { 0, 1, 2, 3, 4, };
    public void Execute(int i)
    {
        switch (i)
        {
            case 0: Example0(); break;
            case 1: Example1(); break;
            case 2: Example2(); break;
            case 3: Example3(); break;
            case 4: Example4(); break;
            default: throw new Exception();
        }
    }
    public void ManualTest()
    {
        string[] allA = Scanner.In.string_array();
        Console.WriteLine(string.Format("allA:{0}", string.Join(" ",allA)));
        string[] allB = Scanner.In.string_array();
        Console.WriteLine(string.Format("allB:{0}", string.Join(" ",allB)));
        string[] allC = Scanner.In.string_array();
        Console.WriteLine(string.Format("allC:{0}", string.Join(" ",allC)));
        int __result = new WinterAndReindeers().getNumber(allA, allB, allC);
        Console.WriteLine("__result:{0}", __result);
    }

    public void ManualTest(string[] allA, string[] allB, string[] allC)
    {
                        Console.WriteLine(string.Format("allA:{0}", string.Join(" ",allA)));
                        Console.WriteLine(string.Format("allB:{0}", string.Join(" ",allB)));
                        Console.WriteLine(string.Format("allC:{0}", string.Join(" ",allC)));
                int __result = new WinterAndReindeers().getNumber(allA, allB, allC);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        string[] allA = new string[] {
            "X"
        };
        Console.WriteLine(string.Format("allA:{0}", string.Join(" ", allA)));
        string[] allB = new string[] {
            "X",
            "Y"
        };
        Console.WriteLine(string.Format("allB:{0}", string.Join(" ", allB)));
        string[] allC = new string[] {
            "X"
        };
        Console.WriteLine(string.Format("allC:{0}", string.Join(" ", allC)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new WinterAndReindeers().getNumber(allA, allB, allC);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        string[] allA = new string[] {
            "ABCXD"
        };
        Console.WriteLine(string.Format("allA:{0}", string.Join(" ", allA)));
        string[] allB = new string[] {
            "BCDEF"
        };
        Console.WriteLine(string.Format("allB:{0}", string.Join(" ", allB)));
        string[] allC = new string[] {
            "CD"
        };
        Console.WriteLine(string.Format("allC:{0}", string.Join(" ", allC)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new WinterAndReindeers().getNumber(allA, allB, allC);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        string[] allA = new string[] {
            "WE",
            "LOVE"
        };
        Console.WriteLine(string.Format("allA:{0}", string.Join(" ", allA)));
        string[] allB = new string[] {
            "WORKING",
            "FOR",
            "SANTA"
        };
        Console.WriteLine(string.Format("allB:{0}", string.Join(" ", allB)));
        string[] allC = new string[] {
            "JK"
        };
        Console.WriteLine(string.Format("allC:{0}", string.Join(" ", allC)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new WinterAndReindeers().getNumber(allA, allB, allC);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        string[] allA = new string[] {
            "ABCDE"
        };
        Console.WriteLine(string.Format("allA:{0}", string.Join(" ", allA)));
        string[] allB = new string[] {
            "CDEAB"
        };
        Console.WriteLine(string.Format("allB:{0}", string.Join(" ", allB)));
        string[] allC = new string[] {
            "B"
        };
        Console.WriteLine(string.Format("allC:{0}", string.Join(" ", allC)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new WinterAndReindeers().getNumber(allA, allB, allC);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        string[] allA = new string[] {
            "ABCABDEGAXAHDJBAAHFJDXBB",
            "ABHFHCDALFDJDBBA",
            "BABBAXAXXX"
        };
        Console.WriteLine(string.Format("allA:{0}", string.Join(" ", allA)));
        string[] allB = new string[] {
            "ABLOCBAXBAHAJDXBIJKA",
            "JBABCDAHKFIUDALPJAH",
            "AABACX"
        };
        Console.WriteLine(string.Format("allB:{0}", string.Join(" ", allB)));
        string[] allC = new string[] {
            "AXBADXBBAB",
            "CDD"
        };
        Console.WriteLine(string.Format("allC:{0}", string.Join(" ", allC)));
        int __expected = 23;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new WinterAndReindeers().getNumber(allA, allB, allC);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
