using System;
using System.ComponentModel;


namespace Csharpproject
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int ReversedNum;

            Console.Write("Enter number :   ");
            num = Convert.ToInt32(Console.ReadLine());

            ReversedNum = Reverse(num);

            if (ReversedNum == 0)
            {
                Console.WriteLine("this number is not in range of -2^31 -- 2^31");
            }
            else
            {
                Console.WriteLine($"{num}   reversed is   {ReversedNum}");
            }
        }
        static int Reverse(int x) 
        {
            string n = Convert.ToString(x);
            char[] result = new char[n.Length];

            if(n[0] != '-')
            {
                for(int i = 0; i < n.Length; i++)
                {
                    result[i] = n[n.Length - 1 - i];
                }
            }
            else
            {
                for(int i = 0; i < n.Length; i++)
                {
                    result[i] = n[n.Length - 1 - i];
                }

                for (int i = n.Length - 2; i > -1; i--)
                {
                    char K = result[i];
                    result[i] = result[i + 1]; 
                    result[i + 1] = K;
                    Console.WriteLine(result);
                }
            }

            long r = Convert.ToInt64(new string(result));

             if (r < -Math.Pow(2,31) || r > Math.Pow(2,31) - 1)
            {
                return 0;
            }
            else
            {
                return (int)r; 
            }
            
        }
    }
}