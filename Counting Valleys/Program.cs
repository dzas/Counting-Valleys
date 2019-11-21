using System;
using System.IO;

namespace Counting_Valleys
{
    class Solution
    {
        // Complete the countingValleys function below.
        static int countingValleys(int n, string s)
        {
            int alt = 0;
            int prevAlt = 0;
            int zeroLevel = 0;
            int valleys = 0;

            foreach (var step in s)
            {
                prevAlt = alt;
                var direction = (step == 'U' || step == 'u')
                    ? 1
                    : -1;

                alt += direction;

                if (alt < zeroLevel && prevAlt < zeroLevel)
                {
                    valleys++;
                }
            }
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();

            int result = countingValleys(n, s);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
