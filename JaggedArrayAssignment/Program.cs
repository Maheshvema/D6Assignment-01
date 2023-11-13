using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JaggedArrayAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] StudentScores = new int[3][]
            {
                new int[3] {85,92,78},
                new int[4] {90,87,93,89},
                new int[2] {76,88}
            };
            for (int i= 0;i<StudentScores.Length;i++) 
            {
                Console.Write($"student {i+1} scores:");
                foreach (int scores in StudentScores[i] ) 
                {
                    Console.Write(scores+" \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("average of the scores for each student:");
            
            for (int i = 0; i < StudentScores.Length; i++)
            {
                int sum = 0;
                Console.Write($"Average of the studentscores {i + 1}  ");
                foreach (int score in StudentScores[i])
                {
                    
                    sum += score;
                }
                double AverageScore = sum / (double)StudentScores[i].Length;
                Console.WriteLine($"{AverageScore}");
            }
            Console.WriteLine("Average of the all students marks");
            int totalSum = 0;
            int totalLength = 0;
            foreach (int[] scores in StudentScores)
            {
                totalSum += scores.Sum();
                totalLength += scores.Length;
            }
            double totalAverage = totalSum / (double)totalLength;
            Console.WriteLine($"{totalAverage}");
            Console.ReadKey();
        }
    }
}
