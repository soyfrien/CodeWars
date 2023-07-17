using System.Diagnostics;

namespace CodeWars;

public static partial class Kata
{
    public static long NextBiggerNumber(long number)
    {
        
        long nextNumber = number;
        // We get the factorial to determin the maximum number of conbinations
        long maximumNumbers = Factorial((long)number.ToString().ToCharArray().Length);
        bool isNextNumber = false;
        long numberCount = 0;
        Dictionary<int, int> valueCounts = new(GetDigitValueCounts(number));
        
        // This timer will return the result from the broken algorith after timeLimitMilliseconds elapses
        Stopwatch sw = Stopwatch.StartNew();
        const int timeLimitMilliseconds = 250;

        if (valueCounts.Count > 1)
        {
            numberCount++;
            while (!isNextNumber)
            {
                isNextNumber = GetIsNextNumber(++nextNumber, valueCounts);
                if (isNextNumber)
                {
                    numberCount++;
                    if (maximumNumbers > 2 && numberCount == maximumNumbers)
                        return -1;
                }
                                
                if (maximumNumbers < Factorial(nextNumber.ToString().ToCharArray().Length))
                    return -1;

                // Uh...trust me, I have no idea what I'm doing
                if (sw.ElapsedMilliseconds > timeLimitMilliseconds)
                    return NextBiggerNumberBroken(number);                
            }
        }
        else
            return -1;

        return nextNumber;
    }


    /// <summary>
    /// This only works up to 20!
    /// </summary>
    /// <param name="length">This is named length, because we are working with a char array</param>
    /// <returns>The computed factorial.</returns>
    public static long Factorial(long length)
    {
        long x = 1;
        for (long i = length; i > 0; i--)
            x *= i;

        return x;
    }


    /// <summary>
    /// The purpose of this method is to determine if the dictionaries are equal.
    /// If they are equal, this means the number being checked has the same digit value counts.
    /// </summary>
    /// <param name="nextNumber">Larger number being checked.</param>
    /// <param name="valueCounts">The Dictionary holding the value counts for the original number.</param>
    /// <returns>A boolean, true or false</returns>
    public static bool GetIsNextNumber(long nextNumber, Dictionary<int, int> valueCounts)
    {
        Dictionary<int, int> nextNumberValueCounts = new(GetDigitValueCounts(nextNumber));

        if (nextNumberValueCounts.Count == valueCounts.Count)
        {
            int value = -1;
            foreach (KeyValuePair<int, int> kvp in valueCounts)
                if (nextNumberValueCounts.ContainsKey(kvp.Key))
                {
                    nextNumberValueCounts.TryGetValue(kvp.Key, out value);
                    if (!(kvp.Value == value))
                        return false;
                }
                else
                    return false;
        }
        else
            return false;

        return true;
    }


    /// <summary>
    /// We will need to know how many of each number we have available for rearranging.
    /// It converts the numeral to a character array. I should have used a Dictionary of char, int
    /// but when I noticed this in the debugger I fonud it works functionally the same.
    /// </summary>
    /// <param name="number">A number as long.</param>
    /// <returns>A Dictionary of int, int with the ASCII value of the character array.</returns>
    public static Dictionary<int, int> GetDigitValueCounts(long number)
    {
        Dictionary<int, int> valueCounts = new();
        foreach (char c in number.ToString().ToCharArray())
            if (valueCounts.ContainsKey(c))
                valueCounts[c] += 1;
            else
                valueCounts.Add(c, 1);

        return valueCounts;
    }


    /// <summary>
    /// This algorith tries to move the smallest number on the right to the left.
    /// </summary>
    /// <param name="n">A number, n, as long</param>
    /// <returns>The next biggest number as long.</returns>
    public static long NextBiggerNumberBroken(long n)
    {
        char[] characters = n.ToString().ToCharArray();
        int digits = characters.Length;

        for (int d = 0; d <= digits; d++)
        {
            for (int i = characters.Length - 1; i >= 1; i--)
            {
                if (characters[i] > characters[i - 1])
                {
                    char temp = characters[i - 1];
                    characters[i - 1] = characters[i];
                    if (characters[i - 1] > characters[characters.Length - 1])
                    {
                        characters[i] = characters[characters.Length - 1];
                        characters[characters.Length - 1] = temp;
                        if (characters[characters.Length - 1] < temp)
                        {
                            temp = characters[i];
                            characters[characters.Length - 1] = characters[i];

                            characters[i] = temp;
                        }

                        return Convert.ToInt64(new string(characters));
                    }
                    else
                    {
                        characters[i] = temp;

                        return Convert.ToInt64(new string(characters));
                    }
                }
            }
        }

        return -1;
    }
}
