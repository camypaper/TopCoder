using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Debug = System.Diagnostics.Debug;
using StringBuilder = System.Text.StringBuilder;
public class ChangingChange
{
    public int[] countWays(int[] ways, int[] v, int[] k)
    {
        //çlé@
        //Ç±ÇÍÇÕñﬂÇ∑DPÇ…ÇµÇ©å©Ç¶Ç»Ç¢ÇÒÇ≈Ç∑Ç™ÇªÇÍÇÕÅc
        //dp[i][j]= dp[i-1][j]+dp[i][j-x]
        //dp[i-1][j]=dp[i][j]-dp[i][j-x]
        var q = v.Length;
        var ans = new int[q];
        var d = ways.Length - 1;
        var dp = new ModInteger[d + 1];
        for (int i = 0; i <= d; i++)
            dp[i] = ways[i];
        for (int i = 0; i < q; i++)
        {
            ans[i] = (int)f(dp, v[i], k[i]).num;
            if (ans[i] == 90406243)
            {
                Debug.WriteLine("{0} {1}", v[i], k[i]);
                f(dp, v[i], k[i]);
            }
        }
        return ans;
    }
    ModTable table = new ModTable(1000050);
    public ModInteger f(ModInteger[] dp, int v, int k)
    {
        var d = dp.Length - 1;
        ModInteger ret = 0;
        var i = 0;
        while (d - i * v >= 0)
        {

            var x = table.RepeatedCombination(k, i) * dp[d - i * v];
            if (i % 2 == 0) ret += x;
            else ret -= x;

            i++;
        }
        return ret;
    }
}
// CUT begin
public class Tester: AbstractTester
{
    static public T[] Enumerate<T>(int n, Func<int, T> f) { var a = new T[n]; for (int i = 0; i < n; ++i) a[i] = f(i); return a; }
    public Random rand = new Random(0);
    public Tester()
    {
        var a = new int[] { 1, 656198958, 661020929, 706614913, 873264677, 302425622, 15572766, 568772484, 421563791, 50767357, 113568099, 600235191, 117600364, 635897540, 928527201, 777970177, 875126110, 331738626, 981690526, 821620118, 231222805, 937199886, 910378636, 432585802, 624651188, 344030077, 131808243, 748383500, 627436238, 873983190, 27648877, 910033233, 443377927, 962392461, 396481250, 194669498, 231802010, 609494932, 503767869, 86562180, 364248841, 707371600, 159618807, 888799478, 701621995, 517301539, 613476842, 560559423, 2639341, 970158485, 611765979, 179858405, 734544263, 225995885, 61297603, 300595023, 735014220, 675139724, 795108824, 906539533, 249171782, 45306410, 956045723, 379703819, 412625757, 808561305, 743340289, 759012011, 456545386, 931768186, 13821941, 285025448, 580347632, 346261628, 985198530, 760843320, 775876654, 630646663, 161259464, 684749159, 45619043, 926642362, 920619522, 432125055, 95937012, 145093937, 999770283, 706898424, 482047335, 505442931, 940952187, 236431234, 803776362, 886208693, 90277649, 631401636, 79718402, 107705264, 888226459, 420826619, 403367181, 800167518, 152141786, 852369853, 924140064, 429047169, 226937598, 261074817, 678306691, 1335582, 493209388, 668302025, 70310750, 293405759, 947668401, 499376648, 220633063, 239001620, 317439027, 755010474, 466021875, 610518795, 167218952, 572515721, 860749106, 416985359, 252678686, 639154627, 274010011, 80034727, 143766089, 114257648, 358603750, 331868707, 455463410, 240826131, 716588169, 880728841, 453408655, 336753503, 570240731, 448065323, 176421236, 256186973, 982043995, 310799215, 856439692, 231384663, 310382591, 315946505, 808472112, 904571798, 567040927, 499388033, 749117258, 683662060, 704774547, 466083592, 457606255, 845797547, 907351330, 776377671, 180091910, 22366086, 650375410, 346524860, 521657972, 871845671, 755653660, 454673634, 834316393, 455741074, 413469550, 168338712, 475216227, 435378247, 759411067, 605967666, 311127424, 631567130, 182072354, 449838900, 545066186, 463204251, 270498749, 82125309, 426669695, 182177815, 176433740, 554994871, 123148448, 999930959, 133936853, 27141919, 218944109, 383381472, 290142564, 569484652, 580829116, 590422011, 333987340 };
        var b = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
        var c = new int[] { 849114, 195058, 461698, 250683, 618567, 343168, 377183, 206101, 808781, 6592, 329302, 429508, 983773, 631947, 675421, 687471, 205443, 30117, 256934, 502086, 167908, 70716, 667674, 184389, 103999, 721639, 9310, 483120, 301102, 420137, 118479, 319831, 323939, 815789, 29959, 554577, 578093, 336457, 330328, 644226, 451826, 232829, 688909, 653463, 905524, 547379, 864301, 670213, 998159, 881022, 56058, 549775, 502070, 797340, 263083, 46591, 884346, 485430, 696632, 710122, 905605, 99485, 326092, 468143, 440345, 445132, 150353, 223477, 235795, 669802, 95786, 265650, 716587, 115014, 594162, 211936, 751539, 691739, 715903, 334727, 999894, 863499, 510179, 457335, 809816, 283302, 356838, 605964, 882585, 109602, 535183, 663147, 614739, 916513, 881818, 169409, 359705, 530608, 316737, 635016, 63065, 239556, 805366, 285124, 718360, 320188, 934308, 828607, 104186, 875044, 828722, 618322, 632120, 77230, 681281, 289949, 629993, 788472, 572587, 934284, 482684, 750794, 187908, 793234, 799738, 574806, 722971, 137134, 449094, 94137, 899639, 524842, 197342, 711670, 952347, 596824, 292057, 245951, 254084, 598742, 925992, 541869, 998887, 619145, 951959, 280773, 436790, 239138, 321418, 520819, 968153, 97758, 309826, 892303, 768183, 559231, 490264, 168028, 792556, 297750, 840830, 473286, 801554, 128250, 482307, 32737, 720186, 9360, 865869, 333998, 853937, 801219, 979357, 854679, 732158, 403466, 807248, 744688, 184032, 458022, 214939, 390134, 410705, 536610, 346764, 834897, 666375, 351699, 520461, 924179, 990192, 873304, 928354, 351671, 917747, 225433, 378983, 844645, 633075, 351690 };
        test.ManualTest(a, b, c);

    }
}
// CUT end


