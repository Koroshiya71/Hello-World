using System;
using System.Diagnostics.CodeAnalysis;
using System.Security;
using System.Threading;

namespace _8._6
{
    class Chickens
    {
        
        static void Main(string[] args)
        {
            int a, b, c;
            for (int i = 0; i <= 20; i++)
            {
                for (int j = 0; j < 34; j++)
                {
                    for (int k = 0; k <= 100; k++)
                    {
                        if ((5 * i + 3 * j + k == 100) && (i + j + k * 3 == 100))
                        {
                            Console.WriteLine(i+"只公鸡，"+j+"只母鸡，"+3*k+"只小鸡");
                        }
                    }
                }
            }
        }
    }
}
