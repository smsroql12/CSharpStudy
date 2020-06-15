using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Standard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");
            Console.Write("당신의 이름은 ? : ");
            string name = Console.ReadLine();
            Console.WriteLine("나의 이름은 " + name + " 입니다.");

            Console.WriteLine("\n자료형의 크기");
            Console.WriteLine("int 형 Max : {0} ~ Min : {1} / size : {2}byte", int.MaxValue, int.MinValue, sizeof(int));
            Console.WriteLine("float 형 Max : {0} ~ Min : {1} / size : {2}byte", float.MaxValue, float.MinValue, sizeof(float));
            Console.WriteLine("double 형 Max : {0} ~ Min : {1} / size : {2}byte", double.MaxValue, double.MinValue, sizeof(double));
            Console.WriteLine("decimal 형 Max : {0} ~ Min : {1} / size : {2}byte", decimal.MaxValue, decimal.MinValue, sizeof(decimal));


            int a = 5;
            int b = 3;
            Console.WriteLine("\n연산");
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
            Console.WriteLine("{0} % {1} = {2}", a, b, a % b);

            Console.WriteLine("\n실수 % 연산");
            float f1 = 3.141592f;
            float f2 = 2.141592f;
            float result = f1 % f2;
            Console.WriteLine("{0} % {1} = {2}", f1, f2, result);

            Console.WriteLine("\n할당 연산");
            Console.WriteLine("{0}", a += b);
            Console.WriteLine("{0}", a -= b);
            Console.WriteLine("{0}", a *= b);
            Console.WriteLine("{0}", a /= b);
            Console.WriteLine("{0}", a %= b);


            int x = 1;
            int y = 2;
            int z = 2;

            Console.WriteLine("\n논리 연산");
            Console.WriteLine("a > b = {0}", x > y);
            Console.WriteLine("a < b = {0}", x < y);
            Console.WriteLine();

            Console.WriteLine("a >= b = {0}", x >= y);
            Console.WriteLine("a <= b = {0}", x <= y);
            Console.WriteLine("b <= c = {0}", x <= z);
            Console.WriteLine();

            Console.WriteLine("a == b = {0}", x == y);
            Console.WriteLine("b == c = {0}", y == z);
            Console.WriteLine("a != b = {0}", x != y);
            Console.WriteLine("b != c = {0}", y != z);


            Console.WriteLine("\n이항 논리 연산");
            Console.WriteLine("논리곱(AND) 참 && 참 = {0}", true && true);
            Console.WriteLine("논리곱(AND) 참 && 거짓 = {0}", true && false);
            Console.WriteLine("논리곱(AND) 거짓 && 참 = {0}", false && true);
            Console.WriteLine("논리곱(AND) 거짓 && 거짓 = {0}", false && false);
            Console.WriteLine();

            Console.WriteLine("논리합(OR) 참 || 참 = {0}", true || true);
            Console.WriteLine("논리합(OR) 참 || 거짓 = {0}", true || false);
            Console.WriteLine("논리합(OR) 거짓 || 참 = {0}", false || true);
            Console.WriteLine("논리합(OR) 거짓 || 거짓 = {0}", false || false);
            Console.WriteLine();

            Console.WriteLine("부정(!) !참 = {0}", !true);
            Console.WriteLine("부정(!) !거짓 = {0}", !false);

            Console.WriteLine("\n비트 이항 연산자\na = 10, b = 5\n");
            byte t = 10;
            byte w = 5;
            string s = "";

            s = Convert.ToString(t, 2).PadLeft(8, '0');      //8자리의 비트로 표현하기 위해 사용한 코드
            Console.WriteLine("a     : {0}, Bit : {1} ", t, s);
            s = Convert.ToString(w, 2).PadLeft(8, '0');
            Console.WriteLine("b     : {0} , Bit : {1} ", w, s);
            Console.WriteLine();

            s = Convert.ToString(t & w, 2).PadLeft(8, '0');
            Console.WriteLine("a & b : {0} , Bit : {1} ", t & w, s);
            Console.WriteLine();

            s = Convert.ToString(t | w, 2).PadLeft(8, '0');
            Console.WriteLine("a | b : {0}, Bit : {1} ", t | w, s);
            Console.WriteLine();

            s = Convert.ToString(t ^ w, 2).PadLeft(8, '0');
            Console.WriteLine("a ^ b : {0}, Bit : {1} ", t ^ w, s);
            Console.WriteLine();

            s = Convert.ToString(t << 1, 2).PadLeft(8, '0');
            Console.WriteLine("a << 1 : {0}, Bit : {1}", t << 1, s);

            s = Convert.ToString(t << 2, 2).PadLeft(8, '0');
            Console.WriteLine("a << 2 : {0}, Bit : {1}", t << 2, s);
            Console.WriteLine();

            s = Convert.ToString(t >> 1, 2).PadLeft(8, '0');
            Console.WriteLine("a >> 1 : {0}, Bit : {1}", t >> 1, s);

            s = Convert.ToString(t >> 2, 2).PadLeft(8, '0');
            Console.WriteLine("a >> 2 : {0}, Bit : {1}", t >> 2, s);


            Console.WriteLine("\n증감 연산자");
            int v = 1;

            Console.WriteLine("현재 값      : {0}", v);
            Console.WriteLine();

            Console.WriteLine("전위 증가 값 : {0}", ++v);
            Console.WriteLine("후위 증가 값 : {0}", v++);
            Console.WriteLine("현재 값      : {0}", v);
            Console.WriteLine();

            Console.WriteLine("전위 감소 값 : {0}", --v);
            Console.WriteLine("후위 감소 값 : {0}", v--);
            Console.WriteLine("현재 값      : {0}", v);

            Console.WriteLine("\n삼항 연산자");
            int num1 = 10;
            int num2 = 20;
            int numTrue = 1;
            int numFalse = 0;

            int r = (num1 > num2) ? numTrue : numFalse;
            Console.WriteLine(r);
        }
    }
}
