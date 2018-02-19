using System;
using System.Collections.Generic;
public partial class Tester
{
    public bool ManualTest(int[] x1, int[] y1, int[] x2, int[] y2,bool __fast=true)
    {
        if(!__fast)
        {
        Console.WriteLine(string.Format("x1:{0}", string.Join(" ",x1)));
        Console.WriteLine(string.Format("y1:{0}", string.Join(" ",y1)));
        Console.WriteLine(string.Format("x2:{0}", string.Join(" ",x2)));
        Console.WriteLine(string.Format("y2:{0}", string.Join(" ",y2)));
        }
        int __result = new SoManyRectangles().maxOverlap(x1, y1, x2, y2);
        if(!__fast)
        {
        Console.WriteLine("Result:{0}", __result);
        }
        return true;
    }

    public bool Example0(bool fast = false)
    {
        Console.WriteLine("Example0");
        
        int[] x1 = new int[] { 0 , 50  };
        int[] y1 = new int[] { 0 , 50  };
        int[] x2 = new int[] { 100 , 60  };
        int[] y2 = new int[] { 100 , 60  };

        Console.WriteLine(string.Format("x1:{0}", string.Join(" ", x1)));
        Console.WriteLine(string.Format("y1:{0}", string.Join(" ", y1)));
        Console.WriteLine(string.Format("x2:{0}", string.Join(" ", x2)));
        Console.WriteLine(string.Format("y2:{0}", string.Join(" ", y2)));

        int __expected = 2;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new SoManyRectangles().maxOverlap(x1, y1, x2, y2);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example1(bool fast = false)
    {
        Console.WriteLine("Example1");
        
        int[] x1 = new int[] { 0 , 90  };
        int[] y1 = new int[] { 0 , 90  };
        int[] x2 = new int[] { 100 , 200  };
        int[] y2 = new int[] { 100 , 200  };

        Console.WriteLine(string.Format("x1:{0}", string.Join(" ", x1)));
        Console.WriteLine(string.Format("y1:{0}", string.Join(" ", y1)));
        Console.WriteLine(string.Format("x2:{0}", string.Join(" ", x2)));
        Console.WriteLine(string.Format("y2:{0}", string.Join(" ", y2)));

        int __expected = 2;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new SoManyRectangles().maxOverlap(x1, y1, x2, y2);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example2(bool fast = false)
    {
        Console.WriteLine("Example2");
        
        int[] x1 = new int[] { 0 , 100  };
        int[] y1 = new int[] { 0 , 100  };
        int[] x2 = new int[] { 100 , 200  };
        int[] y2 = new int[] { 100 , 200  };

        Console.WriteLine(string.Format("x1:{0}", string.Join(" ", x1)));
        Console.WriteLine(string.Format("y1:{0}", string.Join(" ", y1)));
        Console.WriteLine(string.Format("x2:{0}", string.Join(" ", x2)));
        Console.WriteLine(string.Format("y2:{0}", string.Join(" ", y2)));

        int __expected = 1;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new SoManyRectangles().maxOverlap(x1, y1, x2, y2);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example3(bool fast = false)
    {
        Console.WriteLine("Example3");
        
        int[] x1 = new int[] { 0 , 0 , 0 , 0 , 0  };
        int[] y1 = new int[] { 0 , 0 , 0 , 0 , 0  };
        int[] x2 = new int[] { 1 , 1 , 1 , 1 , 1  };
        int[] y2 = new int[] { 1 , 1 , 1 , 1 , 1  };

        Console.WriteLine(string.Format("x1:{0}", string.Join(" ", x1)));
        Console.WriteLine(string.Format("y1:{0}", string.Join(" ", y1)));
        Console.WriteLine(string.Format("x2:{0}", string.Join(" ", x2)));
        Console.WriteLine(string.Format("y2:{0}", string.Join(" ", y2)));

        int __expected = 5;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new SoManyRectangles().maxOverlap(x1, y1, x2, y2);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    public bool Example4(bool fast = false)
    {
        Console.WriteLine("Example4");
        
        int[] x1 = new int[] { 0  };
        int[] y1 = new int[] { 0  };
        int[] x2 = new int[] { 1  };
        int[] y2 = new int[] { 1  };

        Console.WriteLine(string.Format("x1:{0}", string.Join(" ", x1)));
        Console.WriteLine(string.Format("y1:{0}", string.Join(" ", y1)));
        Console.WriteLine(string.Format("x2:{0}", string.Join(" ", x2)));
        Console.WriteLine(string.Format("y2:{0}", string.Join(" ", y2)));

        int __expected = 1;
        Console.WriteLine("Expected:{0}", __expected);
        int __result = new SoManyRectangles().maxOverlap(x1, y1, x2, y2);
        Console.WriteLine("__result:{0}", __result);
        return check(__expected, __result);
    }

    bool check(double ex, double res)
    {
        var d = Math.Abs(res - ex);
        if (d <= 1e-9) return true;
        d /= Math.Abs(ex);
        if (d <= 1e-9) return true;
        return false;
    }
    bool check(double[] ex, double[] res)
    {
        if (ex.Length != res.Length) return false;
        for (int i = 0; i < ex.Length; i++)
            if (!check(ex[i], res[i])) return false;
        return true;
    }
    bool check<T>(T ex, T res)
        where T : IComparable<T>
    {
        return ex.CompareTo(res) == 0;
    }
    bool check<T>(T[] ex, T[] res)
        where T : IComparable<T>
    {
        if (ex.Length != res.Length) return false;
        for (int i = 0; i < ex.Length; i++)
            if (!check(ex[i], res[i])) return false;
        return true;
    }
}
