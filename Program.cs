using System;
using System.Linq;

namespace Tech
{
    class Program
    {
        static int max = -1;
        static int n = -1;
        static int[] rands;

        static void Main(string[] args)
        {
            while (!ReadInput()) {}
            //max = 50;
            //n = 5;
            GenerateRandom();
            WriteRandom();
        }

        private static void GenerateRandom()
        {
            var rand = new Random();
            rands = new int[n];

            for (int i = 0; i <= n - 1; i++)
            {
                rands[i] = rand.Next((-1) * max, max);
                Console.Write(rands[i] + " ");
            }
            Console.WriteLine("");
        }

        private static void WriteRandom()
        {
            int min = rands.Min();
            int sum = 0;
            for (int i = 0; i <= rands.Length - 1; i++)
            {
                sum = sum + rands[i];
                if (rands[i] == min)
                {
                    Console.Write("-(" + rands[i] + ")");
                    sum = sum + rands[i] * (-2);
                }
                else
                {
                    Console.Write(rands[i] >= 0 && i > 0 ? "+" : "");
                    Console.Write(rands[i]);
                }
            }
            Console.Write("=" + sum);

        }

        private static bool ReadInput()
        {
            string tmp;
            string[] tmp2;
            tmp = Console.ReadLine();
            if (tmp.Length > 0)
            {
                tmp2 = tmp.Split(" ");
                if (tmp2.Length == 2)
                {
                    int.TryParse(tmp2[0], out max);
                    int.TryParse(tmp2[1], out n);
                }
            }
 
            if ((max >= 1000 || max <= 0) || (n >= 100 || n <= 0))
            {
                Console.WriteLine("It does not meet the conditions");
                return false;
            }
            return true;
        }
    }
}
