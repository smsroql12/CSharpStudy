using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //기본 배열 선언
            int[] array = new int[5];
            array[1] = 10;

            //배열 초기화
            int[] array1 = new int[] { 1, 3, 5, 7, 9 };

            //new 연산자 사용
            string[] weekDays = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            //new 연산자를 쓰지 않고
            int[] array2 = { 1, 3, 5, 7, 9 };
            string[] weekDays2 = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            int[] array3;
            array3 = new int[] { 1, 3, 5, 7, 9 };   // OK
            //array3 = {1, 3, 5, 7, 9};   // Error


            //2차원 배열
            int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            
            int[,] array2Da = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            
            string[,] array2Db = new string[3, 2] { { "one", "two" }, { "three", "four" }, { "five", "six" } };

            int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } },
                                 { { 7, 8, 9 }, { 10, 11, 12 } } };
            int[,,] array3Da = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } },
                                       { { 7, 8, 9 }, { 10, 11, 12 } } };

            // 출력
            System.Console.WriteLine(array2D[0, 0]);
            System.Console.WriteLine(array2D[0, 1]);
            System.Console.WriteLine(array2D[1, 0]);
            System.Console.WriteLine(array2D[1, 1]);
            System.Console.WriteLine(array2D[3, 0]);
            System.Console.WriteLine(array2Db[1, 0]);
            System.Console.WriteLine(array3Da[1, 0, 1]);
            System.Console.WriteLine(array3D[1, 1, 2]);



            //가변 배열
            //차원가 크기가 서로 다를 수 있다.
            int[][] arr = new int[2][];
            arr[0] = new int[5] { 1, 3, 5, 7, 9 };
            arr[1] = new int[4] { 2, 4, 6, 8 };


            int[][,] jaggedArray4 = new int[3][,]
            {
                new int[,] { {1,3}, {5,7} },
                new int[,] { {0,2}, {4,6}, {8,10} },
                new int[,] { {11,22}, {99,88}, {0,9} }
            };

            Console.WriteLine("{0}", jaggedArray4[0][1, 0]);


        }
    }
}
