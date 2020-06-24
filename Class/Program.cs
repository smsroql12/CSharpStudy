using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class
{
    class Program
    {
        class hero
        {
            public string sName;
            public int nHP;
            public int nPower;

            public void Attack(string target)
            {
                Console.WriteLine("{0}에 {1}의 데미지를 주었습니다.", target, nPower);
            }
        }

        static void Main(string[] args)
        {
            hero newHero = new hero();
            newHero.sName = "맥스";
            newHero.nHP = 10;
            newHero.nPower = 2;

            Console.WriteLine("이름 : {0}, 체력 : {1}, 공격력 : {2}", newHero.sName, newHero.nHP, newHero.nPower);
            newHero.Attack("허수아비");
        }
    }
}
