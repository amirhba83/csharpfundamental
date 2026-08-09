using System.Diagnostics.Metrics;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int [] scores = { 15, 18, 12, 20, 9, 17, 14, 19, 11, 16 };
            Console.WriteLine($"Number of scores: {scores.Length}");            
            //--
            // find the biggest number
            int biggest = scores [0]; 
            foreach(int score in scores)
            {
                if (score > biggest)
                    biggest = score;
            }
            Console.WriteLine($"max is {biggest}");
            //--
            // find the smallest number
            int smallest = scores[0];
            foreach (int score in scores)
            {
                if (score < smallest)
                    smallest = score;
            }
            Console.WriteLine($"min is {smallest}");
            // 
            // calculate avg
            int sum = 0;
            foreach (int score in scores)
            {
                sum += score;
            }
            double avg = (double)sum / scores.Length;
            Console.WriteLine($"average is {avg}");
            //--
            // count of 10+
            int count = 0;
            foreach (int score in scores)
            {
                if (score >= 10)
                    count++;
            }
            Console.WriteLine($"pass count {count}");
            //--
            //sort 
            System.Array.Sort( scores );// focus on choosing name for project
            Console.WriteLine("sorted scores");
            foreach (int score in scores)
            {
                Console.Write($"{score},");
            }

            //-----------------------------------------------------------------------
            // second practice 
            int[] scores_2 = { 12, 5, 8, 20, 15, 20, 3, 17 };
            // find the biggest number
            int biggest_2 = scores_2[0];
            foreach (int score in scores_2)
            {
                if (score > biggest_2)
                    biggest_2 = score;
            }
            Console.WriteLine($"\nmax is {biggest_2}");
            // find the biggest second  number
            //System.Array.Sort( scores_2 );
            //System.Array.Reverse(scores_2);
            int secondBiggest = scores_2[0];
            foreach (int score in scores_2)
            {
                if (score > secondBiggest && score != biggest_2)
                {
                    secondBiggest = score;  
                }
            }
            Console.WriteLine($"the second biggest number is {secondBiggest}");
            //
            int biggestCount = 0;   
            foreach (int score in scores_2)
            {
                if (score == biggest_2)
                    biggestCount ++;
            }
            Console.WriteLine($"count of {biggest_2} (the biggest number) is {biggestCount}");
            //


        }
    }
}
