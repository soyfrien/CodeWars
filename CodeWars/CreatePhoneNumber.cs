using System.Text;

namespace CodeWars;

public partial class Kata
{
    /// <summary>
    /// Write a function that accepts an array of 10 integers (between 0 and 9),
    /// that returns a string of those numbers in the form of a phone number.
    /// 
    /// Example: 
    /// <code> 
    /// CreatePhoneNumber(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0}) // => returns "(123) 456-7890"
    /// </code>
    /// </summary>
    public static string CreatePhoneNumber(int[] numbers)
    {
        if (numbers.Length != 10)
            return "Phone number must be 10 digits.";

        string numbersAsString = string.Empty;
        foreach (int number in numbers)
            numbersAsString += number;

        char[] numbersAsCharArray = numbersAsString.ToCharArray();

        StringBuilder sb = new();
        sb.Append("(")
            .Append(numbersAsCharArray, 0, 3)
            .Append(") ")
            .Append(numbersAsCharArray, 3, 3)
            .Append("-")
            .Append(numbersAsCharArray, 6, 4);

        return sb.ToString();
    }
}
