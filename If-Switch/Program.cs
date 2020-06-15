using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace If_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            if (a > b)
                Console.WriteLine("a는 b보다 크다");

            if (a > b)
                Console.WriteLine("a는 b보다 크다");
            else
                Console.WriteLine("a는 b보다 크지 않다");


            if (a == b)
            {
                Console.WriteLine("a와 b는 같다");
            }
            else if (a < b)
            {
                Console.WriteLine("b는 a보다 크다");
            }
            else
            {
                Console.WriteLine("a는 b보다 크다");
            }


            int x = 15;
            switch (x)
            {
                case 10:
                    Console.WriteLine("x 는 10 이다");
                    break;

                case 15:
                    Console.WriteLine("x 는 15 이다");
                    break;
            }

            Console.WriteLine("\n");


            string str = "빨간색";
            switch (str)
            {
                case "빨간색":
                    Console.WriteLine("좋아 하는 색은? {0}", str);
                    break;
                case "노란색":
                    Console.WriteLine("좋아 하는 색은? {0}", str);
                    break;
                case "파란색":
                    Console.WriteLine("좋아 하는 색은? {0}", str);
                    break;
                default:
                    Console.WriteLine("좋아 하는 색이 없다");
                    break;
            }
        }
    }
}
