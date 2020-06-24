using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class
{
    class myclass
    {
        private int age;
        private string name;
        public myclass(int a, string b)
        {
            age = a;
            name = b;
        } 

        public void meow()
        {
            Console.WriteLine(name + "(" + age + ")" + " : Moew~");
        }
        ~myclass()
        {
            Console.WriteLine(name + " 사라짐(소멸)");
        }
    }
}
