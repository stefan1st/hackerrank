using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Compare_the_Triplets
{
    class Program
    {
        class Program
        {
            // Complete the compareTriplets function below.
            static List<int> compareTriplets(List<int> a, List<int> b)
            {
                var result = new List<int>();
                var aCount = a.Count();
                var bCount = b.Count();

                int aScore = 0;
                int bScore = 0;

                if (aCount != bCount)
                    throw new IndexOutOfRangeException("Lists are not equal");
                for (int i = 0; i < aCount; i++)
                {
                    if (a[i] != b[i] && a[i] > b[i]) aScore++;
                    if (a[i] != b[i] && a[i] < b[i]) bScore++;
                }

                result.Add(aScore);
                result.Add(bScore);

                return result;
            }

            static void Main(string[] args)
            {
                TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

                List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

                List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

                List<int> result = compareTriplets(a, b);

                textWriter.WriteLine(String.Join(" ", result));

                textWriter.Flush();
                textWriter.Close();
            }
        }
    }
}
