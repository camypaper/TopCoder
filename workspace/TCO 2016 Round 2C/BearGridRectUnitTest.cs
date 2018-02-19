using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class UnitTest
{
    public List<Action> Tests = new List<Action>(){};
    public UnitTest()
    {
        Tests.Add(Example0);Tests.Add(Example1);Tests.Add(Example2);Tests.Add(Example3);Tests.Add(Example4);Tests.Add(Example5);Tests.Add(Example6);Tests.Add(Example7);Tests.Add(Example8);    }
    public void ManualTest(int N, int[] r1, int[] r2, int[] c1, int[] c2, int[] cnt)
    {
        Console.WriteLine("N:{0}", N);
        Console.WriteLine(string.Format("r1:{0}", string.Join(" ",r1)));
        Console.WriteLine(string.Format("r2:{0}", string.Join(" ",r2)));
        Console.WriteLine(string.Format("c1:{0}", string.Join(" ",c1)));
        Console.WriteLine(string.Format("c2:{0}", string.Join(" ",c2)));
        Console.WriteLine(string.Format("cnt:{0}", string.Join(" ",cnt)));
        int[] __result = new BearGridRect().findPermutation(N, r1, r2, c1, c2, cnt);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
    }

    [TestMethod]
    public void Example0()
    {
        int N = 5;
        Console.WriteLine("N:{0}", N);
        int[] r1 = new int[] {
            4,
            0
        };
        Console.WriteLine(string.Format("r1:{0}", string.Join(" ", r1)));
        int[] r2 = new int[] {
            4,
            1
        };
        Console.WriteLine(string.Format("r2:{0}", string.Join(" ", r2)));
        int[] c1 = new int[] {
            2,
            1
        };
        Console.WriteLine(string.Format("c1:{0}", string.Join(" ", c1)));
        int[] c2 = new int[] {
            4,
            2
        };
        Console.WriteLine(string.Format("c2:{0}", string.Join(" ", c2)));
        int[] cnt = new int[] {
            0,
            2
        };
        Console.WriteLine(string.Format("cnt:{0}", string.Join(" ", cnt)));
        int[] __expected = new int[] {
            1,
            2,
            4,
            3,
            0
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new BearGridRect().findPermutation(N, r1, r2, c1, c2, cnt);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example1()
    {
        int N = 5;
        Console.WriteLine("N:{0}", N);
        int[] r1 = new int[] {
            4,
            0,
            2
        };
        Console.WriteLine(string.Format("r1:{0}", string.Join(" ", r1)));
        int[] r2 = new int[] {
            4,
            1,
            2
        };
        Console.WriteLine(string.Format("r2:{0}", string.Join(" ", r2)));
        int[] c1 = new int[] {
            2,
            1,
            2
        };
        Console.WriteLine(string.Format("c1:{0}", string.Join(" ", c1)));
        int[] c2 = new int[] {
            4,
            2,
            2
        };
        Console.WriteLine(string.Format("c2:{0}", string.Join(" ", c2)));
        int[] cnt = new int[] {
            0,
            2,
            1
        };
        Console.WriteLine(string.Format("cnt:{0}", string.Join(" ", cnt)));
        int[] __expected = new int[] {
            -1
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new BearGridRect().findPermutation(N, r1, r2, c1, c2, cnt);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example2()
    {
        int N = 3;
        Console.WriteLine("N:{0}", N);
        int[] r1 = new int[] {
            0
        };
        Console.WriteLine(string.Format("r1:{0}", string.Join(" ", r1)));
        int[] r2 = new int[] {
            2
        };
        Console.WriteLine(string.Format("r2:{0}", string.Join(" ", r2)));
        int[] c1 = new int[] {
            0
        };
        Console.WriteLine(string.Format("c1:{0}", string.Join(" ", c1)));
        int[] c2 = new int[] {
            2
        };
        Console.WriteLine(string.Format("c2:{0}", string.Join(" ", c2)));
        int[] cnt = new int[] {
            0
        };
        Console.WriteLine(string.Format("cnt:{0}", string.Join(" ", cnt)));
        int[] __expected = new int[] {
            -1
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new BearGridRect().findPermutation(N, r1, r2, c1, c2, cnt);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example3()
    {
        int N = 4;
        Console.WriteLine("N:{0}", N);
        int[] r1 = new int[] {
            0
        };
        Console.WriteLine(string.Format("r1:{0}", string.Join(" ", r1)));
        int[] r2 = new int[] {
            0
        };
        Console.WriteLine(string.Format("r2:{0}", string.Join(" ", r2)));
        int[] c1 = new int[] {
            0
        };
        Console.WriteLine(string.Format("c1:{0}", string.Join(" ", c1)));
        int[] c2 = new int[] {
            0
        };
        Console.WriteLine(string.Format("c2:{0}", string.Join(" ", c2)));
        int[] cnt = new int[] {
            0
        };
        Console.WriteLine(string.Format("cnt:{0}", string.Join(" ", cnt)));
        int[] __expected = new int[] {
            1,
            0,
            2,
            3
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new BearGridRect().findPermutation(N, r1, r2, c1, c2, cnt);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example4()
    {
        int N = 2;
        Console.WriteLine("N:{0}", N);
        int[] r1 = new int[] {
            0,
            0,
            1,
            1
        };
        Console.WriteLine(string.Format("r1:{0}", string.Join(" ", r1)));
        int[] r2 = new int[] {
            0,
            0,
            1,
            1
        };
        Console.WriteLine(string.Format("r2:{0}", string.Join(" ", r2)));
        int[] c1 = new int[] {
            0,
            1,
            0,
            1
        };
        Console.WriteLine(string.Format("c1:{0}", string.Join(" ", c1)));
        int[] c2 = new int[] {
            0,
            1,
            0,
            1
        };
        Console.WriteLine(string.Format("c2:{0}", string.Join(" ", c2)));
        int[] cnt = new int[] {
            0,
            1,
            1,
            0
        };
        Console.WriteLine(string.Format("cnt:{0}", string.Join(" ", cnt)));
        int[] __expected = new int[] {
            1,
            0
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new BearGridRect().findPermutation(N, r1, r2, c1, c2, cnt);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example5()
    {
        int N = 2;
        Console.WriteLine("N:{0}", N);
        int[] r1 = new int[] {
            0,
            0,
            1,
            1
        };
        Console.WriteLine(string.Format("r1:{0}", string.Join(" ", r1)));
        int[] r2 = new int[] {
            0,
            0,
            1,
            1
        };
        Console.WriteLine(string.Format("r2:{0}", string.Join(" ", r2)));
        int[] c1 = new int[] {
            0,
            1,
            0,
            1
        };
        Console.WriteLine(string.Format("c1:{0}", string.Join(" ", c1)));
        int[] c2 = new int[] {
            0,
            1,
            0,
            1
        };
        Console.WriteLine(string.Format("c2:{0}", string.Join(" ", c2)));
        int[] cnt = new int[] {
            0,
            1,
            0,
            1
        };
        Console.WriteLine(string.Format("cnt:{0}", string.Join(" ", cnt)));
        int[] __expected = new int[] {
            -1
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new BearGridRect().findPermutation(N, r1, r2, c1, c2, cnt);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example6()
    {
        int N = 2;
        Console.WriteLine("N:{0}", N);
        int[] r1 = new int[] {
            0,
            0,
            1,
            1
        };
        Console.WriteLine(string.Format("r1:{0}", string.Join(" ", r1)));
        int[] r2 = new int[] {
            0,
            0,
            1,
            1
        };
        Console.WriteLine(string.Format("r2:{0}", string.Join(" ", r2)));
        int[] c1 = new int[] {
            0,
            1,
            0,
            1
        };
        Console.WriteLine(string.Format("c1:{0}", string.Join(" ", c1)));
        int[] c2 = new int[] {
            0,
            1,
            0,
            1
        };
        Console.WriteLine(string.Format("c2:{0}", string.Join(" ", c2)));
        int[] cnt = new int[] {
            1,
            1,
            1,
            1
        };
        Console.WriteLine(string.Format("cnt:{0}", string.Join(" ", cnt)));
        int[] __expected = new int[] {
            -1
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new BearGridRect().findPermutation(N, r1, r2, c1, c2, cnt);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example7()
    {
        int N = 6;
        Console.WriteLine("N:{0}", N);
        int[] r1 = new int[] {
            0,
            0,
            4
        };
        Console.WriteLine(string.Format("r1:{0}", string.Join(" ", r1)));
        int[] r2 = new int[] {
            2,
            3,
            5
        };
        Console.WriteLine(string.Format("r2:{0}", string.Join(" ", r2)));
        int[] c1 = new int[] {
            0,
            5,
            1
        };
        Console.WriteLine(string.Format("c1:{0}", string.Join(" ", c1)));
        int[] c2 = new int[] {
            4,
            5,
            5
        };
        Console.WriteLine(string.Format("c2:{0}", string.Join(" ", c2)));
        int[] cnt = new int[] {
            3,
            1,
            1
        };
        Console.WriteLine(string.Format("cnt:{0}", string.Join(" ", cnt)));
        int[] __expected = new int[] {
            1,
            2,
            4,
            5,
            3,
            0
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new BearGridRect().findPermutation(N, r1, r2, c1, c2, cnt);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

    [TestMethod]
    public void Example8()
    {
        int N = 3;
        Console.WriteLine("N:{0}", N);
        int[] r1 = new int[] {
            0
        };
        Console.WriteLine(string.Format("r1:{0}", string.Join(" ", r1)));
        int[] r2 = new int[] {
            0
        };
        Console.WriteLine(string.Format("r2:{0}", string.Join(" ", r2)));
        int[] c1 = new int[] {
            0
        };
        Console.WriteLine(string.Format("c1:{0}", string.Join(" ", c1)));
        int[] c2 = new int[] {
            0
        };
        Console.WriteLine(string.Format("c2:{0}", string.Join(" ", c2)));
        int[] cnt = new int[] {
            2
        };
        Console.WriteLine(string.Format("cnt:{0}", string.Join(" ", cnt)));
        int[] __expected = new int[] {
            -1
        };
        Console.WriteLine(string.Format("__expected:{0}", string.Join(" ",__expected)));
        int[] __result = new BearGridRect().findPermutation(N, r1, r2, c1, c2, cnt);
        Console.WriteLine(string.Format("__result:{0}",string.Join(" ", __result)));
            CollectionAssert.AreEquivalent(__expected, __result);
     }

}
