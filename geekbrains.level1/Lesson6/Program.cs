using System;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections;
using System.Drawing;

namespace Lesson6
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // 1. Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
                        Func.SaveFuncF1("data.bin", -100, 100, 0.5,3);
            Console.WriteLine(Func.Load("data.bin"));
            Func.SaveFuncF2( "data.bin", -100, 100, 0.5, 3);
            Console.WriteLine(Func.Load("data.bin"));
            // Через делегаты
            Func.SaveFunc(new FuncD(Func.F2),"data.bin", -100, 100, 0.5, 3);
            Console.WriteLine(Func.Load("data.bin"));
            Func.SaveFunc(Func.F2,"data.bin", -100, 100, 0.5, 3);
            Console.WriteLine(Func.Load("data.bin"));
            /* 2. 2. Модифицировать программу нахождения минимума функции так, чтобы можно было                  
            передавать функцию в виде делегата.
            а) Сделать меню с различными функциями и представить пользователю выбор, для какой
функции и на каком отрезке находить минимум.Использовать массив(или список) делегатов,                        
в котором хранятся различные функции.
б) *Переделать функцию Load, чтобы она возвращала массив считанных значений.Пусть она
возвращает минимум через параметр(с использованием модификатора out).  */
            ArrayList fun = new ArrayList();
            fun.Add(new FuncD(Func.F));
            fun.Add(new FuncD(Func.F1));
            fun.Add(new FuncD(Func.F2));
            Console.WriteLine("Укажите функцию 1=x * x-50*x+10 ; 2=a*x^2 ; 3=a*sin(x)");
            int funcF =int.Parse(Console.ReadLine())-1;
            Console.WriteLine("Задайте диапазоны от A до B шаг H и число Ax ввиде: A B H Ax ");
            double[] per= Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);
            Func.SaveFunc((FuncD)fun[funcF], "data.bin",per[0],per[1],per[2],per[3]);
            Console.WriteLine(Func.Load("data.bin"));
            double min; //б вариант
            double[] mas = Func.LoadWriteLine("data.bin", out min);
            
        }
    }
}
