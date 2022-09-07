using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            int num, num2,num3;
            Console.WriteLine("Enter two number");
            Console.WriteLine("1-->Add   2-->sub   3-->mul  4-->Div");
            num = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    int sum = num3 + num2;
                    Console.WriteLine($"Addition is{sum}");
                    break;
                case 2:
                    int sub = num2 - num3;
                    Console.WriteLine($"subtrastion is {sub}");
                    break;



            }

        }

    }
}
