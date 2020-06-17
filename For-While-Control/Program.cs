using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace For_While_Control
{
    class Program
    {
        static void Main(string[] args)
        {
            //Default For Loop
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Num : {0}", i);
            }

            //2중 For Loop
            for (int i = 1; i < 2; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    Console.WriteLine("{0} * {1} = {2}", i, j, i * j);
                }
            }

            int[] nArr = { 1, 3, 5, 7, 9, 2, 4, 6, 8 };
            int nIndex = 0;

            //Foreach
            foreach (int i in nArr)
            {
                Console.WriteLine("nArr[{0}] = {1}", nIndex++, i);
            }

            //While
            int nNum = 0;
            while (true)
            {
                Console.WriteLine("nNum : {0}", nNum++);

                if (nNum >= 5)
                    break;
            }

            nNum = 0;
            
            while (nNum < 5)
            {
                Console.WriteLine("nNum : {0}", nNum++);
            }

            //Do-While 무조건 1번 이상 실행
            do
            {
                Console.WriteLine("nNum : {0}", nNum--);
            }
            while (nNum > 0);

            int a = 0;

            AAA:
            Console.WriteLine("AAA : {0}", a);
            a++;

            if (a == 5)
                goto BBB;

            goto AAA;
            BBB:

            Console.WriteLine();
            Console.WriteLine("BBB : {0}", a);
        }
    }
}
