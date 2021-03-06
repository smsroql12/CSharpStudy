﻿using System;
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

        //call by value
        static void cPlus(int a)
        {
            a += 323;
        }
        //call by reference
        static void cPlus(ref int a)
        {
            a += 814;
        }

        static public void init(out int num1)
        {
            num1 = 100;
        }

        static void Swap(ref int x, ref int y)
        {
            int temp = x;

            x = y;

            y = temp;
        }

        static void Plus(params object[] obj)
        {
            for (int i = 0; i < obj.Length; i++)
            {
                Console.Write("obj[{0}] : {1}", i, obj[i]);
                Console.WriteLine();
            }
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

            int num = 100;
            init(out num);
            Console.WriteLine("{0}", num);

            int x = 10;
            int y = 5;

            Swap(ref x, ref y);
            Console.WriteLine("x:{0},y:{1}", x, y);

            object[] objArray = { 777, 888, 'k', "test" };
            Plus(objArray);

        }

    }
}
