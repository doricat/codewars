// https://www.codewars.com/kata/spelling-bee/train/csharp

namespace Solutions
{
    public class SpellingBee
    {
        public static int HowManyBees(char[][] hive)
        {
            if (hive == null || hive.Length == 0)
                return 0;

            var count = 0;
            for (var i = 0; i < hive.Length; i++)
            {
                for (var j = 0; j < hive[i].Length; j++)
                {
                    if (hive[i][j] != 'b') continue;
                    if (j - 2 >= 0 && hive[i][j - 2] == 'e' && hive[i][j - 1] == 'e') count++;
                    if (i - 2 >= 0 && hive[i - 2][j] == 'e' && hive[i - 1][j] == 'e') count++;
                    if (j + 2 < hive[i].Length && hive[i][j + 1] == 'e' && hive[i][j + 2] == 'e') count++;
                    if (i + 2 < hive.Length && hive[i + 1][j] == 'e' && hive[i + 2][j] == 'e') count++;
                }
            }

            return count;
        }
    }
}