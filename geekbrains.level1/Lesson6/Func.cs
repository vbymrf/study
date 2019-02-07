﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/*
 * 1. Изменить программу вывода таблицы функции так, чтобы можно было передавать функции                      
типа double (double, double). Продемонстрировать работу на функции с функцией a*x^2 и                        
функцией a*sin(x). 
*/
/*
 * 2. Модифицировать программу нахождения минимума функции так, чтобы можно было                  
передавать функцию в виде делегата.  
а) Сделать меню с различными функциями и представить пользователю выбор, для какой                        
функции и на каком отрезке находить минимум. Использовать массив (или список) делегатов,                        
в котором хранятся различные функции. 
б) *Переделать функцию Load, чтобы она возвращала массив считанных значений. Пусть она                        
возвращает минимум через параметр (с использованием модификатора out).  
*/

public delegate double FuncD(double x, double a);
namespace Lesson6
{
    class Func
    {
        public static double F1(double x, double a) // Изменение для 2
        {
            return a * Math.Pow( x  , 2);
        }
        public static double F2(double x, double a) // Изменение для 2
        {
            return a * Math.Sin(x);
        }
        public static double F(double x,double null_all)
        {
            return x * x - 50 * x + 10;
        }

        public static void SaveFunc(FuncD FD,string fileName, double a, double b, double h, double ax)//Изменение для 2 
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(FD(x,ax));
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }

        public static void SaveFuncF1(string fileName, double a, double b, double h, double ax)//Изменение для 1
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F1(x, ax));
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }
        public static void SaveFuncF2(string fileName, double a, double b, double h, double ax)//Изменение для 1
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F2(x, ax));
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }

        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }
    }
}
