using System;

namespace pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 5;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = k; j >= 1; j--)
                {
                    Console.Write(j);
                }
                k--;
                    Console.WriteLine("     ");
            }
        }    
    }
}
