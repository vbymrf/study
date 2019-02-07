using System;
using System.Text.RegularExpressions;
using System.IO;

namespace Lesson6
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // 1. Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
                        Func.SaveFunc(new FuncD(Func.F1),"data.bin", -100, 100, 0.5,3);
            Console.WriteLine(Func.Load("data.bin"));
            Func.SaveFunc(new FuncD(Func.F2), "data.bin", -100, 100, 0.5, 3);
            Console.WriteLine(Func.Load("data.bin"));


            Console.ReadKey();
        }
    }
}
