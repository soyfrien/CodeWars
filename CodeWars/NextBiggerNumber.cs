using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeWars;

public partial class Kata
{  
    public static long NextBiggerNumber(long n)
    {
        long number = Convert.ToInt64(n.ToString());
        long nextNumber = number;
        long maximumNumbers = Factorial(n.ToString().ToCharArray().Length);
        bool isNextNumber = false;
        List<long> numbers = new();
        Dictionary<int, int> valueCounts = new(GetDigitValueCounts(number));

        if (valueCounts.Count > 0)
        {
            numbers.Add(n);
            while (!isNextNumber)
            {
                isNextNumber = SetIsNextNumber(++nextNumber, valueCounts);
                if(isNextNumber)
                {
                    numbers.Add(nextNumber);
                    if (maximumNumbers > 2 && numbers.Count == maximumNumbers)
                        return -1;
                }
                if (maximumNumbers < Factorial(nextNumber.ToString().ToCharArray().Length))
                    return -1;
            }
        }
        else
            return -1;

        return nextNumber;
    }

    private static long Factorial(int length)
    {
        int x = 1;
        for (int i = length; i > 0; i--)
            x *= i;

        return x;
    }

    private static bool SetIsNextNumber(long nextNumber, Dictionary<int, int> valueCounts)
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


    private static Dictionary<int, int> GetDigitValueCounts(long number)
    {
        Dictionary<int, int> valueCounts = new();
        foreach (char c in number.ToString().ToCharArray())
            if (valueCounts.ContainsKey(c))
                valueCounts[c] += 1;
            else
                valueCounts.Add(c, 1);


        return valueCounts;
    }
        /* switch (Convert.ToInt64(c))
            {
                case '0':
                    if (!valueCounts.ContainsKey(c))
                        valueCounts.Add(c, 1);
                    else
                        valueCounts[c] += 1;
                    break;
                case '1':
                    if (!valueCounts.ContainsKey(c))
                        valueCounts.Add(c, 1);
                    else
                        valueCounts[c] += 1;
                    break;
                case '2':
                    if (!valueCounts.ContainsKey(c))
                        valueCounts.Add(c, 1);
                    else
                        valueCounts[c] += 1;
                    break;
                case '3':
                    if (!valueCounts.ContainsKey(c))
                        valueCounts.Add(c, 1);
                    else
                        valueCounts[c] += 1;
                    break;
                case '4':
                    if (!valueCounts.ContainsKey(c))
                        valueCounts.Add(c, 1);
                    else
                        valueCounts[c] += 1;
                    break;
                case '5':
                    if (!valueCounts.ContainsKey(c))
                        valueCounts.Add(c, 1);
                    else
                        valueCounts[c] += 1;
                    break;
                case '6':
                    if (!valueCounts.ContainsKey(c))
                        valueCounts.Add(c, 1);
                    else
                        valueCounts[c] += 1;
                    break;
                case '7':
                    if (!valueCounts.ContainsKey(c))
                        valueCounts.Add(c, 1);
                    else
                        valueCounts[c] += 1;
                    break;
                case '8':
                    if (!valueCounts.ContainsKey(c))
                        valueCounts.Add(c, 1);
                    else
                        valueCounts[c] += 1;
                    break;
                case '9':
                    if (!valueCounts.ContainsKey(c))
                        valueCounts.Add(c, 1);
                    else
                        valueCounts[c] += 1;
                    break;
            } */

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
