using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static bool IsOdd(int n)
        {
            if (n % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public static bool IsEven(int n)
        {
            if (n % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public static bool IsPrime(int n)
        {   
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                return true;
            }
            return false;
        }

        public void int Square (int n)
        {
            return n*n;
        }

    }
}
