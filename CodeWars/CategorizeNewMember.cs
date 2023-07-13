namespace CodeWars;

public partial class Kata
{
    /// <summary>
    /// The Western Suburbs Croquet Club has two categories of membership, Senior and Open. 
    /// They would like your help with an application form that will tell prospective members which category they will be placed.
    /// To be a senior, a member must be at least 55 years old and have a handicap greater than 7. 
    /// In this croquet club, handicaps range from -2 to +26; the better the player the lower the handicap.
    /// Input will consist of a list of pairs. Each pair contains information for a single potential member. Information consists of an integer for the person's age and an integer for the person's handicap.
    /// Output will consist of a list of string values(in Haskell and C: Open or Senior) stating whether the respective member is to be placed in the senior or open category.
    /// Example
    /// <code>
    /// input =  [[18, 20], [45, 2], [61, 12], [37, 6], [21, 21], [78, 9]]
    /// output = ["Open", "Open", "Senior", "Open", "Open", "Senior"]
    /// </code>
    /// </summary>
    /// <param name="data">Player [age (valid range: 55+][handicap (valid range: -2 to 26)]</param>
    /// <returns>Open or Senior status as list of strings for each player.</returns>
    /// <exception cref="NotImplementedException"></exception>
    public static IEnumerable<string> OpenOrSenior(int[][] playerData)
    {
        List<string> playerStatuses = new();

         foreach (int[] player in  playerData)
            if ((player[0] >= 55) && (player[1] > 7))
                playerStatuses.Add("Senior");
            else
                playerStatuses.Add("Open");

        return playerStatuses;
    }
    
    // https://www.codewars.com/kata/reviews/59ad2a3e4708a2fb7e0008ff/groups/59ad51a81defc89969001c8a
    public static IEnumerable<string> OpenOrSeniorLinq(int[][] playerData)
    {
        return playerData.Select(x => (x[0] >= 55 && x[1] > 7) ? "Senior" : "Open");
    }


    // https://www.codewars.com/kata/reviews/59ad2a3e4708a2fb7e0008ff/groups/5a973974a7dfad825e0016e2
    public static IEnumerable<string> OpenOrSeniorAlt(int[][] playerData)
    {
        foreach (int[] player in playerData)
            if (player[0] >= 55 && player[1] > 7)
                yield return "Senior";
            else
                yield return "Open";
    }

    // https://www.codewars.com/kata/reviews/59ad2a3e4708a2fb7e0008ff/groups/5ab4f390c7245486ad0035a2
    public static IEnumerable<string> OpenOrSeniorWhat(int[][] playerData)    
    {
        return playerData.Select(Categorize);

    }

    private static string Categorize(int[] data)
    {
        if (data.Length != 2)
            throw new ArgumentOutOfRangeException(nameof(data), "The input should contain exactly 2 elements");

        if (data[0] >= 55 && data[1] > 7)
            return "Senior";
        else
            return "Open";
    }
}
