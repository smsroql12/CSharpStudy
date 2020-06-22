using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Method
{
    class Program
    {
        //Static 함수
        static int Plus(int a, int b)
        {
            int result = a + b;
            return result;
        }

        static int oPlus(int a, int b)
        {
            int result = a + b;
            return result;
        }
        static float oPlus(float a, float b)
        {
            float result = a + b;
            return result;
        }

        static void Main(string[] args)
        {
            //Static 함수 사용
            int result = Plus(10, 20);
            Console.WriteLine(result);

            /* 오버로딩 */
            int nPlus = oPlus(10, 20);
            Console.WriteLine(nPlus);

            float fPlus = oPlus(1.4f, 2.423f);
            Console.WriteLine(fPlus);
        }

    }
}
