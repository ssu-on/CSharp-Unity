using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//연습문제 구구단
namespace CSharp
{
    class Test1
    {
        static void Main(string[] args)
        {
            for(int i = 2; i <= 9; i++)
            {
                for(int j = 2; j <= 9; j++)
                {
                    Console.WriteLine($"{i}*{j} = {i * j}");
                }
            }
        }

    }
}
