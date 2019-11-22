using System;
using System.IO;

namespace Counting_Valleys
{
    class Solution
    {
        // Complete the countingValleys function below.
        static int CountValleys(string steps)
        {
            int alt = 0;
            int valleys = 0;

            foreach (var step in steps)
            {
                var direction = (step == 'U' || step == 'u')
                    ? 1
                    : -1;

                if (direction < 0 && alt == 0)
                {
                    valleys++;
                }

                alt += direction;
            }

            return valleys;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();

            int result = CountValleys(s);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
