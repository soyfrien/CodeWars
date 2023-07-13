namespace CodeWars;

public partial class Kata
{
    public class Cogs
    {
        /// <summary>
        /// You are given a list of cogs in a gear train
        /// Each element represents the number of teeth of that cog
        /// e.g. [100, 75] means 1st cog has 100 teeth, 2nd cog has 75 teeth...
        /// If the first cog rotates clockwise at 1 RPM what is the RPM of the final cog?
        /// (use negative numbers for anti-clockwise rotation)
        /// Notes: no two cogs share the same shaft
        /// </summary>
        /// <param name="cogs">List of tooth count for each cog in gear train.</param>
        /// <returns></returns>
        public static double CogRpm(int[] cogs)
        {
            double finalRpm = 1.0;
            List<double> ratios = new();

            for (int i = 0; i < cogs.Length - 1; i++)
                if (i % 2 is 0)
                    ratios.Add(Convert.ToDouble(-cogs[i]) / cogs[i + 1]);
                else
                    ratios.Add(Convert.ToDouble(cogs[i]) / -cogs[i + 1]);

            for (int i = 0; i < ratios.Count; i++)
                finalRpm *= ratios[i];

            return finalRpm;
        }
    }
}


// 100 75 50