#region ModNumber
public partial struct ModInteger
{
    public const long Mod = (long)1e9 + 7;
    public long num;
    public ModInteger(long n) : this() { num = n % Mod; if (num < 0) num += Mod; }
    public override string ToString() { return num.ToString(); }
    public static ModInteger operator +(ModInteger l, ModInteger r) { var n = l.num + r.num; if (n >= Mod) n -= Mod; return new ModInteger() { num = n }; }
    public static ModInteger operator -(ModInteger l, ModInteger r) { var n = l.num + Mod - r.num; if (n >= Mod) n -= Mod; return new ModInteger() { num = n }; }
    public static ModInteger operator *(ModInteger l, ModInteger r) { return new ModInteger(l.num * r.num); }
    public static ModInteger operator ^(ModInteger l, long r) { return ModInteger.Pow(l, r); }
    public static implicit operator ModInteger(long n) { return new ModInteger(n); }
    public static ModInteger Pow(ModInteger v, long k)
    {
        ModInteger ret = 1;
        var n = k;
        for (; n > 0; n >>= 1, v *= v)
        {
            if ((n & 1) == 1)
                ret = ret * v;
        }
        return ret;
    }
}
#endregion
#region Inverse
public partial struct ModInteger
{
    static public ModInteger Inverse(ModInteger v)
    {
        long p, q;
        ExGCD(v.num, Mod, out p, out q);
        return new ModInteger(p % Mod + Mod);
    }
    static public long ExGCD(long a, long b, out long x, out long y)
    {
        var u = new long[] { a, 1, 0 };
        var v = new long[] { b, 0, 1 };
        while (v[0] != 0)
        {
            var t = u[0] / v[0];
            for (int i = 0; i < 3; i++)
            {
                var tmp = u[i] - t * v[i];
                u[i] = v[i];
                v[i] = tmp;
            }
        }
        x = u[1];
        y = u[2];
        if (u[0] > 0)
            return u[0];
        for (int i = 0; i < 3; i++)
            u[i] = -u[i];
        return u[0];

    }
}
#endregion
#region ModTable
public class ModTable
{
    public ModInteger[] perm, inv;
    public ModTable(int n)
    {
        perm = new ModInteger[n + 1];
        inv = new ModInteger[n + 1];
        perm[0] = 1;
        for (int i = 1; i <= n; i++)
            perm[i] = perm[i - 1] * i;
        inv[n] = ModInteger.Inverse(perm[n]);
        for (int i = n - 1; i >= 0; i--)
            inv[i] = inv[i + 1] * (i + 1);
        inv[0] = inv[1];
    }
    public ModInteger Inverse(int k) { return inv[k]; }
    public ModInteger Permutation(int n, int k)
    {
        if (n < 0 || n >= perm.Length)
            return 0;
        if (k < 0 || k >= n)
            return 0;
        return perm[n] * inv[n - k];
    }
    public ModInteger Combination(int n, int r)
    {
        if (n < 0 || n >= perm.Length || r < 0 || r > n) return 0;
        return perm[n] * inv[n - r] * inv[r];
    }
    public ModInteger RepeatedCombination(int n, int k)
    {
        if (k == 0) return 1;
        return Combination(n + k - 1, k);
    }
}
#endregion