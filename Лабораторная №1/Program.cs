using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная__1
{
    class Program
    {


        static void ggg()
        {
            Console.WriteLine("Лабораторная работа №1");
            Console.WriteLine("");
            Console.WriteLine("Выполнил: Ислам Абдуразаков");
            Console.WriteLine("Группа:ИНС-19-1(2)");
            Console.WriteLine();
        }



        static void ooo()
        {
            int a;
            int b = 7;
            string str = "Hello World!!!";
            a = 123;
            Console.WriteLine("Значение перемнной а равно {0}", a);
            Console.WriteLine("a значение переменнной b равно {0}", b);
            Console.WriteLine("значение a+b = {0}+{1} = {2} ", a, b, a + b);
            Console.WriteLine(str);

            //Инвдивидуальное задание

            int w111 = 100, w = 10, bt = 35, x = 1, y = 2;
            int Se = 0;
            Se = w111 + bt - x + (y * w);
            Console.WriteLine("Индивидуальное задание");
            Console.WriteLine("Se=w111+bt-x+y*w={0}", Se);
        }

        static void Main(string[] args)
        {
            ggg();

            ooo();

            Console.ReadKey();


        }

    }
}
