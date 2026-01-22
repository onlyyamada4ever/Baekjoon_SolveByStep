using System;
using System.Text;

namespace Baekjoon
{
    class Baekjoon10871
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            string[] q = Console.ReadLine().Split();

            StringBuilder answer = new StringBuilder();

            for (int i = 0; i < int.Parse(s[0]); i++)
            {
                if (int.Parse(s[1]) > int.Parse(q[i]))
                {
                    answer.Append(q[i] + " ");
                }
            }
            Console.WriteLine(answer.ToString());
        }
    }
}
