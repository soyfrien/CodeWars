namespace CodeWars;

public partial class Kata
{
    public static long NextBiggerNumber(long n)
    {
        char[] characters = n.ToString().ToCharArray();
        int digits = characters.Length;

        for (int d = 0; d <= digits; d++)
            for (int i = characters.Length - 1; i >= 1; i--)
                if (characters[i] > characters[i - 1])
                {
                    char temp = characters[i - 1];
                    characters[i - 1] = characters[i];
                    characters[i] = characters[characters.Length - 1];
                    characters[characters.Length - 1] = temp;

                    return Convert.ToInt64(new string(characters));
                }

        return -1;
    }
}
