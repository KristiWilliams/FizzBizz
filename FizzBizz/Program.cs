using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBizz
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int currantnumber = 1; currantnumber < 101; currantnumber++)
            {
                if (0 == currantnumber % 15)
                {
                 Console.WriteLine("FizzBizz");
                }
                else if (0 == currantnumber % 5)
                {
                 Console.WriteLine("Buzz");
                }
                else if (0 == currantnumber % 3)
                {
                 Console.WriteLine("Fizz");
                }
                else
                {
                 Console.WriteLine(currantnumber);
                }
            }
                 Console.ReadLine();







        }
    }
}
