using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public int[] TestCases = new int[] { 0, 1, 2, 3, 4, 5, };
    public void Execute(int i)
    {
        switch (i)
        {
            case 0: Example0(); break;
            case 1: Example1(); break;
            case 2: Example2(); break;
            case 3: Example3(); break;
            case 4: Example4(); break;
            case 5: Example5(); break;
            default: throw new Exception();
        }
    }
    public void ManualTest()
    {
        int[] warriors = Scanner.In.int_array();
        Console.WriteLine(string.Format("warriors:{0}", string.Join(" ",warriors)));
        int[] horses = Scanner.In.int_array();
        Console.WriteLine(string.Format("horses:{0}", string.Join(" ",horses)));
        int __result = new BearCavalry().countAssignments(warriors, horses);
        Console.WriteLine("__result:{0}", __result);
    }

    public void ManualTest(int[] warriors, int[] horses)
    {
                        Console.WriteLine(string.Format("warriors:{0}", string.Join(" ",warriors)));
                        Console.WriteLine(string.Format("horses:{0}", string.Join(" ",horses)));
                int __result = new BearCavalry().countAssignments(warriors, horses);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int[] warriors = new int[] {
            5,
            8,
            4,
            8
        };
        Console.WriteLine(string.Format("warriors:{0}", string.Join(" ", warriors)));
        int[] horses = new int[] {
            19,
            40,
            25,
            20
        };
        Console.WriteLine(string.Format("horses:{0}", string.Join(" ", horses)));
        int __expected = 2;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearCavalry().countAssignments(warriors, horses);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int[] warriors = new int[] {
            1,
            1
        };
        Console.WriteLine(string.Format("warriors:{0}", string.Join(" ", warriors)));
        int[] horses = new int[] {
            1,
            1
        };
        Console.WriteLine(string.Format("horses:{0}", string.Join(" ", horses)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearCavalry().countAssignments(warriors, horses);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int[] warriors = new int[] {
            10,
            2,
            10
        };
        Console.WriteLine(string.Format("warriors:{0}", string.Join(" ", warriors)));
        int[] horses = new int[] {
            100,
            150,
            200
        };
        Console.WriteLine(string.Format("horses:{0}", string.Join(" ", horses)));
        int __expected = 3;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearCavalry().countAssignments(warriors, horses);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int[] warriors = new int[] {
            10,
            20
        };
        Console.WriteLine(string.Format("warriors:{0}", string.Join(" ", warriors)));
        int[] horses = new int[] {
            1,
            3
        };
        Console.WriteLine(string.Format("horses:{0}", string.Join(" ", horses)));
        int __expected = 1;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearCavalry().countAssignments(warriors, horses);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int[] warriors = new int[] {
            20,
            20,
            25,
            23,
            24,
            24,
            21
        };
        Console.WriteLine(string.Format("warriors:{0}", string.Join(" ", warriors)));
        int[] horses = new int[] {
            20,
            25,
            25,
            20,
            25,
            23,
            20
        };
        Console.WriteLine(string.Format("horses:{0}", string.Join(" ", horses)));
        int __expected = 0;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearCavalry().countAssignments(warriors, horses);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int[] warriors = new int[] {
            970,
            800,
            800,
            800,
            800,
            800,
            800,
            800,
            800,
            800,
            800,
            800,
            800,
            800,
            800,
            800,
            800,
            800,
            800,
            800,
            800,
            800,
            800,
            800,
            800,
            800,
            800,
            800,
            800,
            800,
            800,
            800,
            800,
            800,
            800,
            800,
            800,
            800,
            800,
            800,
            800,
            800,
            800,
            800,
            800,
            800,
            800,
            800,
            800,
            800
        };
        Console.WriteLine(string.Format("warriors:{0}", string.Join(" ", warriors)));
        int[] horses = new int[] {
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000,
            1000
        };
        Console.WriteLine(string.Format("horses:{0}", string.Join(" ", horses)));
        int __expected = 318608048;
        Console.WriteLine("__expected:{0}", __expected);
        int __result = new BearCavalry().countAssignments(warriors, horses);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
