using System;
using System.IO;

namespace Diagonal_Difference
{
    class Program
    {
        // Complete the diagonalDifference function below.
        static int diagonalDifference(int[][] arr)
        {
            int result = 0;
            int it = arr.Length;

            for (int i = 0; i < arr.Length; i++)  result += arr[i][--it] - arr[i][i];

            return result;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[][] arr = new int[n][];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = diagonalDifference(arr);


            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
