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
    public void ManualTest(int sortedness, int[] seq)
    {
        Console.WriteLine("sortedness:{0}", sortedness);
        Console.WriteLine(string.Format("seq:{0}", string.Join(" ",seq)));
        long __result = new Sortish().ways(sortedness, seq);
        Console.WriteLine("__result:{0}", __result);
    }

    [TestMethod]
    public void Example0()
    {
        int sortedness = 5;
        Console.WriteLine("sortedness:{0}", sortedness);
        int[] seq = new int[] {
            4,
            0,
            0,
            2,
            0
        };
        Console.WriteLine(string.Format("seq:{0}", string.Join(" ", seq)));
        long __expected = 2L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new Sortish().ways(sortedness, seq);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example1()
    {
        int sortedness = 4;
        Console.WriteLine("sortedness:{0}", sortedness);
        int[] seq = new int[] {
            0,
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("seq:{0}", string.Join(" ", seq)));
        long __expected = 5L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new Sortish().ways(sortedness, seq);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example2()
    {
        int sortedness = 2;
        Console.WriteLine("sortedness:{0}", sortedness);
        int[] seq = new int[] {
            1,
            3,
            2
        };
        Console.WriteLine(string.Format("seq:{0}", string.Join(" ", seq)));
        long __expected = 1L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new Sortish().ways(sortedness, seq);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example3()
    {
        int sortedness = 3;
        Console.WriteLine("sortedness:{0}", sortedness);
        int[] seq = new int[] {
            0,
            0,
            2,
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("seq:{0}", string.Join(" ", seq)));
        long __expected = 4L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new Sortish().ways(sortedness, seq);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example4()
    {
        int sortedness = 87;
        Console.WriteLine("sortedness:{0}", sortedness);
        int[] seq = new int[] {
            2,
            0
        };
        Console.WriteLine(string.Format("seq:{0}", string.Join(" ", seq)));
        long __expected = 0L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new Sortish().ways(sortedness, seq);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example5()
    {
        int sortedness = 30;
        Console.WriteLine("sortedness:{0}", sortedness);
        int[] seq = new int[] {
            0,
            6,
            3,
            0,
            0,
            2,
            10,
            0,
            0,
            0
        };
        Console.WriteLine(string.Format("seq:{0}", string.Join(" ", seq)));
        long __expected = 34L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new Sortish().ways(sortedness, seq);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

    [TestMethod]
    public void Example6()
    {
        int sortedness = 100;
        Console.WriteLine("sortedness:{0}", sortedness);
        int[] seq = new int[] {
            0,
            13,
            0,
            0,
            12,
            0,
            0,
            0,
            2,
            0,
            0,
            10,
            5,
            0,
            0,
            0,
            0,
            0,
            0,
            7,
            15,
            16,
            20
        };
        Console.WriteLine(string.Format("seq:{0}", string.Join(" ", seq)));
        long __expected = 53447326L;
        Console.WriteLine("__expected:{0}", __expected);
        long __result = new Sortish().ways(sortedness, seq);
        Console.WriteLine("__result:{0}", __result);
        Assert.AreEqual(__expected, __result);
    }

}
