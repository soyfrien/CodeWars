using System.Text;

namespace CodeWars;

public static partial class Kata
{
    /// <summary>
    /// Usually when you buy something, you're asked whether your credit card number, phone number
    /// or answer to your most secret question is still correct. However, since someone could look 
    /// over your shoulder, you don't want that shown on your screen.  Instead, we mask it.
    /// Your task is to write a function maskify, which changes all but the last four characters into '#'.
    /// 
    /// <code>
    /// Kata.Maskify("4556364607935616"); // should return "############5616"
    /// Kata.Maskify("64607935616");      // should return "#######5616"
    /// Kata.Maskify("1");                // should return "1"
    /// Kata.Maskify("");                 // should return ""
    /// 
    /// // "What was the name of your first pet?"
    /// Kata.Maskify("Skippy");                                   // should return "##ippy"
    /// Kata.Maskify("Nananananananananananananananana Batman!"); // should return "####################################man!"
    /// </code>
    /// </summary>
    public static string Maskify(string cc)
    {
        if (cc.Length > 4)
        {
            StringBuilder sb = new();
            sb.Append('#', cc.Length - 4)
                .Append(cc.AsSpan(cc.Length - 4, 4)); //.NET6: .Append(cc.Substring(cc.Length - 4, 4));
            cc = sb.ToString();
        }

        return cc;
    }
}
