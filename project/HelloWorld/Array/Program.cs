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

        }
    }
}
