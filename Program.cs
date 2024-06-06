namespace Assignment5._3._2
{
    internal class Program
    {

            public static int ClimbStairs(int n)
            {
                if (n == 1)
                {
                    return 1;
                }

                int[] ways = new int[n + 1];
                ways[1] = 1;
                ways[2] = 2;

                for (int i = 3; i <= n; i++)
                {
                    ways[i] = ways[i - 1] + ways[i - 2];
                }

                return ways[n];
            }
        static void Main(string[] args)
        { 
            int result = ClimbStairs(5);
            Console.WriteLine(result);
        }
    }
}
