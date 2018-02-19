using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public int[] TestCases = new int[] { 0, 1, 2, 3, };
    public void Execute(int i)
    {
        switch (i)
        {
            case 0: Example0(); break;
            case 1: Example1(); break;
            case 2: Example2(); break;
            case 3: Example3(); break;
            default: throw new Exception();
        }
    }
    public void ManualTest()
    {
        int T = Scanner.In.@int();
        Console.WriteLine("T:{0}", T);
        int[] maxPoints = Scanner.In.int_array();
        Console.WriteLine(string.Format("maxPoints:{0}", string.Join(" ",maxPoints)));
        int[] pointsPerMinute = Scanner.In.int_array();
        Console.WriteLine(string.Format("pointsPerMinute:{0}", string.Join(" ",pointsPerMinute)));
        int[] requiredTime = Scanner.In.int_array();
        Console.WriteLine(string.Format("requiredTime:{0}", string.Join(" ",requiredTime)));
        int __result = new TheProgrammingContestDivOne().find(T, maxPoints, pointsPerMinute, requiredTime);
        Console.WriteLine("__result:{0}", __result);
    }

    public void ManualTest(int T, int[] maxPoints, int[] pointsPerMinute, int[] requiredTime)
    {
                        Console.WriteLine("T:{0}", T);
                        Console.WriteLine(string.Format("maxPoints:{0}", string.Join(" ",maxPoints)));
                        Console.WriteLine(string.Format("pointsPerMinute:{0}", string.Join(" ",pointsPerMinute)));
                        Console.WriteLine(string.Format("requiredTime:{0}", string.Join(" ",requiredTime)));
                int __result = new TheProgrammingContestDivOne().find(T, maxPoints, pointsPerMinute, requiredTime);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int T = 74;
        Console.WriteLine("T:{0}", T);
        int[] maxPoints = new int[] {
            502
        };
        Console.WriteLine(string.Format("maxPoints:{0}", string.Join(" ", maxPoints)));
        int[] pointsPerMinute = new int[] {
            2
        };
        Console.WriteLine(string.Format("pointsPerMinute:{0}", string.Join(" ", pointsPerMinute)));
        int[] requiredTime = new int[] {
            47
        };
        Console.WriteLine(string.Format("requiredTime:{0}", string.Join(" ", requiredTime)));
        int __expected = 408;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TheProgrammingContestDivOne().find(T, maxPoints, pointsPerMinute, requiredTime);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int T = 40000;
        Console.WriteLine("T:{0}", T);
        int[] maxPoints = new int[] {
            100000,
            100000
        };
        Console.WriteLine(string.Format("maxPoints:{0}", string.Join(" ", maxPoints)));
        int[] pointsPerMinute = new int[] {
            1,
            100000
        };
        Console.WriteLine(string.Format("pointsPerMinute:{0}", string.Join(" ", pointsPerMinute)));
        int[] requiredTime = new int[] {
            50000,
            30000
        };
        Console.WriteLine(string.Format("requiredTime:{0}", string.Join(" ", requiredTime)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TheProgrammingContestDivOne().find(T, maxPoints, pointsPerMinute, requiredTime);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int T = 75;
        Console.WriteLine("T:{0}", T);
        int[] maxPoints = new int[] {
            250,
            500,
            1000
        };
        Console.WriteLine(string.Format("maxPoints:{0}", string.Join(" ", maxPoints)));
        int[] pointsPerMinute = new int[] {
            2,
            4,
            8
        };
        Console.WriteLine(string.Format("pointsPerMinute:{0}", string.Join(" ", pointsPerMinute)));
        int[] requiredTime = new int[] {
            25,
            25,
            25
        };
        Console.WriteLine(string.Format("requiredTime:{0}", string.Join(" ", requiredTime)));
        int __expected = 1200;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TheProgrammingContestDivOne().find(T, maxPoints, pointsPerMinute, requiredTime);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int T = 30;
        Console.WriteLine("T:{0}", T);
        int[] maxPoints = new int[] {
            100,
            100,
            100000
        };
        Console.WriteLine(string.Format("maxPoints:{0}", string.Join(" ", maxPoints)));
        int[] pointsPerMinute = new int[] {
            1,
            1,
            100
        };
        Console.WriteLine(string.Format("pointsPerMinute:{0}", string.Join(" ", pointsPerMinute)));
        int[] requiredTime = new int[] {
            15,
            15,
            30
        };
        Console.WriteLine(string.Format("requiredTime:{0}", string.Join(" ", requiredTime)));
        int __expected = 97000;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new TheProgrammingContestDivOne().find(T, maxPoints, pointsPerMinute, requiredTime);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
