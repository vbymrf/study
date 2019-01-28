using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.Struct
{
    struct Complex
    {
//        1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.                  
//Продемонстрировать работу структуры. 
        public Complex Minus(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }

        // Копи паст из методички:



        public double im;
        public double re;
        //  в C# в структурах могут храниться также действия над данными 
        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        //  Пример произведения двух комплексных чисел 
        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        public override string ToString()
        {
            return re + "+" + im + "i";
        }
    }

    
}
